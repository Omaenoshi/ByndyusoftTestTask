using ByndyusoftTestTask.Library;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ByndyusoftTestTask.Test
{
    public class ArrayUtility_SumTwoMinsInArrayShould
    {
        [Test]
        public void SumTwoMinsInArray_Input153_Return4()
        {
            var result = ArrayUtility.SumTwoMinsInArray([ 1, 5, 3]);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void SumTwoMinsInArray_InputSingle1_ReturnArgumentException()
        {
            var array = new int[] { 1 };

            Assert.Throws<ArgumentException>(() => ArrayUtility.SumTwoMinsInArray(array));
        }

        [Test]
        public void SumTwoMinsInArray_InputNull_ReturnArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ArrayUtility.SumTwoMinsInArray(null));
        }

        [Test]
        public void SumTwoMinsInArray_InputEmpty_ReturnArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ArrayUtility.SumTwoMinsInArray([]));
        }

        [Test]
        public void SumTwoMinsInArray_InputMillionNumbers_Return1()
        {
            int[] array = new int[100000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Assert.That(ArrayUtility.SumTwoMinsInArray(array), Is.EqualTo(1));
        }

        [Test]
        public void SumTwoMinsInArray_InputNegatives462_ReturnNegative10()
        {
            var array = new int[] { -4, -6, -2 };

            Assert.That(ArrayUtility.SumTwoMinsInArray(array), Is.EqualTo(-10));
        }
    }
}