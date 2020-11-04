using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;

namespace Classes.CONTROL
{
    public class Ctr_Classe
    {
        Classe classe = new Classe();
        CRUD crud = new CRUD();
        
        

        public void Coloca_Model_nome(string nome){
            classe.Setnome(nome);
        }

        public void Coloca_Model_descricao(string desc) {
            classe.Setdescricao(desc);
        }

        public void Coloca_Model_forca(int forca) {
            classe.Setforca(forca);
        }

        public void Coloca_Model_vitalidade(int vita) {
            classe.Setvitalidade(vita);
        }

        public void Coloca_Model_magia(int magia) {
            classe.Setmagia(magia);
        }

        public void Coloca_Model_aura(int aura) {
            classe.Setaura(aura);
        }

        public void Coloca_Model_velocidade(int velo) {
            classe.Setvelocidade(velo);
        }

        public void Coloca_Model_foco(int foco) {
            classe.Setfoco(foco);
        }

        public void Coloca_Model_precisao(int precisao) {
            classe.Setprecisao(precisao);
        }


        public void Coloca_DAO() {
            crud.Insert_classe(classe.Getnome(), classe.Getforca(), classe.Getvitalidade(), classe.Getmagia(), classe.Getaura(), classe.Getfoco(), classe.Getvelocidade(), classe.Getdescricao(), classe.Getprecisao());
        }
        
    }
}
