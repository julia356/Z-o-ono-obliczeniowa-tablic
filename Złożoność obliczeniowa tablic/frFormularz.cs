using Sortowanie_Tablic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Złożoność_obliczeniowa_tablic
{
    public partial class frFormularz : Form
    {

        public int WielkoscTablicy;                                      // Definiujemy zmienną dla wielkości tablicy 
        public int[] Tablica;                                            // Definiujemy tablicę

        public frFormularz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                                                                 // w kontrolce lbWygenerowanaTablica będziemy wyświetlać wygenerowaną tablicę
            lbWygenerowanaTablica.Text = "";                              // na początku ustawiamy kontrolkę "lbWygenerowanaTablica" na pusty string
        }

        private void btGenerujTablice_Click(object sender, EventArgs e)
        {
            // przed wygenerowaniem tablicy, sprawdzamy poler tekstowe Wielkość tablicy, żeby program się nie wywalił

            // Jeżeli pole tekstowe txtWielkoscTablicy.Text jest puste, wyświetlamy odpowiedni komunikat:
            if (txtWielkoscTablicy.Text == "")          
            {
                MessageBox.Show("Wielkość tablicy nie może być pusta!","Wielkość tablicy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jeżeli pole tekstowe txtWielkoscTablicy.Text nie jest liczbą rzeczywistą, wyświetlamy odpowiedni komunikat:
            else if (!int.TryParse(txtWielkoscTablicy.Text, out WielkoscTablicy))   
            {
                MessageBox.Show("Podana wartość musi być typu intiger!", "Wielkość tablicy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jeżeli pole tekstowe txtWielkoscTablicy.Text jest poniżej 3, wyświetlamy odpowiedni komunikat:
            else if (Convert.ToInt16(txtWielkoscTablicy.Text) < 3)                 
            {
                MessageBox.Show("Podana wartość musi z przedziału od 3 do 200", "Wielkość tablicy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tablica = new int[WielkoscTablicy];                             // tworzymy tablicę o podanej wielkości 

            Random random = new Random();                                   // definiujemy funkcje "Random" do wpisania losowych liczb do tablicy

            for (int i = 0; i < Tablica.Length; i++)                        // w pętli wypełniamy tablice losowymi liczbami
                Tablica[i] = random.Next(1, 1000);

            lbWygenerowanaTablica.Text = "Wygenerowana tablica:" + "\n" + WyswietlTablice(Tablica);     // I wyświetlamy w kontrolce Label, wygenerowaną tablicę

        }

        public static string WyswietlTablice(int[] arr)                      // Definiujemy metodę na wyświetlenie tablicy
        {
            string wynik = "";                                               // Deklarujemy zmienną string i ustawiamy ja pustą

            for (int i = 0; i < arr.Length; i++)                             // w pętli przechodzimy przez wszystkie elementy tablicy 
            {
                if (i % 30 == 0)                                             // w celu wypisania całej tablicy na ekranie, dzielimy ją na linijki po 30 elementów
                    wynik = wynik + "\n";                                    // gdy warunek jest spełniony, dodajemy "znak nowej linii"

                wynik = wynik + arr[i] + ", ";                              // Dodajemy do zmiennej "wynik" kolejny element tablicy
            }

            wynik = wynik.Substring(0, wynik.Length - 2);                   // po dodaniu wszystkich elementów, usuwany z końca przecinek i dwie spację ", ")

            return wynik;                                                    // Zwracamy wynik
        }

        private void btSortuj_Click(object sender, EventArgs e)
        {
            // wyjątek, żeby program się nie wywalił, sprawdzamy czy została podana wielkość tablicy, to znaczy, że tablica zostałą wygenerowana

            if (txtWielkoscTablicy.Text == "")
            {
                MessageBox.Show("Brak możliwości sortowania - tablica nie została wygenerowana", "Wielkość tablicy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtWielkoscTablicy.Text, out WielkoscTablicy))


            Sortowanie.IloscPorownan = 0;                                   // resetujemy wartośc IloscPorownan na 0
            Sortowanie.iloscPrzestawien = 0;                                // resetujemy wartośc iloscPrzestawien na 0

            Sortowanie.BubbleSort(Tablica, WielkoscTablicy);                // sortujemy tablicę metodą BubbleSort
            lbWygenerowanaTablica.Text = lbWygenerowanaTablica.Text + "\n\n" + "Posortowana tablica:" + "\n" + WyswietlTablice(Tablica);    // wyświetlamy w kontrolce Label, posortowaną tablicę

            ArrayList listWyniki = new ArrayList();                         // tworzymy listę w wynikami sortowania                                          

            
            listWyniki.Add(new Wyniki(1, "BubbleSort", Sortowanie.IloscPorownan));      // dodajemy do listy liczbę operacji sortowania BubbleSort
            listWyniki.Add(new Wyniki(2, "QuickSort", Sortowanie.iloscPrzestawien));    // dodajemy do listy liczbę operacji sortowania QuickSort

            // Bind the chart to the list.
            dataGridView.DataSource = listWyniki;                           // podstawiamy wyniki sortowania do wyświetlenia w dataGridView

                                                                            // poniżej tworzymy wykres
            while (chart.Series.Count > 0) 
            { 
                chart.Series.RemoveAt(0); 
            }

            Series series1 = new Series("BubbleSort");
            series1.Points.Add(Sortowanie.IloscPorownan);
            series1.IsValueShownAsLabel = true;
            chart.Series.Add(series1);
            chart.Update();

            Series series2 = new Series("QuickSort");
            series2.Points.Add(Sortowanie.iloscPrzestawien);
            series2.IsValueShownAsLabel = true;
            chart.Series.Add(series2);
            chart.Update();
        }
    }
}
