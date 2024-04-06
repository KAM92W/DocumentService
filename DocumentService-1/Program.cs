// See https://aka.ms/new-console-template for more information
using DocumentService_1.Models;
using System.Runtime.CompilerServices;


Title title = new Title("Это заголовок #1");
Title title_description = new Title("Это заголовок #2", "Это описание #1");
title_description.Show();
Console.WriteLine();

Console.WriteLine("Это были заголовок и описание по-умолчанию");
Console.WriteLine();

Console.WriteLine("Давайте их изменим!");
Console.WriteLine();

Console.Write("Введите свой заголовок: ");
string chtitle = Console.ReadLine();
Console.WriteLine();

Console.Write("Введите своё описание: ");
string chdescription = Console.ReadLine();
Console.WriteLine();

title_description.ChangeTitle(chtitle);
title_description.ChangeDescription(chdescription);
title_description.Show();