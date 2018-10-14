using System;

class MainClass
{


    public static void Main(string[] args)

    {
        int i;
        long userNum, result;
        bool exitProg = false;
        while (exitProg == false)
        {
            Console.WriteLine("enter a number from 1 to 20");
            userNum = int.Parse(Console.ReadLine());
            result = userNum;

            if (userNum <= 20)

                for (i = 1; i < userNum; i++)
                {

                    result = result * i;

                    Console.WriteLine("{0}", result);
                }

            else if (userNum > 20)

            {
                Console.WriteLine("Number has to be under 20!!!!");
            }

           
            
                Console.WriteLine("Would you like to continue y/n ?");
                string exit = Console.ReadLine();
                if (exit == "y" || exit == "Y")

                {
                    exitProg = false;
                    continue;
                }

                else if (exit == "n" || exit == "N")
                {
                    exitProg = true;
                    break;
                }


                else if (exit != "y" || exit != "n" || exit != "Y" || exit != "Y")
                {
                Console.WriteLine("Would you like to continue y/n ?");
                 exit = Console.ReadLine();
                continue;
                }
            


        }
       


        

    }
}