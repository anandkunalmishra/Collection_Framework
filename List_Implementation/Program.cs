namespace collectionLibraries
{
    class List_Implementation
    {
        public void NonGenericWay()
        {
            //creating a List 
            List<int> list_data = new List<int>();

            //adding an object in List
            list_data.Add(7);  //adds element 5 to the list.

            list_data.Add(9);
            list_data.Add(10);
            list_data.Add(4);

            //checks whether the list has any element or not
            Console.WriteLine(list_data.Any()); // returns true or false

            //also adds a data in list
            list_data.Append(5);

            //Removes first occurence of the specific object from list
            list_data.Remove(7);

            //Remove at specific Index
            list_data.RemoveAt(0);

            //Remove at range (start_index,count)
            list_data.RemoveRange(0, 2);

            //Checks Whether 7 is present in the particular list or not.
            list_data.Contains(7);

            //Returns the total number of the element present in the List.
            list_data.Count();
        }

        public static void Main(String[] args)
        {
            List_Implementation obj = new List_Implementation();
            obj.NonGenericWay();


            Console.ReadLine();
        }
    }
}