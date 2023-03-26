using System;
using System.Collections.Generic;
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
            Random rdm = new Random();
            this.id = rdm.Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount_1302210006(int playCount) {
            this.playCount += playCount;            
        }

        public void PrintVideoDetails_1302210006() {
            Console.WriteLine(
                "Video Details: \n" + 
                "ID: " + this.id + "\n" + 
                "Title: " + this.title + "\n" +
                "Play Count: " + this.playCount
            );
        }

    }
}
