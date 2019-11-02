using System;

namespace TextExample
{
    public class Method
    {
        public static bool Calcolo()
        {
            double a = 1.0 / 10.0;
            double somma = a + a + a + a + a + a + a + a + a + a;
            if (somma == 1)
                return true;
            else
                return false;
        }
        public static bool Calcolo1()
        {
            double a = 1.0 / 10.0;
            double somma = a + a + a + a + a + a + a + a + a + a;
            if (somma == 1)
                return false;
            else
                return true;
        }
        public static bool Calcolo2()
        {
            double a = 1.0 / 6.0;
            double prodotto = a * 6.0;
            if (prodotto == 1)
                return true;
            else
                return false;
        }
        public static bool Calcolo3()
        {
            double a = 1.0 / 6.0;
            double prodotto = a * 6.0;
            if (prodotto == 1)
                return false;
            else
                return true;
        }
    }
}
