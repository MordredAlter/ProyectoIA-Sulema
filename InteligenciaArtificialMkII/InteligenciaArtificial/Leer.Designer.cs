namespace InteligenciaArtificial
{
    partial class Form3
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
            this.label_excepcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boton_abrir = new System.Windows.Forms.Button();
            this.boton_examinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_excepcion
            // 
            this.label_excepcion.AutoSize = true;
            this.label_excepcion.Location = new System.Drawing.Point(168, 31);
            this.label_excepcion.Name = "label_excepcion";
            this.label_excepcion.Size = new System.Drawing.Size(321, 20);
            this.label_excepcion.TabIndex = 9;
            this.label_excepcion.Text = "SELECCIONA EL ARCHIVO PARA ABRIR ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boton_abrir
            // 
            this.boton_abrir.Location = new System.Drawing.Point(676, 83);
            this.boton_abrir.Name = "boton_abrir";
            this.boton_abrir.Size = new System.Drawing.Size(123, 40);
            this.boton_abrir.TabIndex = 6;
            this.boton_abrir.Text = "Abrir";
            this.boton_abrir.UseVisualStyleBackColor = true;
            this.boton_abrir.Click += new System.EventHandler(this.boton_abrir_Click);
            // 
            // boton_examinar
            // 
            this.boton_examinar.Location = new System.Drawing.Point(676, 31);
            this.boton_examinar.Name = "boton_examinar";
            this.boton_examinar.Size = new System.Drawing.Size(123, 40);
            this.boton_examinar.TabIndex = 5;
            this.boton_examinar.Text = "Examinar";
            this.boton_examinar.UseVisualStyleBackColor = true;
            this.boton_examinar.Click += new System.EventHandler(this.boton_examinar_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.boton_abrir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 175);
            this.Controls.Add(this.label_excepcion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boton_abrir);
            this.Controls.Add(this.boton_examinar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Leer";
            this.Load += new System.EventHandler(this.Leer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_excepcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boton_abrir;
        private System.Windows.Forms.Button boton_examinar;
    }
}