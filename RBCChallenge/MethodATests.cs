using System;
using Xunit;

namespace XUnitTestProject1
{
    public class MethodATests
    {
        private const int OptionOne = 1;
        private const int OptionTwo = 2;

        [Theory, CombinatorialData]
        public void Test1(bool first, bool second, bool third)
        {
            var actual = AMethodSimplyfied(first, second, third);
            var expected = AMethod(first, second, third);

            Assert.Equal(actual, expected);
        }

        public int AMethodSimplyfied(bool first, bool second, bool third)
        {
            if (!first)
            {
                return OptionOne;
            }
            else if (!second || !third)
            {
                return OptionTwo;
            }

            return OptionOne;
        }

        public int AMethod(bool first, bool second, bool third)
        {
            if (!first)
            {
                if (second)
                {
                    if (third)
                    {
                        return OptionOne;
                    }
                    else if (!second)
                    {
                        return OptionTwo;
                    }
                    else
                    {
                        return OptionOne;
                    }
                }
                else
                {
                    return OptionOne;
                }
            }
            else if (!third)
            {
                if (!second)
                {
                    return OptionTwo;
                }
            }
            else if (!second)
            {
                return OptionTwo;
            }
            if (!(third || !second))
            {
                return OptionTwo;
            }
            return OptionOne;
        }

    }
}
