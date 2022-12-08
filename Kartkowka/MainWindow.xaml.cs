using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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

namespace Kartkowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(podstawa.Text, out double podst) && double.TryParse(wykladnik.Text, out double wykl ))
            {
                double suma = 1.0;
                //if( (wykl % 1) != 0)
                if (wykl == 0.5)
                {
                    double a = 1;
                    double b = podst;
                    double sumka;
                    if (b - a < 0)
                        sumka = (a - b);
                    else
                        sumka = (b - a);

                    int licznik = 0;

                    while ((sumka > 0.1 ) )
                    {
                        licznik++;

                        a += 0.00001;
                        b /= a;

                        if (b - a < 0)
                            sumka = (a - b);
                        else
                            sumka = (b - a);
                    }
                    suma = a;
                }
                else
                {
                    if ( wykl < 0 )
                    {

                        double wynik = 1;
                        for (int i = 0; i > wykl; i--)
                        {
                            wynik *= podst;
                        }
                        suma = 1 / wynik;
                    
                    }
                    if (wykl == 0)
                    {
                        suma = 1;
                    }
                    else
                    {
                        for (int i = 0; i < wykl; i++)
                        {
                            suma *= podst;
                        }
                    }
                }


                MessageBox.Show(podst + " do potegi " + wykl + " = " + suma.ToString(), "Obliczenia", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Pola musza zostac wypelnione liczbami");
            }
            
        }
    }
}
