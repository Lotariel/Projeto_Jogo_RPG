using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;


namespace Classes.CONTROL
{
    public class Ctr_Pericias
    {
        Pericias pericias = new Pericias();
        CRUD crud = new CRUD();

        public void Coloca_Model_nome(string nome) {
            pericias.Setnome(nome);
        }

        public void Coloca_Model_descricao(string desc) {
            pericias.Setdescricao(desc);
        }


        public void Coloca_DAO(){
            crud.Insert_pericia(pericias.Getnome(),pericias.Getdescricao());
        }
        

    }
}
