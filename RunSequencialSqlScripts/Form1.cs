using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunSequencialSqlScripts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                if (ValidarConexao())
                {
                    MessageBox.Show(this, "Conexão feita com sucesso.");
                    this.DesbloquearCampos();
                }
            }
        }

        private bool ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(this.txtServidor.Text))
            {
                MessageBox.Show(this, "Informe o servidor");
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtBanco.Text))
            {
                MessageBox.Show(this, "Informe o banco de dados");
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtUsuario.Text))
            {
                MessageBox.Show(this, "Informe o usuário");
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtSenha.Text))
            {
                MessageBox.Show(this, "Informe a senha");
                return false;
            }

            return true;
        }

        private bool ValidarConexao()
        {
            try
            {
                string conectionString = $"Server={this.txtServidor.Text};Database={this.txtBanco.Text};User Id={this.txtUsuario.Text};Password={this.txtSenha.Text};";
                SqlConnection sqlConnection = new SqlConnection(conectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select 1 as Sucess", sqlConnection);
                if (sqlCommand.ExecuteScalar() != null)
                {
                    return true;
                }

                MessageBox.Show(this, "Conexão não validada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Conexão não validada");
                MessageBox.Show(this, ex.Message);
            }

            return false;
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void DesbloquearCampos()
        {
            this.btnProcessar.Enabled = true;
        }

        private void BloquearCampos()
        {
            this.btnProcessar.Enabled = false;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPasta.Text) || !Directory.Exists(this.txtPasta.Text))
            {
                MessageBox.Show(this, "Pasta dos scripts não informada, ou não existe.");
                return;
            }

            if (this.Processar())
            {
                MessageBox.Show(this, "Processamento finalizado!!!");
            }
            else
            {
                MessageBox.Show(this, "Não foi possível executar todos os scripts.");
            }
        }

        private bool Processar()
        {
            DirectoryInfo df = new DirectoryInfo(this.txtPasta.Text);
            var files = df.GetFiles("*.sql");
            int totalArquivos = files.Count();
            SetarTextoInf($"{totalArquivos} scripts serão processados.");
            Application.DoEvents();
            int count = 1;

            foreach (var file in files)
            {
                SetarTextoInf($"Processando {count} de {totalArquivos} scripts...");
                Application.DoEvents();
                if (!ProcessarComandoTransaction(file))
                {
                    MessageBox.Show(this, "Não foi possível processar todos os scripts. O processamento será interrompido.");
                    return false;
                }

                string novoNome = "OK_" + file.Name;
                File.Move(file.FullName, file.FullName.Replace(file.Name, novoNome));

                Application.DoEvents();
                count++;
            }

            SetarTextoInf("");
            return true;
        }

        private bool ProcessarComandoTransaction(FileInfo f)
        {
            SqlConnection sqlConnection = null;
            SqlTransaction sqlTransaction = null;

            try
            {
                string conectionString = $"Server={this.txtServidor.Text};Database={this.txtBanco.Text};User Id={this.txtUsuario.Text};Password={this.txtSenha.Text};";
                sqlConnection = new SqlConnection(conectionString);
                sqlConnection.Open();
                string comandoTotal = File.ReadAllText(f.FullName);
                sqlTransaction = sqlConnection.BeginTransaction();

                var comandos = comandoTotal.Split(new string[] { "\r\nGO ", "\r\nGO\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                int totalcomandos = comandos.Length;
                int countComandos = 1;
             
                foreach (var comando in comandos)
                {
                    SetarTextoComandInf($"executando {countComandos} de {comandos.Length} comandos");
                    Application.DoEvents();
                    if (!ProcessarComando(comando, sqlConnection, sqlTransaction))
                    {
                        throw new Exception("Um dos comandos contidos no strip " + f.FullName + " não pode ser processado com sucesso.");
                    }

                    countComandos++;
                }

                SetarTextoComandInf("");
                sqlTransaction.Commit();
                sqlConnection?.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao processar comando.");
                MessageBox.Show(this, ex.Message);

                Exception exError = ex;
                StringBuilder sb = new StringBuilder(DateTime.Now.ToString("dd/MM/yyyy HH:ss" + Environment.NewLine));
                while (exError != null)
                {
                    sb.AppendLine(exError.Message);
                    exError = exError.InnerException;
                }

                File.AppendAllText("LogError.txt", sb.ToString());

                sqlTransaction.Rollback();
                sqlConnection?.Close();

            }

            return false;
        }

        private bool ProcessarComando(string comando, SqlConnection connection, SqlTransaction transaction)
        {
            SqlCommand sqlCommand = new SqlCommand(comando, connection, transaction);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public void SetarTextoInf(string text)
        {
            if (lblInf.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { SetarTextoInf(text); };
                lblInf.Invoke(safeWrite);
            }
            else
                lblInf.Text = text;
        }

        public void SetarTextoComandInf(string text)
        {
            if (lblComands.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { SetarTextoInf(text); };
                lblComands.Invoke(safeWrite);
            }
            else
                lblComands.Text = text;
        }
    }
}
