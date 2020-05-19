using System;
namespace CS_Food_Web_App.Core
{

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType cuisine { get; set; }
    }
}
