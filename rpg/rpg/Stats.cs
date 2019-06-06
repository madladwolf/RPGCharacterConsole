using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Stats
    {
        private int _str, _dex, _int, _lck;

        public Stats()
        {
            _str = 3;
            _dex = 3;
            _int = 3;
            _lck = 4;
        }
        public Stats(int s, int d, int i, int l)
        {
            setStr(s);
            setDex(d);
            setInt(i);
            setLck(l);

        }
        public Stats(Stats s)
        {
            _str = s.getStr();
            _dex = s.getDex();
            _int = s.getInt();
            _lck = s.getLck();
        }
        public void setStr(int s)
        {
            _str = s;
        }
        public void setDex(int d)
        {
            _dex = d;
        }
        public void setInt(int i)
        {
            _int = i;
        }
        public void setLck(int l)
        {
            _lck = l;
        }
        public int getStr()
        {
            return _str;
        }
        public int getDex()
        {
            return _dex;
        }
        public int getInt()
        {
            return _int;
        }
        public int getLck()
        {
            return _lck;
        }
    }
}
