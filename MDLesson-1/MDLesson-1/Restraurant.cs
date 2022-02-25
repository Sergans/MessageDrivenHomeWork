using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLesson_1
{
    public class Restraurant
    {
       private readonly List<Table>_tables=new List<Table>();
        public Restraurant()
        {
            for (int i=0; i <=10;i++)
            {
              _tables.Add(new Table(i));
            }
        }

    }
}
