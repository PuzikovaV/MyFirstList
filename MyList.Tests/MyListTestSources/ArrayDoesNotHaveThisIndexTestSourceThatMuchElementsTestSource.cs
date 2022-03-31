using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ArrayDoesNotHaveThisIndexTestSourceThatMuchElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 5;
            AList list = new AList(new int[] { 5, 2, 6, 9 });
            yield return new object[] { amount, list };

            amount = 5;
            list = new AList(new int[] { 4, 2 });
            yield return new object[] { amount, list };
        }
    }
}
