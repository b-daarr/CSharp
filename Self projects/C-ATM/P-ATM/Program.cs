using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            double Daraei = 2000000;

            int W = 20; // 1000
            int X= 40;  // 050
            int Y= 200; // 010
            int Z= 400; // 005

            int Input = 0;
            bool Accept = false;
            int inputPassword = 1399;

            string History = "";

            //////////////////////////////
            while (Accept == false)
            {
                while (Input == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter your Card (press a number except 0 for continue...) : ");
                    Input = int.Parse(Console.ReadLine());

                    if (Input != 0)
                    {
                        Console.Clear();
                        Input = 1;
                    }
                }

                while (Input != 0)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        int vor = 0;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Enter your password: ");
                        vor = int.Parse(Console.ReadLine());

                        if (vor == inputPassword)
                        {
                            Console.Clear();
                            int opr = 5;
                            i = 0;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Select your operate: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Show account balance(0) ~ With 1% tax deducation.\nMoney transfer(1)\nCash withdrawal(2)\nOperation History(3)\nChange password(4)");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(".............(");
                            opr = int.Parse(Console.ReadLine());

                            char Back = 'b';
                            if (Back == 'b')
                            {
                                vor = inputPassword;
                            }

                            if (opr == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Daraei = Daraei * 100 - 1;
                                Console.WriteLine("Your balance is: {0}", Daraei);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("For back press 'b': ");
                                Back = char.Parse(Console.ReadLine());
                            }
                            else if (opr == 1)
                            {
                                Console.Clear();
                                int tra = 0;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Enter the transfer amount: ");
                                tra = int.Parse(Console.ReadLine());
                                Console.Clear();
                                

                                if (tra > Daraei)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Your assets are insufficient!");
                                    Console.ReadLine();
                                    vor = inputPassword;
                                }
                                else
                                {
                                    Console.Clear();
                                    double des = 0;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("Enter the destination account: ");
                                    des = float.Parse(Console.ReadLine());
                                    Console.Clear();

                                    if (des < 1200000000000001)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.Write("This account is not correct! try again: ");
                                        des = int.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        History = "Deposit to account: -" + des + "- | The deposit amount is -" + tra + "-";
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("The amount successfully deposited.");
                                        Console.ReadLine();
                                       vor = inputPassword;
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("For back press 'b': ");
                                Back = char.Parse(Console.ReadLine());
                                Console.Clear();
                            }
                            else if (opr == 2)
                            {
                                Console.Clear();
                                float bar = 0;
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write("Specify the withdrawal amount: ");
                                bar = float.Parse(Console.ReadLine());
                                Console.Clear();

                                if (bar > Daraei)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Your assets are insufficient!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    History = History + "\n" + "Withdraw from bank account: -" + bar + "-";
                                    Daraei -= bar;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Take your card (press a key)");
                                    Console.ReadLine();
                                    Console.Write("Take your money (press a key)");
                                    Console.ReadLine();
                                    vor = inputPassword;
                                }
                            }
                            else if (opr == 3)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Transaction history:\n\n" + History);
                                Console.ReadLine();
                                vor = inputPassword;
                            }
                            else if (opr == 4)
                            {
                                int pass = 0;
                                int repass = 1;

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Enter new password: ");
                                pass = int.Parse(Console.ReadLine());
                                Console.WriteLine("Confirm your password: ");
                                repass = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (pass == repass)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Password changed successfully.");
                                    Console.ReadLine();
                                    pass = inputPassword;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Password is not same!.");
                                    Console.ReadLine();
                                    vor = inputPassword;
                                }
                            }
                            
                        }
                        else if (vor != inputPassword)
                        {
                            bool a = false;
                            while (a == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                i += 1;
                                Console.Write("Password is not correct! you have {0} tried. please try again: ", i);
                                vor = int.Parse(Console.ReadLine());

                                if (vor == inputPassword)
                                {
                                    Console.Clear();
                                    a = true;
                                }

                                if (i >= 2)
                                {
                                    a = true;
                                    Input = 0;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Password is not correct! you have 3 tried. your card is saved. for exit press a key: ");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
