using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreet_Parser.Models
{
    class OSM : Service
    {
        public OSM(string site):base(site) {}
        public OSM(string site, string path, int step):base(site,path,step)
        {

        }
        public OSM(string site, string path):base(site,path)
        {

        }
        public override void ProcessAdress()
        {
            try
            {

                string json = "";
                using (var request = new HttpRequest())
                {
                    json = request.Get($"https://nominatim.openstreetmap.org/search?format=json&q={base.Path.Replace(' ', '+')}&polygon_geojson=1&email=o-markin@mail.ru").ToString();
                }
                Polygon temp = BuildPolygon(json); //временный полигон со всеми точками
                Polygon newPoly = new Polygon();//в соответствии с заданным шагов записываем нужные точки в новый полигон
                for (int i = 0; i < temp.Coordinates.Count; i += base.Step)
                {
                    newPoly.Coordinates.Add(temp.Coordinates[i]);
                }
                Parser.SaveFromFile(base.FilePath, newPoly);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public static Polygon BuildPolygon(string json)
        {
            /*
             * Дессериализация полученного JSON
             * и запись в экземпляр полигона
             */
            try
            {
                Polygon polygon = new Polygon();
                List<Models.JsonResponse.Root> adresses = JsonConvert.DeserializeObject<List<Models.JsonResponse.Root>>(json);
                foreach (Models.JsonResponse.Root adress in adresses)
                {
                    foreach (var point in adress.geojson.coordinates)
                    {
                        polygon.Coordinates.Add(new Point() { lat = adress.lat, lon = adress.lon });
                    }
                }
                return polygon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
