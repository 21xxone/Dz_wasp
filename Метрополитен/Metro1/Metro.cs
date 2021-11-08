using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    class Metro
    {
        List<Line> lines;
        string city;

        public Metro (string city)
        {
            this.city = city;
            lines = new List<Line>();
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine (string name, string color)
        {

        }
        public void RemoveLine (string name)
        {

        }
        public List<Station> FindStation(string name, string lineName)
        {
        
        } 
        public Station FindStation(string name, string lineName)
        {

        }
        public List<Station> GetStationList(string name)
        {

        }
        public void LoadStationsFromFile(string filename)
        {

        }
    }
}
