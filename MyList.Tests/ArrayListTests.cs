using NUnit.Framework;
using System.Collections;
using MyArrayList;


namespace MyList.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(DeleteEveryElementByValueTestSource))]
        public void DeleteEveryElementByValueTest(int value, AList list, AList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteEveryElementByValue(value);

            AList arrayList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, arrayList);
        }

        [TestCaseSource(typeof(AddLastTestSource))]

        public void AddLastTest(int value, AList list, AList expectedList)
        {
            list.AddLast(value);

            AList arrayList = list;

            Assert.AreEqual(expectedList, arrayList);
        }
    }

    public class DeleteEveryElementByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            AList list = new AList(new int[] { 1, 2, 3, 4, 5 });
            AList expectedList = new AList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };

            value = 2;
            list = new AList(new int[] { 5, 7, 3, 99, 5 });
            expectedList = new AList(new int[] { 5, 7, 3, 99, 5 });
            expectedNumber = 0;
            yield return new object[] { value, list, expectedList, expectedNumber };

            value = 16;
            list = new AList(new int[] { 16, 85, 9, 16, 16 });
            expectedList = new AList(new int[] { 85, 9});
            expectedNumber = 3;
            yield return new object[] { value, list, expectedList, expectedNumber };

        }
    }

    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 15;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 15, 18, 19, 25, 15 });
            yield return new object[] { value, list, expectedList };

            value = -80;
            list = new AList(new int[] {});
            expectedList = new AList(new int[] { -80 });
            yield return new object[] { value, list, expectedList };

            value = 8;
            list = new AList(new int[] { 4 });
            expectedList = new AList(new int[] { 4, 8 });
            yield return new object[] { value, list, expectedList };
        }
    }
}