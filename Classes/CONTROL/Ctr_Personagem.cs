using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;

namespace Classes.CONTROL
{
    public class Ctr_Personagem
    {
        Personagem personagem = new Personagem();
        CRUD crud = new CRUD();

        public void Coloca_Modelo_nome(string nome)
        {
            personagem.Setnome(nome);
        }

        public void Coloca_Modelo_sobrenome(string sobrenome)
        {
            personagem.Setsobrenome(sobrenome);
        }

        public void Coloca_Modelo_idade(string idade)
        {
            personagem.Setidade(idade);
        }

        public void Coloca_Modelo_sexo(string sexo)
        {
            personagem.Setsexo(sexo);
        }

        public void Coloca_Modelo_raca(int raca)
        {
            personagem.Setraca(raca);
        }

        public void Coloca_Modelo_classe(int classe)
        {
            personagem.Setclasse(classe);
        }

        public void Coloca_Modelo_olhos(string olhos)
        {
            personagem.Setolhos(olhos);
        }

        public void Coloca_Modelo_cabelo(string cabelo)
        {
            personagem.Setcabelo(cabelo);
        }

        public void Coloca_Modelo_altura(string altura)
        {
            personagem.Setaltura(altura);
        }

        public void Coloca_Modelo_peso(string peso)
        {
            personagem.Setpeso(peso);
        }

        public void Coloca_Modelo_historia(string historia)
        {
            personagem.Sethistoria(historia);
        }


        public void Coloca_DAO()
        {
            crud.Insert_Personagem(personagem.Getnome(), personagem.Getsobrenome(), personagem.Getidade(), personagem.Getsexo(), personagem.Getraca(), personagem.Getclasse(), personagem.Getolhos(), personagem.Getcabelo(), personagem.Getaltura(), personagem.Getpeso(),personagem.Gethistoria());
        }
    }
}
