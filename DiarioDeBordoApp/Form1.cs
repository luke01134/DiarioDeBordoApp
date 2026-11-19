using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiarioDeBordoApp
{
    public partial class Form1 : Form
    {
        // Instância do nosso cérebro gerenciador (Programação Orientada a Objetos)
        private GerenciadorDiario gerenciador;
        private bool _isSyncingType = false;

        public Form1()
        {
            InitializeComponent();
            ConfigurarSistema();
        }

        private void ConfigurarSistema()
        {
            // 1. Preenche as opções do menu suspenso (ComboBox)
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Manutenção");
            cmbTipo.Items.Add("Customização");
            cmbTipo.SelectedIndex = 0; // Deixa "Manutenção" selecionado por padrão
            toggleTipo.SelectedIndex = 0;

            // 2. Inicializa o gerenciador com uma moto base (estilo Royal Enfield)
            Motocicleta motoInicial = new Motocicleta("Royal Enfield Hunter 350", "ABC-1D23", 1200);
            gerenciador = new GerenciadorDiario(motoInicial);
            txtModelo.Text = motoInicial.Modelo;
            lblActiveBike.Text = $"🏍️ {motoInicial.Modelo}";

            // 3. INSCRIÇÃO NOS EVENTOS DE NEGÓCIO (O coração da matéria de POE!)
            gerenciador.RegistroAdicionado += Gerenciador_RegistroAdicionado;
            gerenciador.AlertaManutencao += Gerenciador_AlertaManutencao;

            // 4. Configura as colunas da tabela (DataGridView)
            dgvHistorico.ColumnCount = 4;
            dgvHistorico.Columns[0].Name = "Data";
            dgvHistorico.Columns[0].Width = 90;
            dgvHistorico.Columns[1].Name = "Modelo";
            dgvHistorico.Columns[1].Width = 140;
            dgvHistorico.Columns[2].Name = "Resumo Completo (Polimorfismo)";
            dgvHistorico.Columns[3].Name = "Telefone Fornecedor";
            dgvHistorico.Columns[3].Width = 140;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Aplica o design moderno dark e suave
            UITheme.StyleDataGridView(dgvHistorico);
            ConfigurarEventosVisuais();
            AtualizarDashboard();
        }

        private void ConfigurarEventosVisuais()
        {
            // Feedback tátil e visual ao focar nos inputs
            TextBox[] textboxes = new TextBox[] { txtModelo, txtDescricao, txtCusto, txtKm, txtExtra, txtFornecedorNome, txtFornecedorTelefone };
            foreach (var tb in textboxes)
            {
                tb.Enter += (s, e) =>
                {
                    if (s is TextBox t)
                    {
                        t.BackColor = Color.FromArgb(24, 30, 42);
                    }
                };
                tb.Leave += (s, e) =>
                {
                    if (s is TextBox t)
                    {
                        t.BackColor = UITheme.InputBackground;
                    }
                };
            }
        }

        private void AtualizarDashboard()
        {
            if (gerenciador == null) return;

            decimal totalInvestido = 0;
            int totalManutencoes = 0;
            int totalCustomizacoes = 0;

            foreach (Registro reg in gerenciador.ListaRegistros)
            {
                totalInvestido += reg.Custo;
                if (reg is Manutencao)
                    totalManutencoes++;
                else if (reg is Customizacao)
                    totalCustomizacoes++;
            }

            kpiCustoTotal.ValueText = string.Format("R$ {0:N2}", totalInvestido);
            kpiManutencoes.ValueText = $"{totalManutencoes} serviços";
            kpiCustomizacoes.ValueText = $"{totalCustomizacoes} peças";
            kpiKmAtual.ValueText = $"{gerenciador.Moto.QuilometragemAtual:N0} KM";
            lblHistoricoBadge.Text = $"{gerenciador.ListaRegistros.Count} registros";
            lblActiveBike.Text = $"🏍️ {(string.IsNullOrWhiteSpace(gerenciador.Moto.Modelo) ? "Moto Padrão" : gerenciador.Moto.Modelo)}";
        }

        // EVENTO DE TRANSIÇÃO: Reage quando o usuário clica no seletor segmentado animado
        private void toggleTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isSyncingType) return;
            _isSyncingType = true;
            try
            {
                if (cmbTipo.Items.Count > toggleTipo.SelectedIndex)
                {
                    cmbTipo.SelectedIndex = toggleTipo.SelectedIndex;
                }
            }
            finally
            {
                _isSyncingType = false;
            }
        }

        // EVENTO 1 DE INTERFACE: Reage quando o usuário troca o tipo no ComboBox ou Seletor
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isSyncingType && toggleTipo.SelectedIndex != cmbTipo.SelectedIndex)
            {
                _isSyncingType = true;
                try
                {
                    toggleTipo.SelectedIndex = cmbTipo.SelectedIndex;
                }
                finally
                {
                    _isSyncingType = false;
                }
            }

            if (cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() == "Manutenção")
            {
                lblExtra.Text = "Km Próx. Troca:";
                btnSalvar.SetAccentColor(UITheme.AccentRed, UITheme.AccentRedHover, Color.FromArgb(198, 40, 40));
                btnSalvar.Text = "💾  SALVAR MANUTENÇÃO";
                lblHintText.Text = "💡 Regras de Negócio & POE (Programação Orientada a Eventos):\r\n\r\n• Manutenção: Dispara alerta de revisão quando o KM atual atingir o limite estipulado.\r\n• Associação com Oficina/Fornecedor para controle técnico da moto.";
            }
            else
            {
                lblExtra.Text = "Marca da Peça:";
                btnSalvar.SetAccentColor(UITheme.AccentCyan, UITheme.AccentCyanHover, Color.FromArgb(2, 100, 160));
                btnSalvar.Text = "✨  SALVAR CUSTOMIZAÇÃO";
                lblHintText.Text = "💡 Regras de Negócio & POE (Programação Orientada a Eventos):\r\n\r\n• Customização: Registra peças especiais com polimorfismo dinâmico.\r\n• Associação com Loja/Fornecedor da peça customizada.";
            }
        }

        // EVENTO 2 DE INTERFACE: Reage ao clique no botão Salvar com validação e feedback fluido
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    toastNotification.ShowToast("Campo Obrigatório", "Por favor, digite a descrição do serviço ou peça.", UITheme.AccentAmber, "⚠️");
                    txtDescricao.Focus();
                    return;
                }

                // Atualiza o modelo da moto com o que foi digitado na tela
                if (!string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    gerenciador.Moto.Modelo = txtModelo.Text.Trim();
                    lblActiveBike.Text = $"🏍️ {gerenciador.Moto.Modelo}";
                }

                // Coleta e converte os dados básicos das caixas de texto
                DateTime data = dtpData.Value;
                string descricao = txtDescricao.Text.Trim();

                if (!decimal.TryParse(txtCusto.Text.Trim(), out decimal custo))
                {
                    toastNotification.ShowToast("Valor Inválido", "Digite um valor numérico válido para o Custo (ex: 150,00).", UITheme.AccentRed, "❌");
                    txtCusto.Focus();
                    return;
                }

                if (!int.TryParse(txtKm.Text.Trim(), out int kmAtual))
                {
                    toastNotification.ShowToast("KM Inválida", "Digite um número inteiro para a Quilometragem Atual (ex: 4500).", UITheme.AccentRed, "❌");
                    txtKm.Focus();
                    return;
                }

                // Cria o objeto Fornecedor (Associação)
                Fornecedor fornecedor = new Fornecedor(txtFornecedorNome.Text.Trim(), txtFornecedorTelefone.Text.Trim());

                // Verifica qual classe filha instanciar (Polimorfismo & Herança)
                if (cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() == "Manutenção")
                {
                    if (!int.TryParse(txtExtra.Text.Trim(), out int kmProxima))
                    {
                        toastNotification.ShowToast("KM Inválida", "Digite um número inteiro para a Km da Próxima Troca.", UITheme.AccentRed, "❌");
                        txtExtra.Focus();
                        return;
                    }

                    Manutencao novaManutencao = new Manutencao(data, descricao, custo, kmAtual, fornecedor, kmProxima);

                    // Envia para o gerenciador (que vai disparar os eventos de POE!)
                    gerenciador.AdicionarRegistro(novaManutencao);
                    toastNotification.ShowToast("Manutenção Salva", "Serviço de manutenção registrado com sucesso!", UITheme.AccentGreen, "✅");
                }
                else
                {
                    string marcaPeca = string.IsNullOrWhiteSpace(txtExtra.Text) ? "Genérica" : txtExtra.Text.Trim();
                    Customizacao novaCustom = new Customizacao(data, descricao, custo, kmAtual, fornecedor, marcaPeca);

                    gerenciador.AdicionarRegistro(novaCustom);
                    toastNotification.ShowToast("Customização Salva", "Item de customização registrado com sucesso!", UITheme.AccentCyan, "✨");
                }

                LimparCampos();
            }
            catch (FormatException)
            {
                toastNotification.ShowToast("Erro de Digitação", "Por favor, digite apenas números válidos nos campos numéricos!", UITheme.AccentRed, "❌");
                MessageBox.Show("Por favor, digite apenas números válidos nos campos de Custo, Quilometragem e Km Próxima Troca!", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                toastNotification.ShowToast("Erro Inesperado", ex.Message, UITheme.AccentRed, "❌");
            }
        }

        // EVENTO 3 DE INTERFACE: Limpa os campos para um novo preenchimento
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            toastNotification.ShowToast("Campos Limpos", "O formulário está pronto para um novo registro.", UITheme.TextSecondary, "🧹");
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

            AtualizarDashboard();
        }

        // EVENTO DE NEGÓCIO 2: Reage automaticamente se passar da KM de troca
        private void Gerenciador_AlertaManutencao(object sender, string mensagemAlerta)
        {
            toastNotification.ShowToast("Alerta Preventivo", mensagemAlerta, UITheme.AccentAmber, "⚠️");
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

        // Desenha a borda suave do formulário
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen borderPen = new Pen(UITheme.SurfaceBorder, 1.2F))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }

        // Desenha a linha gradiente de destaque do cabeçalho
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Linha gradiente de alta performance no topo do cabeçalho
            using (LinearGradientBrush grad = new LinearGradientBrush(
                new Point(0, 0),
                new Point(pnlHeader.Width, 0),
                UITheme.AccentRed,
                UITheme.AccentCyan))
            {
                e.Graphics.FillRectangle(grad, 0, 0, pnlHeader.Width, 3);
            }

            // Linha sutil divisória na base do cabeçalho
            using (Pen borderPen = new Pen(UITheme.SurfaceBorder, 1F))
            {
                e.Graphics.DrawLine(borderPen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
            }
        }

        // Desenha o painel de dica com cantos arredondados e barra de destaque
        private void pnlHint_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, pnlHint.Width - 1, pnlHint.Height - 1);

            using (GraphicsPath path = UITheme.CreateRoundedRectanglePath(rect, 8))
            {
                using (Pen pen = new Pen(UITheme.SurfaceBorder, 1.2F))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Faixa vertical de acento âmbar à esquerda
            using (SolidBrush brush = new SolidBrush(UITheme.AccentAmber))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(0, 8, 3, pnlHint.Height - 16));
            }
        }
    }
}