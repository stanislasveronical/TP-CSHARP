using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompteBanquaire
{
    public class Compte
    {
        private static int nombreComptes;
        

        private int numero;
        private string titulaire;
        private decimal solde;
        private decimal decouvertMax;
        private decimal debitMax;

       
      
        /// <sumary>Permet d'instancier le NOM du titulaire et le SOLDE INITIAL</sumary>
        /// <param name="solde" prend la valeur du solde initial./param>
        /// <param name="titulaire" prend le nom du titulaire du compte./param>
        
        public Compte(string titulaire, decimal solde)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            Compte.nombreComptes = Compte.nombreComptes + 1;
            this.debitMax = solde * 0.1m;
            this.decouvertMax = solde * 0.25m;
            this.numero = Compte.nombreComptes;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulaire"></param>
        /// <param name="solde"></param>
        /// <param name="debitMax"></param>
        /// <param name="decouvertMax"></param>
        public Compte(string titulaire, decimal solde, decimal debitMax, decimal decouvertMax)
            :this(titulaire,solde){

                this.debitMax = debitMax;
                this.decouvertMax = decouvertMax;
            //Les autres données membres ont déjà été initialiséés.

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="montant"></param>
        public void Crediter(decimal montant)
        {
            // augmente le solde
            this.solde = this.solde + montant;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public bool Debiter(decimal montant)
        {
            // diminue le solde
            // retourn true ou false si l'opération a réussi.
            return false;
            bool fait = false;
            if (montant < this.debitMax)
            {
                if (montant <= this.solde + this.decouvertMax)
                {
                    this.solde = this.solde - montant;
                    fait = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal GetSolde()
        {
            return this.solde;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompteDestinataire"></param>
        /// <param name="montant"></param>
        public void Virement(Compte CompteDestinataire, decimal montant)
        {
            // virement entre deux comptes.
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return string.Format("compte n°:{0} titulaire:{1} solde:{2} débit max:{3} découvert max:{4}",
                this.numero, this.titulaire, this.solde, this.debitMax, this.decouvertMax);
        }
        
    }
}
