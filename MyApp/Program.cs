using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context mycontext = new Context())
            {
                var a = mycontext.Roles.ToList();
            }
        }
    }
}
