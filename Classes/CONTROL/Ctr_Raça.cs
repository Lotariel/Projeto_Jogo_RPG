using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;

namespace Classes.CONTROL
{
    public class Ctr_Raça
    {
        Raca raca = new Raca();
        CRUD crud = new CRUD();

        public void Coloca_Model_nome(string nome)
        {
            raca.Setnome(nome);
        }

        public void Coloca_Model_descricao(string desc)
        {
            raca.Setdescricao(desc);
        }

        public void Coloca_Model_forca(int forca)
        {
            raca.Setforca(forca);
        }

        public void Coloca_Model_vitalidade(int vitalidade)
        {
            raca.Setvitalidade(vitalidade);
        }

        public void Coloca_Model_magia(int magia)
        {
            raca.Setmagia(magia);
        }

        public void Coloca_Model_aura(int aura)
        {
            raca.Setaura(aura);
        }

        public void Coloca_Model_foco(int foco)
        {
            raca.Setfoco(foco);
        }

        public void Coloca_Model_velocidade(int velo)
        {
            raca.Setvelocidade(velo);
        }

        public void Coloca_DAO()
        {
            crud.Insert_Raca(raca.Getnome(), raca.Getforca(), raca.Getvitalidade(), raca.Getmagia(), raca.Getaura(), raca.Getfoco(), raca.Getvelocidade(), raca.Getdescricao());
        }
    }
}
