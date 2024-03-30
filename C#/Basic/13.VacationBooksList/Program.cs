int pages = int.Parse(Console.ReadLine());
int pagesPerHour =  int.Parse(Console.ReadLine());  
int dayToFinish =  int.Parse(Console.ReadLine());

int neededHours = (pages / pagesPerHour) / dayToFinish;

Console.WriteLine(neededHours);
