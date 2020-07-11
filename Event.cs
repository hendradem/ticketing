using System;
namespace ticketing{
    
    class Event{
        private string JenisEvent;

        public void dataevent (string JenisEvent){
            string[,] Namaevent = new string[,]{
                {"kondangan" , "50.000" },
                {"makan-makan", "30.000" },
                {"reuni","20.000" },
                {"wisuda","100.000" },
                {"coronavirus", "unlimited" }
            };

            for(int i = 0; i <= Namaevent.GetUpperBound(0); i++){
                string Kegiatan = Namaevent[i, 0];
                string HTM = Namaevent[i, 1];
                Console.WriteLine("{0} {1}", Kegiatan,HTM);
            }

            Console.ReadLine();
        }
        public string getJenisEvent(){
            return this.JenisEvent;
        }
    }

}