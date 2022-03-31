using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFewElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int amount = 3;
            AList list = new AList(new int[] { 1, 2, 55, 63, 69 });
            AList expectedList = new AList(new int[] { 1, 2 });
            yield return new object[] { index, amount, list, expectedList };


            index = 1;
            amount = 2;
            list = new AList(new int[] { 88, 18, 99, 19 });
            expectedList = new AList(new int[] { 88, 19 });
            yield return new object[] { index, amount, list, expectedList };
        }
    }
}
