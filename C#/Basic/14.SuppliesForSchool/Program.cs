int broiPaketiHimikli = int.Parse(Console.ReadLine());
int broiPaketiMarkeri = int.Parse(Console.ReadLine());
int litriPrepParachka = int.Parse(Console.ReadLine());
int namalenieProcent =  int.Parse(Console.ReadLine());

//цени на продуктите
double cenaPaketiHimikali = 5.80;
double cenaPaketiMarkeri = 7.20;
double cenaPrepParachka = 1.20;

//Изчисляване на сумата преди намалението 
double obshtaSuma = (broiPaketiHimikli * cenaPaketiHimikali) + (broiPaketiMarkeri * cenaPaketiMarkeri) + (litriPrepParachka * cenaPrepParachka);

//Изчисляване на сумата след намалението 
double sumaSNamalenie = obshtaSuma - (obshtaSuma * namalenieProcent / 100);

//Отпечатване на резултата 
Console.WriteLine(sumaSNamalenie);
