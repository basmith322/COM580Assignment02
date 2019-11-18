using COM580Assignment02.Models;
using System.Collections.Generic;

namespace COM580Assignment02.Services
{
    public interface IAnimalDataService
    {
        void Initialise();
        IList<Animal> SelectAll();
        Animal SelectByID(int id);
        Animal Insert(Animal obj);
        void Update(Animal obj);
        bool Delete(int id);
    }
}
