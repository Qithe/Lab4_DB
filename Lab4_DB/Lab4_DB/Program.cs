using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenuPrinter();
            /*
             
             Hur det ser ut när man startar appen:

            //////////////////////
            ///Choose an action///
            //////////////////////
            1. Add User
            2. See all users

            *NOTE* Den skall endast ta emot 1, 2 eller ESC
            och när tex 3 trycks så körs alternativ 3.


            Hur det ser ut när man tar val: 1

            /////////////////
            ///Add an user///
            ///////////////// 
            Email:<enter here> 
            *enter is pressed and then pic is enterd*
            Picture:<enter here>
            *the full address from Disk cirectory
            
            *NOTE* ev kolla om adressen som skrivs in facktisk är en address och att det finns något i bild adressen
            

            Hur det ser ut när man tar val: 2

            ///////////////
            ///All users///
            ///////////////
            /  ID  / Email            / Bild godkänd / Bild namn
            / 0001 / Example@Mail.com / Godkänd      /
            / 0002 / Test@Test.co.uk  / Inte godkänd /

            *NOTE* ev byta plats på email o bild godkänd, för o slippa omfromatera så mycket
            ID är bara för att hålla reda på rader, inget annat.
            Ev kunna markera hela rader
            ESC för att gåtillbaka till huvud menyn

             */
        }
        static void MainMenuPrinter()
        {
            Console.Clear();
            string MenuHeader =
                "/////////////////////////\n" +
                "/// Main Menu         ///\n" +
                "/// Choose an action  ///\n" +
                "/// Press Esc to exit ///\n" +
                "/////////////////////////";

            string Options =
                "///1. Add a new user\n" +
                "///2. Reveiw the database";

            Console.WriteLine($"{MenuHeader}\n{Options}");

            for (; ; )
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Menu1Printer();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Menu2Printer();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
            }
            
            
        }

        public static void Menu1Printer()
        {
            Console.Clear();
            string MenuHeader = 
                "/////////////////////////\n" +
                "/// Add user Menu       ///\n" +
                "/// Choose an action    ///\n" +
                "/// Press Esc to return ///\n" +
                "/////////////////////////"; ;
            string Options =
                "/// Enter the Email address\n" +
                "/// Then press Enter\n" +
                "/// Enter the local address\n" +
                "/// for profile picture";
            Console.WriteLine($"{MenuHeader}\n{Options}");
            string email = "";
            string PicAddress = "";
            for (; ; )
            {
                
                //Get Email
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        email = Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
                if (email != "")break;
            }
            for (; ; )
            {
                
                //Get Email
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        PicAddress = Console.ReadLine();
                        AddUser(email, PicAddress);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
                if (email != "") break;
            }
        }

        public void Menu2Printer()
        {
            Console.Clear();
            //hämta bös från servern

            //printa ut bös från det som hämtas hem
            //ha en count längst upp som kan visa hur många personer som facktist finns

        }

        private static void AddUser(string email, string picAddress)
        {
            Environment.Exit(0);
            //Do interwebstuff
        }
    }
}
