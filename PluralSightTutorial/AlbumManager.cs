using System;
using System.Collections.Generic;
namespace PluralSightTutorial
{
    public class AlbumManager
    {
        private int currentIndex;
        private const bool mockAlbums = true;
        private List<Album> albums;
        private List<Album> Albums{
            get{
                if (albums == null)
                {
                    if (!mockAlbums)
                    {
                        albums = new List<Album>();
                    }
                    else{
                        albums = new List<Album>{
                            new Album(){
                                Title = "Everything Was Sound",
                                Artist = "Silent Planet"
                            },
                            new Album(){
                                Title="Toxicity",
                                Artist="System of a Down"
                            },
                        };
                    }
                }

                return albums;
            }
            set{
                this.albums = value;
            }
        }

        public AlbumManager()
        {
        }


        public void MoveFirst(){
            currentIndex = 0;
        }
        public void MovePrev(){
            if (currentIndex > 0)
                --currentIndex;
        }

        public void MoveNext(){
            if (currentIndex < Albums.Count - 1)
                ++currentIndex;
        }

        public Album CurrentAlbum(){
            return Albums[currentIndex];
        }
    }
}
