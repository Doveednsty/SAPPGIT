using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp.Data
{
    public class DataShares
    {
        public List<Share> ReadFile(string filepath)
        {
            var lines = File.ReadAllLines(filepath);

            var data = from l in lines
                       let split = l.Split(',')
                       select new Share
                       {
                           SECID = split[0],
                           Name = split[1],
                           //SecID2 = split[2],
                           Price = split[3]
                       };
            return data.ToList();
        }
    }
}
