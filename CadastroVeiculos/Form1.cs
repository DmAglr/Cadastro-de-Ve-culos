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
                        MessageBox.Show("Informações salvas com sucesso!");
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
                        MessageBox.Show("Não foi possível cadastrar as informações.");
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
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
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
                            MessageBox.Show("Cadastro não Encontrado");
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
                        MessageBox.Show("Cadastro não Encontrado");
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
                MessageBox.Show("Não foi possível localizar o funcionário: " + ex.Message);
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
                        MessageBox.Show("Não foi possível atualizar as informações do cadastro.");
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
                    MessageBox.Show("Favor localizar o funcionário que deseja alterar as informações.");
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
                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
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
                        MessageBox.Show("O funcionário foi excluído com sucesso!");
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
                        MessageBox.Show("Não foi possível excluir o funcionário.");
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
                    MessageBox.Show("Favor pesquisar qual funcionário deseja excluir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }
    }
}