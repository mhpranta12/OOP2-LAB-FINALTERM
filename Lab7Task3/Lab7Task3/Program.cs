using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile p = new MusicFile("Pehli Nazar Mein", "Atif Aslam", 2008,250);  // //  Creating Music 
            MusicFile b = new MusicFile("Be Inteha", "Atif Aslam", 2013, 250);
            MusicFile d = new MusicFile("Din gelo ", "Habib", 2007, 210);
            MusicFile a = new MusicFile("Aadat ", "Atif Aslam", 2004, 200);
            MusicFile m = new MusicFile("Tera Chehera", "Adnan Sami", 2002, 250);
            MusicFile z = new MusicFile("Tere Bina ", " Mustafa Zahid", 2012, 220);

            Console.WriteLine();
            Iphone i = new Iphone("Iphone 11");                  // Creating Iphone Phone 
            i.AddMusic(p);                                      //  Adding Music
            i.AddMusic(b);

            i.ShowMusicInfo();                                 //  Displaying All Music Info of IPhone 

            i.play(true);                                     // Execution Of Music Player 
            i.playNext();       
            i.playPrevious();

            Console.WriteLine();


            i.RSwitch(true);                                     // Radio Part 
            i.RsetVolume(25);
            i.retune(89.2);
            i.changeChannel();

            Console.WriteLine();
            Console.WriteLine();

            Redmi r = new Redmi("Redmi Note 8 pro");            // Creating Redmi Phone 
            r.AddMusic(a);                                     //  Adding Music
            r.AddMusic(d);
            r.AddMusic(z);
            r.ShowMusicInfo();                                 //  Displaying All Music Info of Redmi Phone 

            r.MSwitch(true);                                  // Execution Of Music Player
            r.play(true);
            r.playNext();
            r.playNext();
            r.playPrevious();
            r.playPrevious();



            Console.WriteLine();

            r.RSwitch(true);                                 // Radio Part 
            r.RsetVolume(17);
            r.retune(89.6);
            r.changeChannel();

            Console.WriteLine();
            Console.WriteLine();

            Ipod ip = new Ipod("Ipod 10");                  // Creating Ipod
            
            ip.AddMusic(a);                                //  Adding Music
            ip.AddMusic(p);

            ip.ShowMusicInfo();                           //  Displaying All Music Info of IPoD

            ip.play(true );                              // Execution Of Music Player
            ip.playNext();
            ip.playPrevious();

            Console.WriteLine();

            ip.RSwitch(true);                            // Radio Part 
            ip.RsetVolume(25);
            ip.retune(88.0);
            ip.changeChannel();


        }
    }
}
