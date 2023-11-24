using System;


namespace Lommeregner

{
    class program
    {
        static void Main(string[] args)
        {
            string value;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            //ForegroundColor faver teksten, backgroundColor faver baggrunden go clear lægger faven til helle consolen.
            { }

            
                do
                {
                    //man bruger double fordi ellers får man kun helle tal.
                    double res;
                    Console.Write("Indtast den første linje: ");
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Indtast den anden linje: ");
                    double num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Indtast funktion: \n\n" +
                    "+: addition  \n" +
                    "-: subtraktion \n" +
                    "/: multiplikation  \n" +
                    "*: division \n" +
                    "^:Potens \n" +
                    "S: Kvadratrod: \n\n" +

                    "Funktion:"
                    );
                    string symbol = Console.ReadLine();



                    switch (symbol)
                    {
                        case "+" or "tillæge":
                            res = num1 + num2;
                            Console.WriteLine("Resultat: " + res);
                            break;
                        case "-":
                            res = num1 - num2;
                            Console.WriteLine("Resultat: " + res);
                            break;
                        case "*":
                            res = num1 * num2;
                            Console.WriteLine("Resultat: " + res);
                            break;
                        case "/":
                            res = num1 / num2;
                            Console.WriteLine("Resultat: " + res);
                            break;
                        case "^":
                            res = Math.Pow(num1, num2);
                            Console.WriteLine("Resultat: " + res);
                            break;
                        case "S":
                            res = Math.Pow(num1, num2);
                            Console.WriteLine("Resultat: " + res);
                            break;


                    default:
                            res = num1 + num2;
                            Console.WriteLine("forkert");
                            break;




                    }
                    Console.ReadLine();
                    Console.Write("Vil du forsætte? (y/n): ");

                    value = Console.ReadLine();

                }
                while (value == "y" || value == "Y");

            }
          
        }
    }








    /*
{
    class program
    {
        static void Main(string[] args)
        {
            string value;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            //ForegroundColor faver teksten, backgroundColor faver baggrunden go clear lægger faven til helle consolen.
            do
            {
                //man bruger double fordi ellers får man kun helle tal.
                double res;
                Console.Write("");
                double num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("");
                double num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Indtast funktion: ");
                string symbol = Console.ReadLine();



                switch (symbol)
                {
                    case "+" or "tillæge":
                        res = num1 + num2;
                        Console.WriteLine("Total" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Sub " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("gange " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("divi " + res);
                        break;
                    default:
                        res = num1 + num2;
                        Console.WriteLine("forkert");
                        break;
                }
                Console.ReadLine();
                Console.Write("Vil du forsætte? (y/n)");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y"); 
            if (value == "y" || value == "Y") 
            
            {
                Console.WriteLine("lad os renge vider");
            
            }
        }
    }


}*/