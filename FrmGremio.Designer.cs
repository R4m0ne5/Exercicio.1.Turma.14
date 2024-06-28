namespace Exercicio1
{
    partial class FrmGremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGremio));
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(349, 24);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(385, 394);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 425);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FrmGremio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGremio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGremio";
            TopMost = true;
            Load += FrmGremio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}