using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ArrayIsEmptyWithAmountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int amount = 10;
            AList list = new AList(new int[] { });
            yield return new object[] { amount, list };

            amount = 6;
            list = new AList(new int[] { });
            yield return new object[] { amount, list };
        }
    }
}
