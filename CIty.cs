using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public string YearEstablished { get; set; }

        private List<Building> _Buildings { get; set;} = new List<Building>();

        public void AddBuildingToCity(Building buildingToAdd){
                _Buildings.Add(buildingToAdd);}

        public List<Building> Buildings {get { return _Buildings;} set {_Buildings = value; } }
     
    }
}