using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StateMachine
    {
        public enum State
        {
            idle,
            play_hovered,
            vol_hovered,
            play_to_vol,
            vol_to_play,
        }
        static State _state = State.idle;
        
        public void onPlayHovered()
        {
            
            switch (_state)
            {
                case State.idle:
                    _state = State.play_hovered;
                    break;

                case State.vol_hovered:
                    _state = State.vol_to_play;
                    //nextSong();
                    break;
                default:
                    break;
                    
            }

        }

        public void onVolHovered()
        {
            switch (_state)
            {
                case State.idle:
                    _state = State.vol_hovered;
                    break;

                case State.vol_hovered:
                    _state = State.play_to_vol;
                    //prevSong();
                    break;
                default:
                    break;

            }
        }

        private void onHandremoved()
        {
            switch (_state)
            {
                case State.vol_hovered:
                    _state = State.idle;
                    //setVolume();
                    break;

                case State.play_hovered:
                    _state = State.idle;
                    //playPause();
                    break;
                default:
                    break;

            }
        }







        //unnessecary stubs

        private void exit(State old)
        {


        }

        private void entry(State newState)
        {

        }

    }
}
