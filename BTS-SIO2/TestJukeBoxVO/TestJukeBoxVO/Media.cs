using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJukeBoxVO
{
    class Media
    {
        private string commentaire;
        public int duree;
        private bool enStock;
        public string titre;

        public Media(string titre,int duree) 
        {
            this.titre = titre;
            this.duree = duree;
        }

        public void Afficher() 
        {
            base.Afficher();
            Console.WriteLine("C'est un Media");
            Console.WriteLine(" " + artiste);
            Console.WriteLine("  pistes : " + nombrePiste);
        }
        public string GetCommentaire { get { return commentaire; } }
        public bool GetEnStock { get { return enStock; } }
        public string SetCommentaire { set { this.commentaire=commentaire; } }
        public bool SetEnStock { set { this.enStock=enStock; } }
    }
}
