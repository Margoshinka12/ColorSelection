namespace TestControlsApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rgbControl1 = new WinFormsControlLibrary1.RGBControl();
            this.rgbControl2 = new WinFormsControlLibrary1.RGBControl();
            this.SuspendLayout();
            // 
            // rgbControl1
            // 
            this.rgbControl1.CurColor = System.Drawing.Color.Black;
            this.rgbControl1.Location = new System.Drawing.Point(0, 4);
            this.rgbControl1.Name = "rgbControl1";
            this.rgbControl1.Size = new System.Drawing.Size(863, 290);
            this.rgbControl1.TabIndex = 0;
            // 
            // rgbControl2
            // 
            this.rgbControl2.CurColor = System.Drawing.Color.Black;
            this.rgbControl2.Location = new System.Drawing.Point(0, 210);
            this.rgbControl2.Name = "rgbControl2";
            this.rgbControl2.Size = new System.Drawing.Size(842, 239);
            this.rgbControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rgbControl2);
            this.Controls.Add(this.rgbControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsControlLibrary1.RGBControl rgbControl1;
        private WinFormsControlLibrary1.RGBControl rgbControl2;
    }
}