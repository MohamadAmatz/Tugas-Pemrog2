namespace TulisanBerjalan
{
    partial class frmTulisanBerjalan
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
            components = new System.ComponentModel.Container();
            iblAnimasi = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // iblAnimasi
            // 
            iblAnimasi.AutoSize = true;
            iblAnimasi.Location = new Point(159, 80);
            iblAnimasi.Name = "iblAnimasi";
            iblAnimasi.Size = new Size(89, 15);
            iblAnimasi.TabIndex = 0;
            iblAnimasi.Text = "Tulisan Berjalan";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(300, 196);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(75, 23);
            btnKeluar.TabIndex = 1;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // frmTulisanBerjalan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 231);
            Controls.Add(btnKeluar);
            Controls.Add(iblAnimasi);
            Name = "frmTulisanBerjalan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tulisan Berjalan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iblAnimasi;
        private System.Windows.Forms.Timer timer1;
        private Button btnKeluar;
    }
}