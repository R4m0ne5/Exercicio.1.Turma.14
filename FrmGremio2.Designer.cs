namespace Exercicio1
{
    partial class FrmGremio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGremio2));
            label2 = new Label();
            BtnGremio2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(501, 25);
            label2.Name = "label2";
            label2.Size = new Size(230, 400);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BtnGremio2
            // 
            BtnGremio2.BackgroundImage = (Image)resources.GetObject("BtnGremio2.BackgroundImage");
            BtnGremio2.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGremio2.ForeColor = SystemColors.Highlight;
            BtnGremio2.Location = new Point(12, 25);
            BtnGremio2.Name = "BtnGremio2";
            BtnGremio2.Size = new Size(473, 386);
            BtnGremio2.TabIndex = 3;
            BtnGremio2.UseVisualStyleBackColor = true;
            BtnGremio2.Click += button1_Click;
            // 
            // FrmGremio2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGremio2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGremio2";
            Text = "FrmGremio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BtnGremio2;
    }
}