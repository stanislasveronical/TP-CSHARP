using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestJukeBoxVO
{
    class Database
    {
        private List<Media> lesMedias;

        public Database()
        {
            lesMedias = new List<Media>();
        }

        public void Add(Media nouveauMedia) 
        {
            lesMedias.Add(nouveauMedia);
        }

        public void Editer() 
        {
            for (int i = 0; i < lesMedias.Count; i = i + 1)
            {
                Media unMedia = (Media)lesMedias[i];
                Console.WriteLine(unMedia);
            }
             
                
            
        }
    }
}
