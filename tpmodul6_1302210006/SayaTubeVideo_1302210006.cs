using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210006
{
    internal class SayaTubeVideo_1302210006
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo_1302210006(string title) {
            Debug.Assert(title.Length <= 100 && title != null, "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null");
            //generate random id
            Random rdm = new Random();
            this.id = rdm.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount_1302210006(int playCount) {
            Debug.Assert(playCount <= 10000000, "Input penambahan play count maksimal 10.000.000");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }
                        
        }

        public void PrintVideoDetails_1302210006() {
            Console.WriteLine("Video Details: ");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
            Console.WriteLine(" ");
        }

    }
}
