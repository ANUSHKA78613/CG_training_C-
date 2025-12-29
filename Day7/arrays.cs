using System;
class Arrays
{
    public static void Index()
    {
        // int[] a1;
        // int[] a2 = new int[5];
        // int[] a3 = {10,20,30,40};
        // foreach(int i in a3)
        // {
        //     Console.WriteLine(i);
        // }
        // int[,] matrix = {{1,2,5},{3,4,8}};
        // for(int i = 0; i < matrix.GetLength(0); i++)  // getlength due to jagged arrays as they have diff length
        // {
        //     for(int j = 0; j < matrix.GetLength(1); j++)   
        //     {
        //         Console.Write(matrix[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        // jagged arrays
        // int[][] jagged= new int[2][];
        // jagged[0] = new int[] {1,2};
        // jagged[1] = new int[] {3,4,5};
        // Console.WriteLine(jagged[1][2]);
        // for(int i = 0; i < jagged.Length; i++) // getlength will not work as size is not fixed
        // { 
        //     for(int j = 0; j < jagged[i].Length; j++)
        //     {
        //         Console.Write(jagged[i][j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        //    int[] a3 = {10,20,30,40};
        //    Array.Clear(a3,1,2); (a3,0=1,a3.length) will not work 
        //    foreach(int i in a3)
        // {
        //     Console.WriteLine(i);
        // }

    //     int[] src = {1,2,3};
    //     int[] dest = new int[3];
    //     Array.Copy(src,dest,1);
    //    // Array.Copy(src,dest,3);
    //     foreach(int i in dest)
    //     {
    //         Console.Write(i);
    //     }

//     int [] nums = {1,2};
//     Array.Resize(ref nums,4); 
//    //Array.Resize(nums,4);      without ref it will not work
//    Array.Resize(ref nums,1);
//     foreach(int x in nums)
//         {
//             Console.Write(x+" ");
//         }
        int[] arr = {25,33,455,565,77};
        bool found = Array.Exists(arr,x=>x<25);
        Console.WriteLine(found);
    }
}