🧮 C# Arrays (.NET 9)

This console app explores array operations in C# using .NET 9, including:

- Declaring arrays
- Accessing and modifying elements
- Working with strings and characters
- Multi-dimensional arrays
- Understanding null characters and default values

---

## 🧾 Code Highlights

```csharp
string[] arrayOfStrings = { "how", "now", "brown", "cow" };
int[] arrayOfInts = new int[5];
char[] arrayOfLetters = new char[0];

// Assign from string
string cowColor = arrayOfStrings[2]; // "brown"
arrayOfLetters = new char[cowColor.Length];

arrayOfLetters[0] = 'c';
arrayOfLetters[1] = cowColor[1]; // 'r'
arrayOfLetters[2] = cowColor[2]; // 'o'

// Output array
Console.WriteLine(arrayOfLetters);      // prints as string -> cro??
Console.WriteLine(arrayOfLetters[3]);   // prints null char '\0'
```

---

## ♟ Multi-Dimensional Array

```csharp
int[,] checkers = new int[4, 4];

checkers[0, 0] = 1;
checkers[0, 1] = 2;
checkers[1, 0] = 3;
checkers[1, 1] = 4;

// Print 4x4 grid
for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    {
        Console.Write($"{checkers[row, col]} ");
    }
    Console.WriteLine();
}
```

---

## ✅ Key Learnings

- Arrays must be initialized before use.
- Default values for arrays are type-specific (`0`, `\0`, `null`).
- Strings are internally arrays of `char`.
- Indexing starts at 0.
- You can use variables (even array elements) as indexes.
- Multi-dimensional arrays are accessed using `[i, j]` syntax.

---

