﻿namespace Exercicio1
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
            BtnSairUsuarios.BackColor = SystemColors.ActiveCaptionText;
            BtnSairUsuarios.ForeColor = Color.White;
            BtnSairUsuarios.Location = new Point(25, 380);
            BtnSairUsuarios.Name = "BtnSairUsuarios";
            BtnSairUsuarios.Size = new Size(139, 47);
            BtnSairUsuarios.TabIndex = 2;
            BtnSairUsuarios.Text = "Sair";
            BtnSairUsuarios.UseVisualStyleBackColor = false;
            BtnSairUsuarios.Click += BtnSair_Click;
            // 
            // FrmUsuarios
            // 
            AccessibleRole = AccessibleRole.Caret;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSairUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSairUsuarios;
    }
}