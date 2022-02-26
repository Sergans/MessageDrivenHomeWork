using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLesson_1
{
    public class Restaurant
    {
       private readonly List<Table>_tables=new List<Table>();
        public Restaurant()
        {
            for (ushort i=0; i <=10;i++)
            {
              _tables.Add(new Table(i));
            }
        }

    }
}
