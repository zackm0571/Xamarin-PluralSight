using System;
namespace PluralSightTutorial
{
    public class Album
    {
        private String title, artist;
        public String Title{ 
            get{
                return title;  
            } 
            internal set{
                this.title = value;
            }
        }

        public String Artist
        {
            get
            {
                return artist;
            }
            internal set
            {
                this.artist = value;
            }
        }

        public Album()
        {
        }
    }
}
