using DataBase;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Pages
{
    public class ClsGard
    {
        SalesModels oSales = new SalesModels();
        
        List<decimal> sales = new List<decimal>();
        
        decimal sum = 0;
        Entity oEntity = new Entity();
        public decimal GetSum()
        {
            List<SalesModels> sa = oEntity.GetAllSales();
            sales.Add(oSales.Salary);
            foreach(var i in sa )
            {
                sa = new List<SalesModels> ();
                sum += i.Salary ;
            }
            
            return sum;
        }
    }
}
