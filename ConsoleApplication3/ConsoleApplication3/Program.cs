using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace ConsoleApplication3
{
    public delegate void PlayHoveredEventHandler();
    public delegate void PlayNotHoveredEventHandler();
    public delegate void DelayPlayHoveredEventHandler();
    
    public delegate void VolHoveredEventHandler();
    public delegate void VolNotHoveredEventHandler();
    public delegate void DelayVolHoveredEventHandler();


    static class Program
    {
        public static SerialListener _serialListener;

        [STAThread]
        static void Main(string[] args)
        {
            //Console.WriteLine("Started");
            //SerialPort srp = new SerialPort();
            //_serialListener = new SerialListener(srp);
            ////initiate music player etc...


            //StateMachine _stateMachine = new StateMachine();
            //_serialListener.playHovered += _stateMachine.onPlayHovered;
            //_serialListener.volHovered += _stateMachine.onVolHovered;

            //_serialListener.trial();
            //Console.ReadKey();

            mp3Player mp3 = new mp3Player();
            mp3.open();

            Console.ReadKey();


        }

    }

}
