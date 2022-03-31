using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class DeleteFewElementsFromTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 3;
            AList list = new AList(new int[] { 2, 3, 6, 9, 8 });
            AList expectedList = new AList(new int[] { 2, 3 });
            yield return new object[] { amount, list, expectedList };
            
            amount = 0;
            list = new AList(new int[] { 2, 3 });
            expectedList = new AList(new int[] { 2, 3 });
            yield return new object[] { amount, list, expectedList };
            
            amount = 1;
            list = new AList(new int[] { 2 });
            expectedList = new AList(new int[] { });
            yield return new object[] { amount, list, expectedList };


        }
    }
}
