using RunLengthEncoding;
Console.WriteLine("Enter string to be encoded");
string ?input = Console.ReadLine();
Console.Write($"Encoded String : {RunLengthEncoder.Encode(input)}");
Console.ReadLine();
