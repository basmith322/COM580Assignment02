using COM580Assignment02.Models;
using System;

namespace COM580Assignment02.Services
{
    public class ServiceSeeder
    {
        public static void Seed(IAnimalDataService service)
        {
            service.Initialise();

            var a1 = service.Insert(new Animal
            {
                animalName = "Buster",
                animalType = "Dog",
                animalBreed = "Landseer/Collie",
                animalCharacteristics = "Ignorant, Loving, Fluffy, Cheeky",
                animalDOB = DateTime.Parse("11/10/2008"),
                animalGender = "Male",
                animalImage = ""
            });
            var a2 = service.Insert(new Animal
            {
                animalName = "Sylvie",
                animalType = "Cat",
                animalBreed = "Tabby",
                animalCharacteristics = "Sweet, timid",
                animalDOB = DateTime.Parse("11/10/2017"),
                animalGender = "Female",
                animalImage = ""
            });
        }
    }
}
