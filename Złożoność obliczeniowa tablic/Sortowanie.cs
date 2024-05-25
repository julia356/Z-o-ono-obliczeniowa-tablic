using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Tablic
{
    public class Sortowanie
    {
        public static int IloscPorownan = 0;                    // Definiujemy zmienną "IloscPorownan" dla sortowania BuubleSort i ustawiamy wartość początkową 0 
        public static int iloscPrzestawien = 0;                 // Definiujemy zmienną "iloscPrzestawien" dla sortowania BuubleSort i ustawiamy wartość początkową 0 

        public static void BubbleSort(int[] arr, int n)         // Definiujemy metodę dla sortowania BubbleSort  
        {
            int i, j, temp;                                     // Deklarujemy zmienne lokalne
          
            for (i = 0; i < n - 1; i++)                         // Tworzymy pętlę przechodzącą przez całą tablicę, za każdym razem zmniejszając zakres przeszukiwania o jeden (największe elemenenty przechodzą na tył)
            {
                for (j = 0; j < n - i - 1; j++)                 // Tworzymy pętlę przechodzącą przez całą tablicę, za każdym razem porównując i zamieniając sąsiednie elementy w tablicy (zmniejszamy o "i" ponieważ, te elementy są już na swoich miejscach)
                {
                    IloscPorownan++;
                    if (arr[j] > arr[j + 1])                    // Jeżeli element aktualny jest większy od elementu następnego, to zamieniamy miejscami
                    {
                        iloscPrzestawien++;
                        temp = arr[j];                          // podstawiamy pod zmienną tymczasową element aktualny
                        arr[j] = arr[j + 1];                    // następnie za element aktualny podstawiamy element następny
                        arr[j + 1] = temp;                      // a w miejsce elemetnu następnego podstawiamy element aktualny
                    }                                           
                }
            }
        }

    }
}
