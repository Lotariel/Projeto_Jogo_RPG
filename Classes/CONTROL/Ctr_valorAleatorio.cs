using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CONTROL
{
    public class Ctr_valorAleatorio
    {
        Random aleatorio;
        public Ctr_valorAleatorio()
        {
            aleatorio = new Random();
        }

        //número aleatorio de 1 a 100
        public int valor()
        {
            return aleatorio.Next(1, 100);
        }
    }
}
