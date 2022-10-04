Console.WriteLine("Введите строки через зяпятую (пример: \"hello\",\"2\",\"world\",\":-)\")");
string input = Console.ReadLine().TrimStart('"').TrimEnd('"');
string[] mas = input.Split("\",\"");
string[] result = Array.Empty<string>();

foreach (string st in mas)
{
    if (st.Length <= 3)
    {
        result = result.Concat(new String[] { st }).ToArray();
    }
}

Console.WriteLine($"[\"{input}\"] -> [\"{string.Join("\",\"", result)}\"]");