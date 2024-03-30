
Console.WriteLine("Моля, въведете вашето име!");
string name = Console.ReadLine();
Console.WriteLine($"Здравейте, господин/жа {name} ! ");

//въвеждане на нужното количество на материалите
double predpazenNaylon = int.Parse(Console.ReadLine()) ;
int boq = int.Parse(Console.ReadLine());
int razreditelZaBoq = int.Parse((Console.ReadLine()));
int chasoveNaRabota = int.Parse((Console.ReadLine()));

//изчисления 
double cenaNaylon = 1.50;
double cenaBoq = 14.50;
double cenaRazreditel = 5.00;

//допълнителни разходи 
double dopulnitelnoKolichestvoBoq = 0.1 * boq;
double dopulnitelnoKolichestvoNaylon = 2.0;
double cenaTorbichki = 0.40;

//изчисляване на сумата на материалите
double sumaMateriali = (predpazenNaylon + dopulnitelnoKolichestvoNaylon) * cenaNaylon +
    (boq + dopulnitelnoKolichestvoBoq) * cenaBoq +
    razreditelZaBoq * cenaRazreditel + cenaTorbichki;

//изчисляване на сумата за часовете на майсторите
double sumaMajstori = 0.3 * sumaMateriali * chasoveNaRabota;

//обща сума на разходите 
double obshtaSuma = sumaMateriali + sumaMajstori;

//отпечатване на резулатата
Console.WriteLine(obshtaSuma);