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
        
        }
        public string GetName()
        {
            return "";
        }
        public void SetName(string name)
        {

        }
        public string GetColor()
        {
            return "";
        }
        public void SetColor(string color)
        {

        }
        public void AddStation(string name, string color)
        {

        }
        public void AddStation(string name, string color, List<Station> transfers)
        {

        }
        public void RemoveStation(string name)
        {

        }
        public Station FindStationByName(string name)
        {

        }
        public List<Station> GetStationList (string name)
        {

        }
    }
}
