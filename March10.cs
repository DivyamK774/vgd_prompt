//Journal prompt: March 10, 2025
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
// I learned that I need to use escape sequences to insert a special character into a string, like \t for tab, and
// \n for a new line. I can use an escape character for the backslash \\ when I need to use it in all senarios.
// I can also use @ create a verbatim string literal that keeps all whitespace formatting and backslash characters 
// in a string. Finally, I will use the \u plus a four-character code to represent Unicode characters (UTF-16) in 
// a string.
