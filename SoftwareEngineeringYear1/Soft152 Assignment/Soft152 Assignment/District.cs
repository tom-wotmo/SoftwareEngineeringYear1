using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft152_Assignment
{
    class District
    {
        string districtName;
        int numberofNeighbourhood;
        Neighbourhood[] neighbourhoods;

        public District()
        {


        }
        public District(string _districtName, int _numberofNeighbourhood)
        {
            districtName = _districtName;
            numberofNeighbourhood = _numberofNeighbourhood;
        }

        public District(string _districtName, int _numberofNeighbourhood, Neighbourhood[] _neighbourhoods)
        {
            districtName = _districtName;
            numberofNeighbourhood = _numberofNeighbourhood;
            neighbourhoods = _neighbourhoods;

        }
        public string getDistrictData()
        {
            string output = String.Format("District: {0} Neighbourhoods in this District: {1} ", districtName, numberofNeighbourhood);

            return output;
        }

        public void setDistrictName(string inputDistrictName)
        {
            districtName = inputDistrictName;
        }
        public string getDistrictName()
        {
            return districtName;
        }
        public void setNumberofneighbourhood(int inputNumberofneighbourhood)
        {
            numberofNeighbourhood = inputNumberofneighbourhood;
        }
        public int getNumberofneighbourhood()
        {
            return numberofNeighbourhood;
        }
        public Neighbourhood[] getNeighbourhood()
        {
            return neighbourhoods;
        }

        public void setallNBHoods( Neighbourhood[] inNs)
        {
            neighbourhoods = inNs;
        }

    }
}
