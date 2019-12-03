using COM580Assignment02.Models;
using COM580Assignment02.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace COM580Assignment02.Services
{
    public class AnimalDataService : IAnimalDataService
    {
        private AnimalDBContext db = null;

        public AnimalDataService()
        {
            this.db = new AnimalDBContext();
        }

        public AnimalDataService(AnimalDBContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            db.Initialise();
        }

        public bool Delete(int id)
        {
            var existing = db.Animals.FirstOrDefault(a => a.ID == id);
            if (existing == null)
            {
                return false;
            }
            db.Remove(existing);
            db.SaveChanges();
            return true;
        }

        public Animal Insert(Animal obj)
        {
            db.Animals.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public IList<Animal> SelectAll()
        {
            return db.Animals.OrderBy(a => a.animalDOB).ToList();
        }

        public Animal SelectByID(int id)
        {
            return db.Animals.FirstOrDefault(a => a.ID == id);
        }

        public void Update(Animal obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
