using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompteBanquaire
{
    public class BanqueCollectionType
    {
        // Instanciation du tableau de comptes
        //ArrayList lesComptes;

        List<Compte> lesComptes;
        //private Compte[] lesComptes;
        //int count;
        //int taille;
        string nom;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        public BanqueCollectionType(string nom)
        {
            //Instanciation du tableau de comptes
            //lesComptes = new Compte[taille];
            //this.lesComptes = new ArrayList();

            this.lesComptes = new List<Compte>();
            //this.count = 0;
            this.nom = nom;
            //this.taille = taille;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nouveauCompte"></param>
        public void Add(Compte nouveauCompte)
        {
            //if (this.count < this.taille)
            {
                //lesComptes[count] = nouveauCompte;
                this.lesComptes.Add(nouveauCompte);
                //count = count + 1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulaire"></param>
        /// <param name="solde"></param>
        public void Add(string titulaire, decimal solde)
        {
            Compte nouveau = new Compte(titulaire, solde);
            this.Add(nouveau);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            //return this.count;
            return this.lesComptes.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            get
            {
                //return this.count;
                return this.GetCount();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Compte GetCompte(int position)
        {

            //if (position >= 0 && position < this.count)
            if (position >= 0 && position < this.lesComptes.Count) 
            {
                return this.lesComptes[position];
                //return (Compte)this.lesComptes[position];
            }
            else{
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Compte this[int position]
        {
            get {
                //return this.lesComptes[position];
                return this.lesComptes[position];
            }
        }
    }
}
