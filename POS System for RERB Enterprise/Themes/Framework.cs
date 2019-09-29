using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_for_RERB_Enterprise.Themes
{
    #region RoundRectangle

    static class RoundRectangle
    {
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }
        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }
        public static GraphicsPath RoundedTopRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddLine(new Point(Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth), new Point(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height - 1));
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - 1 + Rectangle.Y), new Point(Rectangle.X, Rectangle.Y + Curve));
            return P;
        }
    }

    #endregion
    #region TextBox

    [DefaultEvent("TextChanged")]
    class Framework_Textbox : Control
    {
        #region Variables

        public TextBox framework = new TextBox();
        private GraphicsPath Shape;
        private int _maxchars = 32767;
        private bool _ReadOnly;
        private bool _Multiline;
        private HorizontalAlignment ALNType;
        private bool isPasswordMasked = false;
        private Pen P1;
        private SolidBrush B1;

        #endregion
        #region Properties

        public HorizontalAlignment TextAlignment
        {
            get { return ALNType; }
            set
            {
                ALNType = value;
                Invalidate();
            }
        }
        public int MaxLength
        {
            get { return _maxchars; }
            set
            {
                _maxchars = value;
                framework.MaxLength = 11;
                Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get { return isPasswordMasked; }
            set
            {
                framework.UseSystemPasswordChar = UseSystemPasswordChar;
                isPasswordMasked = value;
                Invalidate();
            }
        }
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (framework != null)
                {
                    framework.ReadOnly = value;
                }
            }
        }
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (framework != null)
                {
                    framework.Multiline = value;

                    if (value)
                    {
                        framework.Height = Height - 10;
                    }
                    else
                    {
                        Height = framework.Height + 10;
                    }
                }
            }
        }

        #endregion
        #region EventArgs

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            framework.Text = Text;
            Invalidate();
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = framework.Text;
        }

        protected override void OnForeColorChanged(System.EventArgs e)
        {
            base.OnForeColorChanged(e);
            framework.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnFontChanged(System.EventArgs e)
        {
            base.OnFontChanged(e);
            framework.Font = Font;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void _OnKeyDown(object Obj, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                framework.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                framework.Copy();
                e.SuppressKeyPress = true;
            }
        }

        private void _Enter(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(205, 87, 40));
            Refresh();
        }
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _Leave(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(180, 180, 180));
            Refresh();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (_Multiline)
            {
                framework.Height = Height - 10;
            }
            else
            {
                Height = framework.Height + 10;
            }

            Shape = new GraphicsPath();
            var _with1 = Shape;
            _with1.AddArc(0, 0, 10, 10, 180, 90);
            _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            _with1.CloseAllFigures();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            framework.Focus();
        }

        #endregion
        public void AddTextBox()
        {
            var _TB = framework;
            _TB.Size = new Size(Width - 10, 33);
            _TB.Location = new Point(7, 4);
            _TB.Text = String.Empty;
            _TB.BorderStyle = BorderStyle.None;
            _TB.TextAlign = HorizontalAlignment.Left;
            _TB.Font = new Font("Century Gothic", 11);
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;
            _TB.Multiline = false;
            framework.KeyDown += _OnKeyDown;
            framework.Enter += _Enter;
            framework.Leave += _Leave;
            framework.TextChanged += OnBaseTextChanged;
            framework.KeyPress += _KeyPress;

        }

        public Framework_Textbox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            AddTextBox();
            Controls.Add(framework);

            P1 = new Pen(Color.FromArgb(180, 180, 180)); // P1 = Border color
            B1 = new SolidBrush(Color.White); // B1 = Rect Background color
            BackColor = Color.Transparent;
            ForeColor = Color.DimGray;

            Text = null;
            Font = new Font("Century Gothic", 11);
            Size = new Size(135, 33);
            DoubleBuffered = true;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.AntiAlias;

            var _TB = framework;
            _TB.Width = Width - 10;
            _TB.TextAlign = TextAlignment;
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;

            G.Clear(Color.Transparent);
            G.FillPath(B1, Shape); // Draw background
            G.DrawPath(P1, Shape); // Draw border

            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }

    }

    #endregion
    #region TextBox Price

    [DefaultEvent("TextChanged")]
    class Framework_Prices : Control
    {
        #region Variables

        public TextBox framework = new TextBox();
        private GraphicsPath Shape;
        private int _maxchars = 32767;
        private bool _ReadOnly;
        private bool _Multiline;
        private HorizontalAlignment ALNType;
        private bool isPasswordMasked = false;
        private Pen P1;
        private SolidBrush B1;

        #endregion
        #region Properties

        public HorizontalAlignment TextAlignment
        {
            get { return ALNType; }
            set
            {
                ALNType = value;
                Invalidate();
            }
        }
        public int MaxLength
        {
            get { return _maxchars; }
            set
            {
                _maxchars = value;
                framework.MaxLength = 11;
                Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get { return isPasswordMasked; }
            set
            {
                framework.UseSystemPasswordChar = UseSystemPasswordChar;
                isPasswordMasked = value;
                Invalidate();
            }
        }
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (framework != null)
                {
                    framework.ReadOnly = value;
                }
            }
        }
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (framework != null)
                {
                    framework.Multiline = value;

                    if (value)
                    {
                        framework.Height = Height - 10;
                    }
                    else
                    {
                        Height = framework.Height + 10;
                    }
                }
            }
        }

        #endregion
        #region EventArgs

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            framework.Text = Text;
            Invalidate();
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = framework.Text;
        }

        protected override void OnForeColorChanged(System.EventArgs e)
        {
            base.OnForeColorChanged(e);
            framework.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnFontChanged(System.EventArgs e)
        {
            base.OnFontChanged(e);
            framework.Font = Font;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void _OnKeyDown(object Obj, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                framework.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                framework.Copy();
                e.SuppressKeyPress = true;
            }
        }

        private void _OnKeyUp(object Obj, KeyEventArgs e)
        {
            if (framework.Text.Length >= 2)
            {
                int selectionStart = framework.SelectionStart;
                framework.Text = framework.Text.Replace(".", "");
                int length = framework.Text.Length;
                framework.Text = framework.Text.Insert(length - 2, ".");
                if (framework.Text.Length > 3)
                    framework.SelectionStart = selectionStart;
            }
        }

        private void _Enter(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(205, 87, 40));
            Refresh();
        }
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void _Leave(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(180, 180, 180));
            Refresh();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (_Multiline)
            {
                framework.Height = Height - 10;
            }
            else
            {
                Height = framework.Height + 10;
            }

            Shape = new GraphicsPath();
            var _with1 = Shape;
            _with1.AddArc(0, 0, 10, 10, 180, 90);
            _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            _with1.CloseAllFigures();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            framework.Focus();
        }

        #endregion
        public void AddTextBox()
        {
            var _TB = framework;
            _TB.Size = new Size(Width - 10, 33);
            _TB.Location = new Point(7, 4);
            _TB.Text = String.Empty;
            _TB.BorderStyle = BorderStyle.None;
            _TB.TextAlign = HorizontalAlignment.Left;
            _TB.Font = new Font("Century Gothic", 11);
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;
            _TB.Multiline = false;
            framework.KeyDown += _OnKeyDown;
            framework.Enter += _Enter;
            framework.Leave += _Leave;
            framework.TextChanged += OnBaseTextChanged;
            framework.KeyPress += _KeyPress;
            framework.KeyUp += _OnKeyUp;
        }

        public Framework_Prices()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            AddTextBox();
            Controls.Add(framework);

            P1 = new Pen(Color.FromArgb(180, 180, 180)); // P1 = Border color
            B1 = new SolidBrush(Color.White); // B1 = Rect Background color
            BackColor = Color.Transparent;
            ForeColor = Color.DimGray;

            Text = null;
            Font = new Font("Century Gothic", 11);
            Size = new Size(135, 33);
            DoubleBuffered = true;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.AntiAlias;

            var _TB = framework;
            _TB.Width = Width - 10;
            _TB.TextAlign = TextAlignment;
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;

            G.Clear(Color.Transparent);
            G.FillPath(B1, Shape); // Draw background
            G.DrawPath(P1, Shape); // Draw border

            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }

    }

    #endregion
    #region TextBox

    [DefaultEvent("TextChanged")]
    class Framework_Textboxco : Control
    {
        #region Variables

        public TextBox framework = new TextBox();
        private GraphicsPath Shape;
        private int _maxchars = 32767;
        private bool _ReadOnly;
        private bool _Multiline;
        private HorizontalAlignment ALNType;
        private bool isPasswordMasked = false;
        private Pen P1;
        private SolidBrush B1;

        #endregion
        #region Properties

        public HorizontalAlignment TextAlignment
        {
            get { return ALNType; }
            set
            {
                ALNType = value;
                Invalidate();
            }
        }
        public int MaxLength
        {
            get { return _maxchars; }
            set
            {
                _maxchars = value;
                framework.MaxLength = 10;
                Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get { return isPasswordMasked; }
            set
            {
                framework.UseSystemPasswordChar = UseSystemPasswordChar;
                isPasswordMasked = value;
                Invalidate();
            }
        }
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (framework != null)
                {
                    framework.ReadOnly = value;
                }
            }
        }
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (framework != null)
                {
                    framework.Multiline = value;

                    if (value)
                    {
                        framework.Height = Height - 10;
                    }
                    else
                    {
                        Height = framework.Height + 10;
                    }
                }
            }
        }

        #endregion
        #region EventArgs

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            framework.Text = Text;
            Invalidate();
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = framework.Text;
        }

        protected override void OnForeColorChanged(System.EventArgs e)
        {
            base.OnForeColorChanged(e);
            framework.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnFontChanged(System.EventArgs e)
        {
            base.OnFontChanged(e);
            framework.Font = Font;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void _OnKeyDown(object Obj, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                framework.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                framework.Copy();
                e.SuppressKeyPress = true;
            }
        }

        private void _Enter(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(205, 87, 40));
            Refresh();
        }
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _Leave(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(180, 180, 180));
            Refresh();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (_Multiline)
            {
                framework.Height = Height - 10;
            }
            else
            {
                Height = framework.Height + 10;
            }

            Shape = new GraphicsPath();
            var _with1 = Shape;
            _with1.AddArc(0, 0, 10, 10, 180, 90);
            _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            _with1.CloseAllFigures();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            framework.Focus();
        }

        #endregion
        public void AddTextBox()
        {
            var _TB = framework;
            _TB.Size = new Size(Width - 10, 33);
            _TB.Location = new Point(7, 4);
            _TB.Text = String.Empty;
            _TB.BorderStyle = BorderStyle.None;
            _TB.TextAlign = HorizontalAlignment.Left;
            _TB.Font = new Font("Century Gothic", 11);
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;
            _TB.Multiline = false;
            framework.KeyDown += _OnKeyDown;
            framework.Enter += _Enter;
            framework.Leave += _Leave;
            framework.TextChanged += OnBaseTextChanged;
            framework.KeyPress += _KeyPress;

        }

        public Framework_Textboxco()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            AddTextBox();
            Controls.Add(framework);

            P1 = new Pen(Color.FromArgb(180, 180, 180)); // P1 = Border color
            B1 = new SolidBrush(Color.White); // B1 = Rect Background color
            BackColor = Color.Transparent;
            ForeColor = Color.DimGray;

            Text = null;
            Font = new Font("Century Gothic", 11);
            Size = new Size(135, 33);
            DoubleBuffered = true;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.AntiAlias;

            var _TB = framework;
            _TB.Width = Width - 10;
            _TB.TextAlign = TextAlignment;
            _TB.UseSystemPasswordChar = UseSystemPasswordChar;

            G.Clear(Color.Transparent);
            G.FillPath(B1, Shape); // Draw background
            G.DrawPath(P1, Shape); // Draw border

            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }

    }

    #endregion
}
