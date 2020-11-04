using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MODEL
{
    public class Raca
    {
        private string nome;

        public string Getnome()
        {
            return nome;
        }

        public void Setnome(string value)
        {
            nome = value;
        }

        private int forca;

        public int Getforca()
        {
            return forca;
        }

        public void Setforca(int value)
        {
            forca = value;
        }

        private int vitalidade;

        public int Getvitalidade()
        {
            return vitalidade;
        }

        public void Setvitalidade(int value)
        {
            vitalidade = value;
        }

        private int magia;

        public int Getmagia()
        {
            return magia;
        }

        public void Setmagia(int value)
        {
            magia = value;
        }

        private int aura;

        public int Getaura()
        {
            return aura;
        }

        public void Setaura(int value)
        {
            aura = value;
        }

        private int foco;

        public int Getfoco()
        {
            return foco;
        }

        public void Setfoco(int value)
        {
            foco = value;
        }

        private int velocidade;

        public int Getvelocidade()
        {
            return velocidade;
        }

        public void Setvelocidade(int value)
        {
            velocidade = value;
        }

        private string descricao;

        public string Getdescricao()
        {
            return descricao;
        }

        public void Setdescricao(string value)
        {
            descricao = value;
        }
    }
}
