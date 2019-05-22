namespace InteligenciaArtificial
{
    partial class Personajes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personajes));
            this.NewPersonaje = new System.Windows.Forms.Button();
            this.DelPersonaje = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // NewPersonaje
            // 
            this.NewPersonaje.Location = new System.Drawing.Point(375, 12);
            this.NewPersonaje.Name = "NewPersonaje";
            this.NewPersonaje.Size = new System.Drawing.Size(112, 23);
            this.NewPersonaje.TabIndex = 0;
            this.NewPersonaje.Text = "Agregar Personaje";
            this.NewPersonaje.UseVisualStyleBackColor = true;
            this.NewPersonaje.Click += new System.EventHandler(this.NewPersonaje_Click);
            // 
            // DelPersonaje
            // 
            this.DelPersonaje.Location = new System.Drawing.Point(375, 41);
            this.DelPersonaje.Name = "DelPersonaje";
            this.DelPersonaje.Size = new System.Drawing.Size(112, 23);
            this.DelPersonaje.TabIndex = 1;
            this.DelPersonaje.Text = "Quitar Personaje";
            this.DelPersonaje.UseVisualStyleBackColor = true;
            this.DelPersonaje.Click += new System.EventHandler(this.DelPersonaje_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(375, 106);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar y Continuar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fate0.png");
            this.imageList1.Images.SetKeyName(1, "Fate2.png");
            this.imageList1.Images.SetKeyName(2, "Fate3.png");
            this.imageList1.Images.SetKeyName(3, "Fate1.png");
            // 
            // Personajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 340);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DelPersonaje);
            this.Controls.Add(this.NewPersonaje);
            this.Name = "Personajes";
            this.Text = "Personajes";
            this.Load += new System.EventHandler(this.Personajes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewPersonaje;
        private System.Windows.Forms.Button DelPersonaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ImageList imageList1;
    }
}