using System.Threading.Channels;
//Console.WriteLine("Please enter architect's name! " );
string architectName = Console.ReadLine();
int numberProjects = int.Parse(Console.ReadLine());
int requiredHours = 3 * numberProjects;
Console.WriteLine($"The architect {architectName} will need {requiredHours} hours to complete {numberProjects} project/s.");
