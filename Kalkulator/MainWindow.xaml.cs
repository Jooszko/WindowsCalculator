using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        bool pierwsze = true;
        Char dzialanie = 'x';
        String pierwszaLiczba = "";
        String drugaLiczba = "";
        Char poprzednieDzialanie = 'x';
        bool ciagleRowna = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void operation(object sender, RoutedEventArgs e)
        {
            if (sender is Control control)
            {
                string name = control.Name;

                try
                {
                    switch (name)
                    {
                        case "p1":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "1";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "1";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;

                        case "p2":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "2";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "2";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p3":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "3";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "3";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p4":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "4";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "4";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p5":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "5";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "5";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p6":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "6";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "6";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p7":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "7";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "7";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p8":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "8";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "8";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p9":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "9";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "9";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "p0":
                            if (wyswietlacz.Text.Equals("0"))
                            {
                                break;
                            }
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "0";
                                pierwsze = false;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + "0";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            ciagleRowna = false;
                            break;
                        case "pC":
                            pierwsze = true;
                            wyswietlacz.Text = "0";
                            dzialanie = 'x';
                            pierwszaLiczba = "";
                            drugaLiczba = "";
                            ciagleRowna = false;
                            break;
                        case "pCe":
                            if (wyswietlacz.Text.ToString().Length == 2)
                            {
                                String zawartoscWyswietlaczaCzyszczenie = wyswietlacz.Text.ToString();
                                zawartoscWyswietlaczaCzyszczenie = zawartoscWyswietlaczaCzyszczenie.Remove(zawartoscWyswietlaczaCzyszczenie.Length - 1);
                                if (zawartoscWyswietlaczaCzyszczenie.Equals("0"))
                                {
                                    pierwsze = true;
                                    wyswietlacz.Text = "0";
                                    break;
                                }
                                else
                                {
                                    wyswietlacz.Text = zawartoscWyswietlaczaCzyszczenie.ToString();
                                }

                            }
                            else if (wyswietlacz.Text.ToString().Length <= 1)
                            {
                                pierwsze = true;
                                wyswietlacz.Text = "0";
                            }
                            else
                            {
                                String zawartoscWyswietlaczaCzyszczenie = wyswietlacz.Text.ToString();
                                zawartoscWyswietlaczaCzyszczenie = zawartoscWyswietlaczaCzyszczenie.Remove(zawartoscWyswietlaczaCzyszczenie.Length - 1);
                                wyswietlacz.Text = zawartoscWyswietlaczaCzyszczenie.ToString();
                            }

                            break;
                        case "pKropka":
                            if (pierwsze)
                            {
                                wyswietlacz.Text = "0,";
                                pierwsze = false;
                            }
                            else if (wyswietlacz.Text.Contains(","))
                            {
                                break;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = zawartoscWyswietlacza + ",";
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            break;
                        case "pZnak":
                            if (pierwsze)
                            {
                                break;
                            }
                            else if (wyswietlacz.Text.ToString().Equals("0"))
                            {
                                break;
                            }else if (Convert.ToDouble(wyswietlacz.Text) == 0)
                            {
                                break;
                            }
                            else if (wyswietlacz.Text.Contains("-"))
                            {
                                wyswietlacz.Text = wyswietlacz.Text.ToString().Remove(0, 1);
                                break;
                            }
                            else
                            {
                                String zawartoscWyswietlacza = wyswietlacz.Text;
                                zawartoscWyswietlacza = "-" + zawartoscWyswietlacza;
                                wyswietlacz.Text = zawartoscWyswietlacza.ToString();
                            }
                            break;
                        case "pPlus":
                            czyKolejneDzialanie();
                            dzialanie = '+';
                            pierwszaLiczba = wyswietlacz.Text.ToString();
                            pierwsze = true;
                            break;
                        case "pMinus":
                            czyKolejneDzialanie();
                            dzialanie = '-';
                            pierwszaLiczba = wyswietlacz.Text.ToString();
                            pierwsze = true;
                            break;
                        case "pMnozenie":
                            czyKolejneDzialanie();
                            dzialanie = '*';
                            pierwszaLiczba = wyswietlacz.Text.ToString();
                            pierwsze = true;
                            break;
                        case "pDzielenie":
                            czyKolejneDzialanie();
                            dzialanie = '/';
                            pierwszaLiczba = wyswietlacz.Text.ToString();
                            pierwsze = true;
                            break;
                        case "pProcent":
                            if (dzialanie.Equals('x'))
                            {
                                pierwsze = true;
                                wyswietlacz.Text = "0";
                                dzialanie = 'x';
                                pierwszaLiczba = "";
                                drugaLiczba = "";
                                ciagleRowna = false;
                            }
                            else
                            {
                                wyswietlacz.Text= Convert.ToString(Convert.ToDouble(wyswietlacz.Text.ToString()) *0.01);
                            }
                            break;

                        case "pPierwiastek":
                            String zawartoscWys = wyswietlacz.Text.ToString();
                            double wyswietlaczLiczba = Convert.ToDouble(zawartoscWys);
                            if (wyswietlaczLiczba < 0)
                            {
                                pierwsze = true;
                                wyswietlacz.Text = "Err";
                            }
                            else
                            {
                                wyswietlacz.Text = Convert.ToString(Math.Sqrt(wyswietlaczLiczba));
                            }

                            break;

                        case "pWynik":
                            obliczanieWyniku();
                            break;

                        default:
                            wyswietlacz.Text = "Err";
                            pierwsze = true;

                            break;
                    }
                }catch(Exception ex)
                {
                    wyswietlacz.Text = "Err";
                    pierwsze = true;
                    dzialanie = 'x';
                    pierwszaLiczba = "";
                    drugaLiczba = "";
                }

               
            }
            
        }

        private void czyKolejneDzialanie()
        {
            if (!dzialanie.Equals('x'))
            {
                obliczanieWyniku();
            }
            
        }

        private void obliczanieWyniku()
        {
            if (wyswietlacz.Text.Equals("Err"))
            {
                return;
            }

            double liczbaEkranowa = Convert.ToDouble(wyswietlacz.Text);

            if (!ciagleRowna)
            {
                drugaLiczba = liczbaEkranowa.ToString();
            }
            

            double wynik = 0;

            switch (ciagleRowna ? poprzednieDzialanie : dzialanie)
            {
                case '+':
                    wynik = Convert.ToDouble(pierwszaLiczba) + Convert.ToDouble(drugaLiczba);
                    break;
                case '-':
                    wynik = Convert.ToDouble(pierwszaLiczba) - Convert.ToDouble(drugaLiczba);
                    break;
                case '*':
                    wynik = Convert.ToDouble(pierwszaLiczba) * Convert.ToDouble(drugaLiczba);
                    break;
                case '/':
                    if (Convert.ToDouble(drugaLiczba) == 0)
                    {
                        wyswietlacz.Text = "Err";
                        pierwsze = true;
                        return;
                    }
                    wynik = Convert.ToDouble(pierwszaLiczba) / Convert.ToDouble(drugaLiczba);
                    break;
                case '%':
                    wynik = Convert.ToDouble(pierwszaLiczba) * Convert.ToDouble(drugaLiczba) * 0.01;
                    break;
            }
            if (!ciagleRowna)
            {
                poprzednieDzialanie = dzialanie;
            }
            ciagleRowna = true;
            dzialanie = 'x';
            wyswietlacz.Text = wynik.ToString();
            pierwszaLiczba = wynik.ToString();
        }
    }
}