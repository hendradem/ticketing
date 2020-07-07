namespace c_example{
    // public class Event{

    //     private string eventName;  

    //     public re(string avalue) {  
    //         eventName = avalue;  
    //     }  

    //     public string Departname {  
    //         get {  
    //             return departname;  
    //         }  
    //     }  

    // }


     public class Tabungan {
		
        private double saldo = 0;
        // array (data event [nama event, tgl, harga tiket])
        

        // Getter & Setter
        public void Menabung(double n) {
            saldo += n;
        }
        public void Mengambil(double n) {
            saldo -= n;
        }


        public double GetSaldo() {
            return saldo;
        }
    }

   


}