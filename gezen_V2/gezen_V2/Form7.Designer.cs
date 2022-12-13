namespace gezen_V2
{
    partial class Form_kilis
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
            this.button_denemeKilis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_denemeKilis
            // 
            this.button_denemeKilis.Location = new System.Drawing.Point(234, 168);
            this.button_denemeKilis.Name = "button_denemeKilis";
            this.button_denemeKilis.Size = new System.Drawing.Size(126, 23);
            this.button_denemeKilis.TabIndex = 0;
            this.button_denemeKilis.Text = "hiçbir şey yok";
            this.button_denemeKilis.UseVisualStyleBackColor = true;
            // 
            // Form_kilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_denemeKilis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_kilis";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_denemeKilis;
    }
}