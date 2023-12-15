using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_P1_C__Slut_opgave
{
    class State
    {
        protected Stack<State> states;
        public State(Stack<State> states)
        {
            this.states = states;
            //Console.WriteLine(this.states.GetHashCode());


           
            
        }
        virtual public void Update() 
        { 
        
        
        
        }
    }
}
