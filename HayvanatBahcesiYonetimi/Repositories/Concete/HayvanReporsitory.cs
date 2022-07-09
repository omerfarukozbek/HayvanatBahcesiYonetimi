using HayvanatBahcesiYonetimi.Entities.Abstract;
using HayvanatBahcesiYonetimi.Entities.Concrete;
using HayvanatBahcesiYonetimi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HayvanatBahcesiYonetimi.Repositories.Concete
{
    public class HayvanReporsitory : BaseHayvanRepository

    {
        public override void Create(int Id, string name, int age, Tur tur)
        {
            if (tur==Tur.At)
            {
                Hayvan at = new At(Id,name,age,tur);
                SeedData.ListHayvan.Add(at);
            }
            else if (tur==Tur.Kedi)
            {
                Hayvan kedi = new Kedi(Id,name,age,tur);
                SeedData.ListHayvan.Add(kedi);
            }
            else if (tur==Tur.Kemirgen)
            {
                Hayvan kemirgen = new Kemirgen(Id, name, age, tur);
                SeedData.ListHayvan.Add(kemirgen);
            }
        }

        public override void Delete(int Id)
        {
            foreach (var item in SeedData.ListHayvan)
            {
                if (item.Id==Id)
                {
                    SeedData.ListHayvan.Remove(item);
                    return;
                }
            }
            Console.WriteLine("Aranan Id de hayvan bulunamadı");
        }

        public override void Find(int Id)
        {
            string mark = new string('=', 20);
            foreach (var item in SeedData.ListHayvan)
            {
                if (Id == item.Id)
                {
                    Console.WriteLine($"Id={item.Id}\nName ={item.Name}\nAge ={item.Age}\nTur ={item.tur}\n{mark}");
                    
                    return;
                }
            }
            Console.WriteLine("Aranan Id de hayvan bulunamadı");
        }

        public override void Update(int Id, string name, int age, Tur tur)
        {
            foreach (var item in SeedData.ListHayvan)
            {
                if (Id == item.Id)
                {
                    item.Name = name;
                    item.Age = age;
                    item.tur = tur;
                    Console.WriteLine($"Id={item.Id}\nName ={item.Name}\nAge ={item.Age}\nTur ={item.tur}");
                    return;
                }
            }
            Console.WriteLine("Aranan Id de hayvan bulunamadı");

        }
        public override void GetList()
        {
            string mark = new string('=', 20);
            foreach (var item in SeedData.ListHayvan)
            {
                
                    Console.WriteLine($"Id={item.Id}\nName ={item.Name}\nAge ={item.Age}\nTur ={item.tur}\n{mark}");
               
                   
                
            }
        }
    }
}
