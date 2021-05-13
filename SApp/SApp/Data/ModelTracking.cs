using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp.Data
{
    public class ModelTracking
    {
        string price = " ";
        public ModelTracking(string ChosenShare, string UserPrice)
        {
            DataShares dataShares = new DataShares();
            var d = dataShares.ReadFile("Table.csv");
            for (int i = 0; i < d.Count; i++)
            {
                if (d[i].SECID.ToString() == ChosenShare)
                {
                    price = d[i].Price.ToString();
                    break;
                }
            }
            
        }

        public string Price()
        {
            return price.ToString();
        }
        
    }
}
