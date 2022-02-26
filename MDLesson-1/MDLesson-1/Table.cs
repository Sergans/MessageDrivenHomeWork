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
        public State State { get; set; }

        public int SeatsCount { get; set; }
        public Table(int id)
        {
            Id = id;
            State = State.Free;
            SeatsCount=new Random().Next(2,5);
            
        }
        public bool SetState(State state)
        {
            if (state == State)
            {
                return false;
            }

            State= state;
            return true;
        }
    }
}
