//Такса за тренировки
double taksaZaEdnaGodina = int.Parse(Console.ReadLine());

//Отстъпки
double otstapkaProcentKecove = 40.0;
double otstapkaProcentEkip = 20.0;

//цена за кецове като цената е 40% по-малка от таксата за една година
double cenaBasketKecove = taksaZaEdnaGodina -
    (taksaZaEdnaGodina * otstapkaProcentKecove / 100);

//цена за екип като цената му е 20% по-евтина от тази на кецовете
double basketEkip = cenaBasketKecove - (cenaBasketKecove 
    * otstapkaProcentEkip / 100);

//топка като цената й е 1/4 от цената на баскетболния екип
double basketTopka = basketEkip / 4;

//аксесоари като цената им е 1/5 от цената на баскетболната топка
double basketAksesoari = basketTopka / 5;

//изчисляване на пълната такса за година 
double pulnaTaksa = taksaZaEdnaGodina
    + cenaBasketKecove + basketEkip + basketTopka
    + basketAksesoari;

//извеждане на резулатата
Console.WriteLine(pulnaTaksa);
