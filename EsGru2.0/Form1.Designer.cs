namespace EsGru2._0
{
    partial class Form1
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
            label1 = new Label();
            InviaDenaro = new Button();
            RiceviDenaro = new Button();
            numericUpDown1 = new NumericUpDown();
            QTAdenaro = new Label();
            label2 = new Label();
            InviaDenaro2 = new Button();
            PrelevaDenaro2 = new Button();
            label3 = new Label();
            label4 = new Label();
            TastoBonifico = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Saldo Conto 1";
            label1.Click += label1_Click;
            // 
            // InviaDenaro
            // 
            InviaDenaro.Location = new Point(11, 63);
            InviaDenaro.Margin = new Padding(2);
            InviaDenaro.Name = "InviaDenaro";
            InviaDenaro.Size = new Size(140, 61);
            InviaDenaro.TabIndex = 2;
            InviaDenaro.Text = "Invia Denaro Conto 1";
            InviaDenaro.UseVisualStyleBackColor = true;
            InviaDenaro.Click += InviaDenaro_Click;
            // 
            // RiceviDenaro
            // 
            RiceviDenaro.Location = new Point(11, 128);
            RiceviDenaro.Margin = new Padding(2);
            RiceviDenaro.Name = "RiceviDenaro";
            RiceviDenaro.Size = new Size(140, 61);
            RiceviDenaro.TabIndex = 3;
            RiceviDenaro.Text = "Preleva Denaro Conto 1";
            RiceviDenaro.UseVisualStyleBackColor = true;
            RiceviDenaro.Click += RiceviDenaro_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(232, 117);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // QTAdenaro
            // 
            QTAdenaro.AutoSize = true;
            QTAdenaro.Location = new Point(251, 86);
            QTAdenaro.Margin = new Padding(2, 0, 2, 0);
            QTAdenaro.Name = "QTAdenaro";
            QTAdenaro.Size = new Size(69, 15);
            QTAdenaro.TabIndex = 5;
            QTAdenaro.Text = "QTA Denaro";
            QTAdenaro.Click += QTAdenaro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // InviaDenaro2
            // 
            InviaDenaro2.Location = new Point(396, 63);
            InviaDenaro2.Name = "InviaDenaro2";
            InviaDenaro2.Size = new Size(139, 61);
            InviaDenaro2.TabIndex = 7;
            InviaDenaro2.Text = "Invia Denaro Conto 2";
            InviaDenaro2.UseVisualStyleBackColor = true;
            InviaDenaro2.Click += InviaDenaro2_Click;
            // 
            // PrelevaDenaro2
            // 
            PrelevaDenaro2.Location = new Point(396, 128);
            PrelevaDenaro2.Name = "PrelevaDenaro2";
            PrelevaDenaro2.Size = new Size(139, 61);
            PrelevaDenaro2.TabIndex = 8;
            PrelevaDenaro2.Text = "Preleva Denaro Conto 2";
            PrelevaDenaro2.UseVisualStyleBackColor = true;
            PrelevaDenaro2.Click += PrelevaDenaro2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "Saldo Conto 2";
            // 
            // TastoBonifico
            // 
            TastoBonifico.Location = new Point(218, 174);
            TastoBonifico.Name = "TastoBonifico";
            TastoBonifico.Size = new Size(122, 52);
            TastoBonifico.TabIndex = 11;
            TastoBonifico.Text = "Bonifico";
            TastoBonifico.UseVisualStyleBackColor = true;
            TastoBonifico.Click += TastoBonifico_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(TastoBonifico);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(PrelevaDenaro2);
            Controls.Add(InviaDenaro2);
            Controls.Add(label2);
            Controls.Add(QTAdenaro);
            Controls.Add(numericUpDown1);
            Controls.Add(RiceviDenaro);
            Controls.Add(InviaDenaro);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button InviaDenaro;
        private Button RiceviDenaro;
        private NumericUpDown numericUpDown1;
        private Label QTAdenaro;
        private Label label2;
        private Button InviaDenaro2;
        private Button PrelevaDenaro2;
        private Label label3;
        private Label label4;
        private Button TastoBonifico;
    }
}
