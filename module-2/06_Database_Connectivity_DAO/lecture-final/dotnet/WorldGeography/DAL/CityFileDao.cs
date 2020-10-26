using System;
using System.Collections.Generic;
using System.Text;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    class CityFileDao
    {
        public CityFileDAO(string databaseconnectionString)
        {
           
        }
        public void AddCity(City city)
        {
            //read a file
            //for each line, split to array
            // add array elements to a list

            // add parameter to the collection
            //write the modified collection to a file
            //return void
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            IList<City> cities = new List<City>();
            //read a file
            //for each line, split to array
            // add array elements to a list
            //search the list for cities with the correct country code
            //if found, add to new list

            return cities;
        }
    }
}
