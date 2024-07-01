using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Common_Elements
{
    public class CommonElemnts
    {
        public static List<int> CommonElements(int[] arr1 , int[] arr2) {
            List <int> result = new List <int>();
            for (int i = 0; i < arr1.Length; i++)
            {
              for (int j = 0; j < arr2.Length; j++) {
                    if (arr1[i] == arr2[j]) {
                        result.Add(arr1[i]);
                    }
                    }
            }
            return result;
        }
    }
}
