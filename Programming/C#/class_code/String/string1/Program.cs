public class Test
{
    public static void Main(string[] args)
    {
        string text = "    Hello everyone! it is a \"C#\" program.    ";
        Console.WriteLine(text);

        Console.WriteLine("0 index's value: " + text[0]);
        Console.WriteLine("Length of string: " + text.Length);

        // using method
        bool isEmpty = string.IsNullOrEmpty(text);
        Console.WriteLine($"Is null or empty: {isEmpty}");

        string upper_str = text.ToUpper();
        Console.WriteLine($"Upper string: {upper_str}");

        string lower_str = text.ToLower();
        Console.WriteLine($"Lower string: {lower_str}");

        string trim_str = text.Trim(); // string-এর শুরু এবং শেষে থাকা extra space remove করবে
        Console.WriteLine($"Trimmed string: {trim_str}"); // TrimStart(), TrimEnd() ও ব্যবহার করা যায়

        string sub_str = text.Substring(6);
        Console.WriteLine($"Substring from index 6: {sub_str}");

        string sub_str2 = text.Substring(6, 5); // (কোথা থেকে শুরু করবে, কতগুলো character নিবে)
        Console.WriteLine($"Substring (index 6, length 5): {sub_str2}");

        string insert_text_str = text.Insert(0, "Hi... "); // index 0 থেকে insert করবে
        Console.WriteLine($"Inserted string: {insert_text_str}");

        string remove_text = text.Remove(6);
        Console.WriteLine($"Removed string: {remove_text}");

        string replace_text = text.Replace("Hello everyone", "Hi!!! ");
        Console.WriteLine($"Replaced string: {replace_text}");

        bool isHere = text.Contains("C#");
        Console.WriteLine($"It contain 'C#' in the string: {isHere}");

        string rev_str = new string (text.Reverse().ToArray());
        Console.WriteLine($"Removed string: {rev_str}");

        var words = text.Split(" ");
        foreach (string w in words)
        {
            Console.WriteLine($"{w}");
        }

        Console.WriteLine($"{string.Join(",", words)}");

    }
}