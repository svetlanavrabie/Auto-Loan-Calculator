using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPretAuto1
{
    class CalculPret
    {
        public static double prixVoitnew { get; set; } = 30000;
        public static double prixVoitact { get; set; } = 10;
        public static double soldePret { get; set; } = 0;
        public static double misefond { get; set; } = 15000;
        public static double duree { get; set; } = 96;
        public static double taxeVente { get; set; } = 13;
        public static double tauxInt { get; set; } = 3;
        public static double pretTotal { get; set; } = 0;
        public static double rembourMensuel { get; set; } = 0;

       /* public CalculPret(double prixVoitnew, double prixVoitact, double soldePret, double misefond, int duree, double taxeVente, double tauxInt, double pretTotal, double rembourMensuel)
        {
            this.prixVoitnew = prixVoitnew;
            this.prixVoitact = prixVoitact;
            this.soldePret = soldePret;
            this.misefond = misefond;
            this.duree = duree;
            this.taxeVente = taxeVente;
            this.tauxInt = tauxInt;
            this.pretTotal = pretTotal;
            this.rembourMensuel = rembourMensuel;
        } */

       

        public static void calcule1()
        {
            double rez1 = ((prixVoitnew - prixVoitact) + (((prixVoitnew - prixVoitact) * taxeVente) / 100)) + soldePret - misefond;
            if (rez1 <= 60000 && rez1 > 0) { 
                pretTotal = Math.Round(rez1, 2);
                double pmt = Financial.Pmt(((tauxInt / 12) / 100), duree, -pretTotal, 0, DueDate.BegOfPeriod);
                rembourMensuel = Math.Round(pmt, 2);
            }
            else { 
                pretTotal = 0;
                rembourMensuel = 0;
            }
        }

        public static void calcule2()
        {
            double pv = Financial.PV(((tauxInt / 12) / 100), duree, -rembourMensuel, 0, DueDate.BegOfPeriod);
            if (pv <= 60000 && pv > 0)
            {
                pretTotal = Math.Round(pv, 2);
                double pnv = ((pretTotal - soldePret + misefond) / (1 + taxeVente / 100)) + prixVoitact;
                prixVoitnew = Math.Round(pnv, 2);
            }
            else
            {
                pretTotal = 0;
                prixVoitnew = 0;

            }
        }

    }
}
