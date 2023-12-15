using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_P1_C__Slut_opgave
{
    class StateGame : State
    {
        public StateGame(Stack<State> states) : base(states) 
        {
            Console.WriteLine("Hello From Game State");
        }
    }
}
