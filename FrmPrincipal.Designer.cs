namespace Exercicio1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BtnUsuarios = new GroupBox();
            button2 = new Button();
            BtnChamados = new Button();
            BtnSair = new Button();
            button1 = new Button();
            BtnUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.White;
            BtnUsuarios.Controls.Add(button2);
            BtnUsuarios.Controls.Add(BtnChamados);
            BtnUsuarios.Controls.Add(BtnSair);
            BtnUsuarios.Controls.Add(button1);
            BtnUsuarios.ForeColor = SystemColors.ButtonFace;
            BtnUsuarios.Location = new Point(44, 41);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(690, 362);
            BtnUsuarios.TabIndex = 0;
            BtnUsuarios.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(486, 220);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(224, 139);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // BtnChamados
            // 
            BtnChamados.BackColor = SystemColors.GradientActiveCaption;
            BtnChamados.ForeColor = SystemColors.ActiveCaptionText;
            BtnChamados.Location = new Point(376, 89);
            BtnChamados.Name = "BtnChamados";
            BtnChamados.Size = new Size(250, 132);
            BtnChamados.TabIndex = 2;
            BtnChamados.Text = "Chamados";
            BtnChamados.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = SystemColors.ActiveCaptionText;
            BtnSair.Location = new Point(23, 298);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(139, 47);
            BtnSair.TabIndex = 1;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(66, 89);
            button1.Name = "button1";
            button1.Size = new Size(250, 132);
            button1.TabIndex = 0;
            button1.Text = "Usuários";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(BtnUsuarios);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            BtnUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BtnUsuarios;
        private Button button1;
        private Button BtnChamados;
        private Button BtnSair;
        private Button button2;
    }
}
