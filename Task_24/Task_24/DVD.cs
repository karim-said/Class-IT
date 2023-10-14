using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24
{
    class DVD : IMethods
    {
       private string Name;
       private bool Status;
       private bool OutputMode;
       private string DiskType;
       private int Volume;
       private string Track;

        public DVD(string name,bool status, bool outputemode,string disktype,int volume,string track)
        {
            this.Name = name;
            this.Status = status;
            this.OutputMode = outputemode;
            this.DiskType = disktype;
            this.Volume = volume;
            this.Track = track;
        }
        public void Close(bool Status)
        {
            if (Status == true)
            {
                Console.WriteLine("Close!");
            }
        }

        public void Eject(bool OutputMode)
        {
            if (OutputMode == true)
            {
                Console.WriteLine($"you threw away the song {Track}");
            }
        }

        public void Mute()
        {
            Console.WriteLine("Mute song!");
        }

        public void NextScore()
        {
            Console.WriteLine("Next !");
        }

        public void NextTrack()
        {
            Console.WriteLine("Next Song!"); ;
        }

        public void Off()
        {
            Console.WriteLine("Off!");
        }

        public void On()
        {
            Console.WriteLine("On!");
        }

        public void Pause()
        {
            Console.WriteLine("Pause!");
        }

        public void Play()
        {
            Console.WriteLine($"{Name}\n{Status}\n{OutputMode}\n{DiskType}\n{Volume}\n{Track}");
        }

        //public void PrevTrack()
        //{
        //    throw new NotImplementedException();
        //}

        //public void PrewScore()
        //{
        //    throw new NotImplementedException();
        //}

        public void Stop()
        {
            Console.WriteLine("Stop!");
        }

        //public void VolumeDown()
        //{
        //    throw new NotImplementedException();
        //}

        //public void VolumeUp()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
