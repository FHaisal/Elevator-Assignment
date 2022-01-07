using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace Elevator
{
    class Sound
    {
        // Initiates objects.
        private SoundPlayer soundPlayer;

        // Declares a delegate to play sound types.
        public delegate void SoundDelegate(string soundType);
        public SoundDelegate soundEvent;

        // Constructor of the class to instantiate variables/objects.
        public Sound()
        {
            // Instantiate objects.
            soundPlayer = new SoundPlayer();
            soundEvent += new SoundDelegate(EventHandler);
        }

        // Method to handle the sound types.
        private void EventHandler(string soundType)
        {
            // Switch that sorts out the sound types.
            switch(soundType)
            {
                // If 'First', then run the FirstFloorSound.
                case "First": FirstFloorSound();
                    break;
                // If 'Ground', then run the GroundFloorSound.
                case "Ground": GroundFloorSound();
                    break;
            }
        }

        // Methods to start playing sounds.
        private void FirstFloorSound()
        {
            // Declare the stream, of the audio file.
            soundPlayer.Stream = Properties.Resources.First_floor;
            // Play the audio file.
            soundPlayer.Play();
        }
        private void GroundFloorSound()
        {
            // Declare the stream.
            soundPlayer.Stream = Properties.Resources.Ground_floor;
            // Play the audio file.
            soundPlayer.Play();
        }
    }
}
