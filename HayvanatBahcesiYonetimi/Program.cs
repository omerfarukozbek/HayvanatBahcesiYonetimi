using HayvanatBahcesiYonetimi.Entities.Concrete;
using HayvanatBahcesiYonetimi.Repositories.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HayvanReporsitory hr=new HayvanReporsitory();
            hr.Create(-1,"beygir",2,Tur.At); // Id degeri -1 girilince default olarak Id ye 0 degerini atadık
            hr.Create(2, "boncuk", 1, Tur.Kedi);
            hr.Create(3,"hamster",3,Tur.Kemirgen);
            hr.GetList();
            hr.Find(2);
         
            hr.Delete(5);
            

            
            Console.ReadLine();

            
            
        }
    }
}
