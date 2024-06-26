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
            BtnSairChamados.BackColor = SystemColors.ActiveCaptionText;
            BtnSairChamados.ForeColor = Color.White;
            BtnSairChamados.Location = new Point(25, 381);
            BtnSairChamados.Name = "BtnSairChamados";
            BtnSairChamados.Size = new Size(139, 47);
            BtnSairChamados.TabIndex = 3;
            BtnSairChamados.Text = "Sair";
            BtnSairChamados.UseVisualStyleBackColor = false;
            // 
            // FrmChamados
            // 
            AccessibleRole = AccessibleRole.Caret;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSairChamados);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChamados";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSairChamados;
    }
}