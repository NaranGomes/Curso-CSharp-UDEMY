namespace modificador_ref_out
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Double(int origin, out int result)
        {
            result = origin * 2;
        }
    }
}
