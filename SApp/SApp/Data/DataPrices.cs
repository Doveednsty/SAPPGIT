using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp.Data
{
    public class DataPrices
    {
        public List<Prices> ReadFile(string filepath)
        {
            var lines = File.ReadAllLines(filepath);

            var data2 = from l in lines
                        let split = l.Split(',')
                        select new Prices
                        {
                            Begin = Convert.ToDouble(split[0]),
                            End = Convert.ToDouble(split[1])
                        };
            return data2.ToList();
        }
    }
}
