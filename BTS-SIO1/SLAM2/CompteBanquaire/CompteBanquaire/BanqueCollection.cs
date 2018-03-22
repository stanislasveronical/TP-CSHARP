using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CompteBanquaire
{
    public class BanqueCollection
    {
        // Instanciation du tableau de comptes
        ArrayList lesComptes;

        
        //private Compte[] lesComptes;
        //int count;
        //int taille;
        string nom;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        public BanqueCollection(string nom)
        {
            //Instanciation du tableau de comptes
            //lesComptes = new Compte[taille];
            this.lesComptes = new ArrayList();

            //this.lesComptes = new List<Compte>();
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
                //return this.lesComptes[position];
                return (Compte)this.lesComptes[position];
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
                return (Compte)this.lesComptes[position];
            }
        }

        /// <summary>
        /// Renvoie le cumul des soldes de la Banque
        /// </summary>
        /// <returns></returns>
        public decimal ValeurDepotsBanque()
        {
            
            decimal cumul = 0;

            for (int i = 0; i < this.GetCount(); i++)
            {
                Compte c = (Compte)this.lesComptes[i];
                cumul = cumul + c.GetSolde();
            }
            return cumul;
        }

        /// <summary>
        /// Etablit le comptage des comptes ayant un solde négatif
        /// </summary>
        /// <returns></returns>
        public int CountSoldesNégatifs()
        {
            //return 0;
            decimal comptage = 0;

            for (int i = 0; i < this.count; i++)
            { 
            }
            

        }

        /// <summary>
        ///  Etablit le comptage des comptes ayant un solde positif
        /// </summary>
        /// <returns></returns>
        public int CountSoldesPositif()
        {
            return 0;
        }

        public Compte CompteLePlusDeficitaire()
        {
            return null;
        }

        public Compte PlusGrandSolde()
        {
            return null;
        }

        public ArrayList LesSoldesNegatif()
        {
            return null;
        }

        public void Supprimer(int position)
        {
            //if (position >= 0 && position < count - 1)
            //{
            //    return (Compte)this.lesComptes[position];
            //}
            //else
            //{
            //    return null;
            //}

        }

        public void Inserer(int position, Compte c)
        {
            //if (position >= 0 && position < count - 1)
            //{
            //    return (Compte)this.lesComptes[position];
            //}
            //else
            //{
            //    return null;
            //}

        }
    }
}
