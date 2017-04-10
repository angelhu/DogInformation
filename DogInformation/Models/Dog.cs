using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogInformation.Models
{
    public class Dog
    {
        public int DogID { get; set; }

        [Display(Name = "Age")]
        public int DogAge { get; set; }

        [Display(Name = "Gender")]
        public string DogGender { get; set; }

        public string Name { get; set; }

        [Display(Name = "Breed")]
        public int DogBreedID { get; set; }
        public virtual DogBreed Breed { get; set; }
    }
}