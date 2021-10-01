using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreet_Parser.Models
{
    abstract class Service
    {
        private string path ="Москва";
        private int step = 1;
        private string file = $"{DateTime.Now.ToShortDateString()}-log.txt";
        public int Step
        {
            get => step;
            set
            {
                if (step > 0)
                {
                    step = value;
                }
            }
        }
        public string FilePath
        {
            get => file;
            set
            {
                if (value != "")
                {
                    file = value;
                }
            }
        }
        public string Path
        {
            get => path;
            set
            {
                if (value != "")
                {
                    path = value;
                };
                
            }
        }
        
        public Service(string site)
        {
            Path = site;
        }
        public Service(string site, string file)
        {

        }
        public Service(string site, string file, int _step)
        {
            Path = site;
            FilePath = file;
            Step = _step;
        }
        public abstract void ProcessAdress();
    }
}
