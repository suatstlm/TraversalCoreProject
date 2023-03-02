using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concrete
{
    public class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstgramUrl { get; set; }
        public bool Status { get; set; }
    }
    public class Contect
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }   
        public bool Status { get; set; }
    }
}
    