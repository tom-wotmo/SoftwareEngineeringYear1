using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft152_Assignment
{
    class Property
    {
        private string propertyId;
        private string propertyName;
        private string hostID;
        private string hostName;
        private string hostProperties;
        private string latitude;
        private string longitude;
        private string roomType;
        private int price;
        private int minNights;
        private int availability;

        public Property()
        {

        }

        public Property(string _propertyId, string _propertyName, string _hostId, string _hostName, string _hostProperties, string _latitude, string _longitude, string _roomType, int _price, int _minNights, int _availability)
        {
            propertyId = _propertyId;
            propertyName = _propertyName;
            hostID = _hostId;
            hostName = _hostName;
            hostProperties = _hostProperties;
            latitude = _latitude;
            longitude = _longitude;
            roomType = _roomType;
            price = _price;
            minNights = _minNights;
            availability = _availability;
        }
        public string getPropertyData()
        {
            string output = String.Format("Property ID: {0}, Property Name: {1}, Host ID: {2}",
                                          propertyId, propertyName, hostID);
           
            return output;
        }

        public void setPropertyId(string inputPropertyId)
        {
            propertyId = inputPropertyId;
        }
        public string getPropertyId()
        {
            return propertyId;
        }
        public void setPropertyName(string inputPropertyName)
        {
            propertyName = inputPropertyName;
        }
        public string getPropertyName()
        {
            return propertyName;
        }
        public void setHostId(string inputHostId)
        {
            hostID = inputHostId;
        }
        public string getHostId()
        {
            return hostID;
        }
        public void setHostName(string inputHostName)
        {
            hostName = inputHostName;
        }
        public string getHostName()
        {
            return hostName;
        }
        public void setHostProperties(string inputHostProperties)
        {
            hostProperties = inputHostProperties;
        }
        public string getHostProperties()
        {
            return hostProperties;
        }
        public void setLatitude(string inputLatitude)
        {
            latitude = inputLatitude;
        }
        public string getLatitude()
        {
            return latitude;
        }
        public void setLongitude(string inputLongitude)
        {
            longitude = inputLongitude;
        }
        public string getLongitude()
        {
            return longitude;
        }
        public void setRoomType(string inputRoomType)
        {
            roomType = inputRoomType;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public void setPrice(int inputPrice)
        {
            price = inputPrice;
        }
        public int getPrice()
        {
            return price;
        }
        public void setMinNight(int inputMinNight)
        {
            minNights = inputMinNight;
        }
        public int getMinNight()
        {
            return minNights;
        }
        public void setAvailability(int inputAvailability)
        {
            availability = inputAvailability;
        }
        public int getAvailability()
        {
            return availability;
        }
    }
}
