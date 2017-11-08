namespace Common
{
    public class MathHelper
    {
        public int Factoriel(int number)
        {
            if (number > 1)
            { 
                return number * Factoriel(number - 1);
            }
            else 
            {
                return 1;
            }
        }
    }
}