    Console.WriteLine("----> First List <----");
    var names = new List<string> {"otabek", "anna", "john", "bruno"};
    int k = 0;
    foreach(var name in names)
    {
        Console.WriteLine($"{k}. {name.ToUpper()}!");
        k++;
    }

    k = 0;
    names.Add("frank");
    names.Add("henry");
    names.Add("emma");

    Console.WriteLine();
    Console.WriteLine("----> New List <----");
    foreach(var name in names)
    {
        Console.WriteLine($"{k}. {name.ToUpper()}");
        k++;
    }

        Console.WriteLine($"\nMy nam is {names[0].ToUpper()}");
        Console.WriteLine($"I've added {names[4].ToUpper()}, {names[5].ToUpper()} and {names[6].ToUpper()} to the List");
        Console.WriteLine($"\nThe List has {names.Count} people in it\n");

        var index = names.IndexOf("john");
        if(index != -1)
        Console.WriteLine($"The name {names[index].ToUpper()} is at index {index}");

        var index1 = names.IndexOf("Alice");
        Console.WriteLine($"Alice dosen't exist in the List. return: {index1}\n");

        Console.WriteLine("----> Sorted List <----");
        names.Sort();
        k = 0;
        foreach (var name in names)
        {
           Console.WriteLine($"{k}. {name.ToUpper()}"); 
           k++;
        }