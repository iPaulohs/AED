using System.Text.RegularExpressions;

string texto = "mail@mail.com";
string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

var match = Regex.IsMatch(texto, pattern);
Console.WriteLine(match); //True