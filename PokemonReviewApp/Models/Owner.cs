﻿namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }

        public int countryID { get; set; }
        public Country? country { get; set; }
    }

}
