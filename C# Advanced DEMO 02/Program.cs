namespace C__Advanced_DEMO_02
{
    internal class Program
    {
        //public static int Sumarraylist(ArrayList x) 
        //{
        //    int sum = 0;
        //    if (x is not null) 
        //    {

        //        for (int i = 0; i < x.Count - 1; i++)
        //        {
        //            sum +=(int) x[i];

        //        }
        //    }
        //    return sum;

        //}

        static void Main(string[] args)
        {
            #region Non Generics-collection
            //ArrayList arraylist = new ArrayList();
            //Console.WriteLine($"the the count of ArrayList: {arraylist.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arraylist.Capacity}");
            //arraylist.Add(1);
            //As soon as I add the first element to the ArrayList, the default capacity is 4
            //New Array Created At Heap with Size 4
            //Console.WriteLine($"After we add the first element");
            //Console.WriteLine($"the the count of ArrayList: {arraylist.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arraylist.Capacity}");
            //arraylist.Add(2);
            //arraylist.AddRange(new int[] { 3, 4});
            //Console.WriteLine($"After we add the first element");
            //Console.WriteLine($"the the count of ArrayList: {arraylist.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arraylist.Capacity}");
            //arraylist.Add(5);
            //Console.WriteLine($"After we add the first element");
            //Console.WriteLine($"the the count of ArrayList: {arraylist.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arraylist.Capacity}");

            //ArrayList arrayList02 = new ArrayList(5) {1,2,3,4,5};
            //Console.WriteLine($"the the count of ArrayList: {arrayList02.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arrayList02.Capacity}");
            //arrayList02.Add(6);
            //Console.WriteLine($"AfteR WE ADDING THE six Element");
            //Console.WriteLine($"the the count of ArrayList: {arrayList02.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {arrayList02.Capacity}");
            //----------------------------------------------------
            // deallocate unused Byte
            //arrayList02.TrimToSize();
            //Console.WriteLine($"the the count of ArrayList: {arrayList02.Count}");//6
            //Console.WriteLine($"the the Capacity of ArrayList: {arrayList02.Capacity}");//6
            //create a new Array at heap with size = Count of element
            // arrayList02.Add(7); //casting from valuetype to reference type
            //Boxing

            //arrayList02.Add("Ebram"); // Arraylist02 ==> Hetrogenous list
            //foreach (var item in arrayList02)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(Sumarraylist(arrayList02));
            #endregion

            #region Generic collection [list]
            //List<int> list = new List<int>();
            //Console.WriteLine($"the the count of ArrayList: {list.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {list.Capacity}");
            //list.Add(1);

            //Console.WriteLine($"After Adding Elemetn");
            //Console.WriteLine($"the the count of ArrayList: {list.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"After Trim");
            //Console.WriteLine($"the the count of ArrayList: {list.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {list.Capacity}");

            //List<int>list02= new List<int>() ;
            //list02.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"the the count of ArrayList: {list02.Count}");
            //Console.WriteLine($"the the Capacity of ArrayList: {list02.Capacity}");

            //List<int> list03= new List<int>(5) { 1,2,3,4,5};
            //Console.WriteLine($"the the count of ArrayList: {list03.Count}");//5
            //Console.WriteLine($"the the Capacity of ArrayList: {list03.Capacity}");//5
            //list03.Add(6);
            //Console.WriteLine($"the the count of ArrayList: {list03.Count}");//6
            //Console.WriteLine($"the the Capacity of ArrayList: {list03.Capacity}");//10

            //list03[0] = 198;
            //foreach (int i in list03) Console.WriteLine(i);


            #endregion

            #region List Method
            //List<int> numbers = new List<int>();
            //numbers.Add(1); //to add element
            //numbers.AddRange(new int[] {2,3,4 }); //to addRange of element
            //numbers.Insert(0, 5);//Insert Element to specific  index;
            //numbers.InsertRange(1, new int[] {6,7,8});//Insert Element to specific  index;
            //numbers.Clear();//remove all elemet in my list

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> numbers02 = new List<int>(4) {1,2,3,4 };
            //numbers02.BinarySearch(4);//Binary search in my List
            //bool x=  numbers02.Contains(8);
            //Console.WriteLine(x);
            //Console.WriteLine(numbers02.EnsureCapacity(8));// Increase Capacity
            //Console.WriteLine(numbers02.IndexOf(1));
            //Console.WriteLine(numbers02.LastIndexOf(2));






            #endregion
        }
    }
}
