using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM
{
    public class Usuario
    {
        public static List<Usuario> UserList = new List<Usuario>();

        // make those fields public for accessibility
        public string id;
        public static int lastID;
        public string Username;
        public string Email;
        public string Password;
        public string Tipo;

        public Usuario()
        {

        }

        public Usuario(string id, string Username, string Email, string Password, string Tipo)
        {
            // assign each fields with arguments from constructor
            this.id = id;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.Tipo = Tipo;
            lastID++;
        }

        public static void Adicionar(Usuario user)
        {
            UserList.Add(user);
        }

        public static void Remover(Usuario user)
        {
            UserList.Remove(user);
        }

        public static List<Usuario> Buscar(string identificador)
        {
            List<Usuario> resultado = UserList.FindAll(x => x.id == identificador);
            return resultado;
        }

        public static bool Logar(string userName, string pass)
        {
            bool login = false;
            List<Usuario> resultado = UserList.FindAll(x => x.Username == userName && x.Password==pass);
            if(resultado.Count==1)
            {
                login = true;
            }
            else
            {
                login = false;
            }
            return login; 
        }

    }
}
