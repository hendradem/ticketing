using System;
namespace ticketing{
    public class bookHotel
    {

        private string[] hotelList = new string[2];
        private string customerName;
        private int selamaDay, pricePerMalam, totalPrice;

        public void setHotel(string cName, int sDay, int pPerMalam, int tPrice)
        {
            this.customerName = cName;
            this.selamaDay = sDay;
            this.pricePerMalam = pPerMalam;
            this.totalPrice = tPrice;
        }

        public void getHotel()
        {

            Console.WriteLine(" ");
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|               YOUR TICKET               |");
            Console.WriteLine("|_________________________________________|");
            Console.WriteLine("|                                         ");
            Console.WriteLine("| Cust Name  : {0}", customerName);
            Console.WriteLine("| During     : {0}", selamaDay + " days");
            Console.WriteLine("| Price      : {0}", pricePerMalam);
            Console.WriteLine("| Total      : {0}", totalPrice);
            Console.WriteLine("|_________________________________________");

        }



    }
}