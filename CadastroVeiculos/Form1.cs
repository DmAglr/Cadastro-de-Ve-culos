using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace CadastroVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPlaca.Text.Equals("") && !txtMarca.Text.Equals("") && !txtFab.Text.Equals("") && !txtModelo.Text.Equals("") && !txtCliente.Text.Equals("") && !txtPfPj.Text.Equals("") && !txtDoc.Text.Equals(""))
                {
                    CadastroVeiculos cadastroVeiculos = new CadastroVeiculos();
                    cadastroVeiculos.placa = txtPlaca.Text;
                    cadastroVeiculos.marca = txtMarca.Text;
                    cadastroVeiculos.AnoFab = txtFab.Text;
                    cadastroVeiculos.AnoModel = txtModelo.Text;
                    cadastroVeiculos.cliente = txtCliente.Text;
                    cadastroVeiculos.TipoCliente = txtPfPj.Text;
                    cadastroVeiculos.documento = txtDoc.Text;

                    if (cadastroVeiculos.CadastrarVeiculos())
                    {
                        MessageBox.Show("Informa��es salvas com sucesso!");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        txtPlaca.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel cadastrar as informa��es.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtPlaca.Clear();
                    txtMarca.Clear();
                    txtFab.Clear();
                    txtModelo.Clear();
                    txtCliente.Clear();
                    txtPfPj.Clear();
                    txtDoc.Clear();
                    txtPlaca.Focus();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtDoc.Text.Equals(""))
                {
                    CadastroVeiculos cadastroVeiculos = new CadastroVeiculos();
                    cadastroVeiculos.documento = txtDoc.Text;

                    MySqlDataReader reader = cadastroVeiculos.LocalizarCadastro();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["ID"].ToString();
                            txtPlaca.Text = reader["PLACA"].ToString();
                            txtMarca.Text = reader["MARCA"].ToString();
                            txtFab.Text = reader["ANO_FAB"].ToString();
                            txtModelo.Text = reader["ANO_MODEL"].ToString();
                            txtCliente.Text = reader["CLIENTE"].ToString();
                            txtPfPj.Text = reader["TIPO_CLI"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cadastro n�o Encontrado");
                            txtPlaca.Clear();
                            txtMarca.Clear();
                            txtFab.Clear();
                            txtModelo.Clear();
                            txtCliente.Clear();
                            txtPfPj.Clear();
                            txtDoc.Clear();
                            lblId.Text = "";
                            txtDoc.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cadastro n�o Encontrado");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        lblId.Text = "";
                        txtDoc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo DOCUMENTO para realizar a pesquisa!");
                    txtPlaca.Clear();
                    txtMarca.Clear();
                    txtFab.Clear();
                    txtModelo.Clear();
                    txtCliente.Clear();
                    txtPfPj.Clear();
                    txtDoc.Clear();
                    lblId.Text = "";
                    txtDoc.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel localizar o funcion�rio: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtFab.Clear();
            txtModelo.Clear();
            txtCliente.Clear();
            txtPfPj.Clear();
            txtDoc.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPlaca.Text.Equals("") && !txtMarca.Text.Equals("") && !txtFab.Text.Equals("") && !txtModelo.Text.Equals("") && !txtCliente.Text.Equals("") && !txtPfPj.Text.Equals("") && !txtDoc.Text.Equals(""))
                {
                    CadastroVeiculos cadastroVeiculos = new CadastroVeiculos();
                    cadastroVeiculos.Id = int.Parse(lblId.Text);
                    cadastroVeiculos.placa = txtPlaca.Text;
                    cadastroVeiculos.marca = txtMarca.Text;
                    cadastroVeiculos.AnoFab = txtFab.Text;
                    cadastroVeiculos.AnoModel = txtModelo.Text;

                    if (cadastroVeiculos.AtualizarCadastro())
                    {
                        MessageBox.Show("Dados cadastrais atualizados com sucesso!");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        lblId.Text = "";
                        txtDoc.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel atualizar as informa��es do cadastro.");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        lblId.Text = "";
                        txtDoc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcion�rio que deseja alterar as informa��es.");
                    txtPlaca.Clear();
                    txtMarca.Clear();
                    txtFab.Clear();
                    txtModelo.Clear();
                    txtCliente.Clear();
                    txtPfPj.Clear();
                    txtDoc.Clear();
                    lblId.Text = "";
                    txtDoc.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcion�rio: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPlaca.Text.Equals("") && !txtMarca.Text.Equals("") && !txtFab.Text.Equals("") && !txtModelo.Text.Equals("") && !txtCliente.Text.Equals("") && !txtPfPj.Text.Equals("") && !txtDoc.Text.Equals(""))
                {
                    CadastroVeiculos cadastroVeiculos = new CadastroVeiculos();
                    cadastroVeiculos.Id = int.Parse(lblId.Text);
                    
                    if (cadastroVeiculos.DeletarFuncionario())
                    {
                        MessageBox.Show("O funcion�rio foi exclu�do com sucesso!");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel excluir o funcion�rio.");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtFab.Clear();
                        txtModelo.Clear();
                        txtCliente.Clear();
                        txtPfPj.Clear();
                        txtDoc.Clear();
                        lblId.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual funcion�rio deseja excluir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }
    }
}