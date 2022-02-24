using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLesson_1
{
  public  class Table
    {
        public int Id { get; set; }
        public States State { get; set; }

        public int SeatsCount { get; set; }
        public Table(int id)
        {
            Id = id;
            State = States.Free;
            
        }
    }
}
