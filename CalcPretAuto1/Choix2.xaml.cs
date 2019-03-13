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
    public partial class Choix2 : Page
    {
       
        public Choix2()
        {
            
            InitializeComponent();
            tb8.Text = CalculPret.rembourMensuel.ToString();
            tb9.Text = CalculPret.prixVoitact.ToString();
            tb10.Text = CalculPret.misefond.ToString();
            tb11.Text = CalculPret.soldePret.ToString();
            tb12.Text = CalculPret.taxeVente.ToString();
            tb13.Text = CalculPret.tauxInt.ToString();
            tb14.Text = CalculPret.duree.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Choix2 c2 = new Choix2();
            NavigationService.Navigate(c2);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Choix1 c1 = new Choix1();
            this.NavigationService.Navigate(c1);
           
        }

      

        public bool validateChBox1(String txt)
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



        private void tb8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb8.Text))
            {
                tb8.Text = "";
            }
        }

        private void tb9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb9.Text))
            {
                tb9.Text = "";
            }
        }

        private void tb10_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb10.Text))
            {
                tb10.Text = "";
            }
        }

        private void tb11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb11.Text))
            {
                tb11.Text = "";
            }
        }

        private void tb12_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb12.Text))
            {
                tb12.Text = "";
            }
        }

        private void tb13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb13.Text))
            {
                tb13.Text = "";
            }
        }

        private void tb14_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validateChBox1(tb14.Text))
            {
                tb14.Text = "";
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Combien aimeriez-vous payer par mois, y compris les taxes?");
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quelle est la valeur de reprise de votre véhicule actuel? Si vous n’avez pas de véhicule d’échange, entrez 0 $.");
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Entrez le montant de votre paiement initial, en argent, pour acheter le véhicule.");

        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel est le solde du prêt pour votre véhicule actuel? Si vous n’avez pas de prêt, entrez 0 $.");
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel est le taux de taxe de vente dans votre province. Entrez-le en pourcentage.");
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quel taux d’intérêt prévoyez-vous obtenir?");
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quelle est la durée (en mois) qu’il vous faudrait pour rembourser votre prêt?");
        }

        private void slider8_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb8.Text))
            {
                CalculPret.rembourMensuel = Double.Parse(tb8.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb8.Text = "";
        }

        private void slider9_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb9.Text))
            {
                CalculPret.prixVoitact = Double.Parse(tb9.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb9.Text = "";
        }

        private void slider10_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb10.Text))
            {
                CalculPret.misefond = Double.Parse(tb10.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb10.Text = "";
        }

        private void slider11_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb11.Text))
            {
                CalculPret.soldePret = Double.Parse(tb11.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb11.Text = "";
        }

        private void slider12_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb12.Text))
            {
                CalculPret.taxeVente = Double.Parse(tb12.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb12.Text = "";
        }

        private void slider13_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb13.Text))
            {
                CalculPret.tauxInt = Double.Parse(tb13.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb13.Text = "";
        }

        private void slider14_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (validateChBox1(tb14.Text))
            {
                CalculPret.duree = Double.Parse(tb14.Text);
                CalculPret.calcule2();
                if (CalculPret.pretTotal > 0)
                {
                    tbtotal3.Visibility = Visibility.Visible;
                    tbtotal4.Visibility = Visibility.Visible;
                    tbtotal3.Text = CalculPret.pretTotal.ToString();
                    tbtotal4.Text = CalculPret.prixVoitnew.ToString();
                }
                else
                {
                    tbtotal3.Visibility = Visibility.Hidden;
                    tbtotal4.Visibility = Visibility.Hidden;
                }
            }
            else tb14.Text = "";
        }

    }
}
