namespace Exercicio1
{
    partial class FrmUsuarios
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
            BtnSairUsuarios = new Button();
            SuspendLayout();
            // 
            // BtnSairUsuarios
            // 
            BtnSairUsuarios.BackColor = SystemColors.InactiveCaptionText;
            BtnSairUsuarios.ForeColor = SystemColors.ButtonFace;
            BtnSairUsuarios.Location = new Point(33, 381);
            BtnSairUsuarios.Name = "BtnSairUsuarios";
            BtnSairUsuarios.Size = new Size(137, 44);
            BtnSairUsuarios.TabIndex = 0;
            BtnSairUsuarios.Text = "Sair";
            BtnSairUsuarios.UseVisualStyleBackColor = false;
            BtnSairUsuarios.Click += BtnSairUsuarios_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSairUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSairUsuarios;
    }
}