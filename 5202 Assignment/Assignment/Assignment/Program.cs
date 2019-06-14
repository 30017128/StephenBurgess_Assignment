//Stephen Burgess
//Methods Login System

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rotorua login system, press enter to continue");//Login Message.

            string input = Console.ReadLine();
            while (input != "n") //Loops User back to the start if they choose to retry.
            {

                Console.WriteLine("Please enter a username that is 8 or more characters long.");
                string username = Console.ReadLine().Trim();
                //Prompts the user to enter a username that is 8 or more characters long, and stores it as string username.


                int length = validateUsername(username);
                //Creates an int called length which uses the string username and this int is = to the method ValidateUsername.


                if (length < 8) // if username length is < 8
                {
                    while (input != "y") //Breaks user out of loop back to the start if they press "y"
                    {

                        Console.WriteLine($"Your username is {length} letters long which means it's to short");
                        Console.WriteLine("Press Y to retry or any other key to exit the program");
                        input = Console.ReadLine();
                        if (input != "y")//If the user presses a key that does not restart the program the program will exit.
                        {
                            Environment.Exit(0);//Exits the program.
                        }


                    }
                }

                else if (length >= 8) //If the username is 8 or more letters long it will tell you that it's the right length and will break the loop.
                {
                    Console.WriteLine($"Your username is {length} letters long which means it's the right length");
                    break;


                }
            }
            string password = Console.ReadLine().Trim(); //declares the string password
            while (input != "n") //Loops User back to the start if they choose to retry.
            {

                Console.WriteLine("Please enter a password that is 8 or more characters long");
                password = Console.ReadLine();

                int length2 = validatePasswordLength(password);
                //Creates an int called length2 which is = to the method validate password which uses the string password.

                if (length2 < 8) //if password lentgth is less then 8
                {
                    while (input != "y") //Breaks user out of loop back to the start if they press "y"
                    {
                        Console.WriteLine("Your password is not long enougth");
                        Console.WriteLine("Press Y to retry or any other key to exit the program ");
                        input = Console.ReadLine();
                        if (input != "y") //If the user presses a key that does not restart the program the program will exit.
                        {
                            Environment.Exit(0); //Exits the program.
                        }

                    }
                }

                else //If the password is the right length. The program will tell the user and break the loop.
                {
                    Console.WriteLine("Your password is the right length. Press Enter to continue.");
                    break;
                }
                

            }


            string password2 = Console.ReadLine().Trim();
            while (input != "n") //Loops User back to the start if they choose to retry.
            {
                Console.WriteLine("Please enter your password again");
                password2 = Console.ReadLine(); //declares the string password 2

                int match = validatePasswordMatch(password, password2); //creates a int called match which is = to the method validatePasswordMatch

                if (match != 0) //Match = 0 when the passwords do not match
                {
                    while (input != "y") //Breaks user out of loop back to the start if they press "y"
                    {
                        {
                            Console.WriteLine("Your password does not match");
                            Console.WriteLine("Press Y to retry or any other key to exit the program ");
                            input = Console.ReadLine();
                            if (input != "y") //If the user presses a key that does not restart the program the program will exit.
                            {
                                Environment.Exit(0); //Exits the program.
                            }
                        }
                    }
                }

                else if (match == 0) //If the password matches it will break the loop and tell the user that their passwords match
                {
                    Console.WriteLine("Your passwords match. Press Enter to continue");
                    Console.ReadLine();
                    break;

                }



                
            }
            Console.WriteLine("Your Login is accepted");//Accepts The Users Login
            Console.ReadLine();

           








        }

        static int validateUsername(string username) //validateUsername Method.
        {
            return username.Length; //returns the length of the username


        }
        static int validatePasswordMatch(string password, string password2) //ValidatePasswordMatch Method
        {

           return string.Compare(password, password2); //Returns the comparison of password 1 and password 2 it =1 if they match and =0 if they don't match
        }
        static int validatePasswordLength(string password) //validatePasswordLength Method
        {

            int passwordlength = password.Length; //Makes the int passwordlength which is = to password.length

            return passwordlength; //Returns the int passwordlength



            
        }

       

        }




    }
