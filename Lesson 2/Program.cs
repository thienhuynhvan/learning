// See https://aka.ms/new-console-template for more information

using Lesson_2;

DateTime hiredDay = new DateTime(2025, 2, 28,14,30,0);
DateTime firedDay = new DateTime(2025, 12, 28,14,30,0);
DateTime startedDay = hiredDay.AddDays(15);
DateTime currentDay=DateTime.Now;
bool are = currentDay.IsDaylightSavingTime();
Console.WriteLine(are);
DateTime startHour=DateTime.Now;
Console.WriteLine(startHour.ToLongDateString());
//DateTime twodaylater = DateTime.DayOfWeek;
Console.WriteLine(hiredDay);
Console.WriteLine(firedDay);
Console.WriteLine(startedDay);



double a= 236363636.23;
int b = (int)a;
Console.WriteLine(b);

int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Tuổi là: " + age);
    Console.WriteLine("Nhập không hợp lệ!");

// int result =AddT
Console.WriteLine(Helper.sumary(2,3));