namespace gezen_V2
{
    partial class Form_ermenek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_denemeErmenek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_denemeErmenek
            // 
            this.button_denemeErmenek.Location = new System.Drawing.Point(232, 117);
            this.button_denemeErmenek.Name = "button_denemeErmenek";
            this.button_denemeErmenek.Size = new System.Drawing.Size(295, 23);
            this.button_denemeErmenek.TabIndex = 0;
            this.button_denemeErmenek.Text = "ırmağının akışına ölürüm ermenek";
            this.button_denemeErmenek.UseVisualStyleBackColor = true;
            // 
            // Form_ermenek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_denemeErmenek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ermenek";
            this.Text = "Form9";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_denemeErmenek;
    }
}