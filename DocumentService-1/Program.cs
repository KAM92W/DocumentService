// See https://aka.ms/new-console-template for more information
using DocumentService_1.Models;
//--------------------------------------------------------------------
//Title title1 = new Title("Это заголовок #1");
//Title title_description = new Title("Это заголовок #2", "Это описание #1");
//title_description.Show();
//Console.WriteLine();
////--------------------------------------------------------------------
//Console.WriteLine("Это были заголовок и описание по-умолчанию");
//Console.WriteLine();

//Console.WriteLine("Давайте их изменим!");
//Console.WriteLine();
////--------------------------------------------------------------------
//Console.Write("Введите свой заголовок: ");
//string chtitle = Console.ReadLine();
//Console.WriteLine();

//Console.Write("Введите своё описание: ");
//string chdescription = Console.ReadLine();
//Console.WriteLine();

//title_description.ChangeTitle(chtitle);
//title_description.ChangeDescription(chdescription);
//title_description.Show();
//Console.WriteLine();
////--------------------------------------------------------------------
//Body content_0 = new Body();
//Console.Write("Введите контент по-умолчанию: ");
//content_0.Content = Console.ReadLine();
//content_0.Show();
//Console.WriteLine();

//Console.Write("А теперь введите свой контент: ");
//Body content_1 = new Body(Console.ReadLine());
//Console.WriteLine();
//Console.Write("Допишите что-нибудь к контенту: ");
//content_1.AddStringToContent(Console.ReadLine());
//content_1.Show();

Document document = new Document (Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
document.GenerateDocument();
//Console.WriteLine (document);