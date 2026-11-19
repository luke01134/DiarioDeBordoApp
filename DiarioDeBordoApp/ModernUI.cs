using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DiarioDeBordoApp
{
    public static class UITheme
    {
        // Paleta Dark Biker / Glassmorphism inspirada em Royal Enfield & Dashboards Modernos
        public static readonly Color Background = Color.FromArgb(15, 18, 24);
        public static readonly Color Surface = Color.FromArgb(22, 27, 36);
        public static readonly Color SurfaceLight = Color.FromArgb(29, 36, 48);
        public static readonly Color SurfaceBorder = Color.FromArgb(42, 52, 68);
        public static readonly Color InputBackground = Color.FromArgb(17, 21, 28);
        public static readonly Color InputBorder = Color.FromArgb(46, 58, 76);
        public static readonly Color InputFocusBorder = Color.FromArgb(229, 57, 53);

        // Acentos
        public static readonly Color AccentRed = Color.FromArgb(229, 57, 53);       // Royal Red (Manutenção)
        public static readonly Color AccentRedHover = Color.FromArgb(244, 67, 54);
        public static readonly Color AccentCyan = Color.FromArgb(2, 132, 199);      // Eletric Cyan (Customização)
        public static readonly Color AccentCyanHover = Color.FromArgb(14, 165, 233);
        public static readonly Color AccentGreen = Color.FromArgb(16, 185, 129);    // Sucesso / KPI
        public static readonly Color AccentAmber = Color.FromArgb(245, 158, 11);    // Alerta

        // Tipografia
        public static readonly Color TextPrimary = Color.FromArgb(248, 250, 252);
        public static readonly Color TextSecondary = Color.FromArgb(148, 163, 184);
        public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);

        // Fontes Padrão
        public static readonly Font FontTitle = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font FontSubtitle = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        public static readonly Font FontSection = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        public static readonly Font FontLabel = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        public static readonly Font FontInput = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static readonly Font FontButton = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font FontKpiValue = new Font("Segoe UI", 15F, FontStyle.Bold);
        public static readonly Font FontKpiTitle = new Font("Segoe UI", 7.5F, FontStyle.Bold);

        // Helper para desenhar retângulos com cantos arredondados
        public static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            // Canto superior esquerdo
            path.AddArc(arc, 180, 90);

            // Canto superior direito
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Canto inferior direito
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Canto inferior esquerdo
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Estilização completa do DataGridView para visual dark fluido
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Surface;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(36, 46, 60);

            // Cabeçalho
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 35, 47);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Linhas Padrão
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(20, 25, 34);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 57, 53);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            // Linhas Alternadas (Zebra)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 41);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 57, 53);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.RowTemplate.Height = 36;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
        }
    }

    /// <summary>
    /// Painel em formato de Card moderno com cantos arredondados, borda suave e anti-aliasing
    /// </summary>
    public class ModernCard : Panel
    {
        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = UITheme.SurfaceBorder;
        public Color FillColor { get; set; } = UITheme.Surface;
        public string HeaderTitle { get; set; } = "";
        public string HeaderIcon { get; set; } = "";

        public ModernCard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.Transparent;
            Padding = new Padding(16);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = UITheme.CreateRoundedRectanglePath(rect, BorderRadius))
            {
                // Preenchimento do Card
                using (SolidBrush brush = new SolidBrush(FillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Borda sutil de vidro / card
                using (Pen pen = new Pen(BorderColor, 1.2F))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Cabeçalho opcional do Card
            if (!string.IsNullOrEmpty(HeaderTitle))
            {
                string textToDraw = string.IsNullOrEmpty(HeaderIcon) ? HeaderTitle : $"{HeaderIcon}  {HeaderTitle}";
                using (SolidBrush textBrush = new SolidBrush(UITheme.TextPrimary))
                {
                    e.Graphics.DrawString(textToDraw, UITheme.FontSection, textBrush, new PointF(18, 14));
                }

                // Linha divisória sutil
                using (Pen dividerPen = new Pen(BorderColor, 1F))
                {
                    e.Graphics.DrawLine(dividerPen, 18, 40, Width - 18, 40);
                }
            }
        }
    }

    /// <summary>
    /// Botão moderno com transições animadas de cor em hover e clique suave
    /// </summary>
    public class ModernButton : Button
    {
        private Color _currentBgColor;
        private Color _targetBgColor;
        private Timer _animTimer;
        private bool _isPressed = false;

        public Color NormalColor { get; set; } = UITheme.AccentRed;
        public Color HoverColor { get; set; } = UITheme.AccentRedHover;
        public Color PressedColor { get; set; } = Color.FromArgb(198, 40, 40);
        public int BorderRadius { get; set; } = 8;
        public Color BorderColor { get; set; } = Color.Transparent;

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = UITheme.FontButton;
            ForeColor = Color.White;
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            _currentBgColor = NormalColor;
            _targetBgColor = NormalColor;

            _animTimer = new Timer();
            _animTimer.Interval = 15;
            _animTimer.Tick += AnimTimer_Tick;
        }

        public void SetAccentColor(Color normal, Color hover, Color pressed)
        {
            NormalColor = normal;
            HoverColor = hover;
            PressedColor = pressed;
            _targetBgColor = normal;
            _currentBgColor = normal;
            Invalidate();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            // Interpolação linear suave (LERP) entre as cores para efeito de fade fluido
            int r = Interpolate(_currentBgColor.R, _targetBgColor.R);
            int g = Interpolate(_currentBgColor.G, _targetBgColor.G);
            int b = Interpolate(_currentBgColor.B, _targetBgColor.B);

            _currentBgColor = Color.FromArgb(r, g, b);

            if (r == _targetBgColor.R && g == _targetBgColor.G && b == _targetBgColor.B)
            {
                _animTimer.Stop();
            }

            Invalidate();
        }

        private int Interpolate(int current, int target)
        {
            int diff = target - current;
            if (Math.Abs(diff) <= 4) return target;
            return current + diff / 3;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _targetBgColor = HoverColor;
            _animTimer.Start();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _targetBgColor = NormalColor;
            _isPressed = false;
            _animTimer.Start();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            _currentBgColor = PressedColor;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            _targetBgColor = HoverColor;
            _animTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = UITheme.CreateRoundedRectanglePath(rect, BorderRadius))
            {
                // Fundo com a cor animada
                using (SolidBrush brush = new SolidBrush(_currentBgColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                // Borda opcional
                if (BorderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(BorderColor, 1.2F))
                    {
                        pevent.Graphics.DrawPath(pen, path);
                    }
                }
            }

            // Desenha o texto centralizado com feedback de clique tátil
            int yOffset = _isPressed ? 1 : 0;
            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                new Rectangle(0, yOffset, Width, Height),
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
            );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _animTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    /// <summary>
    /// Seletor segmentado moderno com pílula de transição animada e suave entre opções
    /// </summary>
    public class ModernSegmentedToggle : Control
    {
        private int _selectedIndex = 0;
        private float _currentIndicatorX = 4f;
        private float _targetIndicatorX = 4f;
        private Timer _slideTimer;

        public event EventHandler SelectedIndexChanged;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex != value && (value == 0 || value == 1))
                {
                    _selectedIndex = value;
                    UpdateTarget();
                    _slideTimer.Start();
                    SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public ModernSegmentedToggle()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Size = new Size(380, 40);

            _slideTimer = new Timer();
            _slideTimer.Interval = 15;
            _slideTimer.Tick += SlideTimer_Tick;
        }

        private void UpdateTarget()
        {
            float segWidth = (Width - 8f) / 2f;
            _targetIndicatorX = _selectedIndex == 0 ? 4f : 4f + segWidth;
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            float diff = _targetIndicatorX - _currentIndicatorX;
            if (Math.Abs(diff) < 0.8f)
            {
                _currentIndicatorX = _targetIndicatorX;
                _slideTimer.Stop();
            }
            else
            {
                _currentIndicatorX += diff * 0.35f; // Easing suave
            }
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTarget();
            _currentIndicatorX = _targetIndicatorX;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int newIndex = e.X < Width / 2 ? 0 : 1;
            SelectedIndex = newIndex;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Fundo da barra segmentada
            Rectangle bgRect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath bgPath = UITheme.CreateRoundedRectanglePath(bgRect, Height / 2))
            {
                using (SolidBrush bgBrush = new SolidBrush(UITheme.InputBackground))
                {
                    e.Graphics.FillPath(bgBrush, bgPath);
                }
                using (Pen borderPen = new Pen(UITheme.SurfaceBorder, 1.2F))
                {
                    e.Graphics.DrawPath(borderPen, bgPath);
                }
            }

            // Pílula indicadora animada
            float segWidth = (Width - 8f) / 2f;
            RectangleF indRect = new RectangleF(_currentIndicatorX, 4f, segWidth, Height - 8f);
            Color activeColor = _selectedIndex == 0 ? UITheme.AccentRed : UITheme.AccentCyan;

            using (GraphicsPath indPath = UITheme.CreateRoundedRectanglePath(Rectangle.Round(indRect), (int)(indRect.Height / 2)))
            {
                using (SolidBrush indBrush = new SolidBrush(activeColor))
                {
                    e.Graphics.FillPath(indBrush, indPath);
                }
            }

            // Textos das duas opções
            Rectangle firstRect = new Rectangle(4, 0, (int)segWidth, Height);
            Rectangle secondRect = new Rectangle((int)(4 + segWidth), 0, (int)segWidth, Height);

            Color firstTextColor = _selectedIndex == 0 ? Color.White : UITheme.TextSecondary;
            Color secondTextColor = _selectedIndex == 1 ? Color.White : UITheme.TextSecondary;

            TextRenderer.DrawText(e.Graphics, "🔧 Manutenção", Font, firstRect, firstTextColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            TextRenderer.DrawText(e.Graphics, "✨ Customização", Font, secondRect, secondTextColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _slideTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    /// <summary>
    /// Card de Métrica / KPI moderno para visualização executiva no topo
    /// </summary>
    public class ModernKpiCard : Panel
    {
        private string _value = "0";
        public string Title { get; set; } = "MÉTRICA";
        public string IconSymbol { get; set; } = "📊";
        public Color AccentColor { get; set; } = UITheme.AccentRed;

        public string ValueText
        {
            get => _value;
            set
            {
                _value = value;
                Invalidate();
            }
        }

        public ModernKpiCard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.Transparent;
            Size = new Size(240, 72);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = UITheme.CreateRoundedRectanglePath(rect, 10))
            {
                // Fundo do card
                using (SolidBrush brush = new SolidBrush(UITheme.Surface))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Borda
                using (Pen pen = new Pen(UITheme.SurfaceBorder, 1.2F))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Faixa de destaque com a cor do acento à esquerda
            Rectangle accentBar = new Rectangle(0, 8, 4, Height - 16);
            using (SolidBrush accentBrush = new SolidBrush(AccentColor))
            {
                e.Graphics.FillRectangle(accentBrush, accentBar);
            }

            // Ícone à esquerda
            using (Font iconFont = new Font("Segoe UI", 16F))
            {
                TextRenderer.DrawText(e.Graphics, IconSymbol, iconFont, new Point(14, 18), AccentColor);
            }

            // Título (uppercase sutil)
            TextRenderer.DrawText(
                e.Graphics,
                Title.ToUpper(),
                UITheme.FontKpiTitle,
                new Point(54, 14),
                UITheme.TextSecondary
            );

            // Valor em destaque
            TextRenderer.DrawText(
                e.Graphics,
                _value,
                UITheme.FontKpiValue,
                new Point(54, 30),
                UITheme.TextPrimary
            );
        }
    }

    /// <summary>
    /// Notificação flutuante tipo Toast com animação suave de descida e auto-dismiss
    /// </summary>
    public class ModernToast : Panel
    {
        private Timer _animTimer;
        private Timer _dismissTimer;
        private int _targetY = 16;
        private int _hiddenY = -80;
        private bool _isShowing = false;
        private string _title = "Notificação";
        private string _message = "";
        private Color _accentColor = UITheme.AccentGreen;
        private string _icon = "✅";

        public ModernToast()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Size = new Size(420, 56);
            Visible = false;
            Location = new Point(100, _hiddenY);

            _animTimer = new Timer();
            _animTimer.Interval = 15;
            _animTimer.Tick += AnimTimer_Tick;

            _dismissTimer = new Timer();
            _dismissTimer.Interval = 3200;
            _dismissTimer.Tick += (s, e) =>
            {
                _dismissTimer.Stop();
                HideToast();
            };
        }

        public void ShowToast(string title, string message, Color accent, string icon = "✅")
        {
            _title = title;
            _message = message;
            _accentColor = accent;
            _icon = icon;

            if (Parent != null)
            {
                Left = (Parent.ClientSize.Width - Width) / 2;
            }

            Top = _hiddenY;
            Visible = true;
            BringToFront();

            _isShowing = true;
            _animTimer.Start();
            _dismissTimer.Stop();
            _dismissTimer.Start();
            Invalidate();
        }

        public void HideToast()
        {
            _isShowing = false;
            _animTimer.Start();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            int destY = _isShowing ? _targetY : _hiddenY;
            int diff = destY - Top;

            if (Math.Abs(diff) <= 2)
            {
                Top = destY;
                _animTimer.Stop();
                if (!_isShowing)
                {
                    Visible = false;
                }
            }
            else
            {
                Top += (int)(diff * 0.35f);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = UITheme.CreateRoundedRectanglePath(rect, 10))
            {
                // Fundo escuro fosco com leve transparência
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(245, 20, 26, 36)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Borda colorida de alerta/sucesso
                using (Pen pen = new Pen(_accentColor, 1.5F))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Ícone
            using (Font iconFont = new Font("Segoe UI", 14F))
            {
                TextRenderer.DrawText(e.Graphics, _icon, iconFont, new Point(14, 12), Color.White);
            }

            // Título
            using (Font titleFont = new Font("Segoe UI", 9.5F, FontStyle.Bold))
            {
                TextRenderer.DrawText(e.Graphics, _title, titleFont, new Point(50, 10), Color.White);
            }

            // Mensagem
            using (Font msgFont = new Font("Segoe UI", 8.5F, FontStyle.Regular))
            {
                TextRenderer.DrawText(e.Graphics, _message, msgFont, new Point(50, 28), UITheme.TextSecondary);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _animTimer?.Dispose();
                _dismissTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

