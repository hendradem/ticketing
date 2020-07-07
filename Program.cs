using System;

namespace c_example{
    class Program{
        static void Main(string[] args){
            bool showMenu = true;
            while (showMenu){
                showMenu = MainMenu();
            }


        }

        private static void nbg(){
            Tabungan bank = new Tabungan();
            bank.Menabung(10000000);
            bank.Mengambil(500000);
            Console.WriteLine(bank.GetSaldo());
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
                    RemoveWhitespace();
                    return true;
                case "3":
                    nbg();
                    return true;
                default:
                    return true;
            }
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
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
