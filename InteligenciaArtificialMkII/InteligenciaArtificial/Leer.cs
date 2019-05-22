using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace InteligenciaArtificial
{
    public partial class Form3 : Form
    {

        
        private string RutaDeArchivo = "";
        int[][]MA;
            public Form3()
        {
            InitializeComponent();
        }

        private void boton_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
                RutaDeArchivo = buscar.FileName;
                Console.WriteLine(RutaDeArchivo);
            }
        }

        private void boton_abrir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RutaDeArchivo))
            {
                MessageBox.Show("Seleccione un archivo");
                return;
            }
          
            var NumeroLineasArchivo = File.ReadLines(RutaDeArchivo).Count();
         
            bool FueRealizado;
            switch (NumeroLineasArchivo)
            {
                case 0:
                    FueRealizado = false;
                    MessageBox.Show("Archivo Vacio");
                    break;
                case 1:
    
                    FueRealizado = LeerArchivoUnaLinea();
                    break;

                default:
                   
                    FueRealizado = EsArchivoValido();
                    break;

            }
            if (FueRealizado)
            {
                Form2 frm2 = new Form2(MA);
                frm2.Show();
                


                this.Close();
            }
            else
            {
                MessageBox.Show("Archivo incorrecto");
            }
        }

        private int[,] ConviertetMatrizStringAint(string[][] first)
        {
            int[,] nueva = new int[first.Length, first[0].Length];

            for (int j = 0; j < first.Length; j++)
            {
                for (int i = 0; i < first[0].Length; i++)
                {
                    int number;
                    bool ok = int.TryParse(first[j][i], out number);
                    if (ok)
                    {
                        nueva[j,i] = number;
                    }
                    else
                    {
                        return null;
                    }
                   
                    
                }
            }
            return nueva;
        }

        
        private bool LeerArchivoUnaLinea()
        {
            bool valida;
                string text = File.ReadAllText(RutaDeArchivo);
                string[][] miMat = text.Split(' ').Select(x => x.Split(',')).ToArray();
            
            if (ConviertetMatrizStringAint(miMat) != null)
            {
                int[,] mat = new int[miMat.Length,miMat[0].Length];
                mat = ConviertetMatrizStringAint(miMat);
                MA = new int[mat.GetLength(0)][];
                for (int i = 0; i < MA.Length; i++)
                {
                    MA[i] = new int[mat.GetLength(1)];
                    for (int j = 0; j < MA[i].Length; j++)
                    {
                        MA[i][j] = mat[i, j];
                        Console.WriteLine(MA[i][j]);
                    }
                }
                
                valida = true;
            }
            else {

                valida = false;
            }
            return valida;

        }
        private bool EsArchivoValido()
        {
            bool valida;
            try
            {

                var texto = File.ReadAllLines(RutaDeArchivo);
                int[][] result = texto.Select(x => x.Split(',').Select(Int32.Parse).ToArray()).ToArray();
                valida = true;
                MA = result;
            }
            catch (Exception ex)
            {
                valida = false;
            }
            return valida;
        }
       

        private void Leer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
