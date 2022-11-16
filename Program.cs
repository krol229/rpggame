using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace rpg

{ 
    internal class Program
{
    static void Main(string[] args)
    {
            //все переменные
            int percent = 100;
            const int y = 0; 
            int viborodin = 1;
            string viborodinasd = viborodin.ToString();
            int vibordva = 2;
            string vibordvaasd = vibordva.ToString();
            int vibortri = 3;
            string vibortriasd = vibortri.ToString();
            int viborch = 4;
            string viborchasd = viborch.ToString();
            int viborp = 5;
            string viborpasd = viborp.ToString();
            int viborsh = 6;
            string viborshasd = viborsh.ToString();
            int vibors = 7;
            string viborsasd = vibors.ToString();
            int viborv = 8;
            string viborvasd = viborv.ToString();
            int vibordev = 9;
            string vibordevasd = vibordev.ToString();
            int kripscrabshp = 10;
            int kripscrabsdam = 1;
            int x = 1;
            int defense = 0;
            float HealthPlayer = 20;
            int bonusdam = 0;
            int DamagePlayer = 5 + bonusdam;
            int defensedamitogotcrabs = kripscrabsdam - defense;
            int ShopMenu2 = 0;
            int MainMenu = 1;
            int cena0 = 1;
            int cena1 = 5;
            int cena2 = 7;
            int cena3 = 10;
            int cena4 = 15;
            int cena5 = 18;
            int cena6 = 25;
            int cena7 = 35;
            int cena8 = 50;
            int cena9 = 75;
            int harakteristiki1 = 3;
            int harakteristiki2 = 4;
            int harakteristiki3 = 5;
            int harakteristiki4 = 7;
            int harakteristiki5 = 8;
            int harakteristiki6 = 10;
            int harakteristiki7 = 15;
            int harakteristiki8 = 20;
            int harakteristiki9 = 30;
            bool buyshlem1 = false;
            bool buyshlem2 = false;
            bool buyshlem3 = false;
            string bloodstone = "Кровавый камень";
            string ahatofhealth = "Шляпа здоровья";
            int ahatofhealthhp = 10;
            string bloodamulet = "Амулет крови";
            int bloodamuletdam = 10;
            string ringofprotection = "Кольцо защиты";
            int ringofprotectiondef = 3;
            string palka = "Палка";
            int palkadam = 1;
            string darovanieoflean = "Дарование лина";
            int darovanieofleanhp = 10;
            int darovanieofleandam = 5;
            int darovanieofleandef = 3;
            string stoneofdemon = "Камень ярости";
            int stoneofdemondam = 20;
            int cenaartdemona = 37;
            string ostrovK = "Остров малых крабов";
            string ostrovD = "Остров Друидов";
            string ostrovT = "Остров Траллов";
            int money = 0;
            Console.WriteLine("Привет, как тебя зовут?");
        string NAME = Console.ReadLine();
            Console.Clear();
            while (true) {
            float vampiricbuy = 0;
            float vampiric = DamagePlayer / ((percent - 90) + vampiricbuy);
            float itogovoehp = vampiric + HealthPlayer;
            float itogvamp = HealthPlayer - DamagePlayer + itogovoehp;
        string[] smile = { " ", "W", "-", "о", "О" };
        Random randomsmile = new Random(); ;
        int randsmile = randomsmile.Next(smile.Length);
        //Главное меню
        Console.Clear();
        Console.WriteLine($"                 Привет,{NAME}, это игровое меню, здесь ты можешь                     ");
        Console.WriteLine("                   приодеть персонажа, а так же фармить с лагерей крипов               ");
        Console.WriteLine("         Куда отправимся?                                                              ");
        Console.WriteLine("                                                                                       ");
        Console.WriteLine(@"                             _______                 <---Тут инфа о голове            ");
        Console.WriteLine($@"Денег: {money} (§)                /       \                                          ");
        Console.WriteLine($@"                           /         \             здоровье персонажа: {HealthPlayer}");
        Console.WriteLine($@"                          |           |            урон персонажа {DamagePlayer}     ");
        Console.WriteLine($@"                          |   -    -  |                  вампиризм: {itogvamp}                             ");
        Console.WriteLine($@"                          |           |              броня: {defense}                                  ");
        Console.WriteLine($@"                          |     {smile[randsmile]}     |                             ");
        Console.WriteLine(@"                           \         /                                                ");
        Console.WriteLine(@"                            \       /    |                                            ");
        Console.WriteLine(@"                             \     /     |                                            ");
        Console.WriteLine(@"                                |        |                                            ");
        Console.WriteLine(@"                                |        ┬              <---+                         ");
        Console.WriteLine(@"     инфа о артефакте--->=======|========|                                            ");
        Console.WriteLine(@"                                |        |                                            ");
        Console.WriteLine(@"                                |        |         открыть инвентарь: /invent                                  ");
        Console.WriteLine(@"                              /   \                                                   ");
        Console.WriteLine(@"                             /     \                                                  ");
        Console.WriteLine(@"                            /       \                                                 ");
        Console.WriteLine(@"                           /         \                 <------Тут Инфа о ногах        ");
        Console.WriteLine(@"                         ---         ---                                              ");
        Console.WriteLine(@"                                                                                      ");
        Console.WriteLine(@"      (1).Магазин обычных вещей                            (2). Магазин артефактов    ");
        Console.WriteLine(@"         |-------------|                                     |-------------|          ");
        Console.WriteLine(@"         |             |                                     |             |          ");
        Console.WriteLine(@"         |             |                                     |             |          ");
        Console.WriteLine(@"         |      ☻      |                                     |     *_*     |          ");
        Console.WriteLine(@"         |-------------|                                     |-------------|          ");
        Console.WriteLine(@"         |             |                                     |             |          ");
        Console.WriteLine(@"         ---------------                                     ---------------          ");
        Console.WriteLine(@"                                                                                      ");
        Console.WriteLine(@"                                                                                      ");
        Console.WriteLine(@"                                                                                      ");
            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("               ---- ▲ ------- ▲  ▲                                                    ");
        Console.WriteLine("        --------- ▲ ---------- -----                                                  ");
        Console.WriteLine("    --------  ------------- ▲ ---                                                     ");
        Console.WriteLine("      ------------- ▲    -----------                                                  ");
        Console.WriteLine($@"           (3). {ostrovK}                                                   ");
        Console.WriteLine("                ---- ▲ --- ------- ▲ ---------                                        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("            ------------------++++++----                                              ");
        Console.WriteLine("                 -----------------++++-----------+++                                  ");
        Console.WriteLine("              -------------++++++-------------+++++-----+++++++---                    ");
        Console.WriteLine("                   -----------+++++++----------------++                               ");
        Console.WriteLine($@"              ---------+++++++--------------  (4). {ostrovD}                     ");
        Console.WriteLine("                          ---------+++++++--------------                              ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("                                ----§§§§§--------§§§§---§§§§§§§--------               ");
        Console.WriteLine("                               §§§§§--------§§§-0-----§§§§0000-----                   ");
        Console.WriteLine("                              ------00§-----0000--§§§§---------                       ");
        Console.WriteLine("                           -----§§§§§-------§§§§-------0000-=-----§§§§------          ");
        Console.WriteLine($@"                           -------§§§§------ (5). {ostrovT} -------§§§§------    ");
        Console.WriteLine("                                       -------§§§§§---0000§§§------                   ");
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("                                                                                      ");
        Console.WriteLine("                                                                                      ");
            Console.ForegroundColor = ConsoleColor.White;
            int nummenu = Convert.ToInt32(Console.ReadLine());
            MainMenu = nummenu + x;
            if (MainMenu == 2)
            {
                    Console.Clear();
                    Console.WriteLine("Что вы хотите выбрать?");
                    Console.WriteLine("1. Шлемы");
                    Console.WriteLine("2. Мечи");
                    Console.WriteLine("3. Сапоги");
                    int ShopMenu = Convert.ToInt32(Console.ReadLine());
                    if (ShopMenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Раздел Шлемов");
                        Console.WriteLine($@"  1. Деревянный Шлем /--\                  стоимость: {cena1} §              (+{harakteristiki1} защиты)           ");
                        Console.WriteLine($@"  2. Улучшенный Деревянный Шлем /-11-\     стоимость: {cena2} §              (+{harakteristiki2} защиты)           ");
                        Console.WriteLine($@"  3. Каменный Шлем \-1-/                  стоимость: {cena3} §              (+{harakteristiki3} защиты)           ");
                        Console.WriteLine($@"  4. Шлем Матфея Великого /--\            стоимость: {cena4} §              (+{harakteristiki4} защиты)           ");
                        Console.WriteLine($@"  5. Железный Шлем \-2-\                  стоимость: {cena5} §              (+{harakteristiki5} защиты)           ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"  6. Линовый Шлем \--/                    стоимость: {cena6} §              (+{harakteristiki6} защиты)          ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"  7.  Шлем Берсерка /-+-\                 стоимость: {cena7} §              (+{harakteristiki7} защиты)          ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"  8. Проклятый Шлем 0000000000            стоимость: {cena8} §              (+{harakteristiki8} защиты)          ");
                        Console.WriteLine($@"  9. Повязка Иллидана -~~-                стоимость: {cena9} §              (+{harakteristiki9} защиты)          ");
                        Console.WriteLine("     Напиши: Назад, чтобы вернуться ");
                        int shopmenudlyshlemov = Convert.ToInt32(Console.ReadLine());

                        Thread.Sleep(500);
                    }
                    else if (ShopMenu == 2) 
                    {
                    Console.Clear();
                    Console.WriteLine("Раздел Мечей");
                    Console.WriteLine($@"  1. Деревянный Меч -----|==========>     стоимость: {cena1} §              (+{harakteristiki1} чистого урона)           ");
                    Console.WriteLine($@"   2. Улучшенный Деревянный Меч -----+==========>     стоимость: {cena2} §  (+{harakteristiki2} чистого урона)           ");
                    Console.WriteLine($@"    3. Каменный Меч   -----)---------->              стоимость: {cena3} § (+{harakteristiki3} чистого урона)           ");
                    Console.WriteLine($@"     4. Меч Матфея Великого    ------)=========>     стоимость: {cena4} § (+{harakteristiki4} чистого урона)           ");
                    Console.WriteLine($@"      5. Железный Меч   ---)=========>               стоимость: {cena5} § (+{harakteristiki5} чистого урона)           ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($@"        6. Линовый Меч       ---)=========--       стоимость: {cena6} § (+{harakteristiki6} чистого урона)             ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"          7.Меч Берсерка ========)¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦►              стоимость: {cena7} § (+{harakteristiki7} чистого урона)");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($@"           8. Проклятый Меч  =======()=========================>           стоимость: {cena8} § (+{harakteristiki8} чистого урона)    ");
                    Console.WriteLine($@"             ");
                    Console.WriteLine($@"             9. Кровавая Коса Великой Элуны    --------------------╕                                                 ");
                    Console.WriteLine($@"                                                                   │      стоимость: {cena9} § (+{harakteristiki9} чистого урона)    ");
                    Console.WriteLine($@"                                                                   │                                                 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("     Напиши: Назад, чтобы вернуться                                                                                 ");
                    }
                    else if (ShopMenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Раздел Сапогов");
                        Console.WriteLine($@"  1. Кожаные Сапоги _| |_     стоимость: {cena1} §              (+{harakteristiki1} защиты)           ");
                        Console.WriteLine($@"   2. Улучшенные Кожаные Сапоги   _| |_   стоимость: {cena2} §  (+{harakteristiki2} защиты)           ");
                        Console.WriteLine($@"    3. Кожано-металлические сапоги  _| |_              стоимость: {cena3} § (+{harakteristiki3} защиты)           ");
                        Console.WriteLine($@"     4. Ботинки Матфея Великого    _! !_     стоимость: {cena4} § (+{harakteristiki4} защиты)           ");
                        Console.WriteLine($@"      5. Железные ботинки        _| \_          стоимость: {cena5} § (+{harakteristiki5} защиты)           ");
                        Console.WriteLine($@"        6. Линовые Ботинки       _/ \_                        стоимость: {cena6} § (+{harakteristiki6} защиты)           ") ;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"                     _/ \_                                                                ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"          7. Ботинки Берсерка _¦¦_              стоимость: {cena7} § (+{harakteristiki7} защиты)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"           8. Проклятые Ботинки  |_|()_*()           стоимость: {cena8} § (+{harakteristiki8} защиты)    ");
                        Console.WriteLine($@"             ");
                        Console.WriteLine($@"             9. Ботинки Богоподобной Защиты              стоимость: {cena9} § (+{harakteristiki9} защиты)                                      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("     Напиши: Назад, чтобы вернуться                                                                                 ");
                        
                    }
                }
                else if (MainMenu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("магазин артефактов");
                    Console.WriteLine($@"1. {bloodstone} стоимость: {cena7} § (+вампирик (10%) ");
                    Console.WriteLine($@"2. {ahatofhealth} стоимость: {cena5} § (+{ahatofhealthhp} здоровье  ");
                    Console.WriteLine($@"3. {bloodamulet} стоимость: {cena6} § (+{bloodamuletdam} к урону  ");
                    Console.WriteLine($@"4. {ringofprotection} стоимость: {cena1} § (+{ringofprotectiondef} защиты");
                    Console.WriteLine($@"5. {palka} стоимость: {cena0} § (+{palkadam} урона ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($@"6. {darovanieoflean} стоимость: {cena6} § (+{darovanieofleanhp} здоровья, +{darovanieofleandam} урона, +{darovanieofleandef} защиты");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"7. {stoneofdemon} стоимость: {cenaartdemona} § (+{stoneofdemondam}  урона");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("     Напиши: Назад, чтобы вернуться                                                                                 ");


                }
               else if (MainMenu == 4)
                {
                    Console.Clear();
                    Console.WriteLine(ostrovK);
                }
              else if (MainMenu == 5)
                {
                    Console.Clear();
                    Console.WriteLine(ostrovD);
                }
                else if (MainMenu == 6)
                {
                    Console.Clear();
                    Console.WriteLine(ostrovT);
                }
               else  if (MainMenu >= 2)
                {
                    Console.Clear();
                    Console.WriteLine("Такого меню нет");
                }
                Thread.Sleep(100000);
            }
        }
    }
}
