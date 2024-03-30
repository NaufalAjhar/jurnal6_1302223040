namespace modul6_1302223040
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Review film apapun itu ");
            SayaTubeVideo video2 = new SayaTubeVideo("Review film bebas");
            SayaTubeVideo video3 = new SayaTubeVideo(" Review film bebas2");
            SayaTubeVideo video4 = new SayaTubeVideo("Review film bebas3");
            SayaTubeVideo video5 = new SayaTubeVideo("Review film bebas4");
            SayaTubeVideo video6 = new SayaTubeVideo("Review film bebas5");
            SayaTubeVideo video7 = new SayaTubeVideo("Review film bebas6");
            SayaTubeVideo video8 = new SayaTubeVideo("Review film bebas7");
            SayaTubeVideo video9 = new SayaTubeVideo("Review film bebas8");
            SayaTubeVideo video10 = new SayaTubeVideo("Review film bebas9");

            SayaTubeUser user = new SayaTubeUser("naufal");
            user.addVideo(video1);
            user.addVideo(video2);
            user.addVideo(video3);
            user.addVideo(video4);
            user.addVideo(video5);
            user.addVideo(video6);
            user.addVideo(video7);
            user.addVideo(video8);
            user.addVideo(video9);
            user.addVideo(video10);



            user.PrintAllVideoPlayCount();
            
        }
    }
}
