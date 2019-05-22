namespace InteligenciaArtificial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.AgregarMeta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarPersonaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboPersoLetra = new System.Windows.Forms.ComboBox();
            this.comboPersoNum = new System.Windows.Forms.ComboBox();
            this.comboMetaLetra = new System.Windows.Forms.ComboBox();
            this.comboMetaNum = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboIndicePerso = new System.Windows.Forms.ComboBox();
            this.MostrarPerso = new System.Windows.Forms.Button();
            this.newMap = new System.Windows.Forms.Button();
            this.btnBacktracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(900, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Turno Actual";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTurno.Location = new System.Drawing.Point(931, 339);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(25, 25);
            this.lblTurno.TabIndex = 14;
            this.lblTurno.Text = "0";
            // 
            // AgregarMeta
            // 
            this.AgregarMeta.Location = new System.Drawing.Point(915, 202);
            this.AgregarMeta.Name = "AgregarMeta";
            this.AgregarMeta.Size = new System.Drawing.Size(75, 23);
            this.AgregarMeta.TabIndex = 35;
            this.AgregarMeta.Text = "Agregar";
            this.AgregarMeta.UseVisualStyleBackColor = true;
            this.AgregarMeta.Click += new System.EventHandler(this.AgregarMeta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Meta:";
            // 
            // AgregarPersonaje
            // 
            this.AgregarPersonaje.Location = new System.Drawing.Point(915, 78);
            this.AgregarPersonaje.Name = "AgregarPersonaje";
            this.AgregarPersonaje.Size = new System.Drawing.Size(75, 23);
            this.AgregarPersonaje.TabIndex = 29;
            this.AgregarPersonaje.TabStop = false;
            this.AgregarPersonaje.Text = "Agregar";
            this.AgregarPersonaje.UseVisualStyleBackColor = true;
            this.AgregarPersonaje.Click += new System.EventHandler(this.AgregarPersonaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Personaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(804, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "*Utiliza las teclas  W,A,S,D para moverte por el mapa";
            // 
            // comboPersoLetra
            // 
            this.comboPersoLetra.FormattingEnabled = true;
            this.comboPersoLetra.Location = new System.Drawing.Point(897, 51);
            this.comboPersoLetra.Name = "comboPersoLetra";
            this.comboPersoLetra.Size = new System.Drawing.Size(46, 21);
            this.comboPersoLetra.TabIndex = 37;
            this.comboPersoLetra.TabStop = false;
            // 
            // comboPersoNum
            // 
            this.comboPersoNum.FormattingEnabled = true;
            this.comboPersoNum.Location = new System.Drawing.Point(949, 51);
            this.comboPersoNum.Name = "comboPersoNum";
            this.comboPersoNum.Size = new System.Drawing.Size(46, 21);
            this.comboPersoNum.TabIndex = 38;
            this.comboPersoNum.TabStop = false;
            // 
            // comboMetaLetra
            // 
            this.comboMetaLetra.FormattingEnabled = true;
            this.comboMetaLetra.Location = new System.Drawing.Point(897, 175);
            this.comboMetaLetra.Name = "comboMetaLetra";
            this.comboMetaLetra.Size = new System.Drawing.Size(46, 21);
            this.comboMetaLetra.TabIndex = 39;
            this.comboMetaLetra.TabStop = false;
            // 
            // comboMetaNum
            // 
            this.comboMetaNum.FormattingEnabled = true;
            this.comboMetaNum.Location = new System.Drawing.Point(949, 175);
            this.comboMetaNum.Name = "comboMetaNum";
            this.comboMetaNum.Size = new System.Drawing.Size(46, 21);
            this.comboMetaNum.TabIndex = 40;
            this.comboMetaNum.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dantes_Costume.png");
            this.imageList1.Images.SetKeyName(1, "KingHassanStage2.png");
            this.imageList1.Images.SetKeyName(2, "MusashiSprite2.png");
            this.imageList1.Images.SetKeyName(3, "EmiyaAssassin_Sprite3.png");
            this.imageList1.Images.SetKeyName(4, "Grail.png");
            // 
            // comboIndicePerso
            // 
            this.comboIndicePerso.FormattingEnabled = true;
            this.comboIndicePerso.Location = new System.Drawing.Point(952, 24);
            this.comboIndicePerso.Name = "comboIndicePerso";
            this.comboIndicePerso.Size = new System.Drawing.Size(46, 21);
            this.comboIndicePerso.TabIndex = 41;
            this.comboIndicePerso.TabStop = false;
            // 
            // MostrarPerso
            // 
            this.MostrarPerso.Location = new System.Drawing.Point(897, 391);
            this.MostrarPerso.Name = "MostrarPerso";
            this.MostrarPerso.Size = new System.Drawing.Size(101, 23);
            this.MostrarPerso.TabIndex = 42;
            this.MostrarPerso.Text = "Ocultar Personaje";
            this.MostrarPerso.UseVisualStyleBackColor = true;
            this.MostrarPerso.Click += new System.EventHandler(this.MostrarPerso_Click);
            // 
            // newMap
            // 
            this.newMap.Location = new System.Drawing.Point(897, 432);
            this.newMap.Name = "newMap";
            this.newMap.Size = new System.Drawing.Size(101, 23);
            this.newMap.TabIndex = 43;
            this.newMap.Text = "Nuevo Mapa";
            this.newMap.UseVisualStyleBackColor = true;
            this.newMap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBacktracking
            // 
            this.btnBacktracking.Enabled = false;
            this.btnBacktracking.Location = new System.Drawing.Point(897, 247);
            this.btnBacktracking.Name = "btnBacktracking";
            this.btnBacktracking.Size = new System.Drawing.Size(101, 23);
            this.btnBacktracking.TabIndex = 44;
            this.btnBacktracking.TabStop = false;
            this.btnBacktracking.Text = "BackTracking";
            this.btnBacktracking.UseVisualStyleBackColor = true;
            this.btnBacktracking.Click += new System.EventHandler(this.btnBacktracking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 487);
            this.Controls.Add(this.btnBacktracking);
            this.Controls.Add(this.newMap);
            this.Controls.Add(this.MostrarPerso);
            this.Controls.Add(this.comboIndicePerso);
            this.Controls.Add(this.comboMetaNum);
            this.Controls.Add(this.comboMetaLetra);
            this.Controls.Add(this.comboPersoNum);
            this.Controls.Add(this.comboPersoLetra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AgregarMeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgregarPersonaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button AgregarMeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarPersonaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboPersoLetra;
        private System.Windows.Forms.ComboBox comboPersoNum;
        private System.Windows.Forms.ComboBox comboMetaLetra;
        private System.Windows.Forms.ComboBox comboMetaNum;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboIndicePerso;
        private System.Windows.Forms.Button MostrarPerso;
        private System.Windows.Forms.Button newMap;
        private System.Windows.Forms.Button btnBacktracking;
    }
}

