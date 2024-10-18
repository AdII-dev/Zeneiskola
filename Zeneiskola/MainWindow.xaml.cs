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
using System.IO;
using static Zeneiskola.Zenedarabok;

namespace Zeneiskola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            try
            {
                string filePath = "src/zenemuvek.txt";
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    string[] data = lines[0].Split(';');

                    Zene zene = new Zene
                    {
                        ZeneDarab = data[0],
                        Keletkezes = int.Parse(data[1]),
                        Nehezseg = int.Parse(data[2]),
                        Zeneszerzo = data[3]
                    };


                    string filePath = "src/zenemuvek.txt";
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length > 0)
                    {
                        foreach (var line in lines)
                        {
                            string[] lineData = line.Split(';'); // Átnevezve data-ra

                            Zene zene = new Zene
                            {
                                ZeneDarab = lineData[0],
                                Keletkezes = int.Parse(lineData[1]),
                                Nehezseg = int.Parse(lineData[2]),
                                Zeneszerzo = lineData[3]
                            };

                            // ZeneDarab hozzáadása a listához
                            ZeneDarabokLista.Add(zene);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }




        //GOMBOK
        private void Listazas_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Darabok_keletkezese_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tizes_nehezsegu_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Debussy_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Valasztott_darabok_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kereses_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Valasz_kuldese_gomb_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}