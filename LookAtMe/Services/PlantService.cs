using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Models;

namespace LookAtMe.Services
{
    public static class PlantService
    {
        static List<Plant> Plants { get; }
        static int nextId = 3;
        static PlantService()
        {
            Plants = new List<Plant>
            {
                new Plant { Height = "Medium", Name = "Sunflower", Summary = "Happy plant"},
                new Plant { Height = "Small", Name = "Basil", Summary = "Tasty"},
                new Plant { Height = "Big", Name = "Money Tree", Summary = "Nice plant"},
                new Plant { Height = "Small", Name = "Garlic", Summary = "Smelly"}
            };
        }
        public static List<Plant> GetAll() => Plants;
        public static Plant Get(string name) => Plants.FirstOrDefault(p => p.Name == name);
        public static void Add(Plant plant)
        {
            Plants.Add(plant);
        }
        public static void Delete(string name)
        {
            var plant = Get(name);
            if (plant is null)
                return;

            Plants.Remove(plant);
        }
        public static void Update(Plant plant)
        {
            var index = Plants.FindIndex(p => p.Name == plant.Name);
            if (index == -1)
                return;

            Plants[index] = plant;
        }
    }
}
