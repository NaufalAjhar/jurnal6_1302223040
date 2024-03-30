using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223040
{
    public class SayaTubeVideo
    {
        public int Id;
        public string Title;
        public int PlayCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.Id = random.Next(00000, 99999);
            this.Title = title;
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.PlayCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.Id + " Title: " + this.Title + " Play Count " + this.PlayCount);
        }

        public int GetPlayCount()
        {
            return this.PlayCount;
        }
    }

}
