﻿namespace ObservableNumberGenerator.Hybrid
{
    public class EvenNumbers : RandomNumbers
    {
        public EvenNumbers(int maxNumbersToGenerate,
            int startAfterMilliseconds = 1000, int generateEveryMilliseconds = 1000) :
            base(maxNumbersToGenerate, startAfterMilliseconds, generateEveryMilliseconds)
        { }

        protected override int GenerateNumber()
        {
            int n = _random.Next(0, 10);

            if (n % 2 != 0)
            {
                if (n + 1 > 10)
                    --n;
                else
                    ++n;
            }

            return n;
        }
    }
}
