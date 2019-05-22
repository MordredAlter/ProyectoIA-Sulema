namespace InteligenciaArtificial
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NumeroLabel2 = new System.Windows.Forms.Label();
            this.NumeroLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIJA EL COLOR DE CADA UNO DE LOS TERRENOS ";
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "Agua",
            "Tierra",
            "Pasto",
            "Pared",
            "Montaña",
            "Camino",
            "Arena",
            "Lava"});
            this.comboBox16.Location = new System.Drawing.Point(135, 554);
            this.comboBox16.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(148, 21);
            this.comboBox16.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 48;
            this.button2.Text = "CONTINUAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumeroLabel2
            // 
            this.NumeroLabel2.AutoSize = true;
            this.NumeroLabel2.Location = new System.Drawing.Point(19, 144);
            this.NumeroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroLabel2.Name = "NumeroLabel2";
            this.NumeroLabel2.Size = new System.Drawing.Size(0, 13);
            this.NumeroLabel2.TabIndex = 18;
            // 
            // NumeroLabel1
            // 
            this.NumeroLabel1.AutoSize = true;
            this.NumeroLabel1.Location = new System.Drawing.Point(19, 110);
            this.NumeroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroLabel1.Name = "NumeroLabel1";
            this.NumeroLabel1.Size = new System.Drawing.Size(0, 13);
            this.NumeroLabel1.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox16);
            this.Controls.Add(this.NumeroLabel2);
            this.Controls.Add(this.NumeroLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NumeroLabel2;
        private System.Windows.Forms.Label NumeroLabel1;
    }
}