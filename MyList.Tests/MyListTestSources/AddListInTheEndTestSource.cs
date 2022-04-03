using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayList;

namespace MyList.Tests.MyListTestSources
{
    public class AddListInTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList extraList = new AList(new int[] {55,44,33});
            AList list = new AList(new int[] { 5, 4, 3 });
            AList expectedList = new AList(new int[] { 5, 4, 3, 55, 44, 33 });
            yield return new object[] { extraList, list, expectedList };

            extraList = new AList(new int[] {  });
            list = new AList(new int[] { 5, 4, 3 });
            expectedList = new AList(new int[] { 5, 4, 3 });
            yield return new object[] { extraList, list, expectedList };
            
            extraList = new AList(new int[] { });
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { });
            yield return new object[] { extraList, list, expectedList };
            
            extraList = new AList(new int[] { 5 });
            list = new AList(new int[] { });
            expectedList = new AList(new int[] { 5 });
            yield return new object[] { extraList, list, expectedList };
        }
    }
}
