using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Złożoność_obliczeniowa_tablic
{
    public class Wyniki                                         // Definujemy klasę, która będzie wykorzystana do stworzenia listy wyników sortowania
    {
        int id;                                                 // Definiujemy pola "id" - pozycja na liście, "nazwa" - typ sortowania, "wartosc" - liczba operacji danego sortowania 
        string nazwa;                                           
        int wartosc;                                             

        public Wyniki(int id, string nazwa, int wartosc)        // Tworzymy konstruktor Wyniki
        {
            this.id = id;                                       
            this.Nazwa = nazwa;
            this.Wartość = wartosc;
        }
        public int ID                                           // Deklarujemy metodę na usyawienie i odczytanie ID
        {
            set { id = value; }                                 // ustawiamy wartość "value" do zmiennej "id"
            get { return id; }                                  // pobieramy zawartość "id", a następnie zwracamy jej wartość
        }
        public string Nazwa                                     // Deklarujemy metodę na usyawienie i odczytanie Nazwy
        {
            set { nazwa = value; }                              // ustawiamy wartość "value" do zmiennej "nazwa"
            get { return nazwa; }                               // pobieramy zawartość "nazwa", a następnie zwracamy jej wartość
        }
        public int Wartość                                      // Deklarujemy metodę na usyawienie i odczytanie Wartości
        {
            set { wartosc = value; }                            // ustawiamy wartość "value" do zmiennej "wartosc"
            get { return wartosc; }                             // pobieramy zawartość "wartosc", a następnie zwracamy jej wartość
        }
    }
}
