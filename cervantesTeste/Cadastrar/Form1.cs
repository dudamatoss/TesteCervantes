using System.Data;
using Microsoft.VisualBasic;
using Npgsql;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Cadastrar
{

    public partial class Form1 : Form
    {

        private string connectionString = "Host=127.0.0.1;Username=postgres;Password=duda123;Database=cadastro_db";
        public Form1()
        {
            InitializeComponent();
            ListarDados();
        }
        //salvar
       
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int numeros = Convert.ToInt32(textBoxNumeros.Text);
            if (errosInput(textBoxTexto))
            {
                return;
            }

            var connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = "INSERT INTO cadastro (texto, numeros) VALUES (@texto, @numeros);";
                var cmd = new NpgsqlCommand(query, connection);
                {
                    cmd.Parameters.AddWithValue("texto", textBoxTexto.Text);
                    cmd.Parameters.AddWithValue("numeros", numeros);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox
                        .Show("Seu cadastro foisalvo com sucesso!");
                    Registrar("INSERT");
                    DateTime.Now.ToString();
                    ListarDados();
                    limparCaixa();
                }
            }
            catch (Exception ex)
            {
                MessageBox
                    .Show($"Ocorreu um erro:{ex.Message}");
            }
        }

        //editar
        private void buttonEditar_Click(object sender, EventArgs e)
        {

            int? id = verificaId(); 
            if (id == null)
            {
                return;
            }

            var connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
                
                //input novo texto
                string novoTexto = Interaction.InputBox("Digite o novo Texto:", "Editar Texto");

                if (string.IsNullOrWhiteSpace(novoTexto))
                {
                    MessageBox
                        .Show("Texto não pode ser vazio.");
                    return;
                }

                //input novo numero
                string edit = Interaction.InputBox("Digite o novo Número", "Editar Numeros");

                if (!int.TryParse(edit, out int novoNum))
                {
                    MessageBox
                        .Show("Digite um numero valido.");
                    return;
                }

                //atualizando cadastro
                 
                string atualizarTable = "UPDATE cadastro SET texto = @texto, numeros = @numeros WHERE id_cadastro = @id;";
                using (var cmdAtualizar = new NpgsqlCommand(atualizarTable, connection))
                {
                    cmdAtualizar.Parameters.AddWithValue("@texto", novoTexto);
                    cmdAtualizar.Parameters.AddWithValue("@numeros", novoNum);
                    cmdAtualizar.Parameters.AddWithValue("@id", id);

                    int rowsAfetada = cmdAtualizar.ExecuteNonQuery();
                    if (rowsAfetada > 0)
                    {
                        MessageBox
                            .Show("Seu cadastro foi atualizado com sucesso!");
                        ListarDados();
                        Registrar("UPDATE");
                        DateTime.Now.ToString();
                    }
                    else
                    {
                        MessageBox
                            .Show("Não foi possivel atualizar seu cadastro.");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox
                    .Show($"Foi detectado um erro ao atualizar cadastro: {ex.Message}");
            }
        }

        //excluir
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
           
            int? id = verificaId(); // Pega o id do usuário
            if (id == null)
            {
                return;
            }
            if (MessageBox
        .Show($"Tem certeza que deseja excluir este cadastro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                                                          
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string excluiCadastro = "DELETE FROM cadastro WHERE id_cadastro = @id;";
                        using (var cmdExcluir = new NpgsqlCommand(excluiCadastro, connection))
                        {
                            cmdExcluir.Parameters.AddWithValue("@id", id);

                            int rowsAfetada = cmdExcluir.ExecuteNonQuery();
                            if (rowsAfetada > 0)
                            {
                                MessageBox
                                    .Show("Seu cadastro foi excluido com sucesso!");
                                Registrar("DELETE");
                                DateTime.Now.ToString();
                                ListarDados();
                            }
                            else
                            {
                                MessageBox
                                    .Show("Não foi pssivel excluir seu cadastro");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox
                            .Show($"Ocorreu um erro ao excluir:{ex.Message}");
                    }
                }
            }
            else 
            {
                MessageBox
                    .Show("Operação cancelada.");
                return;
            }
        }
        
        //limpar caixa de texto
        private void  limparCaixa()
        {
            textBoxNumeros.Clear ();
            textBoxTexto.Clear ();
        }

        //impedir que digite algo diferente do numero no input textBoxNumero
        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) //vai ver se não é numero nem tecla de apagar
            {
                e.Handled = true; //bloqueia caracter diferente de numero
            }
        }

        //verifica se input não é vazio
        private bool errosInput(TextBox input)
        {
            string texto = input.Text;
            
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox
                    .Show("ATENÇÃO! O campo texto não pode ser vazio", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return true;
            }
            return false;           
        }

        //confere se o id existe 
        private int? verificaId()
        {
            var id_cadastro = Interaction.InputBox("Digite o Id do cadastro que você deseja alterar", "Editar");
            if (!int.TryParse(id_cadastro, out int id))
            {
                MessageBox
                    .Show("Digite um número válido para o ID.");
                return null;
                
            }
            var connection = new NpgsqlConnection(connectionString);
            {
                connection.Open();
                
                string verificaId = "SELECT COUNT(*) FROM cadastro WHERE id_cadastro = @id;";


                using (var cmdVerificaId = new NpgsqlCommand(verificaId, connection))
                {
                    cmdVerificaId.Parameters.AddWithValue("@id", id);
                    int idExiste = Convert.ToInt32(cmdVerificaId.ExecuteScalar());

                    if (idExiste == 0)
                    {
                        MessageBox
                            .Show("Este ID não foi encontrado no banco de dados");
                        return null;
                    }
                }
            }
            return id;
        }
        //registrando inset na tabela log_operacoes
        private void Registrar(string operationType)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var query = "INSERT INTO log_operacoes (operacao) VALUES (@operacao);";


                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@operacao", operationType);

                        cmd.ExecuteNonQuery();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox
                       .Show($"Ops, Ocorreu um erro ao registrar a operação:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //mostrando tebela 
        private void ListarDados()
        {
            var connection = new NpgsqlConnection(connectionString);
            {

                connection.Open();
                string query = "SELECT * FROM cadastro ORDER BY id_cadastro ASC;";

                using (var dados = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable tabela = new DataTable();
                    dados.Fill(tabela);
                    dataGridViewCadastros.DataSource = tabela;
                    StyleDataGrid();

                }
            }
        }
        // estilizando a tabela
        private void StyleDataGrid()
        {
            dataGridViewCadastros.RowHeadersVisible = false; //remove barra lateral
            dataGridViewCadastros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCadastros.RowTemplate.Height = 30; //altura linhas
            dataGridViewCadastros.AllowUserToAddRows = false;
            dataGridViewCadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCadastros.MultiSelect = false;
            dataGridViewCadastros.ReadOnly = true;
            dataGridViewCadastros.DefaultCellStyle.SelectionBackColor = dataGridViewCadastros.DefaultCellStyle.BackColor;
            dataGridViewCadastros.DefaultCellStyle.SelectionForeColor = dataGridViewCadastros.DefaultCellStyle.ForeColor;         
          }       
    }
}

