namespace Exercicio1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BtnSair = new Button();
            BtnUsuarios = new Button();
            BtnChamados = new Button();
            BtnGremio = new Button();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.BackColor = SystemColors.ActiveCaptionText;
            BtnSair.ForeColor = Color.White;
            BtnSair.Location = new Point(25, 367);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(165, 61);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = SystemColors.GradientActiveCaption;
            BtnUsuarios.ForeColor = SystemColors.ActiveCaptionText;
            BtnUsuarios.Location = new Point(102, 105);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(270, 147);
            BtnUsuarios.TabIndex = 4;
            BtnUsuarios.Text = "Usuários";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnChamados
            // 
            BtnChamados.BackColor = SystemColors.GradientActiveCaption;
            BtnChamados.ForeColor = SystemColors.ActiveCaptionText;
            BtnChamados.Location = new Point(419, 105);
            BtnChamados.Name = "BtnChamados";
            BtnChamados.Size = new Size(275, 147);
            BtnChamados.TabIndex = 5;
            BtnChamados.Text = "Chamados";
            BtnChamados.UseVisualStyleBackColor = false;
            BtnChamados.Click += BtnChamados_Click;
            // 
            // BtnGremio
            // 
            BtnGremio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGremio.BackColor = SystemColors.Highlight;
            BtnGremio.BackgroundImage = (Image)resources.GetObject("BtnGremio.BackgroundImage");
            BtnGremio.FlatStyle = FlatStyle.Popup;
            BtnGremio.ForeColor = SystemColors.ControlLightLight;
            BtnGremio.Location = new Point(520, 283);
            BtnGremio.Margin = new Padding(0);
            BtnGremio.Name = "BtnGremio";
            BtnGremio.Size = new Size(249, 145);
            BtnGremio.TabIndex = 6;
            BtnGremio.UseVisualStyleBackColor = false;
            BtnGremio.Click += BtnGremio_Click_1;
            // 
            // FrmPrincipal
            // 
            AccessibleRole = AccessibleRole.Caret;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(BtnGremio);
            Controls.Add(BtnChamados);
            Controls.Add(BtnUsuarios);
            Controls.Add(BtnSair);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSair;
        private Button BtnUsuarios;
        private Button BtnChamados;
        private Button BtnGremio;
    }
}