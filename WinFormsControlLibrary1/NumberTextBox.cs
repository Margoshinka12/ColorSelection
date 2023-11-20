using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsControlLibrary1
{
    public partial class NumberTextBox : TextBox
    {
       
        private readonly Regex allowedLettersForHex = new Regex("(\\d|[a-f])");

        private readonly Regex allowedLettersForDec = new Regex("\\d");

      
        private Mode textMode;

        public EventHandler ModeChanged;

        public NumberTextBox()
        {
            InitializeComponent();
            ModeChanged += OnModeChanged;
            MaxLength = 3;
        }

        
        public NumberTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ModeChanged += OnModeChanged;
            MaxLength = 3;
        }

       
        public enum Mode
        {
            
            Dec,

            
            Hex
        }

        public Mode TextMode
        {
            get => textMode;
            set
            {
                textMode = value;
                ModeChanged.Invoke(this, null);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (TextMode != Mode.Hex || !Regex.IsMatch(e.KeyChar.ToString(), allowedLettersForHex.ToString(), RegexOptions.IgnoreCase))
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            foreach (var letter in Text)
            {
                if (TextMode == Mode.Hex && Regex.IsMatch(
                        letter.ToString(),
                        allowedLettersForHex.ToString(),
                        RegexOptions.IgnoreCase) || TextMode == Mode.Dec && Regex.IsMatch(
                        letter.ToString(),
                        allowedLettersForDec.ToString(),
                        RegexOptions.IgnoreCase)) continue;
                Undo();
                break;
            }

            if (Text != string.Empty)
            {
                Text = Text.ToUpper();
                int n;
                if (textMode == Mode.Hex)
                {
                    n = Convert.ToInt32(Text, 16);
                    if (n > 255)
                    {
                        Text = @"FF";
                    }
                }
                else
                {
                    if (!int.TryParse(Text, out _))
                    {
                        Text = @"0";
                    }
                    else
                    {
                        n = Convert.ToInt32(Text);
                        if (n > 255)
                        {
                            Text = @"255";
                        }
                    }
                }
            }

            base.OnTextChanged(e);
        }

        private void OnModeChanged(object sender, EventArgs eventArgs)
        {
            switch (textMode)
            {
                case Mode.Dec:
                    {
                        Text = Text != "" ? Convert.ToInt32(Text, 16).ToString() : "";
                        MaxLength = 3;
                        break;
                    }
                case Mode.Hex:
                    {
                        Text = $@"{int.Parse(Text):X}";
                        MaxLength = 2;
                        break;
                    }
            }
        }
    }
}
