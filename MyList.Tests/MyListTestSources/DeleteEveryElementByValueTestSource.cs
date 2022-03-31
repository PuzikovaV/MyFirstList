using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
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
            expectedList = new AList(new int[] { 85, 9 });
            expectedNumber = 3;
            yield return new object[] { value, list, expectedList, expectedNumber };

        }
    }
}
