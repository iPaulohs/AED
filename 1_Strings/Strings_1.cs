using System.Globalization;

//Obtendo o número de objetos Char contidos na String
string name = "John Doe";
var length = name.Length;
Console.WriteLine(length);

//Obtendo os caracteres Unicode da string separadamente
TextElementEnumerator charEnum = StringInfo.GetTextElementEnumerator(name);
while (charEnum.MoveNext())
{
    Console.WriteLine(charEnum.GetTextElement());
}

//Imutabilidade de strings
var s1 = "In C#, strings are";
var s2 = "always immutable objects.";

var s3 = s1 += s2;
Console.WriteLine(s3); //In C#, strings are always immutable objects.

//Tranformando string em char[]
var s4 = "C# is the better lang";
var s4CharArray = s4.ToCharArray();
Console.WriteLine(s4CharArray.GetType());
