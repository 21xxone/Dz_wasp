using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    public class Station
    {
        protected string name;
        protected ConsoleColor color;
        protected Line line;
        protected bool isWheelchairAccessible;
        protected bool hasParkAndRide;
        protected bool hasNearbyCableCar;
        protected List<Station> transfers;
        public Station(string name, ConsoleColor color, params[] string info)
        {
            this.name = name;
            this.color = color;
            foreach (Station c in transfers)
            {
                this.transfers.Add(c);
            }
        }
        public Station(string name, ConsoleColor color, List<Station> transfers, params[] string info)
        {
            this.name = name;
            this.color = color;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public bool IsWheelchairAccessible
        {
            get
            {
                return isWheelchairAccessible;
            }
            set
            {
                isWheelchairAccessible = value;
            }
        }
        public bool HasParkAndRide
        {
            get
            {
                return HasParkAndRide;
            }
            set
            {
                HasParkAndRide = value;
            }
        }
        public bool HasNearbyCableCar
        {
            get
            {
                return hasNearbyCableCar;
            }
            set
            {
                hasNearbyCableCar = value;
            }
        }
        public string GetLineName()
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
        public override string ToString()
        {
            return "";
        }
    }
}

