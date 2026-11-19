namespace DiarioDeBordoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblStatusPill = new System.Windows.Forms.Label();
            this.lblActiveBike = new System.Windows.Forms.Label();
            this.kpiCustoTotal = new DiarioDeBordoApp.ModernKpiCard();
            this.kpiManutencoes = new DiarioDeBordoApp.ModernKpiCard();
            this.kpiCustomizacoes = new DiarioDeBordoApp.ModernKpiCard();
            this.kpiKmAtual = new DiarioDeBordoApp.ModernKpiCard();
            this.cardNovoRegistro = new DiarioDeBordoApp.ModernCard();
            this.toggleTipo = new DiarioDeBordoApp.ModernSegmentedToggle();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFornecedorNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFornecedorTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new DiarioDeBordoApp.ModernButton();
            this.btnLimpar = new DiarioDeBordoApp.ModernButton();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.lblHintText = new System.Windows.Forms.Label();
            this.cardHistorico = new DiarioDeBordoApp.ModernCard();
            this.lblHistoricoBadge = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.toastNotification = new DiarioDeBordoApp.ModernToast();
            this.pnlHeader.SuspendLayout();
            this.cardNovoRegistro.SuspendLayout();
            this.pnlHint.SuspendLayout();
            this.cardHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.pnlHeader.Controls.Add(this.lblActiveBike);
            this.pnlHeader.Controls.Add(this.lblStatusPill);
            this.pnlHeader.Controls.Add(this.lblAppSubtitle);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Controls.Add(this.lblAppIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1140, 68);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblAppIcon
            // 
            this.lblAppIcon.AutoSize = true;
            this.lblAppIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblAppIcon.Location = new System.Drawing.Point(18, 12);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(49, 37);
            this.lblAppIcon.TabIndex = 0;
            this.lblAppIcon.Text = "🏍️";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(70, 13);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(175, 25);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "DIÁRIO DE BORDO";
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.AutoSize = true;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(72, 38);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(377, 13);
            this.lblAppSubtitle.TabIndex = 2;
            this.lblAppSubtitle.Text = "Gestão de Manutenção Preventiva & Customizações • Royal Enfield & Custom";
            // 
            // lblStatusPill
            // 
            this.lblStatusPill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusPill.AutoSize = true;
            this.lblStatusPill.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusPill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblStatusPill.Location = new System.Drawing.Point(825, 26);
            this.lblStatusPill.Name = "lblStatusPill";
            this.lblStatusPill.Size = new System.Drawing.Size(107, 15);
            this.lblStatusPill.TabIndex = 3;
            this.lblStatusPill.Text = "● SISTEMA ONLINE";
            // 
            // lblActiveBike
            // 
            this.lblActiveBike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblActiveBike.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActiveBike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblActiveBike.Location = new System.Drawing.Point(945, 18);
            this.lblActiveBike.Name = "lblActiveBike";
            this.lblActiveBike.Size = new System.Drawing.Size(175, 30);
            this.lblActiveBike.TabIndex = 4;
            this.lblActiveBike.Text = "🏍️ Moto Padrão";
            this.lblActiveBike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kpiCustoTotal
            // 
            this.kpiCustoTotal.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.kpiCustoTotal.IconSymbol = "💰";
            this.kpiCustoTotal.Location = new System.Drawing.Point(16, 78);
            this.kpiCustoTotal.Name = "kpiCustoTotal";
            this.kpiCustoTotal.Size = new System.Drawing.Size(265, 72);
            this.kpiCustoTotal.TabIndex = 1;
            this.kpiCustoTotal.Title = "INVESTIMENTO TOTAL";
            this.kpiCustoTotal.ValueText = "R$ 0,00";
            // 
            // kpiManutencoes
            // 
            this.kpiManutencoes.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.kpiManutencoes.IconSymbol = "🔧";
            this.kpiManutencoes.Location = new System.Drawing.Point(297, 78);
            this.kpiManutencoes.Name = "kpiManutencoes";
            this.kpiManutencoes.Size = new System.Drawing.Size(265, 72);
            this.kpiManutencoes.TabIndex = 2;
            this.kpiManutencoes.Title = "MANUTENÇÕES";
            this.kpiManutencoes.ValueText = "0 serviços";
            // 
            // kpiCustomizacoes
            // 
            this.kpiCustomizacoes.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.kpiCustomizacoes.IconSymbol = "✨";
            this.kpiCustomizacoes.Location = new System.Drawing.Point(578, 78);
            this.kpiCustomizacoes.Name = "kpiCustomizacoes";
            this.kpiCustomizacoes.Size = new System.Drawing.Size(265, 72);
            this.kpiCustomizacoes.TabIndex = 3;
            this.kpiCustomizacoes.Title = "CUSTOMIZAÇÕES";
            this.kpiCustomizacoes.ValueText = "0 peças";
            // 
            // kpiKmAtual
            // 
            this.kpiKmAtual.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.kpiKmAtual.IconSymbol = "🛣️";
            this.kpiKmAtual.Location = new System.Drawing.Point(859, 78);
            this.kpiKmAtual.Name = "kpiKmAtual";
            this.kpiKmAtual.Size = new System.Drawing.Size(265, 72);
            this.kpiKmAtual.TabIndex = 4;
            this.kpiKmAtual.Title = "QUILOMETRAGEM";
            this.kpiKmAtual.ValueText = "0 KM";
            // 
            // cardNovoRegistro
            // 
            this.cardNovoRegistro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cardNovoRegistro.BorderRadius = 12;
            this.cardNovoRegistro.Controls.Add(this.pnlHint);
            this.cardNovoRegistro.Controls.Add(this.btnLimpar);
            this.cardNovoRegistro.Controls.Add(this.btnSalvar);
            this.cardNovoRegistro.Controls.Add(this.txtFornecedorTelefone);
            this.cardNovoRegistro.Controls.Add(this.label8);
            this.cardNovoRegistro.Controls.Add(this.txtFornecedorNome);
            this.cardNovoRegistro.Controls.Add(this.label7);
            this.cardNovoRegistro.Controls.Add(this.txtExtra);
            this.cardNovoRegistro.Controls.Add(this.lblExtra);
            this.cardNovoRegistro.Controls.Add(this.txtKm);
            this.cardNovoRegistro.Controls.Add(this.label5);
            this.cardNovoRegistro.Controls.Add(this.txtCusto);
            this.cardNovoRegistro.Controls.Add(this.label4);
            this.cardNovoRegistro.Controls.Add(this.dtpData);
            this.cardNovoRegistro.Controls.Add(this.label6);
            this.cardNovoRegistro.Controls.Add(this.txtDescricao);
            this.cardNovoRegistro.Controls.Add(this.label3);
            this.cardNovoRegistro.Controls.Add(this.txtModelo);
            this.cardNovoRegistro.Controls.Add(this.label2);
            this.cardNovoRegistro.Controls.Add(this.label1);
            this.cardNovoRegistro.Controls.Add(this.cmbTipo);
            this.cardNovoRegistro.Controls.Add(this.toggleTipo);
            this.cardNovoRegistro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.cardNovoRegistro.HeaderIcon = "📝";
            this.cardNovoRegistro.HeaderTitle = "NOVO REGISTRO DE SERVIÇO";
            this.cardNovoRegistro.Location = new System.Drawing.Point(16, 160);
            this.cardNovoRegistro.Name = "cardNovoRegistro";
            this.cardNovoRegistro.Padding = new System.Windows.Forms.Padding(16);
            this.cardNovoRegistro.Size = new System.Drawing.Size(460, 544);
            this.cardNovoRegistro.TabIndex = 5;
            // 
            // toggleTipo
            // 
            this.toggleTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toggleTipo.Location = new System.Drawing.Point(20, 50);
            this.toggleTipo.Name = "toggleTipo";
            this.toggleTipo.SelectedIndex = 0;
            this.toggleTipo.Size = new System.Drawing.Size(420, 38);
            this.toggleTipo.TabIndex = 0;
            this.toggleTipo.SelectedIndexChanged += new System.EventHandler(this.toggleTipo_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(20, 50);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(10, 21);
            this.cmbTipo.TabIndex = 21;
            this.cmbTipo.Visible = false;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo da Motocicleta:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(20, 116);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(420, 24);
            this.txtModelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição do Serviço / Peça:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(20, 164);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(420, 24);
            this.txtDescricao.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label6.Location = new System.Drawing.Point(20, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data do Serviço:";
            // 
            // dtpData
            // 
            this.dtpData.CalendarForeColor = System.Drawing.Color.White;
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.dtpData.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(20, 214);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 24);
            this.dtpData.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(240, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custo Total (R$):";
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCusto.ForeColor = System.Drawing.Color.White;
            this.txtCusto.Location = new System.Drawing.Point(240, 214);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(200, 24);
            this.txtCusto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(20, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Km Atual da Moto:";
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKm.ForeColor = System.Drawing.Color.White;
            this.txtKm.Location = new System.Drawing.Point(20, 264);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(200, 24);
            this.txtKm.TabIndex = 10;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblExtra.Location = new System.Drawing.Point(240, 246);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(92, 15);
            this.lblExtra.TabIndex = 11;
            this.lblExtra.Text = "Km Próx. Troca:";
            // 
            // txtExtra
            // 
            this.txtExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtExtra.ForeColor = System.Drawing.Color.White;
            this.txtExtra.Location = new System.Drawing.Point(240, 264);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(200, 24);
            this.txtExtra.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(20, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Oficina / Fornecedor:";
            // 
            // txtFornecedorNome
            // 
            this.txtFornecedorNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtFornecedorNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorNome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFornecedorNome.ForeColor = System.Drawing.Color.White;
            this.txtFornecedorNome.Location = new System.Drawing.Point(20, 314);
            this.txtFornecedorNome.Name = "txtFornecedorNome";
            this.txtFornecedorNome.Size = new System.Drawing.Size(200, 24);
            this.txtFornecedorNome.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label8.Location = new System.Drawing.Point(240, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone / Contato:";
            // 
            // txtFornecedorTelefone
            // 
            this.txtFornecedorTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.txtFornecedorTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorTelefone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFornecedorTelefone.ForeColor = System.Drawing.Color.White;
            this.txtFornecedorTelefone.Location = new System.Drawing.Point(240, 314);
            this.txtFornecedorTelefone.Name = "txtFornecedorTelefone";
            this.txtFornecedorTelefone.Size = new System.Drawing.Size(200, 24);
            this.txtFornecedorTelefone.TabIndex = 16;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BorderColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BorderRadius = 8;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnSalvar.Location = new System.Drawing.Point(20, 356);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnSalvar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalvar.Size = new System.Drawing.Size(280, 46);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "💾  SALVAR REGISTRO";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnLimpar.BorderRadius = 8;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnLimpar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnLimpar.Location = new System.Drawing.Point(310, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.btnLimpar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnLimpar.Size = new System.Drawing.Size(130, 46);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "🧹  Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnlHint
            // 
            this.pnlHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.pnlHint.Controls.Add(this.lblHintText);
            this.pnlHint.Location = new System.Drawing.Point(20, 418);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(420, 106);
            this.pnlHint.TabIndex = 19;
            this.pnlHint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHint_Paint);
            // 
            // lblHintText
            // 
            this.lblHintText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHintText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblHintText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHintText.Location = new System.Drawing.Point(0, 0);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.lblHintText.Size = new System.Drawing.Size(420, 106);
            this.lblHintText.TabIndex = 0;
            this.lblHintText.Text = "💡 Regras de Negócio & POE (Programação Orientada a Eventos):\r\n\r\n• Manutenção: Dis" +
    "para alerta de revisão quando o KM atual atingir o limite estipulado.\r\n• Customi" +
    "zação: Registra peças especiais com polimorfismo dinâmico.";
            // 
            // cardHistorico
            // 
            this.cardHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardHistorico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cardHistorico.BorderRadius = 12;
            this.cardHistorico.Controls.Add(this.lblHistoricoBadge);
            this.cardHistorico.Controls.Add(this.dgvHistorico);
            this.cardHistorico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.cardHistorico.HeaderIcon = "📋";
            this.cardHistorico.HeaderTitle = "HISTÓRICO & EVENTOS DE BORDO";
            this.cardHistorico.Location = new System.Drawing.Point(492, 160);
            this.cardHistorico.Name = "cardHistorico";
            this.cardHistorico.Padding = new System.Windows.Forms.Padding(16);
            this.cardHistorico.Size = new System.Drawing.Size(632, 544);
            this.cardHistorico.TabIndex = 6;
            // 
            // lblHistoricoBadge
            // 
            this.lblHistoricoBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoricoBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.lblHistoricoBadge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHistoricoBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHistoricoBadge.Location = new System.Drawing.Point(495, 12);
            this.lblHistoricoBadge.Name = "lblHistoricoBadge";
            this.lblHistoricoBadge.Size = new System.Drawing.Size(120, 24);
            this.lblHistoricoBadge.TabIndex = 1;
            this.lblHistoricoBadge.Text = "0 registros";
            this.lblHistoricoBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(18, 52);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(596, 472);
            this.dgvHistorico.TabIndex = 0;
            // 
            // toastNotification
            // 
            this.toastNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toastNotification.Location = new System.Drawing.Point(360, -70);
            this.toastNotification.Name = "toastNotification";
            this.toastNotification.Size = new System.Drawing.Size(420, 56);
            this.toastNotification.TabIndex = 7;
            this.toastNotification.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1140, 720);
            this.Controls.Add(this.toastNotification);
            this.Controls.Add(this.cardHistorico);
            this.Controls.Add(this.cardNovoRegistro);
            this.Controls.Add(this.kpiKmAtual);
            this.Controls.Add(this.kpiCustomizacoes);
            this.Controls.Add(this.kpiManutencoes);
            this.Controls.Add(this.kpiCustoTotal);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diário de Bordo - Motocicleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardNovoRegistro.ResumeLayout(false);
            this.cardNovoRegistro.PerformLayout();
            this.pnlHint.ResumeLayout(false);
            this.cardHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppIcon;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Label lblStatusPill;
        private System.Windows.Forms.Label lblActiveBike;
        private ModernKpiCard kpiCustoTotal;
        private ModernKpiCard kpiManutencoes;
        private ModernKpiCard kpiCustomizacoes;
        private ModernKpiCard kpiKmAtual;
        private ModernCard cardNovoRegistro;
        private ModernSegmentedToggle toggleTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFornecedorNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFornecedorTelefone;
        private ModernButton btnSalvar;
        private ModernButton btnLimpar;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Label lblHintText;
        private ModernCard cardHistorico;
        private System.Windows.Forms.Label lblHistoricoBadge;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private ModernToast toastNotification;
    }
}
