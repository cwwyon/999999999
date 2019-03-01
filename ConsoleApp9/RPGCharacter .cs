using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class RPGCharacter
    {
        protected string name;
        protected int strength;
        protected int dectrtity;
        protected int intelligence;
        protected int experience;
        public RPGCharacter(string name, int strength, int dectrtity,int intelligence)
        {
            experience = 0;
        }
        public int Dectrtity
        {
            get
            {
                return dectrtity;
            }
            set
            {
                dectrtity = value;
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                strength = value;
            }
        }

    }
}
