using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    class Station
    {
        string name;
        string color;
        Line line;
        bool isWheelchairAccessible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;
        List<Station> transfers;

        public Station(string name, string color)
        {

        }
        public Station(string name, string color, List<Station> transfers)
        {

        }
        public string GetName()
        {
            return "";
        }
        public void SetName(string name)
        {

        }
        public bool IsWheelchairAccessible()
        {
            return true;
        }
        public bool HasParkAndRide()
        {
            return true;
        }
        public bool HasNearbyCableCar()
        {
            return true;
        }
        public string GetLineName()
        {
            return "";
        }
        public List<Station> GetTransferList()
        {
            
        }
    }
}
