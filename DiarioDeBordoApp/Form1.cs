using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiarioDeBordoApp
{
    public partial class Form1 : Form
    {

        // Instância do nosso cérebro gerenciador
        private GerenciadorDiario gerenciador;

        public Form1()
        {
            InitializeComponent();
            ConfigurarSistema();
        }

        private void ConfigurarSistema()
        {
            // 1. Preenche as opções do menu suspenso (ComboBox)
            cmbTipo.Items.Add("Manutenção");
            cmbTipo.Items.Add("Customização");
            cmbTipo.SelectedIndex = 0; // Deixa "Manutenção" selecionado por padrão

            // 2. Inicializa o gerenciador com uma moto base (será atualizada pelo campo txtModelo)
            Motocicleta motoInicial = new Motocicleta("Moto Padrão", "ABC-0000", 0);
            gerenciador = new GerenciadorDiario(motoInicial);

            // 3. INSCRIÇÃO NOS EVENTOS DE NEGÓCIO (O coração da matéria de POE!)
            gerenciador.RegistroAdicionado += Gerenciador_RegistroAdicionado;
            gerenciador.AlertaManutencao += Gerenciador_AlertaManutencao;

            // 4. Configura as colunas da tabela (DataGridView)
            dgvHistorico.ColumnCount = 4;
            dgvHistorico.Columns[0].Name = "Data";
            dgvHistorico.Columns[1].Name = "Modelo";
            dgvHistorico.Columns[2].Name = "Resumo Completo (Polimorfismo)";
            dgvHistorico.Columns[3].Name = "Telefone Fornecedor";
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // EVENTO 1 DE INTERFACE: Reage quando o usuário troca o tipo no ComboBox
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.ToString() == "Manutenção")
            {
                lblExtra.Text = "Km Próx. Troca:";
                //btnSalvar.BackColor = Color.LightSalmon; // Alerta visual para mecânica
            }
            else
            {
                lblExtra.Text = "Marca da Peça:";
                //btnSalvar.BackColor = Color.LightSkyBlue; // Visual azul para estética/custom
            }
        }

        // EVENTO 2 DE INTERFACE: Reage ao clique no botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Atualiza o modelo da moto com o que foi digitado na tela
                if (!string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    gerenciador.Moto.Modelo = txtModelo.Text;
                }

                // Coleta e converte os dados básicos das caixas de texto
                DateTime data = dtpData.Value;
                string descricao = txtDescricao.Text;
                decimal custo = decimal.Parse(txtCusto.Text);
                int kmAtual = int.Parse(txtKm.Text);

                // Cria o objeto Fornecedor (Associação)
                Fornecedor fornecedor = new Fornecedor(txtFornecedorNome.Text, txtFornecedorTelefone.Text);

                // Verifica qual classe filha instanciar
                if (cmbTipo.SelectedItem.ToString() == "Manutenção")
                {
                    int kmProxima = int.Parse(txtExtra.Text);
                    Manutencao novaManutencao = new Manutencao(data, descricao, custo, kmAtual, fornecedor, kmProxima);

                    // Envia para o gerenciador (que vai disparar os eventos!)
                    gerenciador.AdicionarRegistro(novaManutencao);
                }
                else
                {
                    string marcaPeca = txtExtra.Text;
                    Customizacao novaCustom = new Customizacao(data, descricao, custo, kmAtual, fornecedor, marcaPeca);

                    gerenciador.AdicionarRegistro(novaCustom);
                }

                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite apenas números válidos nos campos de Custo, Quilometragem e Km Próxima Troca!", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // EVENTO DE NEGÓCIO 1: Reage automaticamente quando o Gerenciador avisa que salvou
        private void Gerenciador_RegistroAdicionado(object sender, EventArgs e)
        {
            dgvHistorico.Rows.Clear();

            foreach (Registro reg in gerenciador.ListaRegistros)
            {
                // Chama o método polimórfico ObterResumo() de cada classe filha!
                dgvHistorico.Rows.Add(
                    reg.Data.ToShortDateString(),
                    gerenciador.Moto.Modelo,
                    reg.ObterResumo(),
                    reg.Fornecedor != null ? reg.Fornecedor.Telefone : ""
                );
            }
        }

        // EVENTO DE NEGÓCIO 2: Reage automaticamente se passar da KM de troca
        private void Gerenciador_AlertaManutencao(object sender, string mensagemAlerta)
        {
            MessageBox.Show(mensagemAlerta, "Alerta de Manutenção Preventiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtCusto.Clear();
            txtKm.Clear();
            txtFornecedorNome.Clear();
            txtFornecedorTelefone.Clear();
            txtExtra.Clear();
            txtDescricao.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Define a cor verde escura (mesma do botão) e a espessura (4 pixels)
            Color verdeEscuro = Color.FromArgb(0, 64, 0);
            int espessura = 4;

            using (Pen canetaVerde = new Pen(verdeEscuro, espessura))
            {
                // Desenha o retângulo da borda ajustado à área interna do formulário
                Rectangle retangulo = new Rectangle(
                    espessura / 2,
                    espessura / 2,
                    this.ClientSize.Width - espessura,
                    this.ClientSize.Height - espessura
                );

                e.Graphics.DrawRectangle(canetaVerde, retangulo);
            }
        }
    }
    }