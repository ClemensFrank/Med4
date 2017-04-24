using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace ConsoleApplication3
{
    class SerialListener
    {
        bool playLocked = false;
        bool volLocked  = false;

        SerialPort srp = new SerialPort();
        public event PlayHoveredEventHandler playHovered;
        public event VolHoveredEventHandler volHovered;
        public event PlayNotHoveredEventHandler playNotHovered;
        public event VolNotHoveredEventHandler volNotHovered;

        //specify serialport
        public SerialListener(SerialPort srp)
        {
            this.srp = srp;
        }

        public void listen()
        {

            while (true)
            {
                if (!srp.IsOpen)
                {
                    break;
                }
                else if (srp.BytesToRead > 0)
                {

                    byte[] _inbuffer = new byte[16];

                    int _numBytesRead = srp.Read(_inbuffer, 0, _inbuffer.Length);

                    // raise events depending on custom logic. i.e. if buffer = whatever the arduino sends when hovering the play
                    // sensor, raise playpause event
                    if (true && !playLocked)
                    {
                        playHovered();
                    }
                    else if (true && !volLocked)
                    {
                        volHovered();
                    }


                }
            }
        }


        public void trial()
        {
            playHovered();
        }
    }

}
