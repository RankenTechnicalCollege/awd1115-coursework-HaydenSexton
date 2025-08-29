
int rows;
int cols;
bool isValid;


do
{
    Console.WriteLine("How many rows should the multiplcation table have?");
    isValid = int.TryParse(Console.ReadLine(), out rows);
} while (!isValid);

do
{
    Console.WriteLine("How many columns should the multiplication table have?");
    isValid = int.TryParse(Console.ReadLine(), out cols);
} while (!isValid);

for (int row = 0; row <= rows; row++)
{
    // first row, display the amount of columns wanted
    if (row == 0)
    {
        // empty space for the corner slot
        Console.Write($"{"",6} |");

        for (int col = 1; col <= cols; col++)
        {
            Console.Write($"{col,6} |");
        }

        Console.WriteLine();
        // creates a line based on the length of the cols variable
        Console.Write(new string('-', 8 * (cols + 1)));
        Console.WriteLine();
    }
    else
    {
        Console.Write($"{row,6} |");
        for (int col = 1; col<= cols; col++)
        {
            Console.Write($"{row * col,6} |");
        }

        // makes a space (line break)
        Console.WriteLine();
    }
}