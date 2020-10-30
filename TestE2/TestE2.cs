using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using E2_E3_week_6b;
namespace TestE2
{
    public class Tests
    {

        [Test]
        [TestCase(new int[]{1,2,3,4,5}, new int[]{5,4,3,2,1})]
        [TestCase(new int[]{}, new int[]{})]
        [TestCase(new int[]{99}, new int[]{99})]
        public void Test_Reverse_Array(int[] intarray, int[] result)
        {
            ArrayTools.ReverseArray(intarray);
            Assert.AreEqual(result, intarray);
        }


        [Test]
        [TestCase(new int[]{ 1, 2, 3, 4, 5}, 2)]
        [TestCase(new int[]{ -4,0,4}, 3)]
        [TestCase(new int[]{ }, 0)]
        [TestCase(new int[]{ 1,3,5,7}, 0)]
        public void Test_Event_Amount_Array(int[] intarray, int result)
        {
            Assert.AreEqual(result, ArrayTools.AmountOfEven(intarray));
        }


        [Test]
        [TestCase(5, new int[]{0,1,2,3,4})]
        [TestCase(1, new int[]{0})]
        [TestCase(0, new int[]{})]
        public void Test_Create_Array(int input, int[] result)
        {
            Assert.AreEqual( result, ArrayTools.CreateArray(input));
        }

        [Test]
        [TestCase(new int[] {1, 2, 3}, new int[] {2, 4, 8}, 2)]
        [TestCase(new int[] {1, 1, 1, 1}, new int[] {-1, 0, 1, 2}, 4)]

        public void Test_Difference_Count(int[] array1, int[] array2, int result)
        {
            Assert.AreEqual(result, ArrayTools.CountDifference(array1, array2));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 4, 8, 5 })]
        [TestCase(new int[] { 1, 1, 1, 1, 6 }, new int[] { -1, 0, 1, 2 })]
        public void ShouldThrow_Exception(int[] array1, int[] array2)
        {
            //Assert.Throws(typeof(Exception), () => ArrayTools.CountDifference(array1, array2)); //without message
            Assert.Throws<Exception>(() => ArrayTools.CountDifference(array1, array2)); //also without message choose this or the line above
            //Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Arrays are not the same length"), () => ArrayTools.CountDifference(array1, array2)); //with message
        }

        [Test]
        [TestCase(new int[] { 1, 2, 1, 3 }, 1, true)]
        [TestCase(new int[] { 1, 2, 1, 3 }, 2, false)]
        [TestCase(new int[] { 1, 2, 1, 3, 4 }, 1, false)]
        public void Test_IfOverall_isTrue(int[] array, int value, bool result)
        {
            Assert.AreEqual(result, ArrayTools.IsOveral(array, value));
        }

        [Test]
        [TestCase(new int[] {1, 2, 1, 3}, false)]
        [TestCase(new int[] {1, 2, 2, 3}, true)]
        [TestCase(new int[] {2, 2, 2, 3, 2, 2}, true)]
        public void Test_Two(int[] array, bool result)
        {
            Assert.AreEqual(result, ArrayTools.Two(array));
        }
    }
}