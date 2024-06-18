
// See https://aka.ms/new-console-template for more information
// 48. Количество чеков на сумму превышающую заданную.
// 49. Общая сумма по всем чекам
// Квитанция с максимальной суммой
// Общее количество накладных

using ConsoleApp2;

Document[] arr = [
    new Document(),
    new Document(1000, "1Д1/2024"),
    new Check(),
    new Check(3),
    new Check(740, "2L/2024"),
    new Check(5, 800, "П84-91/2010"),
    new Nakladnaya(),
    new Nakladnaya(300, "ФФФ04"),
    new Nakladnaya("Москва", "Пермь"),
    new Nakladnaya(900, "ДОСТ-4491/2023","Воронеж","Иркутск"),
    new Kvitanciya(),
    new Kvitanciya("ХВС"),
    new Kvitanciya(100, "ХВС-3301-2022"),
    new Kvitanciya(234, "ХВС-3302-2022", "ХВС"),
    ];
Console.WriteLine("++++++++++");
Console.WriteLine("Все элементы последовательности");
foreach (Document doc in arr)
{
    Console.WriteLine(doc.ToString());
}
Console.WriteLine("++++++++++");
Console.WriteLine("Количество чеков на сумму превышающую заданную");
Console.Write("Введите минимальную сумму чека: ");
int minCheckSum = Int32.Parse(Console.ReadLine());
foreach (Document doc in arr)
{
    if (doc is Check && doc.PaySize >= minCheckSum)
    {
        Console.WriteLine(doc.ToString());
    }
}
Console.WriteLine("++++++++++");
Console.WriteLine("Общая сумма по всем чекам");
int checkSum = 0;
foreach (Document doc in arr)
{
    if (doc is Check)
    {
        checkSum += doc.PaySize;
    }
}
Console.WriteLine($"Общая сумма по всем чекам: {checkSum}");
Console.WriteLine("++++++++++");
Console.WriteLine("Квитанция с максимальной суммой");
Kvitanciya maxKvitanciya = new Kvitanciya();
foreach (Document doc in arr)
{
    if (doc is Kvitanciya && doc.PaySize >= maxKvitanciya.PaySize)
    {
        maxKvitanciya = (Kvitanciya)doc;
    }
}
Console.WriteLine($"Квитанция с максимальной суммой: {maxKvitanciya.ToString()}");
Console.WriteLine("++++++++++");
Console.WriteLine("Общее количество накладных");
int nakladnayaCount = 0;
foreach (Document doc in arr)
{
    if (doc is Nakladnaya)
    {
        nakladnayaCount++;
    }
}
Console.WriteLine($"Кол-во накладных: {nakladnayaCount}");