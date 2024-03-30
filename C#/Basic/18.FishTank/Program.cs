double duljina = double.Parse(Console.ReadLine());
double shirochina = double.Parse(Console.ReadLine());
double visochina = double.Parse(Console.ReadLine());
double procent =  double.Parse(Console.ReadLine());

double obemNaAkquarium = duljina * shirochina * visochina;

double obemVLitri2 = obemNaAkquarium / 1000;

double zaetoProstranstwo = (100 - procent) / 100;

double nujniLitri = obemNaAkquarium * (1 - zaetoProstranstwo);

Console.WriteLine(nujniLitri);







