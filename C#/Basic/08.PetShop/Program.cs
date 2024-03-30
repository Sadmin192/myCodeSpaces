double dogFood = 2.50;
double catFood = 4;
double dog = int.Parse(Console.ReadLine()) * dogFood;
double cat = int.Parse(Console.ReadLine()) * catFood;
double endPrice = dog + cat;    
Console.WriteLine($"{endPrice} lv.");
