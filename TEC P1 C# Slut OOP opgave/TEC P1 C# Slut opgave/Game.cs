using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_P1_C__Slut_opgave
{
    class Game
    {
        //varriable
        private bool end;
           /*     {
            get { return this.end; }
            set { this.end = value; }
        }*/

        public bool End 
        {
            get { return this.end; } 
            set { this.end = value; }
        
        }



        private GUI gui;


        private Stack<State> states;  
        //private functions

        private void InitVariables()
        {
           // this.end = true;
            this.end = false;
        }
        private void InitStates() 
        { 
            this.states = new Stack<State>();
            Console.WriteLine(states.GetHashCode());

            //push the first state
            this.states.Push(new StateMainMenu(this.states));
            
        }
        private void InitGUI() 
        { 
        
        this.gui = new GUI();

        }




        //constructors and destructors

        public Game()
        {
            this.InitVariables();
            this.InitStates();
            this.InitGUI();

            Console.WriteLine("Hello World! Going to Sleep");
        }
        public void Run() 
        
        {
            while(this.end == false) 
            {
                this.gui.render();


                Console.WriteLine("Write a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number <= 0)
                    this.end = true;                
                else
                 Console.WriteLine("You inputted: " + number);
                
            }

            Console.WriteLine("Ending game...");
        }


    }
}
