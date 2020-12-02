using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class Ipod:MusicPlayerInterface
    {
        private int mscount = 0;
        private int j = 0;
        private string n;
        MusicFile[] listofmusic;
        public Ipod(string n)
        {
            this.n = n;
            listofmusic = new MusicFile[500];

        }
        public void MSwitch(bool x)  // Music Part 
        {
            if (x.Equals(true))
            {
                Console.WriteLine("The Music Player is now ON  in " + this.n + "!");
            }
            else
                Console.WriteLine("The Music Player is now OFF in " + this.n + "!");
        }
        public void play(bool x)
        {
            if (x.Equals(true))
                Console.WriteLine("Now Playing :" + listofmusic[0].tittle + " . . . . . . . . . ");


        }
        public void setVolume(int loudness)
        {
            Console.WriteLine("Now the volume of Music Player is about :" + loudness);
        }
        public void playNext()
        {


            Console.WriteLine("Now Playing :" + listofmusic[j + 1].tittle + " . . . . . . . . . ");
            j++;

        }
        public void playPrevious()
        {
            j--;
            Console.WriteLine("Now Playing :" + listofmusic[j].tittle + " . . . . . . . . . ");

        }
        
        

        public void AddMusic(MusicFile x)
        {

            listofmusic[mscount++] = x;
            Console.WriteLine("Song Added!");

        }
        public void ShowMusicInfo()
        {
            Console.WriteLine(this.n + " has following music :");
            int j = 1;
            for (int i = 0; i < mscount; i++)
            {
                Console.WriteLine(j + ".");
                listofmusic[i].ShowInfo();
                j++;
            }
        }

            public void RSwitch(bool x)   // Radio Part 
        {
            if (x.Equals(true))
            {
                Console.WriteLine("The Radio Player is now ON !!");
            }
            else
                Console.WriteLine("The Radio Player is now OFF");
        }
        public void retune(double frequency)
        {
            Console.WriteLine("The frequency of Radio Player is set to :" + frequency);

        }
        public void RsetVolume(int loudness)
        {
            Console.WriteLine("Now the volume of Radio Player is about :" + loudness);

        }
        public void changeChannel()
        {
            Console.WriteLine("The Channel was changed !");
        }


    }
}
