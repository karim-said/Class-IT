using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24
{
    interface IMethods
    {
       void On();

       void Off();

      void  Mute();

      void  NextTrack();

      //void  PrevTrack();

      //void  VolumeUp();

      //void  VolumeDown();

      void  NextScore();

    //   void PrewScore();

      void  Pause();

       void Stop();

       void Play();

      void  Eject(bool OutputMode);

       void Close(bool Status);
    }
}
