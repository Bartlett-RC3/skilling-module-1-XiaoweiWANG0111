using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animalworld
{
    class Animal
    {
        public string Species;
        private string Gender;

        public float Weight;
        private int Age;
        private string AnimalCountry;

        public Animal(string _species, string _gender, float _weight, int _age, string _animalCountry)
        {
            Species = _species;
            Gender = _gender;
            Weight = _weight;
            Age = _age;
            AnimalCountry = _animalCountry;

        }
    }
}
