using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace COM580Assignment02.Models
{
    public class Animal
    {
        public int ID { get; set; }

        [StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Name Required")]
        [DisplayName("Animal Name")]
        public string animalName { get; set; }

        [StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Type Required")]
        [DisplayName("Animal Type")]
        public string animalType { get; set; }

        [StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Breed Required")]
        [DisplayName("Animal Breed")]
        public string animalBreed { get; set; }

        [StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Gender Required")]
        [DisplayName("Animal Gender")]
        public string animalGender { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Invalid Date")]
        [DisplayName("Animal DOB")]
        public DateTime animalDOB { get; set; }

        [StringLength(200)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Characteristics Required")]
        [DisplayName("Animal Characteristics")]
        public string animalCharacteristics { get; set; }

        [StringLength(200)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Image Required")]
        [DisplayName("Animal Image")]
        public string animalImage { get; set; }
    }
}
