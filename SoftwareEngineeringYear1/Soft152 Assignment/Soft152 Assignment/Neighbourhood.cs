using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft152_Assignment
{
    class Neighbourhood
    {
        private string neighbourhoodName;
        private int numberofProperties;
        private Property[] properties;


        public Neighbourhood()
        {

        }
        public Neighbourhood(string _neighbourhoodName, int _numberofProperties)
        {
            neighbourhoodName = _neighbourhoodName;
            numberofProperties = _numberofProperties;
        }
        public Neighbourhood(string _neighbourhoodName, int _numberofProperties, Property[] _properties)
        {
            neighbourhoodName = _neighbourhoodName;
            numberofProperties = _numberofProperties;
            properties = _properties;
        }

        public string getNeighbourhoodData()
        {
            string output = String.Format("Neighbourhood: {0} Properties in this neighbourhood {1} ",
                                          neighbourhoodName, numberofProperties);
            return output;
        }

        public void setneighbourhoodName(string inputneighbourgoodName)
        {
            neighbourhoodName = inputneighbourgoodName;
        }
        public string getneighbourhoodName()
        {
            return neighbourhoodName;
        }
        public void setnumberofProperties(int inputnumberofProperties)
        {
            numberofProperties = inputnumberofProperties;
        }
        public int getnumberofProperties()
        {
            return numberofProperties;
        }
        public void setProperties(Property[] inputProperties)
        {
            properties = inputProperties;
        }
        public Property[] getProperties()
        {
            return properties;

        }




    }

}  
