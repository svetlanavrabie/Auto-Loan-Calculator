using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace CalcPretAuto1
{
    /// <summary>
    /// Logique d'interaction pour Choix1.xaml
    /// </summary>
    public partial class Choix1 : Page
    {

        public Choix1()
        {
            InitializeComponent();
            tb1.Text = CalculPret.prixVoitnew.ToString();
            tb2.Text = CalculPret.prixVoitact.ToString();
            tb3.Text = CalculPret.soldePret.ToString();
            tb4.Text = CalculPret.misefond.ToString();
            tb5.Text = CalculPret.duree.ToString();
            tb6.Text = CalculPret.taxeVente.ToString();
            tb7.Text = CalculPret.tauxInt.ToString();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Choix2 c2 = new Choix2();
            this.NavigationService.Navigate(c2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Choix1 c1 = new Choix1();
            NavigationService.Navigate(c1);
        }



        public bool validateChBox(String txt)
        {

            string tString = txt;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]) && tString[i] != '.' && tString[i] != ',')
                {
                    MessageBox.Show("S'il vous plait, entrez un nombre valide");
                    return false;
                }

            }
            return true;
        }

       

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb1.Text))
            {
                tb1.Text = "";
            }
           
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb2.Text))
            {
                tb2.Text = "";
            }
           
        }

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb3.Text))
            {
                tb3.Text = "";
            }
            
        }

        private void tb4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb4.Text))
            {
                tb4.Text = "";
            }
            
        }

        private void tb5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb5.Text))
            {
                tb5.Text = "";
            }
            
        }

        private void tb6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb6.Text))
            {
                tb6.Text = "";
            }
           
        }

        private void tb7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox(tb7.Text))
            {
                tb7.Text = "";
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Prix de votre nouveau vehicule a acheter. Ce prix ne peut pas depasser $170000");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quelle est la valeur de reprise de votre véhicule actuel? Si vous n’avez pas de véhicule d’échange, entrez 0 $.");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel est le solde du prêt pour votre véhicule actuel? Si vous n’avez pas de prêt, entrez 0 $.");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Entrez le montant de votre paiement initial, en argent, pour acheter le véhicule.");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quelle est la durée (en mois) qu’il vous faudrait pour rembourser votre prêt?");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel est le taux de taxe de vente dans votre province. Entrez-le en pourcentage.");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel taux d’intérêt prévoyez-vous obtenir?");
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb1.Text)) { 
                CalculPret.prixVoitnew = Double.Parse(tb1.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0) {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                  tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                } else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            } else tb1.Text = "";
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb2.Text))
            {
                CalculPret.prixVoitact = Double.Parse(tb2.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb2.Text = "";
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb3.Text))
            {
                CalculPret.soldePret = Double.Parse(tb3.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb3.Text = "";
        }

        private void slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb4.Text))
            {
                CalculPret.misefond = Double.Parse(tb4.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb4.Text = "";
        }

        private void slider5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb5.Text))
            {
                CalculPret.duree = Double.Parse(tb5.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb5.Text = "";
        }

        private void slider6_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb6.Text))
            {
                CalculPret.taxeVente = Double.Parse(tb6.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb6.Text = "";
        }

        private void slider7_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox(tb7.Text))
            {
                CalculPret.tauxInt = Double.Parse(tb7.Text);
                CalculPret.calcule1();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal1.Visibility = Visibility.Visible;
                    tbtotal2.Visibility = Visibility.Visible;
                    tbtotal1.Text = CalculPret.pretTotal.ToString();
                    tbtotal2.Text = CalculPret.rembourMensuel.ToString();
                }
                else
                {
                    tbtotal1.Visibility = Visibility.Hidden;
                    tbtotal2.Visibility = Visibility.Hidden;
                }
            }
            else tb7.Text = "";
        }

      
    }
}
