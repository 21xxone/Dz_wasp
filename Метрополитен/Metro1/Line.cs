using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    public class Line
    {
        List<Station> stations;
        string name;
        string color;

        public Line(string name, string color)
        {
            this.color = color;
            this.name = name;
        }
        public Station GetStation(string name)
        {
            return null;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name, string color)
        {
            stations.Add(new Station(name, color));
        }
        public void AddStation(string name, string color, List<Station> transfers)
        {
            stations.Add(new Station(name, color, transfers));
        }
        public void RemoveStation(string name)
        {

        }
        public Station FindStationByName(string name)
        {
            return null;
        }
        public List<Station> GetStationList()
        {
            return stations;
        }
    }
    public class UndergroundLine : Line
    {
        public UndergroundLine(string name, string color) : base(string name, ConsoleColor color)
        {

        }
    }
}
