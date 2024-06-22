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
            BtnSair = new Button();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.BackColor = SystemColors.ActiveCaptionText;
            BtnSair.ForeColor = Color.White;
            BtnSair.Location = new Point(38, 371);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(139, 47);
            BtnSair.TabIndex = 2;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmUsuarios
            // 
            AccessibleRole = AccessibleRole.Caret;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            ShowIcon = false;
            ShowInTaskbar = false;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSair;
    }
}