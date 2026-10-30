using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8.Classes
{
    public class electronics : Shop
    {
        public double battSize { get; set; }
       public double drivSpeed { get; set; }
        public electronics(string Name, int Price,double battSize, double drivSpeed):base(Name,Price) { 
            this.battSize = battSize;
            this.drivSpeed = drivSpeed;
        }
    }
}
