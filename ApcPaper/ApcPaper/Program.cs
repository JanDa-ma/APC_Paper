using System;
using Xamarin.Forms;

namespace ApcPaper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region header

            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo paper '==-operator in C#'");
            Console.WriteLine("------------------------------\n");

            #endregion header

            Console.WriteLine("--ValueTypes--");
            TestValueTypes();
            Console.WriteLine("\n\n--ReferenceTypes--");
            TestReferenceTypes();
            Console.WriteLine("\n\n--TestGenerics--");
            TestGenerics();
            Console.WriteLine("\n\n--VergelijkStrings--");
            VergelijkStrings();

            #region footer

            Console.WriteLine("\n\nDruk om te stoppen...");
            Console.ReadKey();

            #endregion footer
        }

        #region Value types

        private static void TestValueTypes()
        {
            PersoonS p1 = new PersoonS() { Naam = "Peter" };
            PersoonS p2 = new PersoonS() { Naam = "Peter" };
            PersoonS p3 = new PersoonS() { Naam = "Post" };
            Console.WriteLine($"p1-Peter == p2-Peter: {p1 == p2}");
            Console.WriteLine($"p1-Peter != p2-Peter: {p1 != p2}");
            Console.WriteLine($"p1-Peter == p3-Post: {p1 == p3}");
            Console.WriteLine($"p1-Peter == p3-Post: {p1 != p3}");
        }

        #endregion Value types

        #region Reference types

        private static void TestReferenceTypes()
        {
            PersoonC p1 = new PersoonC() { Naam = "Peter" };
            PersoonC p2 = new PersoonC() { Naam = "Peter" };
            PersoonC p3 = new PersoonC() { Naam = "Post" };
            Console.WriteLine($"p1-Peter == p2-Peter: {p1 == p2}");
            Console.WriteLine($"p1-Peter != p2-Peter: {p1 != p2}");
            Console.WriteLine($"p1-Peter == p3-Post: {p1 == p3}");
            Console.WriteLine($"p1-Peter == p3-Post: {p1 != p3}");
        }

        #endregion Reference types

        #region Generics

        private static void TestGenerics()
        {
            PersoonC p1 = new PersoonC() { Naam = "Peter" };
            PersoonC p2 = new PersoonC() { Naam = "Peter" };
            GenericsVergelijking(p1, p2);
            GenericsVergelijkingEquals(p1, p2);
        }

        private static void GenericsVergelijking<T>(T obj1, T obj2) where T : class
        {
            Console.WriteLine($"obj1==obj2: {obj1 == obj2}");
        }

        private static void GenericsVergelijkingEquals<T>(T obj1, T obj2)
        {
            Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
        }

        #endregion Generics

        #region Strings

        private static void VergelijkStrings()
        {
            string woord1 = "Programmeren";
            string woord2 = "Programmeren";
            Console.WriteLine($"woord1 == woord2 {woord1 == woord2}");
        }

        #endregion Strings
    }
}