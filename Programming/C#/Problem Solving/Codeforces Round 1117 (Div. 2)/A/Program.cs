int tc = int.Parse(Console.ReadLine());

while (tc-- > 0)
{
    string[] nm = Console.ReadLine()!.Trim().Split();
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);
    // Track which uppercase first-letters are currently in S
    var available = new HashSet<char>();
    // Read ordinary words (lowercase) — add their first letter
    for (int i = 0; i < n; i++)
    {
        string word = Console.ReadLine()!.Trim();
        available.Add(char.ToUpper(word[0]));
    }
    // Read the m abbreviations (already uppercase)
    string[] abbrevs = new string[m];
    for (int i = 0; i < m; i++)
        abbrevs[i] = Console.ReadLine()!.Trim().ToUpper();
    // Greedy: repeatedly process any abbreviation that is "ready"
    bool[] processed = new bool[m];
    int processedCount = 0;
    bool changed = true;
    while (changed)
    {
        changed = false;
        for (int i = 0; i < m; i++)
        {
            if (processed[i]) continue;
            // Check if all characters of abbrevs[i] are available
            bool canProcess = true;
            foreach (char c in abbrevs[i])
            {
                if (!available.Contains(c))
                {
                    canProcess = false;
                    break;
                }
            }
            if (canProcess)
            {
                processed[i] = true;
                processedCount++;
                available.Add(abbrevs[i][0]); // first letter now in S
                changed = true;
            }
        }
    }
    Console.WriteLine(processedCount == m ? "YES" : "NO");


}
