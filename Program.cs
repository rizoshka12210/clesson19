//Classtask
//1
// try
// {
//     System.Console.Write("Enter your number: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Enter your second number: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine($"Division: {a/b}");
// }
// catch(Exception e)
// {
//     System.Console.WriteLine(e.Message);
// }



//2
// DateTime day = DateTime.Now;
// System.Console.WriteLine(day);



//3
// DateTime now = DateTime.Now;
// DateTime.Now.ToString("YYYY.MM.DD");
// var day = Convert.ToDateTime(Console.ReadLine());
// int time = (now - day).Days;
// System.Console.WriteLine(time);




//4
// int number = Convert.ToInt32(Console.ReadLine());
// Months month = (Months)number;
// Console.WriteLine("Название месяца: " + month);
// enum Months
// {
//     January = 1,
//     February,
//     March,
//     April,
//     May,
//     June,
//     Jule,
//     August,
//     September,
//     October,
//     November,
//     December
// }




//5
// Console.Write("Enter color (red, green, blue): ");
// string input = Console.ReadLine().ToLower();
// switch (input)
// {
//     case "red":
//         System.Console.WriteLine(Color.Red);
//         break;

//     case "green":
//         System.Console.WriteLine(Color.Red);
//         break;

//     case "blue":
//         System.Console.WriteLine(Color.Red);
//         break;

//     default:
//         Console.WriteLine("error");
//         break;
// }
// enum Color
// {
//     Red = 0xFF0000,
//     Green = 0x00FF00,
//     Blue = 0x0000FF
// }




//Hometask
//1
// DateTime day = new DateTime(2016,08,16,3,57,32,11);
// System.Console.WriteLine($"year = {day.Year}");
// System.Console.WriteLine($"months = {day.Month}");
// System.Console.WriteLine($"day = {day.Day}");
// System.Console.WriteLine($"hour = {day.Hour}");
// System.Console.WriteLine($"minute = {day.Minute}");
// System.Console.WriteLine($"second = {day.Second}");
// System.Console.WriteLine($"millisecond = {day.Millisecond}");



//2
// int count = 0;
// while (true)
// {
//     string input = Console.ReadLine();
//     if (input == "end")
//     {
//         break;
//     }
//     count++;
// }
// Console.WriteLine(count);



//3
// Gauge g = new Gauge();
// Console.WriteLine(g.value);
// g.Increase();
// g.Increase();
// Console.WriteLine(g.value); 
// g.Decrease();
// Console.WriteLine(g.value); 
// for (int i = 0; i < 10; i++)
// {
//     g.Increase();
// }
// Console.WriteLine(g.value); 
// Console.WriteLine(g.Full()); 



//4
// Counter c1 = new Counter();
// Counter c2 = new Counter(10);
// c1.Increase();
// Console.WriteLine(c1.value); 
// c2.Decrease();
// Console.WriteLine(c2.value); 
// c2.Increase(5);
// Console.WriteLine(c2.value); 
// c2.Decrease(3);
// Console.WriteLine(c2.value);
// c2.Increase(-5);
// Console.WriteLine(c2.value); 




//5
PaymentCard card = new PaymentCard(20);
PaymentTerminal terminal = new PaymentTerminal();
Console.WriteLine("Баланс: " + card.balance);
if (terminal.EatLunch(card))
{
    Console.WriteLine("Обед оплачен");
}
else
{
    Console.WriteLine("Недостаточно средств");
}
Console.WriteLine("Баланс: " + card.balance); 

terminal.DrinkCoffee(card);
Console.WriteLine("Баланс: " + card.balance); 

terminal.AddMoneyToCard(card, 20);
Console.WriteLine("Баланс после пополнения: " + card.balance); 

double change = terminal.EatLunch(50);
Console.WriteLine("Сдача: " + change); 
