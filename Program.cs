﻿using System;

namespace ticketing{
    class Program{
        static void Main(string[] args){
            bool showMenu = true;
            while (showMenu){
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu(){
            Console.Clear();
            Console.WriteLine(" _________________________________");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|             WELCOME             |");
            Console.WriteLine("|          Ticketing App          |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|                                 |");
            Console.WriteLine("| 1.HOME |  2.BOOK | 3.EVENT LIST |");
            Console.WriteLine("|_________________________________|");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine()){
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    bookEvents();
                    return true;
                case "3":
                    eventList();
                    return true;
                default:
                    return true;
            }
        }

        private static void bookEvents(){
            Console.WriteLine("Masukkan jumlah");
            int size = Convert.ToInt32( Console.In.ReadLine() );
            string name, price, cust, phone;
            string[] mhs = new string[size];

            bookEvent e = new bookEvent();

            for(int i=0; i<mhs.Length; i++){
                Console.Write("Nama Event    : ");
                name = Console.ReadLine();

                Console.Write("Harga Tiket   : ");
                price = Console.ReadLine();

                Console.Write("Nama Pemesan  : ");
                cust = Console.ReadLine();

                Console.Write("No HP Pemesan : ");
                phone = Console.ReadLine();

                e.setEvent(name, price, cust, phone);
            }

            e.getEvent();
            Console.Read();

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }


        public static void eventList(){
            Console.WriteLine("|---------------|------------|");
            Console.WriteLine("|-----EVENT-----|----HARGA---|");
            Console.WriteLine("|---------------|------------|");
            Event eve = new Event();
            eve.dataevent("");
            Console.WriteLine(eve.getJenisEvent());
            Console.ReadKey();
        }

        
 
        private static string CaptureInput(){
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
 
        private static void ReverseString(){
            Console.Clear();
            Console.WriteLine("Reverse String");
 
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
 
        private static void RemoveWhitespace(){
            Console.Clear();
            Console.WriteLine("Remove Whitespace");
 
            DisplayResult(CaptureInput().Replace(" ", ""));
        }
 
        private static void DisplayResult(string message){
            Console.WriteLine($"{message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
