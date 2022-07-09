using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiYonetimi.Entities.Abstract
{
    public abstract class Hayvan
    {
        private int _ıd;

        public int Id
        {
            get { return _ıd; }
            set {
                if (value>0)
                {
                _ıd = value; 

                }
                else
                {
                    Console.WriteLine("Girilen Id degeri hatalı");
                }
            }
        }
        public string Name { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set {
                if (value>0)
                {
                _age = value; 

                }
                else
                {
                    Console.WriteLine("Hatalı Yas degeri girdiniz!!");
                }
            }
        }
        public Tur tur { get; set; }



    }
}
