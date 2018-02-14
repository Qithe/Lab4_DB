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

            //öppnar väg till servern här
            //"startar program"

            MainMenu();
            /*
             
             Hur det ser ut när man startar appen:

            //////////////////////
            ///Choose an action///
            //////////////////////
            1. Add User
            2. See all users
            3. Exit application

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
        static void MainMenu()
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
                        AddUserMenuIntro();
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


        static void AddUserMenuIntro()
        {
            UserContex contex = new UserContex();
            Console.Clear();
            string Email = "";
            string PicAddress = "";
            string MenuHeader =
                "/////////////////////////\n" +
                "/// Add user Menu     ///\n" +
                "/// Escape to return  ///\n" +
                "/////////////////////////"; ;
            string Options =
                "/// Enter the Email address\n" +
                "/// Then press Enter\n" +
                "/// Enter the local address\n" +
                "/// for profile picture";

            //Printar "menyn"
            Console.WriteLine($"{MenuHeader}\n{Options}");
            Console.Write("Email: ");
            // Registrerar email
            Email = AddUserMenuEmail();
            //Rensa och registrera bilden
            Console.Clear();
            Console.WriteLine($"{MenuHeader}\n{Options}\nEmail: {Email}");
            Console.Write("Picture Address: ");
            PicAddress = AddUserMenuPic();
            //Skiakca denna data till en funktion som skickar till servern
            SendUserToServer(contex, Email, PicAddress);

        }
        public static string AddUserMenuEmail()
        {
            //om vi vill ha något somm kollar att det är en email kan det göras här
            return(Console.ReadLine());
        }
        public static string AddUserMenuPic()
        {
            // om vi vill verifiera att det finns en bil i denna sök väg gör se här
            return (Console.ReadLine());
        }
        public static void SendUserToServer(UserContex contex, string email, string PicAddress)
        {
            UserClass user = new UserClass(email, PicAddress);
            contex.UserClasses.Add(user);
            contex.SaveChanges();

            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(". .");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(". . .");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("All done!");
            Console.Read();
            MainMenu();
        }
        

        public void Menu2Printer()
        {
            Console.Clear();
            //hämta bös från servern

            //printa ut bös från det som hämtas hem
            //ha en count längst upp som kan visa hur många personer som facktist finns

        }

        


       
    }
}
