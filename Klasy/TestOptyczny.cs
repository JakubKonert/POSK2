using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace POSK2.Klasy
{
     public static class TestOptyczny
    {
        public static int NumerPomiaru = 0;
        public static Random Losowe = new Random();
        public static Stopwatch CzasPomiaru = new Stopwatch();
        public static List<int> WynikiOptycznyList = new List<int>();
        public static bool TestOptycznyTrwa = false;

        public static int ZmianaLiczby()
        {
            var LosowaLiczba = new Random().Next(1,10);
            return LosowaLiczba; 
        }
    }
}
