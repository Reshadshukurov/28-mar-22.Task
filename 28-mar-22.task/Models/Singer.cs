using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_mar_22.task.Models
{
    class Singer
    {
        private string _Name;
        public string Name { 
            get
            {
                return _Name;
            } 
            set
            {
                if (Name.Length < 100)
                {
                    _Name = Name;
                }
            }
        }
       
        private string _Surname;
        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                if (Surname.Length < 100)
                {
                    _Surname = Surname;
                }
            }
        }
        private int _Age;
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if(Age > 0 && Age < 170)
            {
                    _Age = Age;
                }
            }
        }
       
    }
}
