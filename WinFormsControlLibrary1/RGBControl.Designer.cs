namespace WinFormsControlLibrary1
{
    partial class RGBControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ntbBlue = new WinFormsControlLibrary1.NumberTextBox(this.components);
            this.ntbGreen = new WinFormsControlLibrary1.NumberTextBox(this.components);
            this.ntbRed = new WinFormsControlLibrary1.NumberTextBox(this.components);
            this.labRed = new System.Windows.Forms.Label();
            this.labGreen = new System.Windows.Forms.Label();
            this.labBlue = new System.Windows.Forms.Label();
            this.rbutDec = new System.Windows.Forms.RadioButton();
            this.rbutHex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ntbBlue
            // 
            this.ntbBlue.Location = new System.Drawing.Point(119, 104);
            this.ntbBlue.MaxLength = 3;
            this.ntbBlue.Name = "ntbBlue";
            this.ntbBlue.Size = new System.Drawing.Size(125, 27);
            this.ntbBlue.TabIndex = 0;
            this.ntbBlue.TextMode = WinFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbBlue.TextChanged += new System.EventHandler(this.ntbBlue_TextChanged);
            // 
            // ntbGreen
            // 
            this.ntbGreen.Location = new System.Drawing.Point(119, 63);
            this.ntbGreen.MaxLength = 3;
            this.ntbGreen.Name = "ntbGreen";
            this.ntbGreen.Size = new System.Drawing.Size(125, 27);
            this.ntbGreen.TabIndex = 1;
            this.ntbGreen.TextMode = WinFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbGreen.TextChanged += new System.EventHandler(this.ntbGreen_TextChanged);
            // 
            // ntbRed
            // 
            this.ntbRed.Location = new System.Drawing.Point(119, 23);
            this.ntbRed.MaxLength = 3;
            this.ntbRed.Name = "ntbRed";
            this.ntbRed.Size = new System.Drawing.Size(125, 27);
            this.ntbRed.TabIndex = 2;
            this.ntbRed.TextMode = WinFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbRed.TextChanged += new System.EventHandler(this.ntbRed_TextChanged);
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.Location = new System.Drawing.Point(16, 30);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(71, 20);
            this.labRed.TabIndex = 3;
            this.labRed.Text = "Красный";
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.Location = new System.Drawing.Point(16, 70);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(70, 20);
            this.labGreen.TabIndex = 4;
            this.labGreen.Text = "Зелёный";
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.Location = new System.Drawing.Point(16, 111);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(54, 20);
            this.labBlue.TabIndex = 5;
            this.labBlue.Text = "Синий";
            // 
            // rbutDec
            // 
            this.rbutDec.AutoSize = true;
            this.rbutDec.Location = new System.Drawing.Point(8, 164);
            this.rbutDec.Name = "rbutDec";
            this.rbutDec.Size = new System.Drawing.Size(56, 24);
            this.rbutDec.TabIndex = 6;
            this.rbutDec.TabStop = true;
            this.rbutDec.Text = "Dec";
            this.rbutDec.UseVisualStyleBackColor = true;
            this.rbutDec.CheckedChanged += new System.EventHandler(this.rbutDec_CheckedChanged);
            // 
            // rbutHex
            // 
            this.rbutHex.AutoSize = true;
            this.rbutHex.Location = new System.Drawing.Point(89, 164);
            this.rbutHex.Name = "rbutHex";
            this.rbutHex.Size = new System.Drawing.Size(56, 24);
            this.rbutHex.TabIndex = 7;
            this.rbutHex.TabStop = true;
            this.rbutHex.Text = "Hex";
            this.rbutHex.UseVisualStyleBackColor = true;
            this.rbutHex.CheckedChanged += new System.EventHandler(this.rbutHex_CheckedChanged);
            // 
            // RGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbutHex);
            this.Controls.Add(this.rbutDec);
            this.Controls.Add(this.labBlue);
            this.Controls.Add(this.labGreen);
            this.Controls.Add(this.labRed);
            this.Controls.Add(this.ntbRed);
            this.Controls.Add(this.ntbGreen);
            this.Controls.Add(this.ntbBlue);
            this.Name = "RGBControl";
            this.Size = new System.Drawing.Size(674, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextBox ntbBlue;
        private NumberTextBox ntbGreen;
        private NumberTextBox ntbRed;
        private Label labRed;
        private Label labGreen;
        private Label labBlue;
        private RadioButton rbutDec;
        private RadioButton rbutHex;
    }
}
