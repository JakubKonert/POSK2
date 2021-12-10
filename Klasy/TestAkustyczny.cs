using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace POSK2.Klasy
{
    public static class TestAkustyczny
    {
        public static int NumerPomiaru = 0;
        public static Random Losowe = new Random();
        public static Stopwatch CzasPomiaru = new Stopwatch();
        public static List<int> WynikiAkustycznyList = new List<int>();
        public static bool TestAkustycznyTrwa = false;
    }
}
