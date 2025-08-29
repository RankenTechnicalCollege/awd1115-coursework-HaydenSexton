
string ccNumber;
string maskedNumber = String.Empty;

do
{
    Console.WriteLine("Enter a CC number:");
    ccNumber = Console.ReadLine();
} while (String.IsNullOrEmpty(ccNumber));

int i = 0;
foreach (char c in ccNumber)
{ 
    if (i <= ccNumber.Length - 5)
    {
        if (c == '-')
        {
            maskedNumber += "-";
        }
        else if (c == ' ')
        {
            maskedNumber += " ";
        }
        else
        {
            maskedNumber += "X";
        }
    }
    else
    {
        maskedNumber += c;
    }

    i++;
}

Console.WriteLine(maskedNumber);
