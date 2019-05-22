using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligenciaArtificial
{
    /*  class Nodo
      {

          /*  private string dato;

            private Nodo hijo;
            private Nodo hermano;

            public string Dato { get => dato; set => dato = value; }
            public Nodo Hijo { get => hijo; set => hijo = value; }
            public Nodo Hermano { get => hermano; set => hermano = value; }

            public Nodo()
            {
                dato = "";
                hijo = null;
                hermano = null;
            }
          public string Posicion;
          public string Padre;
          public string Hijo;
          public Nodo izq, der;

      }*/

    public class ArbolBinarioOrdenado
    {
        class Nodo
        {
            public string Posicion;
            public int Peso;
            public Nodo izq, der;

            public String HijoArriba;
            public String HijoDer;
            public String HijoAbajo;
            public String HijoIzq;

        }
        Nodo raiz;

        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

    }

}
