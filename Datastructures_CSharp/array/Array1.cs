using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Threading.Tasks;
using System.Collections;

namespace Datastructures_CSharp.array
{
    public class Array1
    {
        public static void Run()
        {
            //1D Array
            int[] arr1 = new int[5];
            int[] arr2 = new int[] { 1,2,3,4,5};
            int[] arr3 ={ 1,2,3,4,5};
            WriteLine(arr3[1]); //2
            foreach (int i in arr3)
            {
                Write("{0} ", i);
            }//1 2 3 4 5
            string.Join(" ", arr3);//1 2 3 4 5


            //2D Array
            int[,] arr4 = new int[2,3];
            int[,] arr5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] arr6 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            WriteLine(arr6[1, 1]);//4  //second row second column
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    WriteLine("Element({0},{1})={2}", i, j, arr5[i, j]);
                }
            }/* Output:
                    Element(0,0)=1
                    Element(0,1)=2
                    Element(1,0)=3
                    Element(1,1)=4
                    Element(2,0)=5
                    Element(2,1)=6
                    Element(3,0)=7
                    Element(3,1)=8
                */

            //3D Array
            int[,,] arr7 = new int[4,2,3];
            int[,,] arr9 = new int[2, 2, 3] { 
                        { { 1, 2, 3 }, { 4, 5, 6 } },
                        { { 7, 8, 9 }, { 10, 11, 12 } } 
            };
            WriteLine(arr9[1, 1, 2]); //12 //x=2,y=2,z=3

            int[,] arr10;
            arr10 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
            //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error
            arr10[2, 1] = 25; //ok

            //Jagged Array > array  of arrays.so this elemets are reference types.so default null
            int[][] arr11 = new int[3][];
            arr11[0] = new int[5];
            arr11[1] = new int[4];
            arr11[2] = new int[2];

            int[][] arr12 = new int[3][];
            arr12[0] = new int[] { 1, 3, 5, 7, 9 };
            arr12[1] = new int[] { 0, 2, 4, 6 };
            arr12[2] = new int[] { 11, 22 };
            for (int i = 0; i < arr12.Length; i++)
            {
                Write("Element({0})", i);
                for (int j = 0; j < arr12[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr12[i][j], j == (arr12[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            //Element(0): 1 3 5 7 9
            //Element(1): 2 4 6 8


            int[][] arr13 = new int[][]
            {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
            };

            int[][] arr14 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            //Mixed Jagged and Multidimentional Array
            int[][,] arr15 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };
            WriteLine(arr15[0][1, 0]);//5


            //Arrays are fixed length
            //dimension and length of array can't be changed once instantiated
            //default value of numeric array=0, reference elements initialized with default null
            //array index [0,1,....,n-1], lenght=n
            //elements can be any tpe including array tupe
            //Arrays are refrence type. (derived from abstract base type 'Array' and implemets IList<T> and IEnumerable<T>)
            //All the reference types(including the non-nullable), have the values null.
            //For nullable value types, HasValue is set to false and the elements would be set to null.

            //if we need bigger array sized than initialized then copy the array, delete and reinitialize new. to avoid this manual use LISt

            //----------------------------------------------------------------------------------------------------
            //Array PROPERTIES
            //Rank  >number of dimensions
            //Length >the total number of elements of the Array.
            //LongLength >the total number of elements in all the dimensions of the Array.
            //IsFixedSize >O(1) | true for Array, false for List.An array with a fixed size does not allow the addition or removal of elements after the array is created, but it allows the modification of existing elements.


            int[,] arr16 = new int[10, 3];
            _ = arr16.Rank;//2 
            _ = arr16.LongLength;//13  

            //A jagged array(an array of arrays) is a 1D array. so rank=1
            //-----
            int[] arr17 = new int[5];
            _ = arr17.Length;//5

            //-----------------------------------------------------------------------------------------------------
            //Array METHODS
            //CreateInstance(Type elementType, int length);
            //CreateInstance(Type,Int[]);
            //CreateInstance(Type,Int,Int);
            //CreateInstance(Type,Int[],Int[]);
            //CreateInstance(Type,Int,Int,Int);
            //GetLowerBound(int dimension) >Gets the index of the first element of the specified dimension in the array.
            //GetUpperBound(int dimension) >Gets the index of the last element of the specified dimension in the array.
            //SetValue()
            //GetValue()

            Array arr18 = Array.CreateInstance(typeof(int), 5);
            for (int i = arr18.GetLowerBound(0); i <= arr18.GetUpperBound(0); i++)
            {
                arr18.SetValue(i + 1, i);
            }
               
            IEnumerator arr18Enumerator = arr18.GetEnumerator();
            int i1 = 0;
            int cols = arr18.GetLength(arr18.Rank - 1);
            while (arr18Enumerator.MoveNext())
            {
                if (i1 < cols)
                {
                    i1++;
                }
                else
                {
                    Console.WriteLine();
                    i1 = 1;
                }
                Console.Write("\t{0}", arr18Enumerator.Current);
            }//1    2    3    4    5


            //4D ARray
            Array my4DArray = Array.CreateInstance(typeof(string), new int[4] { 2, 3, 4, 5 });

            //2D ARray
            Array my2DArray = Array.CreateInstance(typeof(string), 2, 3);
            for (int i = my2DArray.GetLowerBound(0); i <= my2DArray.GetUpperBound(0); i++)
                for (int j = my2DArray.GetLowerBound(1); j <= my2DArray.GetUpperBound(1); j++)
                    my2DArray.SetValue("abc" + i + j, i, j);
        }
    }
}
