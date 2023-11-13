using CadastroDeDados.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CadastroDeDados
{
    public partial class Form1 : Form
    {
        ContatoDAO contatoConectar;

        public Form1()
        {
            contatoConectar = new ContatoDAO();
            InitializeComponent();
            DgvContato.DataSource = contatoConectar.Buscar().Tables[0];

            DgvContato.SelectionChanged += DgvContato_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConexao connect = new DBConexao();

            Contato contato = OberInformacoesForm();

            if (contato != null)
            {
                contatoConectar.inserir(contato);
                DgvContato.DataSource = contatoConectar.Buscar().Tables[0];
            }
        }

        private Contato OberInformacoesForm()
        {
            Contato contato = new Contato();

            contato.cod_contato = idContatoSelecionado;

            contato.nome = TxtNome.Text;
            contato.cidade = TxtCidade.Text.ToUpper();

            if (CbMasculino.Checked && CbFeminino.Checked)
            {
                ExibirMensagemErro("Por favor, selecione apenas uma opção de sexo.");
                return null;
            }
            else if (CbMasculino.Checked)
            {
                contato.sexo = "Masculino";
            }
            else if (CbFeminino.Checked)
            {
                contato.sexo = "Feminino";
            }
            else
            {
                ExibirMensagemErro("Por favor, selecione o sexo.");
                return null;
            }

            contato.data = DateTime.Now;

            if (string.IsNullOrEmpty(contato.nome))
            {
                ExibirMensagemErro("Por favor, insira o seu nome.");
                return null;
            }
            if (string.IsNullOrEmpty(contato.cidade))
            {
                ExibirMensagemErro("Por favor, insira a cidade.");
                return null;
            }

            ExibirMensagemSucesso("Contato inserido com sucesso!");
            LimparCamposFormulario();

            return contato;
        }

        private void LimparCamposFormulario()
        {
            TxtNome.Text = string.Empty;
            TxtCidade.Text = string.Empty;
            CbMasculino.Checked = false;
            CbFeminino.Checked = false;
        }

        private void LimparTxt()
        {
            textBox1.Text = string.Empty;
        }

        private void ExibirMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExibirMensagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int idContatoSelecionado;

        private void DgvContato_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvContato.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvContato.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["cod_contato"].Value.ToString(), out idContatoSelecionado))
                {
                    string nome = selectedRow.Cells["Nome"].Value.ToString();
                    string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                    string cidade = selectedRow.Cells["Cidade"].Value.ToString();

                    TxtNome.Text = nome;

                    if (sexo == "Masculino")
                    {
                        CbMasculino.Checked = true;
                        CbFeminino.Checked = false;
                    }
                    else if (sexo == "Feminino")
                    {
                        CbMasculino.Checked = false;
                        CbFeminino.Checked = true;
                    }

                    TxtCidade.Text = cidade;
                }
            }
        }

        private void BtnExclui_Click(object sender, EventArgs e)
        {
            //Contato contato = OberInformacoesForm();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este contato?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                contatoConectar.Delete(idContatoSelecionado);
                DgvContato.DataSource = contatoConectar.Buscar().Tables[0];
                LimparCamposFormulario();
            }
        }

        private void BtnAltera_Click(object sender, EventArgs e)
        {
            Contato contato = OberInformacoesForm();
            if (contato != null)
            {
                contatoConectar.Update(contato);
                DgvContato.DataSource = contatoConectar.Buscar().Tables[0];
            }
        }


        private void ContarContatosPorCidade_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            DataSet dataset = contatoConectar.Buscar();

            int numeroDeHomens = 0;
            int numeroDeMulheres = 0;

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                if (row["Sexo"].ToString() == "Masculino")
                {
                    numeroDeHomens++;
                }
                else
                {
                    numeroDeMulheres++;
                }
            }

            textBox1.AppendText("Análise de Contatos: ");
            textBox1.AppendText($"\r\nNúmero de contatos no banco de dados: {dataset.Tables[0].Rows.Count}, ");
            textBox1.AppendText($"{numeroDeHomens} Homens e {numeroDeMulheres} mulheres");

            Dictionary<string, Dictionary<string, int>> contatosPorCidadeEMes = new Dictionary<string, Dictionary<string, int>>();

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                string cidade = row["Cidade"].ToString();

                if (!contatosPorCidadeEMes.ContainsKey(cidade))
                {
                    contatosPorCidadeEMes[cidade] = new Dictionary<string, int>();
                }

                DateTime dataDoBanco = Convert.ToDateTime(row["Data"]);
                int numeroDoMes = dataDoBanco.Month;
                string nomeDoMes = NomeMes(numeroDoMes);

                string chaveMes = $"{cidade}_{nomeDoMes}";

                if (!contatosPorCidadeEMes[cidade].ContainsKey(chaveMes))
                {
                    contatosPorCidadeEMes[cidade][chaveMes] = 0;
                }

                contatosPorCidadeEMes[cidade][chaveMes]++;
            }

            foreach (var cidadeContatos in contatosPorCidadeEMes)
            {
                textBox1.AppendText($"\r\n. Contatos em {cidadeContatos.Key}:");

                foreach (var mesContatos in contatosPorCidadeEMes[cidadeContatos.Key])
                {
                    string nomeMes = mesContatos.Key.Split('_')[1];
                    int totalContatosMes = mesContatos.Value;
                    int homens = 0;
                    int mulheres = 0;

                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        DateTime dataDoBanco = Convert.ToDateTime(row["Data"]);
                        int numeroDoMes = dataDoBanco.Month;
                        string nomeDoMes = NomeMes(numeroDoMes);

                        if (row["Cidade"].ToString() == cidadeContatos.Key && nomeDoMes == nomeMes)
                        {
                            if (row["Sexo"].ToString() == "Masculino")
                            {
                                homens++;
                            }
                            else
                            {
                                mulheres++;
                            }
                        }
                    }

                    textBox1.AppendText($"\r\n{nomeMes}: {totalContatosMes}, {homens} homens e {mulheres} mulheres");
                }

                int totalContatosCidade = contatosPorCidadeEMes[cidadeContatos.Key].Values.Sum();
                textBox1.AppendText($"\r\nTotal: {totalContatosCidade}\n");
            }
        }





        private string NomeMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    return string.Empty;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

    }
}
