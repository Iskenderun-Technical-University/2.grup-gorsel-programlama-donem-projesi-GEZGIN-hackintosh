namespace gezen_V2
{
    partial class Form_ankara
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
            this.listBox_denemeankara = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_denemeankara
            // 
            this.listBox_denemeankara.FormattingEnabled = true;
            this.listBox_denemeankara.ItemHeight = 15;
            this.listBox_denemeankara.Location = new System.Drawing.Point(111, 210);
            this.listBox_denemeankara.Name = "listBox_denemeankara";
            this.listBox_denemeankara.Size = new System.Drawing.Size(120, 94);
            this.listBox_denemeankara.TabIndex = 0;
            // 
            // Form_ankara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_denemeankara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ankara";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox_denemeankara;
    }
}