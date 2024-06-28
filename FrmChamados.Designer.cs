namespace Exercicio1
{
    partial class FrmChamados
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
            BtnSairChamados = new Button();
            SuspendLayout();
            // 
            // BtnSairChamados
            // 
            BtnSairChamados.BackColor = SystemColors.InactiveCaptionText;
            BtnSairChamados.ForeColor = SystemColors.ButtonFace;
            BtnSairChamados.Location = new Point(29, 376);
            BtnSairChamados.Name = "BtnSairChamados";
            BtnSairChamados.Size = new Size(137, 44);
            BtnSairChamados.TabIndex = 1;
            BtnSairChamados.Text = "Sair";
            BtnSairChamados.UseVisualStyleBackColor = false;
            BtnSairChamados.Click += BtnSairChamados_Click;
            // 
            // FrmChamados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSairChamados);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChamados";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSairChamados;
    }
}