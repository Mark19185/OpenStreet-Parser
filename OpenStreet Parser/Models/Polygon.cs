using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreet_Parser.Models
{
    class Polygon
    {
        public List<Point> Coordinates = new List<Point>();
        public Polygon()
        {

        }
        public Polygon(Point[] points)
        {

        }
        public void AddNewPoint(Point point)
        {
            if (point.ToString() != "")
            {
                Coordinates.Add(point);
            }
        }

    }
}
