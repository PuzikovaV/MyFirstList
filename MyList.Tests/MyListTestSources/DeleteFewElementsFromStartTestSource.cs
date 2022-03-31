using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFewElementsFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 3;
            AList list = new AList(new int[] { 5, 9, 50, 26 });
            AList expectedList = new AList(new int[] { 26 });
            yield return new object[] { amount, list, expectedList };

            amount = 2;
            list = new AList(new int[] { 9, 50, 26 });
            expectedList = new AList(new int[] { 26 });
            yield return new object[] { amount, list, expectedList };

        }
    }
}
