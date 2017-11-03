using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Users> Users { get; set; }


    }
}
