using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication19.Models
{
    public class Kniga
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get;set;}
        public int Release_date { get; set; }
        public int Rating { get; set; }
        public string Jenre { get; set; }
    }
}
