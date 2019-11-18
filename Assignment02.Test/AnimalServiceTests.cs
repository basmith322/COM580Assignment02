using COM580Assignment02.Services;
using System;
using System.Linq;
using Xunit;

namespace COM580Assignment02.Test
{
    public class AnimalServiceTests
    {
        private IAnimalDataService service;


        public AnimalServiceTests()
        {
            service = new AnimalDataService();
            service.Initialise();
            ServiceSeeder.Seed(service);
        }
        [Fact]
        public void TestSelectAll()
        {
            var animals = service.SelectAll();
            var animalCount = animals.Count();

            //assert
            Assert.Equal(2, animalCount);
        }

        [Fact]
        public void TestSelectByID()
        {
            var animal = service.SelectByID(1);
            string animalName = animal.animalName;

            //Assert
            Assert.Equal("Buster", animalName);
        }

        [Fact]
        public void TestInsert()
        {
            var animal = service.Insert(new Models.Animal
            {
                animalName = "Noki",
                animalType = "Dog",
                animalBreed = "Dachshund/Lab",
                animalCharacteristics = "Nervous, Affectionate, loud",
                animalDOB = DateTime.Parse("11/11/2017"),
                animalGender = "Male",
                animalImage = ""
            });

            //Assert
            Assert.Equal("Noki", animal.animalName);
        }

        [Fact]
        public void TestDelete()
        {
            var animal = service.SelectByID(2);
            var result = service.Delete(2);

            //Assert
            Assert.True(result);
            animal = service.SelectByID(2);
            Assert.Null(animal);
        }

        [Fact]
        public void TestUpdate()
        {
            var animal = service.SelectByID(1);
            animal.animalName = "Buster2";
            service.Update(animal);

            //assert
            animal = service.SelectByID(1);
            Assert.Equal("Buster2", animal.animalName);
        }
    }
}
