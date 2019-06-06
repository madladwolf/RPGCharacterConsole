using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Character
    {
        private string classe, raca, _sexo, regiao, status;
        public Stats stats { get; set; }
        public Character()
        {
            classe = "default";
            raca = "default";
            _sexo = "default";
            regiao = "default";
            stats = new Stats();
        }

        public Character(string c, string r, string s, string reg, Stats stat)
        {
            if (!setClasse(c)) classe = "default";
            if (!setRaca(r)) raca = "default";
            if (!setSexo(s)) _sexo = "default";
            if (!setRegiao(r)) regiao = "default";
            stats = new Stats(stat);
        }
        public Character(Character c)
        {
            classe = c.getClass();
            raca = c.getRaca();
            _sexo = c.getSexo();
            regiao = c.getRegiao();
            stats = new Stats(c.stats);
        }
        public bool setClasse(string c)
        {
            if (c != "" || c != null)
            {
                classe = c;
                return true;
            }
            return false;
        }

        //set sexo
        public bool setSexo(string s)
        {
            if(s != "" )
            {
                if(s == "Masculino" || s == "Feminino")
                {
                    _sexo = s;
                    return true;
                } 
            }
            return false;
        }

        public bool setRaca(string r)
        {
            if(r != "" || r != null)
            {
                raca = r;
                return true;
            }
            return false;
        }

        public bool setRegiao(string reg)
        {
            if(reg != "" || reg != null)
            {
                regiao = reg;
                return true;
            }
            return false;
        }
        public string getClass()
        {
            return classe;
        }
        public string getRaca()
        {
            return raca;
        }
        public string getSexo()
        {
            return _sexo;
        }
        public string getRegiao()
        {
            return regiao;
        }
    }
}
