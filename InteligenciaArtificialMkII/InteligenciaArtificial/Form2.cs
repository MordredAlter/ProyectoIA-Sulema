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
    public partial class Form2 : Form
    {
        

        int [][]Matriz;
        List<int> numList;
        int CantidadNumeros = 0;
        ComboBox[] ListaCombo;
        ComboBox[] ListaComboTerreno;
        Label[] CadenaLabel;
        public Form2(int[][] Ma)
        {
            Matriz = Ma;
            InitializeComponent();
            DetectaNumerosMatriz();
          //  Combo();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

        private void DetectaNumerosMatriz()
        {
            int cont = 0;
            CadenaLabel = new Label[15];
            ListaComboTerreno = new ComboBox[15];
            ListaCombo = new ComboBox[15];
            string[] colorSet = {"Red","Blue", "Green", "Yellow","AliceBlue","Aqua","Black","Gray","Purple","Brown","Orange","Moccasin", "SaddleBrown" };
            Color end = Color.White;

            String[] ListaTerrenos = {"Agua","Pasto","Tierra","Lava","Camino","Montaña"
            ,"Bosque","Arena","Pantano","Pared"};
            //List<String> numListTerrno = new List<String>();
            numList = new List<int>();
            for (int i = 0; i < Matriz.Length; i++)
            {
                for (int j = 0; j < Matriz[0].Length; j++)
                {
                    if (!numList.Contains(Matriz[i][j]))
                    {
                        cont++;
                        numList.Add(Matriz[i][j]);
                    }
                }

            
            }
            CantidadNumeros = numList.Count;
            Console.WriteLine(CantidadNumeros);

           
  
            for (int i = 0; i < cont; i++)
            {
                CadenaLabel[i] = new Label();
                ListaCombo[i] = new ComboBox();
                ListaComboTerreno[i] = new ComboBox();
                CadenaLabel[i].Name = String.Concat("Label", i.ToString());
                CadenaLabel[i].Text = String.Concat("Numero:",numList[i].ToString());
                //CadenaLabel[i].Size = new Size(50, 50);
                //CadenaLabel[i].Location = new System.Drawing.Point(150, 150, (i * 28));
                CadenaLabel[i].Width = 60;
                CadenaLabel[i].Height = 20;
                CadenaLabel[i].Top = (i+1) * 50;
                CadenaLabel[i].Left = i * 0;
                
                ListaComboTerreno[i].Name = String.Concat("ComboBoxTerreno", i.ToString());
                ListaComboTerreno[i].Height = 20;
                ListaComboTerreno[i].Width = 80;
                ListaComboTerreno[i].Top = (i + 1) * 50;
                ListaComboTerreno[i].Left = 60;

                ListaCombo[i].Name = String.Concat("ComboBoxColor", i.ToString());
                ListaCombo[i].Height = 20;
                ListaCombo[i].Width = 80;
                ListaCombo[i].Top = (i + 1) * 50;
                ListaCombo[i].Left =  200;

               
                // CadenaLabel[i].Location = new Point(i, 20);
                for (int j = 0; j < colorSet.Length; j++)
                {
                    ListaCombo[i].Items.Add(colorSet[j]);

                }
                for (int x = 0; x < ListaTerrenos.Length; x++)
                {
                    ListaComboTerreno[i].Items.Add(ListaTerrenos[x]);
                }
                this.Controls.Add(ListaCombo[i]);
                this.Controls.Add(CadenaLabel[i]);
                this.Controls.Add(ListaComboTerreno[i]);


            }
     
        }

       /* private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {

                ComboBox  cmb = sender as ComboBox;
                if (cmb == null) return;
                if (e.Index < 0) return;
                if (!(cmb.Items[e.Index] is Color)) return;
                Color color = (Color)cmb.Items[e.Index];
                // Dibujamos el fondo
                e.DrawBackground();
                // Creamos los objetos GDI+
                Brush brush = new SolidBrush(color);
                Pen forePen = new Pen(e.ForeColor);
                Brush foreBrush = new SolidBrush(e.ForeColor);
                // Dibujamos el borde del rectángulo
                e.Graphics.DrawRectangle(
                    forePen,
                    new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 19,
                        e.Bounds.Size.Height - 4));
                // Rellenamos el rectángulo con el Color seleccionado
                // en la combo
                e.Graphics.FillRectangle(brush,
                    new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18,
                        e.Bounds.Size.Height - 5));
                // Dibujamos el nombre del color
                e.Graphics.DrawString(color.Name, cmb.Font,
                    foreBrush, e.Bounds.Left + 25, e.Bounds.Top + 2);
                // Eliminamos objetos GDI+
                brush.Dispose();
                forePen.Dispose();
                foreBrush.Dispose();


            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }*/
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (RevisaControlEsVacio())
            {
                MessageBox.Show("Seleciona el terreno y color para todos");
                return;
            }
            List<Terreno> miListTerrenos = new List<Terreno>();
            for(int i = 0; i < CantidadNumeros; i++)
            {
                string tipo = ListaComboTerreno[i].Text;
                string color = ListaCombo[i].Text;
                int num = numList[i];

                Terreno aux = new Terreno()
                {
                    Tipo = tipo,
                    MiColor = color,
                    Numero = num,
                    Peso = new int[] { 0, 0, 0, 0 }
                };

                aux.Peso[0] = 0;
                
                miListTerrenos.Add(aux);
            }
            //Form1 frm = new Form1(Matriz,miListTerrenos);
            //frm.Show();

            Personajes perso = new Personajes(Matriz,miListTerrenos);
            perso.Show();
            this.Close();

        }
        bool RevisaControlEsVacio()
        {
            for (int i = 0; i < CantidadNumeros; i++)
            {
                if (string.IsNullOrEmpty(ListaCombo[i].Text) ||
                    string.IsNullOrEmpty(ListaComboTerreno[i].Text))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
