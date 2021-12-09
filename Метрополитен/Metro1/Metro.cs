using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метрополитен
{
    class Metro
    {
        private List<Line> lines;
        private string city;

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
            Line line = new Line(name, color);
            lines.Add(line);
        }
        public void RemoveLine(string name)
        {
            for(int i = 0; i < lines.Count(); i++)
            {
                if(lines[i].GetName() == name)
                {
                    lines.Remove(lines[i]);
                }
            }
        }
        public List<Station> FindStation(string name, string lineName)
        {
            return null;
        } 
        public Station FindStation()
        {
            return null;
        }
        public List<Station> GetStationList(string name)
        {
            return null;
        }
        public void LoadStationsFromFile(string filename)
        {

        }
        public override string ToString()
        {
            return null;
        }
    }
}
