using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PlayListManagement
{
    public class PlayList
    {
        public List<Song> Songs { get; set; }
        public int Current { get; set; }

        public PlayList()
        {
            Songs = new List<Song>();
            Current = 0;

            var media = new MediaLibrary();
            var songs = media.Songs;

            foreach (var song in songs)
            {
                this.Songs.Add(song);
            }
        }

        public void Next()
        {

        }

        public void Pause()
        {

        }
    }

    class DummyPlayList
    {
        private String[] songs = { "ms-appx:///Audio/Two Steps From Hell - El Dorado (SkyWorld).mp3",
                                   "ms-appx:///Audio/Two Steps from Hell - Protectors of the Earth.mp3",
                                   "ms-appx:///Audio/Two_Steps_From_Hell_-_Heart_of_Courag_(mp3.pm).mp3"};

        private int current = 0;

        public void Next()
        {
            current = (current + 1) % 3;
            //switch
            //BackgroundMediaPlayer.Current.SetUriSource(new Uri(songs[current]));
            //BackgroundMediaPlayer.Current.Play();
        }

        public void Pause()
        {
            //pause
        }
    }
}
