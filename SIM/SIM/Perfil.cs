using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM
{
    public class Perfil
    {
        public static List<Perfil> ProfileList = new List<Perfil>();

        public string id;
        public string nome;
        public string foto;

        public Perfil()
        {

        }

        public Perfil(string id, string nome, string foto)
        {
            this.id = id;
            this.nome = nome;
            this.foto = foto;
        }

        public static void Adicionar(Perfil profile)
        {
            ProfileList.Add(profile);
        }

        public static List<Perfil> Buscar(string identificador)
        {
            List<Perfil> resultado = ProfileList.FindAll(x => x.id == identificador);
            return resultado;
        }

    }
}
