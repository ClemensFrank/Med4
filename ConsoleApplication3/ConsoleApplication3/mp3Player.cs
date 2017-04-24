using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder strReturn, int ReturnLength, IntPtr handle);


        List<string> playlistFiles = new List<string>{
            "Clementi.mp3",
            "MacCun.mp3",
            "Schuber.mp3",
            };
        int iCurrentSong =0;
        public bool playing = true;
        public bool stopped =false;
        private bool opened =false;

        public mp3Player()
        {

        }

        public void open()
        {
            if (opened)
                close();
            opened = true;
            mciSendString("open \""+ @"C:\Users\Mr.Frank\Desktop\Mp3Files\piano2.wav"+"\" alias MediaFile", null, 0, IntPtr.Zero);
            if (playing)
                play();
        }

        private void play()
        {
            Console.WriteLine("thefucksgoinon");
            if (stopped)
            {
                playing = true;
                stopped = false;
                open();
            }
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        private void close()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }




    }
}
