using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    class Station
    {
        public string name;
        public string color;
        public Line line;
        bool isWheelchairAccessible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;
        List<Station> transfers;

        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station(string name, string color, List<Station> transfers)
        {
            this.name = name;
            this.color = color;

        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelchairAccessible()
        {
            return isWheelchairAccessible;
        }
        public bool HasParkAndRide()
        {
            return hasParkAndRide;
        }
        public bool HasNearbyCableCar()
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
    }
}
