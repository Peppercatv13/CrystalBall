using System;
using System.Threading;

namespace CrystalBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("");
            Console.WriteLine(@"
(  ____ \(  ____ )|\     /|(  ____ \\__   __/(  ___  )( \        (  ___ \ (  ___  )( \      ( \      
| (    \/| (    )|( \   / )| (    \/   ) (   | (   ) || (        | (   ) )| (   ) || (      | (      
| |      | (____)| \ (_) / | (_____    | |   | (___) || |        | (__/ / | (___) || |      | |      
| |      |     __)  \   /  (_____  )   | |   |  ___  || |        |  __ (  |  ___  || |      | |      
| |      | (\ (      ) (         ) |   | |   | (   ) || |        | (  \ \ | (   ) || |      | |      
| (____/\| ) \ \__   | |   /\____) |   | |   | )   ( || (____/\  | )___) )| )   ( || (____/\| (____/\
(_______/|/   \__/   \_/   \_______)   )_(   |/     \|(_______/  |/ \___/ |/     \|(_______/(_______/");
            Console.WriteLine("");
            Console.WriteLine(@"  
         _...._
       .`      `.
      / ***      \         
     : **         :        
     :            :        Welcome to Crystal Ball 1.0  
      \          /           the interactive console
       `-.,,,,.-'               fortune teller.
        _(    )_
       )        (
      (          )
       `-......-`");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");          
            Thread.Sleep(5000);

            bool activeUser = true;

            while (activeUser == true)
            {
                Console.WriteLine("Ask me a question...");
                string userQuestion = Console.ReadLine();
                Console.WriteLine("Let me think...");
                Thread.Sleep(8000);



                Console.WriteLine(userQuestion);

                Random rnd = new Random();

                int randomInt = rnd.Next(1, 10);

                switch (randomInt)
                {
                    case 1:

                        if (randomInt == 1)
                        {
                            Console.WriteLine("Absolutely, yes.");
                        }
                        break;

                    case 2:

                        if (randomInt == 2)
                        {
                            Console.WriteLine("Inarguably, no");
                        }
                        break;

                    case 3:

                        if (randomInt == 3)
                        {
                            Console.WriteLine("Either or really...");
                        }
                        break;

                    case 4:

                        if (randomInt == 4)
                        {
                            Console.WriteLine("We may never know...");
                        }
                        break;

                    case 5:


                        if (randomInt == 5)
                        {
                            Console.WriteLine("That's a silly question");
                        }
                        break;

                    case 6:


                        if (randomInt == 6)
                        {
                            Console.WriteLine("Ask again later...");
                        }
                        break;

                    case 7:


                        if (randomInt == 7)
                        {
                            Console.WriteLine("Maybe?");
                        }
                        break;

                    case 8:

                        if (randomInt == 8)
                        {
                            Console.WriteLine("NO.");
                        }

                        break;

                    case 9:
                        if (randomInt == 9)
                        {
                            Console.WriteLine("YES!");
                        }
                        break;


                    default:

                        Console.WriteLine("The last guy who asked me a question like that...");
                        break;

                }
                
                Console.WriteLine("Do you have another question?  Y / N ?");
                string rpsLoop = Console.ReadLine();
                if (rpsLoop == "y")
                {
                    activeUser = true;
                }
                else if (rpsLoop == "n")
                {
                    activeUser = false;
                }
            }            
        }
    }
}
