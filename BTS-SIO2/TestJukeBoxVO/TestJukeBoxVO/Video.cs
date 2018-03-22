using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJukeBoxVO
{
    class Video : Media
    {
        private string metteurEnScene;

        public Video(string titre, string metteurEnScene, int duree) :base(titre,duree)
        {
            this.metteurEnScene = metteurEnScene;
        }
        public new void Afficher() 
        {
            base.Afficher();
            Console.WriteLine("C'est une Video");
            Console.WriteLine(" " + metteurEnScene);
        }
        public override string ToString()
        {
            string s = string.Format("C'est une vidéo");
            s = s + string.Format(" " + metteurEnScene);
            return s;
        }

    }
}
