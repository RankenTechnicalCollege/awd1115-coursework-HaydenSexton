bool exit = false;
Dictionary<string, string> phoneBook = new();
phoneBook.Add("Evan", "123-456-7890");
phoneBook.Add("Jane", "456-789-1240");
phoneBook.Add("Doe", "789-460-1234");

do
{
    Console.WriteLine("\n 1. Add Contact \n 2. View Contact \n 3. Edit Contact \n 4. Delete Contact \n 5. List all contacts \n 6. Exit");
    Console.Write("Enter Choice:");
    string? choice = Console.ReadLine();

    // Exit Loop
    if (choice.Equals("6"))
    {
        exit = true;
    } 

    // Add Contact
    else if (choice.Equals("1"))
    {
        Console.Write("Enter Name:");
        string name = Console.ReadLine();

        Console.Write("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();
        phoneBook.Add(name, phoneNumber);   
    }

    // View specific contact
    else if (choice.Equals("2"))
    {
        Console.Write("Enter Name:");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"\n Name: {name} \n Phone Number: {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    // Edit contact
    else if (choice.Equals("3"))
    {
        Console.Write("Enter Name:");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.Write("Enter new phone number:");
            string phoneNumber = Console.ReadLine();
            phoneBook[name] = phoneNumber;
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    // Delete contact
    else if (choice.Equals("4"))
    {
        Console.Write("Enter Name:");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
    
    // List all contacts
    else if (choice.Equals("5"))
    {
        foreach (KeyValuePair<string, string> contact in phoneBook)
        {
            Console.WriteLine($"------------------------------\n Name: {contact.Key} \n Phone Number: {contact.Value}");
            Console.WriteLine("------------------------------");
        }
    }

} while (exit == false);