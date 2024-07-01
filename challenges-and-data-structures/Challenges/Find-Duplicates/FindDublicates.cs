using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Find_Duplicates
{
    internal class FindDublicates
    {
        public static int [] FindDublicatess(int [] arr) {
            int[] arrN = new int[arr.Length];
            int count = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                bool isAlreadyAdded = false;
                for (int j = 0; j < arr.Length; j++) {
                    if (arr[i] == arr[j])
                    {
                        for (int k = 0; k < count; k++)
                        {
                            if (arrN[k] == arr[i])
                            {
                                isAlreadyAdded = true;
                                break;
                            }
                        }
                        if (!isAlreadyAdded)
                        {
                            arrN[count] = arr[i];
                            count++;
                        }
                    }
                    }
                }
            
        
            int[]arr3=new int[count];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arrN[i];
            }

            return arr3;
        }
}
    }

