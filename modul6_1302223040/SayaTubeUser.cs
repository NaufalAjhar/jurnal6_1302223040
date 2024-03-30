using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223040
{
    public class SayaTubeUser
    {
        public int id;
        public List<SayaTubeVideo> uploadedVideos;
        public String Username;

        public SayaTubeUser(String username)
        {
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += this.uploadedVideos[i].GetPlayCount();
            }
            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            for (int i = 0;i < uploadedVideos.Count;i++)
            {
                int j = i + 1;
                Console.WriteLine("User: " + this.Username
               + "\nVideo " + j + " judul: " + this.uploadedVideos[i].Title);
            }
           
        }


    }
}
