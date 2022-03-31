using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class ArrayDoesNotHaveThisIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 155;
            int value = 56;
            AList list = new AList(new int[] { 15, 16, 2 });
            yield return new object[] {index, value, list};

            index = 0;
            value = 5;
            list = new AList(new int[] { });
            yield return new object[] { index, value, list };

            index = -2;
            value = 5;
            list = new AList(new int[] { 5, 1, 6, 8, 9 });
            yield return new object[] { index, value, list };
        }
    }
}
