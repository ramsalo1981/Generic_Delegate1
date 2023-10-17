namespace CAGenericDelegate
{
    //___________________________(3)___________________________
    //public delegate bool Filter(int n);
    //___________________________(4)___________________________
    public delegate bool Filter<in T>(T n);
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //___________________________(1)___________________________
            //Console.WriteLine("Numbers less than 6: ");
            //PrintLessThanSix(list1);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Numbers less than 7: ");
            //PrintLessThanSeven(list1);


            //___________________________(2)___________________________
            //Console.WriteLine("Numbers less than 6: ");
            //PrintLessThan(list1, 6);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Numbers less than 7: ");
            //PrintLessThan(list1, 7);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Even numbers: ");
            //PrintEvenNumber(list1);

            //___________________________(3)___________________________
            //Console.WriteLine("Numbers less than 6: ");
            //PrintNumber(list1, n => n < 6);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Numbers less than 7: ");
            //PrintNumber(list1, n => n < 7);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Even numbers: ");
            //PrintNumber(list1, n => n % 2 == 0);

            //___________________________(4)___________________________
            Console.WriteLine("Numbers less than 6: ");
            PrintNumber(list1, n => n < 6);
            Console.WriteLine("\n\n");
            Console.WriteLine("Numbers less than 7: ");
            PrintNumber(list1, n => n < 7);
            Console.WriteLine("\n\n");
            Console.WriteLine("Even numbers: ");
            PrintNumber(list1, n => n % 2 == 0);

            IEnumerable<decimal> list2 = new decimal[] { 1.43m, 2.55m, 3.64m, 4.31m, 5.7m, 6.94m, 7.15m, 8.53m, 9.82m };
            Console.WriteLine("\n\nNumber greater than or equal 3.7: ");
            PrintNumber(list2, n => n >= 3.7m);

            Console.ReadKey();

        }

        //___________________________(1)___________________________
        //public static void PrintLessThanSix(IEnumerable<int> list)
        //{
        //    foreach (var n in list)
        //    {
        //        if (n < 6) Console.Write($" {n}");
        //    }
        //}

        //public static void PrintLessThanSeven(IEnumerable<int> list)
        //{
        //    foreach (var n in list)
        //    {
        //        if (n < 7) Console.Write($" {n}");
        //    }
        //}

        //___________________________(2)___________________________
        //public static void PrintLessThan(IEnumerable<int> list ,int pivotNumber)
        //{
        //    foreach (var n in list)
        //    {
        //        if (n < pivotNumber) Console.Write($" {n}");
        //    }
        //}

        //public static void PrintEvenNumber(IEnumerable<int> list)
        //{
        //    foreach (var n in list)
        //    {
        //        if (n % 2 == 0) Console.Write($" {n}");
        //    }
        //}



        //___________________________(3)___________________________
        //public static void PrintNumber(IEnumerable<int> list, Filter filter)
        //{
        //    foreach (var n in list)
        //    {
        //        if (filter(n))
        //        {
        //            Console.Write($" {n}");

        //        }
        //    }
        //}

        //___________________________(4)___________________________
        public static void PrintNumber<T>(IEnumerable<T> list, Filter<T> filter)
        {
            foreach (var n in list)
            {
                if (filter(n))
                {
                    Console.Write($" {n}");

                }
            }
        }
    }
}