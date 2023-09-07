using System;


namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool m = true;
            Console.WriteLine($"bool\tM = {m}\t{typeof(bool)}");
            byte a = 12;
            Console.WriteLine($"byte\tA = {a}\t{typeof(byte)}\t{byte.MaxValue}\t{byte.MinValue}");
            sbyte b = 12;
            Console.WriteLine($"sbyte\tB = {b}\t{typeof(sbyte)}\t{sbyte.MaxValue}\t{sbyte.MinValue}");
            short c = 12;
            Console.WriteLine($"short\tC = {c}\t{typeof(short)}\t{short.MaxValue}\t{short.MinValue}" );
            ushort d = 12;
            Console.WriteLine($"ushort\tD = {d}\t{typeof(ushort)}\t{ushort.MaxValue}\t{ushort.MinValue}");
            int e = 12;
            Console.WriteLine($"int\tE = {e}\t{typeof(int)}\t{int.MaxValue}\t{int.MinValue}");
            uint f = 12;
            Console.WriteLine($"unit\tF = {f}\t{typeof(uint)}\t{uint.MaxValue}\t{uint.MinValue}"    );
            long g = 12;
            Console.WriteLine($"long\tG = {g}\t{typeof(long)}\t{long.MaxValue}\t{long.MinValue}");
            ulong h = 12;
            Console.WriteLine($"ulong\tH = {h}\t{typeof(ulong)}\t{ulong.MaxValue}\t{ulong.MinValue}");
            decimal i = 123.34m;
            Console.WriteLine($"decimal\tK = {i}\t{typeof(decimal)}\t{decimal.MaxValue}\t{decimal.MinValue}");
            float j = 123.34f;
            Console.WriteLine($"float\tI = {j}\t{typeof(float)}\t{float.MaxValue}\t{float.MinValue}");
            double k = 123.34;
            Console.WriteLine($"double\tJ = {k}\t{typeof(double)}\t{double.MaxValue}\t{double.MinValue}" );
            char l = 'f';
            Console.WriteLine($"char\tL = {l}\t{typeof(char)}");

           
            Console.ReadKey();
        }
    }
}
