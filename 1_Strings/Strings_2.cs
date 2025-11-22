string emptText = "";

//Verificar se uma string é vazia ou null
if (string.IsNullOrEmpty(emptText))
{
    Console.WriteLine("String vazia.");
}

//Verifica se uma string é vazia ou possui apenas um espaço em branco
if (string.IsNullOrWhiteSpace(emptText))
{
    Console.WriteLine("String com apenas um espaço.");
}

//Verifica se a string termina com o padrão informado
string pdfExtension = ".pdf";
if (pdfExtension.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Começa com pdf");
}

//Verifica se a string inicia com o padrão informado
string pdfName = "arquive.pdf";
if (pdfName.StartsWith("arquive", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Termina com 'arquive'");
}

//Verifica se uma string contém um texto específico
string phrase = "Hello World";
if (phrase.Contains("World"))
{
    Console.WriteLine("Contém 'World'.");
}

//Remove espaços em branco do início/fim da string
string text = "  exemplo  ";
string trimmed = text.Trim();           // "exemplo"
string trimmedStart = text.TrimStart(); // "exemplo  "
string trimmedEnd = text.TrimEnd();     // "  exemplo"

//Converte para minúsculas ou maiúsculas
string name = "Exemplo";
Console.WriteLine(name.ToLower()); // "exemplo"
Console.WriteLine(name.ToUpper()); // "EXEMPLO"

//ubstitui parte da string por outro valor
string original = "Olá Mundo";
string updated = original.Replace("Mundo", "Terra");
Console.WriteLine(updated); // "Olá Terra"

//Retorna parte da string
string code = "ABC12345";
string part = code.Substring(3);     // "12345"
string part2 = code.Substring(3, 2); // "12"

//Divide a string pelo separador
string fruits = "maçã,banana,uva";
string[] arr = fruits.Split(',');

foreach (var item in arr)
{
    Console.WriteLine(item);
}

//Junta vários elementos com um separador
string[] words = ["Olá", "mundo", "C#"];
string sentence = string.Join(" ", words);
Console.WriteLine(sentence); // "Olá mundo C#"

//Preenche a string com caracteres à esquerda ou direita
string number = "42";

Console.WriteLine(number.PadLeft(5, '0'));  // "00042"
Console.WriteLine(number.PadRight(5, '.')); // "42..."