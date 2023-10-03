//listid võimaldavad salvestada mitu andme tükki ühes kastis. salvestada saab ainult ühe tüüpi andmeid . listid on paindlikumad kui massiivid, saab juurde lisada nt. 
//esiteks loome listi andmetega, mida hiljem soovime salvestada faili

string folderPath = @"C:\DATA";
string fileName ="shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();   

if (File.Exists(filePath))

{
     myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);

}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} file has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}


static List<string> GetItemsFromUser()

{

    List<string> userList = new List<string>();

    while (true)

    {
        Console.Write("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine(); //userchoice muutuja

        if (userChoice == "add")
        {

            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();//userItem muutuja
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userList;
}


static void ShowItemsFromList(List<string> someList)
{

     Console.Clear();

     int listLength = someList.Count; //shoppinglist käitub samamoodi nagu massiiv , esimene element kohal 0,siis 1 jne. 
     Console.WriteLine($"You have added {listLength} items toy your shopping list. ");

      int i = 1; //nummerdab loetelu , 1 2 3 jne. //i deklareeritud väljaspool foreachi . foreach teeb tööd ühele itemile. 
      foreach (string item in someList)

{
    Console.WriteLine($"{i}.{item}");
    i++;


}



}