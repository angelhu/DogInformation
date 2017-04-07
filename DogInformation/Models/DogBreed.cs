using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogInformation.Models
{
    public class DogBreed
    {
        public int DogBreedID { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Breed")]
        public string Description { get; set; }
    }
}