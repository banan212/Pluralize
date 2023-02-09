namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            int a0 = count % 10;
            int a1 = (count / 10) % 10;

            if (a1 == 1)
                return "рублей";
            else

                if (a0 == 1)
                return "рубль";
            else if (a0 > 1 & a0 < 5)
                return "рубля";
            else return "рублей";




        }
    }
}

			