using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligenciaArtificial
{
    public partial class Personajes : Form
    {

        List<Terreno> TerrenosDetectados;
        List<Personaje> ListaPersonajes = new List<Personaje>();

        TextBox[,] numeric;
        PictureBox[] imgPerso;
        int PersosCreados = 1;

        int[][] Matriz;

        public Personajes(int[][] Ma, List<Terreno> l)
        {
            InitializeComponent();

            Matriz = Ma;
            TerrenosDetectados = l;
            numeric = new TextBox[TerrenosDetectados.Count, 4];
            imgPerso = new PictureBox[4];

            CrearTextBox();

        }

        private void Personajes_Load(object sender, EventArgs e)
        {

        }
        

        public void CrearTextBox()
        {
            int MargenSup = 70;
            int MargenLad = 50;
            for(int i = 0;i< TerrenosDetectados.Count; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    imgPerso[j] = new PictureBox();
                    imgPerso[j].Width = 40;
                    imgPerso[j].Height = 40;
                    imgPerso[j].Top = 20;
                    imgPerso[j].Left = j * 60 + MargenLad;
                    imgPerso[j].Image = imageList1.Images[j];
                    imgPerso[j].Visible = false;
                    this.Controls.Add(imgPerso[j]);

                    numeric[i, j] = new TextBox();
                    numeric[i, j].Width = 40;
                    numeric[i, j].Height = 10;
                    numeric[i, j].Top = i * 30 + MargenSup;
                    numeric[i, j].Left = j * 60 + MargenLad;
                    numeric[i, j].Text = "0";
                    numeric[i, j].Visible = false;
                    this.Controls.Add(numeric[i, j]);
                }
                for(int m = 0; m < PersosCreados; m++)
                {
                    numeric[i, m].Visible = true;
                    imgPerso[m].Visible = true;
                }
            }
        }

        public void AgainTextBox()
        {
            for (int i = 0; i < TerrenosDetectados.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    numeric[i, j].Text = "0";
                    numeric[i, j].Visible = false;
                    imgPerso[j].Visible = false;
                }
                for (int m = 0; m < PersosCreados; m++)
                {
                    numeric[i, m].Visible = true;
                    imgPerso[m].Visible = true;
                }
            }
        }

        private void NewPersonaje_Click(object sender, EventArgs e)
        {
            if (PersosCreados == 3)
            {
                NewPersonaje.Enabled = false;
            }

            DelPersonaje.Enabled = true;
            PersosCreados++;
            AgainTextBox();
        }

        private void DelPersonaje_Click(object sender, EventArgs e)
        {
            if (PersosCreados == 2)
            {
                DelPersonaje.Enabled = false;
            }

            NewPersonaje.Enabled = true;
            PersosCreados--;
            AgainTextBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Terreno t in TerrenosDetectados)
            {
                t.Peso[0] = Convert.ToInt32(numeric[i, 0].Text);
                t.Peso[1] = Convert.ToInt32(numeric[i, 1].Text);
                t.Peso[2] = Convert.ToInt32(numeric[i, 2].Text);
                t.Peso[3] = Convert.ToInt32(numeric[i, 3].Text);

                Personaje pers = new Personaje()
                {
                    NumPersonaje = i,
                    IndiceImagen = i
                };

                ListaPersonajes.Add(pers);

                i++;
            }

            Form1 frm = new Form1(Matriz, TerrenosDetectados, PersosCreados); 
            frm.Show();
            this.Close();

        }
    }
}
