using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papier_kamien
{
    class Program
    {
        // Wybory
        static public char Choosing()
        {
            char a;
            a=char.Parse(Console.ReadLine());
            return a;
        }
        static public int Randomize()
        {
            Random rnd = new Random();
            int x = rnd.Next(0,3); //0=papier  1=kamien  2=nozyce
            return x;
        }

        //Wyniki
        static public void Win()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("WYGRAŁEŚ!!!!!!");
            System.Threading.Thread.Sleep(1500);
            Console.ResetColor();
            Console.Clear();
        }
        static public void Loose()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("PRZEGRAŁEŚ :(");
            System.Threading.Thread.Sleep(1500);
            Console.ResetColor();
            Console.Clear();

        }
        static public void Remis()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("REMIS!");
            System.Threading.Thread.Sleep(1500);
            Console.ResetColor();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            char choice = 'b';
            


            while (true)
            {
                
                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----> PAPIER KAMIEŃ NOŻYCE <-----");
                Console.WriteLine("'p'-papier  'k'-kamień  'n'-nożyce");
                int enemy_choice=Randomize(); //losowanie wyboru komputera
                choice =Choosing(); //wybranie
                
                if (choice=='p' || choice == 'k' || choice == 'n')
                {
                    switch (choice)
                    {
                        case 'p':
                            {
                                if (enemy_choice == 0) { Remis(); break; }

                                else if (enemy_choice == 1) { Win(); break; }

                                else if (enemy_choice == 2) { Loose(); break; }

                                else Console.WriteLine("błąd"); break;
                            }
                        case 'k':
                            {
                                if (enemy_choice == 0) { Loose(); break; }

                                else if (enemy_choice == 1) { Remis(); break; }

                                else if (enemy_choice == 2) { Win(); break; }

                                else Console.WriteLine("błąd"); break;
                            }
                        case 'n':
                            {
                                if (enemy_choice == 0) { Win(); break; }

                                else if (enemy_choice == 1) { Loose(); break; }

                                else if (enemy_choice == 2) { Remis(); break; }

                                else Console.WriteLine("błąd"); break;
                            }
                        default: Console.WriteLine("błąd, zagraj ponownie"); break;

                    }
                       
                }
                else Console.WriteLine("blad!");

            }
        }
    }
}
