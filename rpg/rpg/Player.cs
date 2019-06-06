using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Player
    {
        private string nome, sexo, email;
        private bool newsletter;
        private string dataNas;
        private DateTime dataNascimento;

        public Player()
        {
            nome = "default";
            sexo = "default";
            email = "default";
            newsletter = false;
            dataNas = "01/01/2000";
            dataNascimento = DateTime.Parse(dataNas);
        }
        public Player(string n, string s, string e, bool news, string d)
        {
            if (!setNome(n)) nome = "default";
            if (!setSexo(s)) sexo = "default";
            if (!setEmail(e)) email = "default";
            setNewsletter(news);
            if (!setDate(d)) dataNascimento = DateTime.Parse("01/01/2000");
        }
        public Player(Player c)
        {
            nome = c.getNome();
            sexo = c.getSexo();
            email = c.getEmail();
            newsletter = c.getNews();
            dataNascimento = c.getDatanasc();
        }
        public bool setNome(string n)
        {
            if(n != "" && n != null)
            {
                nome = n;
                return true;
            }
            return false;
        }
        public bool setSexo(string s)
        {
            if(s != "Masculino" || s != "Feminino")
            {
                sexo = s;
                return true;
            }
            return false;
        }
        public bool setEmail(string e)
        {
            if(e != "" && e != null)
            {
                email = e;
                return true;
            }
            return false;
        }
        public bool setNewsletter(bool n)
        {
            newsletter = n;
            return true;
        }

        public bool setDate(string d)
        {
            DateTime date;
            if(DateTime.TryParse(d, out date) != false)
            {
                date = dataNascimento;
                return true;
            }
            return false;
        }

        public string getNome()
        {
            return nome;
        }
        public string getSexo()
        {
            return sexo;
        }
        public DateTime getDatanasc()
        {
            return dataNascimento;
        }
        public string getEmail()
        {
            return email;
        }
        public bool getNews()
        {
            return newsletter;
        }
    }
}
