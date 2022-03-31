using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFewElementsFromTheEndWithAmountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 2;
            AList list = new AList(new int[] { 5, 4, 6, 8 });
            AList expectedList = new AList(new int[] { 5, 4 });
            yield return new object[] { amount, list, expectedList };

            amount = 3;
            list = new AList(new int[] { 4, 6, 8 });
            expectedList = new AList(new int[] { });
            yield return new object[] { amount, list, expectedList };
        }
    }
}
