using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;

namespace Classes.CONTROL
{
    public class Ctr_Tipo
    {
        Tipos tipos = new Tipos();
        CRUD crud = new CRUD();

        public void Coloca_Model_nome(string nome) {
            tipos.Setnome(nome);
        }

        public void Coloca_DAO() {
            crud.Insert_tipos(tipos.Getnome());
        }
    }
}
