using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InteligenciaArtificial;


namespace InteligenciaArtificial
{

    public partial class Form1 : Form
    {
        class Nodo
        {
            public string Posicion = "";
            public int Peso;
            public Nodo izq, der;
            public int Turno;
            public string estado = "vivo";

            public Nodo Padre = null;
            public Nodo HijoArriba = null;
            public Nodo HijoDer = null;
            public Nodo HijoAbajo = null;
            public Nodo HijoIzq = null;

            
        }
        Nodo raiz;
        

        public void ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        public void Insertar(int infoX, int infoY)
        {
            Nodo nuevo;
            nuevo = new Nodo();

            String letras = "ABCDEFGHIJKLMNO";

            String letra = devolverLetra(infoX);
            String let = "";

            String dato = letra + "-" + infoY.ToString();
            Console.Write("\nDato: " + dato + "\n");

            nuevo.Posicion = dato;

            int posicionX = infoX;
            int posicionY = infoY;

            if (posicionY == 0)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Arriba Nulo\n");
                nuevo.HijoArriba = null;
            }
            else
            {
                let = letras.ElementAt(posicionX).ToString();
                Nodo HijoAr = new Nodo();
                HijoAr.Posicion = let + "-" + (posicionY - 1).ToString();
                HijoAr.Padre = nuevo;
                nuevo.HijoArriba = HijoAr;
            }
            
            if (posicionX == MatrizY-1)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Derecha Nulo\n");
                nuevo.HijoDer = null;
            }
            else
            {
                let = letras.ElementAt(posicionX + 1).ToString();
                Nodo HijoDer = new Nodo();
                HijoDer.Posicion = let + "-" + (posicionY).ToString();
                HijoDer.Padre = nuevo;
                nuevo.HijoDer = HijoDer;
            }

            if (posicionY == MatrizX-1)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Abajo Nulo\n");
                nuevo.HijoAbajo = null;
            }
            else
            {
                let = letras.ElementAt(posicionX).ToString();
                Nodo HijoAb = new Nodo();
                HijoAb.Posicion = let + "-" + (posicionY + 1).ToString();
                HijoAb.Padre = nuevo;
                nuevo.HijoAbajo = HijoAb;
            }

            if (posicionX == 0)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Izquierda Nulo\n");
                nuevo.HijoIzq = null;
            }
            else
            {
                let = letras.ElementAt(posicionX - 1).ToString();
                Nodo HijoIz = new Nodo();
                HijoIz.Posicion = let + "-" + (posicionY).ToString();
                HijoIz.Padre = nuevo;
                nuevo.HijoIzq = HijoIz;
            }

            //nuevo.Peso = ObtenerPeso() ;

            if (Arbol.Count == 0) {
                Nodo Pater = new Nodo();
                Pater.Posicion = "Root";
            }
            else
                nuevo.Padre = Arbol.Peek();

            nuevo.Turno = Turno;

            PintaHijos(nuevo, infoX, infoY);

            Arbol.Push(nuevo);

            /*
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (Peso < reco.Peso)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (Peso < anterior.Peso)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }*/
        }

        private String devolverLetra(int info)
        {
            switch (info)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                case 5:
                    return "F";
                case 6:
                    return "G";
                case 7:
                    return "H";
                case 8:
                    return "I";
                case 9:
                    return "J";
                case 10:
                    return "K";
                case 11:
                    return "L";
                case 12:
                    return "M";
                case 13:
                    return "N";
                case 14:
                    return "O";
                default:
                    break;
            }

            return "";
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write("\n Coordenada: "+reco.Posicion+" Turno: " + reco.Turno + "\n");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

        public void MostrarArbol()
        {
            int cont = Arbol.Count();
            cont--;
            Console.Write("Arbol: " + cont + "\n");
            for(int i = cont; i>=0; i--)
            {
                Console.Write("Nodo: " + Arbol.ElementAt(i).Posicion);
                Console.Write("  Turno: " + Arbol.ElementAt(i).Turno + "\n");
                if (Arbol.ElementAt(i).Padre != null)
                    Console.Write("  Padre: " + Arbol.ElementAt(i).Padre.Posicion);
                else
                    Console.Write("  Padre: Null");
                if (Arbol.ElementAt(i).HijoArriba != null)
                    Console.Write("  HijoArriba: " + Arbol.ElementAt(i).HijoArriba.Posicion);
                else
                    Console.Write("  HijoArriba: Null");
                if (Arbol.ElementAt(i).HijoDer != null)
                    Console.Write("  HijoDer: " + Arbol.ElementAt(i).HijoDer.Posicion);
                else
                    Console.Write("  HijoDer: Null");
                if (Arbol.ElementAt(i).HijoAbajo != null)
                    Console.Write("  HijoAbajo: " + Arbol.ElementAt(i).HijoAbajo.Posicion);
                else
                    Console.Write("  HijoAbajo: Null");
                if (Arbol.ElementAt(i).HijoIzq != null)
                    Console.Write("  HijoIzq: " + Arbol.ElementAt(i).HijoIzq.Posicion +"\n");
                else
                    Console.Write("  HijoIzq: Null\n");
            }
        }

        private int MatrizX = 0;
        private int MatrizY = 0;

        Button[,] btnAux = new Button[15, 15];
        Button[,] btn = new Button[15, 15];
        Button[] BbordeX = new Button[15];
        Button[] BbordeY = new Button[15];

        String letras = "ABCDEFGHIJKLMNO";

        int[] PersonajeActual = new int[2];
        int[] Meta = new int[2];

        int InicialX = 0;
        int InicialY = 0;

        int Turno = -1;

        int[][] Mat;

        List<Terreno> TerrenosDetectados;
        Stack<Nodo> Arbol = new Stack<Nodo>();

        int TotalPersonajes = 1;
        int IndicePersonajeUtilizado = 0;

        public Form1(int[][] Ma,List<Terreno> l, int Personajes)
        {
            this.SetBounds(5, 5, 10, 10);
            InitializeComponent();
            
            Mat = Ma;
            TerrenosDetectados = l;
            MatrizX = Ma.Length;
            MatrizY = Ma[0].Length;
            int[,] matriz = new int[MatrizX, MatrizY];
            //TotalPersonajes = ListaPersonajes.Count;
            TotalPersonajes = Personajes;

            LlenarComboPerso(MatrizX, MatrizY);
            LlenarComboMeta(MatrizX, MatrizY);

            CargarMapa(MatrizX,MatrizY);
            //PintaTerrenosEnMapa();
            newMap.Visible = false;
            MostrarPerso.Visible = false;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LlenarComboPerso(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            {
                comboPersoNum.Items.Add(i);
            }
            comboPersoNum.SelectedIndex = 0;
            
            for (int i = 0; i < y; i++)
            {
                comboPersoLetra.Items.Add(letras.ElementAt(i));
            }
            comboPersoLetra.SelectedIndex = 0;

            for (int i = 1; i <= TotalPersonajes; i++)
            {
                comboIndicePerso.Items.Add(i);
            }
            comboIndicePerso.SelectedIndex = 0;
        }

        public void LlenarComboMeta(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            {
                comboMetaNum.Items.Add(i);
            }
            comboMetaNum.SelectedIndex = 0;

            for (int i = 0; i < y; i++)
            {
                comboMetaLetra.Items.Add(letras.ElementAt(i));
            }
            comboMetaLetra.SelectedIndex = 0;
        }

        private void PintaTerrenosEnMapa()
        {
            foreach (Terreno t in TerrenosDetectados)
            {

                Color thisColor = Color.FromName(t.MiColor);
                for (int i = 0; i < MatrizX; i++)
                {
                    for (int j = 0; j < MatrizY; j++)
                    {
                        if (Mat[i][j] == t.Numero)
                        {
                            btn[i, j].BackColor = thisColor;
                        }

                    }
                }
            }
        }

        private void PintaHijos(Nodo padre, int posX, int posY)
        {
            //int posX = padre.Posicion.ElementAt(0) - 'A';
            //int posY = padre.Posicion.ElementAt(2) - '1';
            Console.Write("  Padre: " + padre.Posicion + "\n");

            foreach (Terreno t in TerrenosDetectados){
                Color thisColor = Color.FromName(t.MiColor);
                if (Mat[posY][posX] == t.Numero){
                    btn[posY, posX].BackColor = thisColor;
                    //Console.Write("\nPaso 1\n");
                }
            }

            int posicionX = posX;
            int posicionY = posY;
            int iposX;
            int iposY;

            if (padre.HijoArriba != null)
            {
                iposX = posX;
                iposY = posY - 1;
                Console.Write("HijoArr: " + iposX + "-" + iposY + "\n");
                foreach (Terreno t in TerrenosDetectados)
                {
                    Color thisColor = Color.FromName(t.MiColor);
                    if (Mat[iposY][iposX] == t.Numero)
                    {
                        
                        btn[iposY, iposX].BackColor = thisColor;
                        //Console.Write("\nPaso 3\n");
                    }
                }
            }

            if (padre.HijoDer != null)
            {
                iposX = posX + 1;
                iposY = posY;
                Console.Write("HijoDer: " + iposX + "-" + iposY + "\n");
                foreach (Terreno t in TerrenosDetectados)
                {
                    Color thisColor = Color.FromName(t.MiColor);
                    if (Mat[iposY][iposX] == t.Numero)
                    {
                        Console.Write("\nX: " + posX + " Y: "+ posY +"\n");
                        btn[iposY, iposX].BackColor = thisColor;
                        //Console.Write("\nPaso 3\n");
                    }
                }
            }

            if (padre.HijoAbajo != null)
            {
                iposX = posX;
                iposY = posY + 1;
                Console.Write("HijoAba: " + iposX + "-" + iposY + "\n");
                foreach (Terreno t in TerrenosDetectados)
                {
                    Color thisColor = Color.FromName(t.MiColor);
                    if (Mat[iposY][iposX] == t.Numero)
                    {
                        //Console.Write("\nPaso 2\n");
                        btn[iposY, iposX].BackColor = thisColor;
                        //Console.Write("\nPaso 3\n");
                    }
                }
            }

            if (padre.HijoIzq != null)
            {
                iposX = posX - 1;
                iposY = posY;
                Console.Write("HijoIzq: " + iposX + "-" + iposY + "\n");
                foreach (Terreno t in TerrenosDetectados)
                {
                    Color thisColor = Color.FromName(t.MiColor);
                    if (Mat[iposY][iposX] == t.Numero)
                    {
                        //Console.Write("\nPaso 2\n");
                        btn[iposY, iposX].BackColor = thisColor;
                        //Console.Write("\nPaso 3\n");
                    }
                }
            }
        }

        public void CargarMapa(int x, int y)
        {
            int margenSup = 35;
            int margenLat = 35;
            try
            {

                //Borde Letras
                for (int i = 0; i < y; i++)
                {
                    BbordeX[i] = new Button();
                    BbordeX[i].Width = 45;
                    BbordeX[i].Height = 30;
                    BbordeX[i].Text = letras.ElementAt(i).ToString();
                    BbordeX[i].Enabled = false;
                    BbordeX[i].FlatStyle = FlatStyle.Flat;
                    BbordeX[i].FlatAppearance.BorderSize = 0;

                    BbordeX[i].Top = 5;
                    BbordeX[i].Left = i * 44 + margenLat;
                    this.Controls.Add(BbordeX[i]);
                }
                //Borde Numeros
                for (int i = 0; i < x; i++)
                {
                    BbordeY[i] = new Button();
                    BbordeY[i].Width = 30;
                    BbordeY[i].Height = 45;
                    BbordeY[i].Text = (i + 1).ToString();
                    BbordeY[i].Enabled = false;
                    BbordeY[i].FlatStyle = FlatStyle.Flat;
                    BbordeY[i].FlatAppearance.BorderSize = 0;

                    BbordeY[i].Top = i * 44 + margenSup;
                    BbordeY[i].Left = 5;
                    this.Controls.Add(BbordeY[i]);
                }

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {

                        btn[i, j] = new Button();
                        btnAux[i, j] = new Button();
                        btn[i, j].Font = new Font(btn[i, j].Font.Name, 7);
                        btn[i, j].TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        btn[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                        btn[i, j].Click += btn_Click;
                        btn[i, j].Width = 45;
                        btn[i, j].Height = 45;
                        btn[i, j].Top = i * 44 + margenSup;
                        btn[i, j].Left = j * 44 + margenLat;
                        btn[i, j].TabStop = false;

                        btnAux[i, j].Text = j.ToString() + (i+1).ToString();
                       // btn[i, j].ResetText();
      
                        //btn[i, j].BackColor = Color.Transparent;
                        btn[i, j].BackColor = Color.Black;
                        btn[i, j].Font = new Font(btn[i, j].Font.Name, 7);

                        btn[i, j].FlatStyle = FlatStyle.Flat;
                        btn[i, j].FlatAppearance.BorderSize = 1;

                        this.Controls.Add(btn[i, j]);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en fila o columna");
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button botonSel = sender as Button;
            int PosMatrizX = botonSel.Bounds.X;
            PosMatrizX = PosMatrizX - 10;
            PosMatrizX = PosMatrizX / 44;
            int PosMatrizY = botonSel.Bounds.Y;
            PosMatrizY = PosMatrizY - 10;
            PosMatrizY = PosMatrizY / 44;
            MessageBox.Show("btn[" + letras.ElementAt(PosMatrizX) + "][" + (PosMatrizY +1) + "]");


        }

        private void AgregarPersonaje_Click(object sender, EventArgs e)
        {
            IndicePersonajeUtilizado = comboIndicePerso.SelectedIndex;

            PersonajeActual[0] = comboPersoLetra.SelectedIndex;
            PersonajeActual[1] = comboPersoNum.SelectedIndex;


            int x = PersonajeActual[0];
            int y = PersonajeActual[1];

            int Terren = 0;
            int Peso = 0;

            Turno = 1;

            Terren = Mat[PersonajeActual[1]][PersonajeActual[0]];

            ArbolBinarioOrdenado();
            
            foreach (Terreno t in TerrenosDetectados)
            {
                if (t.Numero == Terren)
                {
                    Peso = t.Peso[IndicePersonajeUtilizado];
                }
            }

            if (Peso >= 0)
            {
                btn[y, x].Text = "I,1,";
                btn[y, x].ImageList = imageList1;
                btn[y, x].ImageIndex = IndicePersonajeUtilizado;

                /***************************************************************/
                Insertar(y, x);
                InicialX = x;
                InicialY = y;

                AgregarPersonaje.Enabled = false;
                AgregarMeta.Enabled = true;
                comboPersoLetra.Enabled = false;
                comboPersoNum.Enabled = false;
            }
            else
            {
                MessageBox.Show("Posicion del personaje no valida");
            }
            
        }

        private void AgregarMeta_Click(object sender, EventArgs e)
        {

            Meta[0] = comboMetaLetra.SelectedIndex;
            Meta[1] = comboMetaNum.SelectedIndex;

            int x = Meta[0];
            int y = Meta[1];

            if (x == PersonajeActual[0] && y == PersonajeActual[1])
            {
                MessageBox.Show("La posicion del Personaje y de la meta no \n puede ser la misma");
            }
            else
            {
                btn[y, x].Text = "Meta";
                btn[y, x].BackColor = Color.Gold;
                btn[y, x].ImageList = imageList1;
                btn[y, x].ImageIndex = 4;

                Turno = 1;
                lblTurno.Text = Turno.ToString();

                AgregarMeta.Enabled = false;
                comboMetaLetra.Enabled = false;
                comboMetaNum.Enabled = false;
                comboIndicePerso.Enabled = false;

                //label7.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            String Texto = "";

            int Terren = 0;
            int Peso = 0;

            if (Turno != -1)
            {
                if (Meta[0] == PersonajeActual[0] && Meta[1] == PersonajeActual[1])
                {
                    btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",F";
                    MessageBox.Show("HAZ LLEGADO A LA META");
                    ImprimirEntre();
                    MostrarPerso.Visible = true;
                    newMap.Visible = true;
                }

                if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
                {
                    Console.Write("Arriba - ");

                    btn[PersonajeActual[1], PersonajeActual[0]].ImageList = null;

                    
                    PersonajeActual[1] -= 1;
                    try
                    {
                        Texto = btn[PersonajeActual[1], PersonajeActual[0]].Text;
                        Turno++;
                      //  label2.Text = btnAux[PersonajeActual[1], PersonajeActual[0]].Text;//Cambiar cuando ya esten los pesos
                       // Insertar(btnAux[PersonajeActual[1], PersonajeActual[0]].ToString(), PersonajeActual[1]);
                        Terren = Mat[PersonajeActual[1]][PersonajeActual[0]];
                        foreach(Terreno t in TerrenosDetectados)
                        {
                            if(t.Numero == Terren)
                            {
                                Peso = t.Peso[IndicePersonajeUtilizado];
                            }
                        }

                        if (Peso >= 0)
                        {
                            btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",";

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                            Insertar(PersonajeActual[0], PersonajeActual[1]);
                            lblTurno.Text = Turno.ToString();
                            // label2.Text = lblTurno.ToString();   
                     
                        }
                        else
                        {
                            PersonajeActual[1] += 1;

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Posicion Inalcanzable");
                        PersonajeActual[1] += 1;

                        btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                        btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                    }

                    Terren = 0;
                    Peso = 0;
                }
                else if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
                {
                    Console.Write("Derecha - ");

                    btn[PersonajeActual[1], PersonajeActual[0]].ImageList = null;

                    PersonajeActual[0] += 1;
                    try
                    {
                        Texto = btn[PersonajeActual[1], PersonajeActual[0]].Text;
                        Terren = Mat[PersonajeActual[1]][PersonajeActual[0]];

                       // label2.Text = btnAux[PersonajeActual[1], PersonajeActual[0]].Text;//Cambiar cuando ya esten los pesos
                     //   Insertar(label2.Text, PersonajeActual[1]);
                        foreach (Terreno t in TerrenosDetectados)
                        {
                            if (t.Numero == Terren)
                            {
                                Peso = t.Peso[IndicePersonajeUtilizado];
                            }
                        }

                        if (Peso >= 0)
                        {
                            Turno++;
                            btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",";

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                            Insertar(PersonajeActual[0], PersonajeActual[1]);
                            lblTurno.Text = Turno.ToString();
                            // label2.Text = lblTurno.ToString();
                      
                        }
                        else
                        {
                            PersonajeActual[0] -= 1;

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Posicion Inalcanzable");
                        PersonajeActual[0] -= 1;

                        btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                        btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                    }
                }
                else if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                {
                    Console.Write("Abajo - ");
                    btn[PersonajeActual[1], PersonajeActual[0]].ImageList = null;
                    PersonajeActual[1] += 1;             
                    
                    try
                    {
                        Texto = btn[PersonajeActual[1], PersonajeActual[0]].Text;
                        Terren = Mat[PersonajeActual[1]][PersonajeActual[0]];

                       // label2.Text = btnAux[PersonajeActual[1], PersonajeActual[0]].Text;//Cambiar cuando ya esten los pesos
                    //    Insertar(label2.Text, PersonajeActual[1]);
                        foreach (Terreno t in TerrenosDetectados)
                        {
                            if (t.Numero == Terren)
                            {
                                Peso = t.Peso[IndicePersonajeUtilizado];
                                 
                            }
                        }

                        if (Peso >= 0)
                        {
                            Turno++;
                            btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",";

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                            Insertar(PersonajeActual[0], PersonajeActual[1]);
                            lblTurno.Text = Turno.ToString();
                            // label2.Text = lblTurno.ToString();
                           
                        }
                        else
                        {
                            PersonajeActual[1] -= 1;

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Posicion Inalcanzable");
                        PersonajeActual[1] -= 1;

                        btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                        btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                    }
                }
                else if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
                {
                    Console.Write("Izquierda - ");
                    btn[PersonajeActual[1], PersonajeActual[0]].ImageList = null;

                    PersonajeActual[0] -= 1;

                    try
                    {
                        Texto = btn[PersonajeActual[1], PersonajeActual[0]].Text;
                     //   label2.Text = btnAux[PersonajeActual[1], PersonajeActual[0]].Text;//Cambiar cuando ya esten los pesos
                        Terren = Mat[PersonajeActual[1]][PersonajeActual[0]];
                    //    Insertar(label2.Text, PersonajeActual[1]);
                        foreach (Terreno t in TerrenosDetectados)
                        {
                            if (t.Numero == Terren)
                            {
                                Peso = t.Peso[IndicePersonajeUtilizado];
                            }
                        }

                        if (Peso >= 0)
                        {
                            Turno++;
                            btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",";

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                            Insertar(PersonajeActual[0], PersonajeActual[1]);
                            lblTurno.Text = Turno.ToString();
                            // label2.Text = lblTurno.ToString();
                         
                        }
                        else
                        {
                            PersonajeActual[0] += 1;

                            btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                            btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Posicion Inalcanzable");
                        PersonajeActual[0] += 1;

                        btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                        btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                    }
                }

                if (Meta[0] == PersonajeActual[0] && Meta[1] == PersonajeActual[1])
                {
                    btn[PersonajeActual[1], PersonajeActual[0]].Text = Texto + Turno + ",F";
                    MessageBox.Show("HAZ LLEGADO A LA META");
                    ImprimirEntre();
                    MostrarPerso.Visible = true;
                    newMap.Visible = true;
                    MostrarArbol();
                }

            }

        
        }


        private void MostrarPerso_Click(object sender, EventArgs e)
        {
            if(MostrarPerso.Text.Equals("Ocultar Personaje"))
            {
                btn[PersonajeActual[1], PersonajeActual[0]].ImageList = null;
                MostrarPerso.Text = "Mostrar Personaje";
            }
            else if (MostrarPerso.Text.Equals("Mostrar Personaje"))
            {
                btn[PersonajeActual[1], PersonajeActual[0]].ImageList = imageList1;
                btn[PersonajeActual[1], PersonajeActual[0]].ImageIndex = IndicePersonajeUtilizado;
                MostrarPerso.Text = "Ocultar Personaje";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frmL = new Form3();
            frmL.Show();
            this.Close();
        }

        private void btnBacktracking_Click(object sender, EventArgs e)
        {
            btnBacktracking.Enabled = false;

            BackTracking();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Form3 frmL = new Form3();
            frmL.Show();
            this.Close();
        }*/

        Stack<Nodo> PilaBT = new Stack<Nodo>();

        public void BackTracking()
        {
            bool Solucion = false;
            //1.Elegir un órden de expansión de nodos

            //2.Inserto el nodo inicial a la pila
            InsertarBT(InicialY, InicialX);

            //3.Voy al último elemento de la pila

            //Para saber la letra
            
            Nodo aux = PilaBT.Peek();

            int pX = RecuperarInt(aux.Posicion.ElementAt(0));
            int pY = (int)Char.GetNumericValue(aux.Posicion.ElementAt(2));
            mostrarPilaBT();

            //4.Si es mi nodo final entonces termino
            int j = 0;
            while (true)
            {
                j++;
                switch (j) { 
                    case 1:
                        if (Meta[0] == pY && Meta[1] == pX)
                            Solucion = true;
                        break;
                    case 2:
                        if (aux.HijoArriba != null)
                            if(aux.HijoArriba.estado.Equals("vivo"))
                                InsertarBT(pX, pY+1);
                        break;
                    case 3:
                        if (aux.HijoDer != null)
                            if(aux.HijoDer.estado.Equals("vivo"))
                                InsertarBT(pX+1, pY);
                        break;
                    case 4:
                        if (aux.HijoAbajo != null)
                            if(aux.HijoAbajo.estado.Equals("vivo"))
                                InsertarBT(pX, pY-1);
                        break;
                    case 5:
                        if (aux.HijoIzq != null)
                            if(aux.HijoIzq.estado.Equals("vivo"))
                                InsertarBT(pX-1, pY);
                        break;
                    default:
                        break;
                }
                if (j == 5)
                    break;
            }

            mostrarPilaBT();

            //5.Si no es mi nodo final y aún tiene hijos que no han sido expandidos: expando uno de los hijos del nodo
            //actual(lo meto a la pila, en el órden elegido en el paso 1).

            //6.Si no es mi nodo final y ya no tiene hijos entonces marco como cerrado el nodo actual(lo saco de la
            //pila y lo meto en una lista de nodos cerrados)

            //7.Vuelvo al paso 3











            //1.Nodo inicial

            //Se elige nodo actual
            //Si no es solucion continua
            //cambiar estado del nodo a expansion
            //Agregar hijos a la pila(solo si no estan visitados)
            //Se elige al hijo vivo mas al fondo de la pila
            //


            //Solucion: Elementos de la pila que estan en expansion
        }

        public int RecuperarInt(char letra)
        {
            String letras = "ABCDEFGHIJKLMNO";
            int i = 0;
            while (letra.Equals(letras.ElementAt(i)))
            {
                if (letra.Equals(letras.ElementAt(i)))
                    return i;
                i++;
            }
            return 0;

        }

        public void InsertarBT(int infoX, int infoY)
        {
            Nodo nuevo;
            nuevo = new Nodo();

            String letras = "ABCDEFGHIJKLMNO";

            String letra = devolverLetra(infoX);
            String let = "";

            String dato = letra + "-" + infoY.ToString();
            Console.Write("\nDato: " + dato + "\n");

            nuevo.Posicion = dato;

            int posicionX = infoX;
            int posicionY = infoY;

            if (posicionY == 0)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Arriba Nulo\n");
                nuevo.HijoArriba = null;
            }
            else
            {
                let = letras.ElementAt(posicionX).ToString();
                Nodo HijoAr = new Nodo();
                HijoAr.Posicion = let + "-" + (posicionY - 1).ToString();
                HijoAr.Padre = nuevo;
                nuevo.HijoArriba = HijoAr;
            }

            if (posicionX == MatrizY - 1)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Derecha Nulo\n");
                nuevo.HijoDer = null;
            }
            else
            {
                let = letras.ElementAt(posicionX + 1).ToString();
                Nodo HijoDer = new Nodo();
                HijoDer.Posicion = let + "-" + (posicionY).ToString();
                HijoDer.Padre = nuevo;
                nuevo.HijoDer = HijoDer;
            }

            if (posicionY == MatrizX - 1)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Abajo Nulo\n");
                nuevo.HijoAbajo = null;
            }
            else
            {
                let = letras.ElementAt(posicionX).ToString();
                Nodo HijoAb = new Nodo();
                HijoAb.Posicion = let + "-" + (posicionY + 1).ToString();
                HijoAb.Padre = nuevo;
                nuevo.HijoAbajo = HijoAb;
            }

            if (posicionX == 0)
            {
                Console.Write("PosX: " + posicionX + " MY: " + MatrizY + " Izquierda Nulo\n");
                nuevo.HijoIzq = null;
            }
            else
            {
                let = letras.ElementAt(posicionX - 1).ToString();
                Nodo HijoIz = new Nodo();
                HijoIz.Posicion = let + "-" + (posicionY).ToString();
                HijoIz.Padre = nuevo;
                nuevo.HijoIzq = HijoIz;
            }

            //nuevo.Peso = ObtenerPeso() ;

            if (PilaBT.Count == 0)
            {
                Nodo Pater = new Nodo();
                Pater.Posicion = "Root";

                
            }
            else
            {
                //nuevo.Padre = PilaBT.Peek();
            }
            

            nuevo.Turno = Turno;
            nuevo.estado = "expandido";

            PintaHijos(nuevo, infoX, infoY);

            PilaBT.Push(nuevo);

            
        }

        public void mostrarPilaBT()
        {
            Console.WriteLine("Pila:");
            int i = 0;
            while (i < PilaBT.Count())
            {
                Console.WriteLine("Nodo: " + PilaBT.ElementAt(i).Posicion);
                i++;
            }
        }
    }
}

