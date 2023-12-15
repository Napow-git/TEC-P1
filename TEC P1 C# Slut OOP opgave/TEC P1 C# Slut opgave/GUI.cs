using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_P1_C__Slut_opgave
{
    class GUI
    {
        private string header;
        public string Header 
        {
            get { return header; } 
            set {  header = value; }


        }
       public GUI() 
        {
            this.header = "Welcome to the game" +
                "\n" +
                "=======================================" +
                "\n";
        }
        public void render()
        {
            Console.WriteLine(this.header);
        } 



    }
}
