using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiYonetimi.Repositories.Abstract
{
    public abstract class BaseHayvanRepository
    {
        public abstract void Find(int Id);
        public abstract void Create(int Id,string name,int age,Tur tur);
        public abstract void Update(int Id,string name,int age,Tur tur);

        public abstract void Delete(int Id);
        public abstract void GetList();

    }
}
