using BlazorDestinationGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDestinationGame.Data
{
    public class Destinations
    {
        public Destinations(out List<Destination> destinations)
        {
            destinations = new List<Destination>();
            Destination place1 = new Destination
            {
                LocationName = "Disney",
                LocationDescription = "Disney Land",
                Location = "Anaheim CA USA",
                LocationImage = "image/Disney.jpg",
                WrongAnswer1 = "Eiffel Tower",
                WrongAnswer2 = "The Alamo"
            };

            destinations.Add(place1);

            Destination place2 = new Destination
            {
                LocationName = "Giza",
                LocationDescription = "The Pyramids at Giza",
                Location = "Giza Egypt",
                LocationImage = "image/Giza.jpg",
                WrongAnswer1 = "San Diego",
                WrongAnswer2 = "Las Vegas"
            };

            destinations.Add(place2);

            Destination place3 = new Destination
            {
                LocationName = "Louvre",
                LocationDescription = "The Louvre",
                Location = "Paris France",
                LocationImage = "image/Louvre.jpg",
                WrongAnswer1 = "Statue of Liberty",
                WrongAnswer2 = "Jefferson Memorial"
            };

            destinations.Add(place3);

            Destination place4 = new Destination
            {
                LocationName = "Taj Mahal",
                LocationDescription = "The Taj Mahal",
                Location = "Agra India",
                LocationImage = "image/tajmahal.jpg",
                WrongAnswer1 = "The Kremlin",
                WrongAnswer2 = "Notre Dame"
            };

            destinations.Add(place4);

            Destination place5 = new Destination
            {
                LocationName = "Waikiki",
                LocationDescription = "Waikiki Beach",
                Location = "Honolulu HI USA",
                LocationImage = "image/WaikikiBeach.jpg",
                WrongAnswer1 = "Phuket Thailand",
                WrongAnswer2 = "San Paulo Brazil"
            };

            destinations.Add(place5);

        }
    }
}
