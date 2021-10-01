using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using Newtonsoft.Json;
using OpenStreet_Parser.Models;

namespace OpenStreet_Parser
{
    static class Parser
    {
        public static async void SaveFromFile(string path, Polygon polygon)
        {
            try
            {
                var poly = JsonConvert.SerializeObject(polygon);
                using (StreamWriter writer = new StreamWriter($"{path}", true, Encoding.Default))
               {
                   await writer.WriteLineAsync(poly.ToString());
               }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
