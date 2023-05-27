using System;

namespace P03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string weekDay = Console.ReadLine();

            float totalMoney = 0f;
            float pricePerPerson = 0f;

            switch (typeGroup)
            {
                case "Students":
                    switch (weekDay)
                    {
                        case "Friday":
                            pricePerPerson = 8.45f;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.8f;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46f;
                            break;
                    }
                    totalMoney = count * pricePerPerson;
                    if (count >= 30)
                    {
                        totalMoney -= (totalMoney * 15) / 100;
                    }
                    break;
                case "Business":
                    switch (weekDay)
                    {
                        case "Friday":
                            pricePerPerson = 10.9f;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.6f;
                            break;
                        case "Sunday":
                            pricePerPerson = 16f;
                            break;
                    }
                    if (count >= 100)
                    {
                        count -= 10;
                    }
                    totalMoney = count * pricePerPerson;
                    break;
                case "Regular":
                    switch (weekDay)
                    {
                        case "Friday":
                            pricePerPerson = 15f;
                            break;
                        case "Saturday":
                            pricePerPerson = 20f;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.5f;
                            break;
                    }
                    if (count >= 10 && count <= 20)
                    {
                        totalMoney -= (totalMoney * 5) / 100;
                    }
                    totalMoney = count * pricePerPerson;
                    break;
            }
            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}
