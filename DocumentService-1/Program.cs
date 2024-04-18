using DocumentService_1.Models;

Console.Write("Input the Title: "); 
string T = Console.ReadLine();
Console.Write("Input the Description: "); 
string D = Console.ReadLine();
Console.Write("Input the Content: "); 
string C = Console.ReadLine();
Document document = new Document (T, D, C);
Console.WriteLine();
document.GenerateDocument();

Console.WriteLine();

Console.Write("Input the new Title: ");
string newTitle = Console.ReadLine();
document.ForChangeTitle(newTitle); 
Console.Write("Input the new Description: ");   
string newDescription = Console.ReadLine();
document.ForChangeDescription(newDescription);
Console.Write("Input the new Content: ");
string NC = Console.ReadLine();
document.ForChangeContent(NC);
Console.WriteLine();
document.GenerateDocument();

Console.WriteLine();