using HayvanatBahcesiYonetimi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiYonetimi.Entities.Concrete
{
    public class At : Hayvan
    {
        public At(int Id,string name,int age,Tur tur)
        {
            this.Id = Id;
            this.Name = name;   
            this.Age = age;
            this.tur = tur;
        }
    }
}
