using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibrary1
{
    public partial class RGBControl : UserControl
    {
        private Color _currentColor;

        private NumberTextBox.Mode _currentType;

        public event EventHandler ChangeColorEvent;

        public RGBControl()
        {
            InitializeComponent();
            _currentType = NumberTextBox.Mode.Dec;
            ntbRed.Text = @"0";
            ntbGreen.Text = @"0";
            ntbBlue.Text = @"0";
            CurColor = Color.Black;
            rbutDec.Checked = true;
            ChangeColorEvent += DrawRectangle;
            ChangeColorEvent.Invoke(this, null);
        }

        public Color CurColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
                e.Graphics.FillRectangle(new SolidBrush(_currentColor), 300, 20, 100, 120);
            
        }

       

        

        private void DrawRectangle(object sender, EventArgs eventArgs)
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(300, 20, 100, 120);
            OnPaint(new PaintEventArgs(graphics, rectangle));
        }

        private void ChangeColor()
        {
            if (!ntbRed.Focused && !ntbGreen.Focused && !ntbBlue.Focused)
            {
                return;
            }

            if (ntbRed.Text == string.Empty || ntbGreen.Text == string.Empty || ntbBlue.Text == string.Empty
                || ntbRed.TextMode != ntbGreen.TextMode || ntbGreen.TextMode != ntbBlue.TextMode)
            {
                return;
            }

            CurColor = _currentType == NumberTextBox.Mode.Dec
                           ? Color.FromArgb(int.Parse(ntbRed.Text), int.Parse(ntbGreen.Text), int.Parse(ntbBlue.Text))
                           : Color.FromArgb(
                               Convert.ToInt32(ntbRed.Text, 16),
                               Convert.ToInt32(ntbGreen.Text, 16),
                               Convert.ToInt32(ntbBlue.Text, 16));
           ChangeColorEvent.Invoke(this, null);
        }

       

        

        private void ntbRed_TextChanged(object sender, EventArgs e)
        {
            ChangeColorEvent += DrawRectangle;
            ChangeColor();
            
           // DrawRectangle();
        }

        private void ntbGreen_TextChanged(object sender, EventArgs e)
        {
            ChangeColorEvent += DrawRectangle;
            ChangeColor();
           
            // DrawRectangle();
        }

        private void ntbBlue_TextChanged(object sender, EventArgs e)
        {
            ChangeColorEvent += DrawRectangle;
            ChangeColor();
           
            // DrawRectangle();
        }

        private void rbutHex_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentType != NumberTextBox.Mode.Dec)
            {
                return;
            }

            _currentType = NumberTextBox.Mode.Hex;
            ntbRed.TextMode = _currentType;
            ntbGreen.TextMode = _currentType;
            ntbBlue.TextMode = _currentType;
        }

        private void rbutDec_CheckedChanged(object sender, EventArgs e)
        {

            if (_currentType != NumberTextBox.Mode.Hex)
            {
                return;
            }

            _currentType = NumberTextBox.Mode.Dec;
            ntbRed.TextMode = _currentType;
            ntbGreen.TextMode = _currentType;
            ntbBlue.TextMode = _currentType;
        }
    }
}
