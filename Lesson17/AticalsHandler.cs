using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class AticalsHandler
    {
        private List<Atical>? aticals;

        public AticalsHandler()
        {
            this.aticals = new List<Atical>();
        }
        public void Add(Atical atical) 
        {
            aticals!.Add(atical);
            string path = "atical.json";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                string json = JsonSerializer.Serialize(aticals);
                writer.WriteLine(json);                
            }
        }
        public void Remove(Atical atical)
        {
            aticals!.Remove(atical);
        }
        public List<Atical> getAticals() => aticals!;
        public Atical getAtical(int index) => aticals![index];
        public void ReadAticals()
        {
            string path = "atical.json";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    aticals = JsonSerializer.Deserialize<List<Atical>>(text);
                }
            }
        }
    }
}
