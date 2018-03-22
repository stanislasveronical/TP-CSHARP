﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GencodeEan13
{
    class Ean13
    {
        private int[] ean13;

        public Ean13(int[] ean13) {
            if (ean13.Length != 12) {
                throw new Exception("Un code Ean 13 doit être un tableau de 12 entiers");
            }
            this.ean13 = new int[13];
            for (int i = 0; i < 12; i++) {
                this.ean13[i] = ean13[i];
            }
        }

        public int PoidsPair() {
            int cumul = 0;
            for (int i = 1; i <= 11; i = i + 2)
            {
                cumul = cumul + this.ean13[i] * 3;
            }
            return cumul;
        }

        public int PoidsImpair() {
            int cumul = 0;
            for (int i = 0; i <= 11; i = i + 2) {
                cumul = cumul + this.ean13[i];
            }
            return cumul;
        }

        public int Reste() {
            int cumul = PoidsImpair() + PoidsPair();
            int restDiv = cumul % 10;
            return restDiv;
        }

        public int Cle() {
            int soust = 10 - Reste();
            return soust;
        }

        public override string ToString() {
            return string.Format("{0}{1}{2}{3}-{4}{5}{6}{7}-{8}{9}{10}{11}-{12}", 
                ean13[0], ean13[1], ean13[2], ean13[3], ean13[4], ean13[5], ean13[6], ean13[7], ean13[8], 
                ean13[9], ean13[10], ean13[11], Cle());
        }

    }
}
