using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogInformation.Models
{
    public class Dog
    {
        public int DogID { get; set; }
        public int DogAge { get; set; }
        public string DogGender { get; set; }

        public int DogBreedID { get; set; }
        public virtual DogBreed Breed { get; set; }
    }
}