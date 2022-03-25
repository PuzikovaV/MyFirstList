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

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, AList list, AList expectedList)
        {
            list.AddFirst(value);

            AList arrayList = list;

            Assert.AreEqual(expectedList, arrayList);
        }

        [TestCaseSource(typeof(InsertByIndexTestSource))]
        public void InsertByIndexTest(int value, int index, AList list, AList expectedList)
        {
            list.InsertByIndex(value, index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(AList list, AList expectedList)
        {
            list.DeleteLast();

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(AList list, AList expectedList)
        {
            list.DeleteFirst();

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, AList list, AList expectedList)
        {
            list.DeleteByIndex(index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFewElementsFromStartTestSource))]
        public void DeleteFewElementsFromStartTest(int amount, AList list, AList expectedList)
        {
            list.DeleteFewElementsFromStart(amount);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFewElementsFromTheEndTestSource))]
        public void DeleteFewElementsFromTheEndTest(int amount, AList list, AList expectedList)
        {
            list.DeleteFewElementsFromTheEnd(amount);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ShowValueByIndexTestSource))]
        public void ShowValueByIndexTest(int index, AList list, int expectedValue)
        {
            int actualValue = list.ShowValueByIndex(index);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCaseSource(typeof(ShowIndexByValueTestSource))]
        public void ShowIndexByValueTest(int value, AList list, int expectedIndex)
        {
            int actualIndex = list.ShowIndexByValue(value);

            Assert.AreEqual(expectedIndex, actualIndex);
    
        }

        [TestCaseSource(typeof(ChangeElementByIndexTestSource))]
        public void ChangeElementByIndexTest(int index, int value, AList list, AList expectedList)
        {
            list.ChangeElementByIndex(value, index);

            AList actualList = list;

            Assert.AreEqual(expectedList, actualList);

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

    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 2, 15, 18, 19, 25 });
            yield return new object[] { value, list, expectedList };

            value = 568;
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { 568 });
            yield return new object[] { value, list, expectedList };

            value = 19;
            list = new AList(new int[] { 4 });
            expectedList = new AList(new int[] { 19, 4 });
            yield return new object[] { value, list, expectedList };
        }
    }

    public class InsertByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            int index = 2;
            AList list = new AList(new int[] { 15, 18, 19, 25 });
            AList expectedList = new AList(new int[] { 15, 18, 2, 19, 25 });
            yield return new object[] { value, index, list, expectedList };

            value = 5;
            index = 0;
            list = new AList(new int[] { 7 });
            expectedList = new AList(new int[] { 5, 7 });
            yield return new object[] { value, index, list, expectedList };

            value = 19;
            index = 1;
            list = new AList(new int[] { 4, 8 });
            expectedList = new AList(new int[] { 4, 19, 8 });
            yield return new object[] { value, index, list, expectedList };
        }
    }

    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 5, 9, 20 });
            AList expectedList = new AList(new int[] { 1, 5, 9 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1, 5 });
            expectedList = new AList(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1 });
            expectedList = new AList(new int[] { });
            yield return new object[] { list, expectedList };

        }
    }

    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 5, 9, 20 });
            AList expectedList = new AList(new int[] { 5, 9, 20 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 4, 1 });
            expectedList = new AList(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new AList(new int[] { 1 });
            expectedList = new AList(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }

    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            AList list = new AList(new int[] { 1, 6, 8});
            AList expectedList = new AList(new int[] {1,6});
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new AList(new int[] { 1, 6, 8 });
            expectedList = new AList(new int[] { 6, 8 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new AList(new int[] { 5 });
            expectedList = new AList(new int[] { });
            yield return new object[] { index, list, expectedList };
        }
    }

    public class DeleteFewElementsFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 2;
            AList list = new AList(new int[] { 5, 9, 50, 26 });
            AList expectedList = new AList(new int[] { 50, 26 });
            yield return new object[] { amount, list, expectedList };

            amount = 2;
            list = new AList(new int[] { 9, 50, 26 });
            expectedList = new AList(new int[] { 26 });
            yield return new object[] { amount, list, expectedList };
        }
    }

    public class DeleteFewElementsFromTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 2;
            AList list = new AList(new int[] { 5, 4, 6, 8 });
            AList expectedList = new AList(new int[] { 5, 4 });
            yield return new object[] {amount, list, expectedList };

            amount = 3;
            list = new AList(new int[] { 4, 6, 8 });
            expectedList = new AList(new int[] { });
            yield return new object[] { amount, list, expectedList };
        }
    }

    public class ShowValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            AList list = new AList(new int[] { 88, 25, 6 });
            int expectedValue = 25;
            yield return new object[] { index, list, expectedValue };

            index = 5;
            list = new AList(new int[] { 15, 16, 6, 9, 7, 8 });
            expectedValue = 8;
            yield return new object[] { index, list, expectedValue };
        }
    }

    public class ShowIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            AList list = new AList(new int[] { 88, 6, 25, 5 });
            int expectedIndex = 3;
            yield return new object[] { value, list, expectedIndex };

            value = 88;
            list = new AList(new int[] { 88, 6, 25, 5 });
            expectedIndex = 0;
            yield return new object[] { value, list, expectedIndex };
        }
    }

    public class ChangeElementByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            int index = 2;
            AList list = new AList(new int[] { 15, 20, 36, 8 });
            AList expectedList = new AList(new int[] { 15, 20, 5, 8 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
}