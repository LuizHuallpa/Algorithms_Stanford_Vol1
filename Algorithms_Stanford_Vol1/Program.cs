using Algorithms_Stanford_Vol1;

//Quick Find and Quick Union

int N = int.Parse(Console.ReadLine());

// Create a QuickUnionUF instance
QuickUnionUF uf = new QuickUnionUF(N);

// Read pairs of integers from standard input until there is no more input
while (true)
{
    // Read p and q from standard input
    string[] input = Console.ReadLine().Split();
    if (input.Length < 2) break; // Exit loop if there is no more input

    int p = int.Parse(input[0]);
    int q = int.Parse(input[1]);

    // Check if p and q are connected
    if (!uf.Connected(p, q))
    {
        // If not, connect them and print the pair
        uf.WeightedUnion(p, q);
        Console.WriteLine(p + " " + q);
    }
}


