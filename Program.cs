class Program
{
    private static void Main(string[] args)
    {
        //khai bao mang
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(myArray[i] + " ");
        }

        //tim phan tu co trong mang
        int index = 0;
        Console.WriteLine("Nhap phan tu vao index: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == x)
            {
                index = i;
            }
        }
        //chen phan tu da nhap vao vi tri index
        for (int i = index; i < myArray.Length - 1; i++)
        {
            myArray[i] = myArray[i + 1];
        }
        //thay doi kich thuoc mang
        Array.Resize(ref myArray, myArray.Length - 1);
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }
    }
}