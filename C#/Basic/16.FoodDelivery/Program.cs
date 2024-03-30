int broyPileshkiMenuta = int.Parse(Console.ReadLine());
int broyMenutaSRiba = int.Parse(Console.ReadLine());
int broyVegetarianskiMenuta = int.Parse(Console.ReadLine());

double cenaPileshkiMenuta = 10.35;
double cenaMenuSRiba = 12.40;
double cenaVegetarianskiMenuta = 8.15;
double cenaNaDostavka = 2.50;
double otstapkaProcent = 20.0 / 100.0;

double obshtaCenaNaMenutata = (broyPileshkiMenuta * cenaPileshkiMenuta)
    + (broyMenutaSRiba * cenaMenuSRiba) +
    (broyVegetarianskiMenuta * cenaVegetarianskiMenuta);

double cenaNaDeserta = obshtaCenaNaMenutata * otstapkaProcent;
double obshtaCenaNaPoruchkata = obshtaCenaNaMenutata + cenaNaDeserta + cenaNaDostavka;

    Console.WriteLine(obshtaCenaNaPoruchkata);


