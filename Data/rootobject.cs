using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Data
{   
    public class Rootobject
    {
        public string activity { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public int price { get; set; }
        public string link { get; set; }
        
        [Key]public string key { get; set; }
        public float accessibility { get; set; }
    }

}
