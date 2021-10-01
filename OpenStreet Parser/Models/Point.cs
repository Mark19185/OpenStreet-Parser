using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreet_Parser.Models
{
    class Point
    {
        public string lat { get; set; }
        public string lon { get; set; }
        public Point()
        {

        }
        public Point(string _lat, string _lon)
        {
            lat = _lat;
            lon = _lon;
        }
        public override string ToString()
        {
            return $"{lat},{lon}";
        }
    }
}
