using System;
using System.Threading;

namespace rpg

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //все переменные
            int percent = 100;
            const int y = 0;
            int x = 1;
            int ShopMenu2 = 0;
            int MainMenu = 0;
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
            int harakteristiki0 = 0;
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
            int introforcrabs = 0;
            int introfordruids = 0;
            int introfortralls = 0;
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
            Console.WriteLine("Привет, как тебя зовут?");
            string NAME = Console.ReadLine();
            Console.Clear();
            int money = 0;
            int defense = harakteristiki0;
            int bonusdam = harakteristiki0 + 5;
            int Damagep = bonusdam;
            int obschdef = 0;
            int obschdam = 0;
            int obschdefarm = 0;
            float HealthPlayerDefault = 20;
            float vampiricbuy = 0;
            int defenseart = 0;
            int damageart = 0;
            int healthart = 0;
            float Damageforvamp = Damagep;
            float HealthPlayer = 20;

            while (HealthPlayer > 0)
            {
                if (HealthPlayerDefault < HealthPlayer)
                {

                    HealthPlayer = HealthPlayerDefault;

                }
                int obschdefheaditog = obschdef;
                int obschdamitog = obschdam;
                int obschdefarmitog = obschdefarm;
                int artefakthp = healthart;
                int artefaktdam = damageart;
                int artefaktdef = defenseart;
                float artefaktvamp = vampiricbuy;
                int DamagePlayer = Damagep;
                float vampiric = (0 + DamagePlayer) / percent;
                float vampiricplushp = (HealthPlayerDefault + vampiric) / percent;
                //крабы
                // обыкновенный
                int kripscrabobikshp = 20;
                int kripscrabsobikdam = 3;
                int kripscrabsobikdef = 1;
                // элитный
                int kripscrabelitehp = 100;
                int kripscrabelitedam = 20;
                int kripscrabelitedef = 35;
                // король
                int kripscrabkorolhp = 350;
                int kripscrabkoroldam = 45;
                int kripscrabkoroldef = 60;
                //друиды
                // друид-мечник
                int druidmechnikhp = 500;
                int druidmechnikdam = 105;
                int druidmechnikdef = 100;
                // друид-монах
                int druidmonahhp = 1500;
                int druidmonahdam = 80;
                int druidmonahdef = 365;
                // друид-убийца
                int druidkillerhp = 800;
                int druidkillerdam = 550;
                int druidkillerdef = 100;
                // траллы
                // тралл-охотник
                int trallohotnikhp = 1500;
                int trallohotnikdam = 650;
                int trallohotnikdef = 200;
                // тралл-Шаман
                int trallshamanhp = 1550;
                int trallshamandamphys = 100;
                int trallshamandammage = 650;
                int trallshamandef = 500;
                // тралл-танк
                int tralltankhp = 30000;
                int tralltankdam = 500;
                int tralltankdef = 1500;
                float DefensePlayer = defense;
                string[] smile = { " ", "W", "-", "о", "О" };
                Random randomsmile = new Random();
                int randsmile = randomsmile.Next(smile.Length);
                //Главное меню
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine($"                 Привет,{NAME}, это игровое меню, здесь ты можешь                     ");
                Console.WriteLine($"                   приодеть персонажа, а так же фармить с лагерей крипов               ");
                Console.WriteLine($"         Куда отправимся?                                                              ");
                Console.WriteLine($"                                                                                       ");
                Console.WriteLine($@"                            _______                 <---Общая броня головы:            ");
                Console.WriteLine($@"                           /       \                                       {obschdefheaditog} ");
                Console.WriteLine($@"                          /         \             здоровье персонажа: {HealthPlayer}/{HealthPlayerDefault}");
                Console.WriteLine($@"                          |          |           урон персонажа {DamagePlayer}     ");
                Console.WriteLine($@"                          |  -    -  |                 вампиризм: {vampiricplushp}                             ");
                Console.WriteLine($@"                          |          |             броня: {DefensePlayer}                                  ");
                Console.WriteLine($@"                          |    {smile[randsmile]}     |                             ");
                Console.WriteLine($@"                           \         /                                                ");
                Console.WriteLine($@"                            \       /    |                Золото: {money} (§)                             ");
                Console.WriteLine($@"                             \     /     |                                            ");
                Console.WriteLine($@"                                |        |                                            ");
                Console.WriteLine($@"                                |        ┬              <--- Общий урон с меча:                        ");
                Console.WriteLine($@"                         =======|========|                                  {obschdam}          ");
                Console.WriteLine($@"                                |        |        Хар-ики  с артефактов:                                    ");
                Console.WriteLine($@"                                |        |                          хп: {artefakthp}                                ");
                Console.WriteLine($@"                              /   \                                 урон: {artefaktdam}                 ");
                Console.WriteLine($@"                             /     \                                защита: {artefaktdef}                 ");
                Console.WriteLine($@"                            /       \                                                 ");
                Console.WriteLine($@"                           /         \                 <------Общая броня с ног:        ");
                Console.WriteLine($@"                         ---         ---                                 {obschdefarmitog}             ");
                Console.WriteLine($@"                                                                                      ");
                Console.WriteLine(@"      (1). Магазин обычных вещей                           (2). Магазин артефактов    ");
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
                Random randcenacrabaodin = new Random();
                Random randcenacrabadva = new Random();
                Random randcenacrabatri = new Random();
                Random randcenadruidmechnik = new Random();
                Random randcenadruidmonah = new Random();
                Random randcenadruidkiller = new Random();
                Random randcenatrallohotnik = new Random();
                Random randcenatrallshaman = new Random();
                Random randcenatralltank = new Random();
                int randcenacrabsobik = randcenacrabaodin.Next(5, 10);
                int randcenacrabselite = randcenacrabadva.Next(10, 15);
                int randcenacrabskorol = randcenacrabatri.Next(20, 25);
                int randcenadruidmechnikodin = randcenadruidmechnik.Next(40, 47);
                int randcenadruidmonahdva = randcenadruidmonah.Next(55, 80);
                int randcenadruidkilertri = randcenadruidkiller.Next(75, 90);
                int randcenatrallohotnikodin = randcenatrallohotnik.Next(100, 150);
                int randcenatrallshamandva = randcenatrallshaman.Next(200, 250);
                int randcenatralltanktri = randcenatralltank.Next(500, 600);
                int nummenu = Convert.ToInt32(Console.ReadLine());
                MainMenu = nummenu;
                //магаз
                if (MainMenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Что вы хотите выбрать? денег: {money}§");
                    Console.WriteLine($@"1. Шлемы /==\");
                    Console.WriteLine($@"2. Мечи --|========>");
                    Console.WriteLine($@"3. Сапоги /\");
                    Console.WriteLine($@"4. Назад");
                    int ShopMenu = Convert.ToInt32(Console.ReadLine());
                    if (ShopMenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($@"Раздел Шлемов /==\ денег: {money}");
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
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("     Напиши: 10, чтобы вернуться назад ");
                        int shopmenudlyashlemov = Convert.ToInt32(Console.ReadLine());
                        if (shopmenudlyashlemov == 1)
                        {
                            if (money >= cena1)
                            {
                                money -= cena1;
                                defense += harakteristiki1;
                                obschdef += harakteristiki1;
                            }
                            else if (money < cena1)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 2)
                        {
                            if (money >= cena2)
                            {
                                money -= cena2;
                                defense += harakteristiki2;
                                obschdef += harakteristiki2;
                            }
                            else if (money < cena2)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 3)
                        {
                            if (money >= cena3)
                            {
                                money -= cena3;
                                defense += harakteristiki3;
                                obschdef += harakteristiki3;

                            }
                            else if (money < cena3)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 4)
                        {
                            if (money >= cena4)
                            {
                                money -= cena4;
                                defense += harakteristiki4;
                                obschdef += harakteristiki4;
                            }
                            else if (money < cena4)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 5)
                        {
                            if (money >= cena5)
                            {
                                money -= cena5;
                                defense += harakteristiki5;
                                obschdef += harakteristiki5;
                            }
                            else if (money < cena5)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 6)
                        {
                            if (money >= cena6)
                            {
                                money -= cena6;
                                defense += harakteristiki6;
                                obschdef += harakteristiki6;
                            }
                            else if (money < cena6)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 7)
                        {
                            if (money >= cena7)
                            {
                                money -= cena7;
                                defense += harakteristiki7;
                                obschdef += harakteristiki7;
                            }
                            else if (money < cena7)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 8)
                        {
                            if (money >= cena8)
                            {
                                money -= cena8;
                                defense += harakteristiki8;
                                obschdef += harakteristiki8;
                            }
                            else if (money < cena8)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 9)
                        {
                            if (money >= cena9)
                            {
                                money -= cena9;
                                defense += harakteristiki9;
                                obschdef += harakteristiki9;
                            }
                            else if (money < cena9)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyashlemov == 10)
                        {
                            MainMenu -= 1;
                        }
                        Thread.Sleep(500);
                    }
                    else if (ShopMenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($@"Раздел Мечей --|========> денег: {money}");
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
                        Console.WriteLine("     Напиши: 10, чтобы вернуться назад                                                                                 ");
                        int shopmenudlyamechei = Convert.ToInt32(Console.ReadLine());
                        if (shopmenudlyamechei == 1)
                        {
                            if (money >= cena1)
                            {
                                money -= cena1;
                                Damagep += harakteristiki1;
                                obschdam += harakteristiki1;
                            }
                            else if (money <= cena1)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 2)
                        {
                            if (money >= cena2)
                            {
                                money -= cena2;
                                Damagep += harakteristiki2;
                                obschdam += harakteristiki2;
                            }
                            else if (money < cena2)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 3)
                        {
                            if (money >= cena3)
                            {
                                money -= cena3;
                                Damagep += harakteristiki3;
                                obschdam += harakteristiki3;
                            }
                            else if (money < cena3)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 4)
                        {
                            if (money >= cena4)
                            {
                                money -= cena4;
                                Damagep += harakteristiki4;
                                obschdam += harakteristiki4;
                            }
                            else if (money < cena4)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 5)
                        {
                            if (money >= cena5)
                            {
                                money -= cena5;
                                Damagep += harakteristiki5;
                                obschdam += harakteristiki5;
                            }
                            else if (money < cena5)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 6)
                        {
                            if (money >= cena6)
                            {
                                money -= cena6;
                                Damagep += harakteristiki6;
                                obschdam += harakteristiki6;
                            }
                            else if (money < cena6)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 7)
                        {
                            if (money >= cena7)
                            {
                                money -= cena7;
                                Damagep += harakteristiki7;
                                obschdam += harakteristiki7;
                            }
                            else if (money < cena7)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 8)
                        {
                            if (money >= cena8)
                            {
                                money -= cena8;
                                Damagep += harakteristiki8;
                                obschdam += harakteristiki8;
                            }
                            else if (money < cena8)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 9)
                        {
                            if (money >= cena9)
                            {
                                money -= cena9;
                                Damagep += harakteristiki9;
                                obschdam += harakteristiki9;
                            }
                            else if (money < cena9)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyamechei == 10)
                        {
                            MainMenu -= 1;
                        }
                        Thread.Sleep(500);
                    }
                    else if (ShopMenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine($@"Раздел Сапогов денег:{money} ");
                        Console.WriteLine($@"  1. Кожаные Сапоги _| |_     стоимость: {cena1} §              (+{harakteristiki1} защиты)           ");
                        Console.WriteLine($@"   2. Улучшенные Кожаные Сапоги   _| |_   стоимость: {cena2} §  (+{harakteristiki2} защиты)           ");
                        Console.WriteLine($@"    3. Кожано-металлические сапоги  _| |_              стоимость: {cena3} § (+{harakteristiki3} защиты)           ");
                        Console.WriteLine($@"     4. Ботинки Матфея Великого    _! !_     стоимость: {cena4} § (+{harakteristiki4} защиты)           ");
                        Console.WriteLine($@"      5. Железные ботинки        _| \_          стоимость: {cena5} § (+{harakteristiki5} защиты)           ");
                        Console.WriteLine($@"        6. Линовые Ботинки       _/ \_                        стоимость: {cena6} § (+{harakteristiki6} защиты)           ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"                     _/ \_                                                                ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"          7. Ботинки Берсерка _¦¦_              стоимость: {cena7} § (+{harakteristiki7} защиты)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"           8. Проклятые Ботинки  |_|()_*()           стоимость: {cena8} § (+{harakteristiki8} защиты)    ");
                        Console.WriteLine($@"             ");
                        Console.WriteLine($@"             9. Ботинки Богоподобной Защиты              стоимость: {cena9} § (+{harakteristiki9} защиты)                                      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("     Напиши: 10, чтобы вернуться назад                                                                                 ");
                        int shopmenudlyabotinok = Convert.ToInt32(Console.ReadLine());
                        if (shopmenudlyabotinok == 1)
                        {
                            if (money >= cena1)
                            {
                                money -= cena1;
                                defense += harakteristiki1;
                                obschdefarm += harakteristiki1;
                            }
                            else if (money < cena1)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 2)
                        {
                            if (money >= cena2)
                            {
                                money -= cena2;
                                defense += harakteristiki2;
                                obschdefarm += harakteristiki2;
                            }
                            else if (money < cena2)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 3)
                        {
                            if (money >= cena3)
                            {
                                money -= cena3;
                                defense += harakteristiki3;
                                obschdefarm += harakteristiki3;
                            }
                            else if (money < cena3)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 4)
                        {
                            if (money >= cena4)
                            {
                                money -= cena4;
                                defense += harakteristiki4;
                                obschdefarm += harakteristiki4;
                            }
                            else if (money < cena4)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 5)
                        {
                            if (money >= cena5)
                            {
                                money -= cena5;
                                defense += harakteristiki5;
                                obschdefarm += harakteristiki5;
                            }
                            else if (money < cena5)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 6)
                        {
                            if (money >= cena6)
                            {
                                money -= cena6;
                                defense += harakteristiki6;
                                obschdefarm += harakteristiki6;
                            }
                            else if (money < cena6)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 7)
                        {
                            if (money >= cena7)
                            {
                                money -= cena7;
                                defense += harakteristiki7;
                                obschdefarm += harakteristiki7;
                            }
                            else if (money < cena7)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 8)
                        {
                            if (money >= cena8)
                            {
                                money -= cena8;
                                defense += harakteristiki8;
                                obschdefarm += harakteristiki8;
                            }
                            else if (money < cena8)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 9)
                        {
                            if (money >= cena9)
                            {
                                money -= cena9;
                                defense += harakteristiki9;
                                obschdefarm += harakteristiki9;
                            }
                            else if (money < cena9)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyabotinok == 10)
                        {
                            MainMenu -= 1;
                        }
                        Thread.Sleep(500);
                    }
                    else if (ShopMenu >= 4)
                    {
                        nummenu -= 1;
                    }
                }
                //артефакты
                else if (MainMenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine($@"магазин артефактов денег: {money}§");
                    Console.WriteLine($@"1. {bloodstone} стоимость: {cena7} § (+вампирик (10%) (в разработке) ");
                    Console.WriteLine($@"2. {ahatofhealth} стоимость: {cena5} § (+{ahatofhealthhp} здоровье)  ");
                    Console.WriteLine($@"3. {bloodamulet} стоимость: {cena6} § (+{bloodamuletdam} к урону)  ");
                    Console.WriteLine($@"4. {ringofprotection} стоимость: {cena1} § (+{ringofprotectiondef} защиты)");
                    Console.WriteLine($@"5. {palka} стоимость: {cena0} § (+{palkadam} урона) ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($@"6. {darovanieoflean} стоимость: {cena6} § (+{darovanieofleanhp} здоровья, +{darovanieofleandam} урона, +{darovanieofleandef} защиты)");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"7. {stoneofdemon} стоимость: {cenaartdemona} § (+{stoneofdemondam}  урона)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("     Напиши: 10, чтобы вернуться назад                                                                                 ");
                    int artefaktsshop = Convert.ToInt32(Console.ReadLine());
                    if (artefaktsshop == 1)
                    {
                        if (money >= cena7)
                        {
                            vampiricbuy += 10;
                        }
                        else if (money < cena7)
                        {
                            Console.WriteLine("Не хватает золота");
                        }

                    }
                    else if (artefaktsshop == 2)
                    {
                        if (money >= cena5)
                        {
                            money -= cena5;
                            HealthPlayerDefault += ahatofhealthhp;
                            healthart += ahatofhealthhp;
                        }
                        else if (money < cena5)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                    else if (artefaktsshop == 3)
                    {
                        if (money >= cena6)
                        {
                            money -= cena6;
                            Damagep += bloodamuletdam;
                        }
                        else if (money < cena6)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                    else if (artefaktsshop == 4)
                    {
                        if (money >= cena1)
                        {
                            money -= cena1;
                            defense += ringofprotectiondef;
                            defenseart += ringofprotectiondef;
                        }
                        else if (money < cena1)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                    else if (artefaktsshop == 5)
                    {
                        if (money >= cena0)
                        {
                            money -= cena0;
                            Damagep += palkadam;
                            damageart += palkadam;
                        }
                        else if (money < cena0)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                    else if (artefaktsshop == 6)
                    {
                        if (money >= cena6)
                        {
                            money -= cena6;
                            Damagep += darovanieofleandam;
                            HealthPlayerDefault += darovanieofleanhp;
                            obschdef += darovanieofleandef;
                            healthart += darovanieofleanhp;
                            defenseart += darovanieofleandef;
                            obschdam += darovanieofleandam;
                        }
                        else if (money < cena6)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                    else if (artefaktsshop == 7)
                    {
                        if (money >= cenaartdemona)
                        {
                            money -= cenaartdemona;
                            Damagep += stoneofdemondam;
                            damageart += stoneofdemondam;
                        }
                        else if (money < cenaartdemona)
                        {
                            Console.WriteLine("Не хватает золота");
                        }
                    }
                }
                //остров крабов
                else if (MainMenu == 3)
                {

                    Console.Clear();
                    introforcrabs += 1;
                    if (introforcrabs == 1) {
                        Console.Write(ostrovK, " - это очень опасное масто для простых людей,");
                        Console.Write(" - ");
                        Thread.Sleep(100);
                        Console.Write("это ");
                        Thread.Sleep(100);
                        Console.Write("очень ");
                        Thread.Sleep(100);
                        Console.Write("о");
                        Thread.Sleep(100);
                        Console.Write("п");
                        Thread.Sleep(100);
                        Console.Write("а");
                        Thread.Sleep(100);
                        Console.Write("с");
                        Thread.Sleep(100);
                        Console.Write("н");
                        Thread.Sleep(100);
                        Console.Write("о");
                        Thread.Sleep(100);
                        Console.Write("е ");
                        Thread.Sleep(100);
                        Console.Write("м");
                        Thread.Sleep(100);
                        Console.Write("е");
                        Thread.Sleep(100);
                        Console.Write("с");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.WriteLine("о");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("а");
                        Thread.Sleep(100);
                        Console.Write("к ");
                        Thread.Sleep(100);
                        Console.Write("ч");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("о ");
                        Thread.Sleep(100);
                        Console.Write("б");
                        Thread.Sleep(100);
                        Console.Write("у");
                        Thread.Sleep(100);
                        Console.Write("д");
                        Thread.Sleep(100);
                        Console.Write("ь");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("е ");
                        Thread.Sleep(100);
                        Console.Write("вн");
                        Thread.Sleep(100);
                        Console.Write("им");
                        Thread.Sleep(100);
                        Console.Write("ат");
                        Thread.Sleep(100);
                        Console.Write("ель");
                        Thread.Sleep(100);
                        Console.Write("ней!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.WriteLine($@"         Добро Пожаловать на остров крабов!!!                                   ");
                    Console.WriteLine($@"               Выберите куда хотите пойти:                                      ");
                    Console.WriteLine($@"                                                                                ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"     1. /---------------\          крабы обыкновенные                                             ");
                    Console.WriteLine($@"       /   1       1     \         Здоровье: {kripscrabobikshp}                                              ");
                    Console.WriteLine($@"      /-------------------\        Защита: {kripscrabsobikdef}                                                                  ");
                    Console.WriteLine($@"     /    \           /    \       Урон: {kripscrabsobikdam}                                               ");
                    Console.WriteLine($@"    /                       \     Золото: от 5 до 10                                                ");
                    Console.WriteLine($@"                                                                                ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@" 2.    /================================\          /   Элитный Краб             ");
                    Console.WriteLine($@"      /                                  \        /    Здоровье: {kripscrabelitehp}                ");
                    Console.WriteLine($@" |---/       00#0               0#00      \------/     Защита:  {kripscrabelitedef}                ");
                    Console.WriteLine($@" |  /                                      \           Урон: {kripscrabelitedam}                   ");
                    Console.WriteLine($@"   /----------------------------------------\          Золото: от 10 до 15                          ");
                    Console.WriteLine($@"  /                                          \                                  ");
                    Console.WriteLine($@"                                                                                ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@" 3.            |-_-_-_-_-_-_-_-_-_-|               Король Крабов                                                    ");
                    Console.WriteLine($@"               | /              \  |               Здоровье: {kripscrabkorolhp}                            ");
                    Console.WriteLine($@"               |/                \ |               Защита: {kripscrabkoroldam}                         ");
                    Console.WriteLine($@"               |___________________|               Урон: {kripscrabkoroldef}                            ");
                    Console.WriteLine($@"           _-------------------------------_                                                                  ");
                    Console.WriteLine($@"          /       0               0          \                |                   ");
                    Console.WriteLine($@"         /       090             090          \               |                    ");
                    Console.WriteLine($@"        /         0               0            \--------------+----------       ");
                    Console.WriteLine($@"       /========================================\             |                    ");
                    Console.WriteLine($@"      /                                          \            |                   ");
                    Console.WriteLine($@"     /                                            \                              ");
                    Console.WriteLine($@"    /                                              \                              ");
                    Console.WriteLine($@"                                                     Золото: от 20 до 25         ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@"                Напишите 4, что бы выйти из меню         ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int fightcrabs = Convert.ToInt32(Console.ReadLine());
                    if (fightcrabs == 1)
                    {
                        Console.Clear();
                        while (kripscrabobikshp > 0)
                        {
                            Console.WriteLine($@" Здоровье: {HealthPlayer}/{HealthPlayerDefault}      ");
                            Console.WriteLine($@"        /---------------\          краб обыкновенный                                            ");
                            Console.WriteLine($@"       /   1       1     \         Здоровье:  {kripscrabobikshp}                                             ");
                            Console.WriteLine($@"      /-------------------\        Защита: {kripscrabsobikdef}                                                                  ");
                            Console.WriteLine($@"     /    \           /    \       Урон:  {kripscrabsobikdam}                                              ");
                            Console.WriteLine($@"    /                       \                                                    ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать                                2. Защищаться    3. Назад В Меню  ");
                            int fightcrabsodin = Convert.ToInt32(Console.ReadLine());
                            if (fightcrabsodin == 1)
                            {
                                Console.Clear();
                                kripscrabobikshp -= (DamagePlayer - kripscrabsobikdef);
                                HealthPlayer -= (kripscrabsobikdam - DefensePlayer);
                                if (kripscrabobikshp > 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                }
                                else if (kripscrabobikshp <= 0)
                                {
                                    if (HealthPlayer > 0)
                                    {
                                        Console.WriteLine("Победа!!!");
                                        Thread.Sleep(2000);
                                        nummenu -= 1;
                                        money += randcenacrabsobik;
                                        Console.Clear();
                                    }
                                    else if (HealthPlayer <= 0)
                                    {
                                        Console.WriteLine("Ты умер(");
                                    }
                                }
                            }
                            else if (fightcrabsodin == 2)
                            {
                                HealthPlayer -= (kripscrabsobikdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            else if (fightcrabsodin == 3)
                            {
                                break;
                            }
                            else if (fightcrabsodin >= 4)
                            {
                                Console.WriteLine("Нет такого действия(");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                    }
                    else if (fightcrabs == 2)
                    {
                        Console.Clear();
                        while (kripscrabelitehp > 0)
                        {
                            if (HealthPlayerDefault < HealthPlayer)
                            {

                                HealthPlayer = HealthPlayerDefault;

                            }
                            if (HealthPlayer == 0)
                            {
                                Environment.Exit(0);
                            }
                            Console.WriteLine($@" Здоровье: {HealthPlayer}      ");
                            Console.WriteLine($@"                                                                                ");
                            Console.WriteLine($@"       /================================\          /   Элитный Краб             ");
                            Console.WriteLine($@"      /                                  \        /    Здоровье: {kripscrabelitehp}               ");
                            Console.WriteLine($@" |---/       00#0               0#00      \------/     Защита: {kripscrabelitedef}                 ");
                            Console.WriteLine($@" |  /                                      \           Урон: {kripscrabelitedam}                   ");
                            Console.WriteLine($@"   /----------------------------------------\          Золото: от 10 до 15                          ");
                            Console.WriteLine($@"  /                                          \                                  ");
                            Console.WriteLine($@"                                                                                ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать                                2. Защищаться    3. Назад В Меню  ");
                            int fightcrabsdva = Convert.ToInt32(Console.ReadLine());
                            if (fightcrabsdva == 1)
                            {
                                Console.Clear();
                                if (HealthPlayerDefault < HealthPlayer)
                                {
                                    HealthPlayer = HealthPlayerDefault;
                                }
                                kripscrabelitehp -= (DamagePlayer - kripscrabelitedef);
                                HealthPlayer -= (kripscrabelitedam - DefensePlayer);
                                if (kripscrabelitehp > 0)
                                {
                                    Console.Clear();
                                }
                                else if (kripscrabelitehp < 0)
                                {
                                    if (HealthPlayer > 0) {
                                        Console.WriteLine("Победа!!!");
                                        Thread.Sleep(2000);
                                        money += randcenacrabselite;
                                        nummenu -= 1;
                                        Console.Clear();
                                    }
                                    else if (HealthPlayer <= 0)
                                    {
                                        Console.WriteLine("Ты умер(");
                                    }
                                }
                            }
                            else if (fightcrabsdva == 2)
                            {
                                HealthPlayer -= (-(DefensePlayer * 2));
                                Console.Clear();
                            }
                            else if (fightcrabsdva == 3)
                            {
                                break;
                            }
                            else if (fightcrabsdva >= 4)
                            {
                                Console.WriteLine("Нет такого действия(");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                    }
                    else if (fightcrabs == 3)
                    {
                        Console.Clear();
                        while (kripscrabobikshp > 0)
                        {
                            Console.WriteLine($@" Здоровье: {HealthPlayer}      ");
                            Console.WriteLine($@"               |-_-_-_-_-_-_-_-_-_-|               Король Крабов                                                    ");
                            Console.WriteLine($@"               | /               \ |               Здоровье: {kripscrabkorolhp}                             ");
                            Console.WriteLine($@"               |/                 \|               Защита:  {kripscrabkoroldef}                            ");
                            Console.WriteLine($@"               |___________________|               Урон: {kripscrabkoroldam}                             ");
                            Console.WriteLine($@"           _-------------------------------_                                                                  ");
                            Console.WriteLine($@"          /       0               0          \                |                   ");
                            Console.WriteLine($@"         /       090             090          \               |                    ");
                            Console.WriteLine($@"        /         0               0            \--------------+----------       ");
                            Console.WriteLine($@"       /========================================\             |                    ");
                            Console.WriteLine($@"      /                                          \            |                   ");
                            Console.WriteLine($@"     /                                            \                              ");
                            Console.WriteLine($@"    /                                              \                              ");
                            Console.WriteLine($@"                                                     Золото: от 20 до 25         ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать                                2. Защищаться    3. Назад В Меню  ");
                            int fightcrabstri = Convert.ToInt32(Console.ReadLine());
                            if (HealthPlayer <= 0)
                            {
                                Console.WriteLine("Ты проиграл...");
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                            }
                            else if (fightcrabstri == 1)
                            {
                                kripscrabkorolhp -= (DamagePlayer - kripscrabkoroldef);
                                HealthPlayer -= (kripscrabkoroldam - DefensePlayer);
                                Console.Clear();

                                if (kripscrabkorolhp > 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {

                                        HealthPlayer = HealthPlayerDefault;

                                    }
                                    Console.Clear();
                                }
                                else if (kripscrabkorolhp <= 0)
                                {
                                    if (HealthPlayer > 0)
                                    {
                                        Console.WriteLine("Победа!!!");
                                        Thread.Sleep(2000);
                                        money += randcenacrabskorol;
                                        nummenu -= 1;
                                        Console.Clear();
                                        break;
                                    }
                                    else if (HealthPlayer <= 0)
                                    {
                                        Console.WriteLine("Ты умер(");
                                    }
                                }
                            }
                            else if (fightcrabstri == 2)
                            {
                                HealthPlayer -= (kripscrabsobikdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            else if (fightcrabstri == 3)
                            {
                                break;
                            }
                            else if (fightcrabstri >= 4)
                            {
                                Console.WriteLine("Нет такого действия(");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }

                        }
                    }
                    else if (fightcrabs >= 4)
                    {
                        nummenu -= 1;
                    }
                }
                //остров друидов
                else if (MainMenu == 4)
                {
                    introfordruids += 1;
                    if (introfordruids == 1)
                    {
                        Console.Clear();
                        Console.Write("Друиды ");
                        Thread.Sleep(200);
                        Console.Write("- жрецы ");
                        Thread.Sleep(200);
                        Console.Write("у древних ");
                        Thread.Sleep(200);
                        Console.Write("кельтских народов, ");
                        Thread.Sleep(200);
                        Console.Write("организованные в виде");
                        Thread.Sleep(200);
                        Console.Write(" замкнутого, ");
                        Thread.Sleep(200);
                        Console.Write("но не ");
                        Thread.Sleep(200);
                        Console.Write("наследственного сословия");
                        Thread.Sleep(200);
                        Console.WriteLine(" ");
                        Console.Write("                                  ");
                        Thread.Sleep(200);
                        Console.Write("Б");
                        Thread.Sleep(200);
                        Console.Write("у");
                        Thread.Sleep(200);
                        Console.Write("");
                        Thread.Sleep(200);
                        Console.Write("д");
                        Thread.Sleep(200);
                        Console.Write("ь");
                        Thread.Sleep(200);
                        Console.Write("т");
                        Thread.Sleep(200);
                        Console.Write("е");
                        Thread.Sleep(200);
                        Console.Write(" ");
                        Console.Write("акк");
                        Thread.Sleep(200);
                        Console.Write("ур");
                        Thread.Sleep(200);
                        Console.Write("ат");
                        Thread.Sleep(200);
                        Console.Write("ны");
                        Thread.Sleep(200);
                        Console.Write("!");
                        Thread.Sleep(4000);
                        Console.Clear();
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(ostrovD);
                    Console.WriteLine($@"                      Добро пожаловать на остров друидов!!!                                                                                             ");
                    Console.WriteLine($@"                                                      Кого зарейдим?                                                            ");
                    Console.WriteLine($@"  Здоровье: {druidmechnikhp}                     Здоровье: {druidmonahhp}                       Здоровье: {druidkillerhp}                                                                                            ");
                    Console.WriteLine($@"  Урон: {druidmechnikdam}                         Урон: {druidmonahdam}                             Урон: {druidkillerdam}                                                                                        ");
                    Console.WriteLine($@"  Защита: {druidmechnikdef}                       Защита: {druidmonahdef}                          Защита: {druidkillerdef}                                                                                            ");
                    Console.WriteLine($@"                                                                                                                  ");
                    Console.WriteLine($@"     1. Друид-Мечник               2. Друид-Монах                       3. Друид-Убийца                                                               ");
                    Console.WriteLine($@"                                     ____________                       |==============|                                                       ");
                    Console.WriteLine($@"       |-------|                     \  9    9  /                       |  000     000 |                                        ");
                    Console.WriteLine($@"       | 0   0 |                      \        /     ____________       |  090     090 |                                             ");
                    Console.WriteLine($@"       |       |                       \  О   /      |           \      |==============|                                  ");
                    Console.WriteLine($@"        \  -  /                         \    /       |            \     |==============|                                 ");
                    Console.WriteLine($@"         \   /                            |          |                          0                                      ");
                    Console.WriteLine($@"          \ /                             |          |                          0                                       ");
                    Console.WriteLine($@"           |    \------|                  |          |                          0                                       ");
                    Console.WriteLine($@"          /|\    \     |                 /|----------|                         /0\                                                   ");
                    Console.WriteLine($@"         / | \    \    |                / |          |                        / 0 \                                        ");
                    Console.WriteLine($@"        /  |  \   /\___|               /  |          |                       /  0  \                                           ");
                    Console.WriteLine($@"       /   |   \ /                    /   |          |                      /   0   \                                     ");
                    Console.WriteLine($@" <===|---  |    /                    /    |          |                     /    0   =====))¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦►                                    ");
                    Console.WriteLine($@"           |                              |          |                          0                                      ");
                    Console.WriteLine($@"           |                              |          |                         / \                                      ");
                    Console.WriteLine($@"           |                             / \         |                        /   \                                    ");
                    Console.WriteLine($@"          / \                           /   \        |                       /     \                                      ");
                    Console.WriteLine($@"         /   \                         /     \       |                      /       \                                    ");
                    Console.WriteLine($@"        /     \                       /       \      |                     /         \                                    ");
                    Console.WriteLine($@"       /       \                     /         \     |                    /           \                                   ");
                    Console.WriteLine($@"   ___/         \___            ____/           \____|               ____/             \____                                             ");
                    Console.WriteLine($@"  4. Выйти                                             ");
                    int Druidnumber = Convert.ToInt32(Console.ReadLine());
                    if (Druidnumber == 1)
                    {
                        Console.Clear();

                        while (druidmechnikhp > 0)
                        {
                            if (HealthPlayerDefault < HealthPlayer)
                            {
                                HealthPlayer = HealthPlayerDefault;
                            }
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"                                                                                                               ");
                            Console.WriteLine($@"            Твое Здоровье: {HealthPlayer}                                                                                             ");
                            Console.WriteLine($@"                                                                                                               ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"     Друид-Мечник                                         ");
                            Console.WriteLine($@"                                                             ");
                            Console.WriteLine($@"       |-------|                                             ");
                            Console.WriteLine($@"       | 0   0 |                                             ");
                            Console.WriteLine($@"       |       |                                             ");
                            Console.WriteLine($@"        \  -  /                 Здоровье: {druidmechnikhp}   ");
                            Console.WriteLine($@"         \   /                                               ");
                            Console.WriteLine($@"          \ /                                                ");
                            Console.WriteLine($@"           |    \------|                                     ");
                            Console.WriteLine($@"          /|\    \     |        Урон: {druidmechnikdam}      ");
                            Console.WriteLine($@"         / | \    \    |                                     ");
                            Console.WriteLine($@"        /  |  \   /\___|                                     ");
                            Console.WriteLine($@"       /   |   \ /                                           ");
                            Console.WriteLine($@" <===|---  |    /               Защита: {druidmechnikdef}    ");
                            Console.WriteLine($@"           |                                                 ");
                            Console.WriteLine($@"           |                                                 ");
                            Console.WriteLine($@"           |                                                 ");
                            Console.WriteLine($@"          / \                                                ");
                            Console.WriteLine($@"         /   \                                               ");
                            Console.WriteLine($@"        /     \                                              ");
                            Console.WriteLine($@"       /       \                                             ");
                            Console.WriteLine($@"   ___/         \___                                         ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fightdruidmechnik = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidmechnik == 1)
                            {
                                druidmechnikhp -= (DamagePlayer - druidmechnikdef);
                                HealthPlayer -= (druidmechnikdam - DefensePlayer);
                                if (kripscrabobikshp > 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                    if (druidmechnikhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenadruidmechnikodin;
                                            Console.Clear();
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер(");
                                        }
                                    }
                                }
                            }
                            if (fightdruidmechnik == 2)
                            {
                                HealthPlayer -= (druidmonahdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            if (fightdruidmechnik == 3)
                            {
                                break;
                            }
                            if (fightdruidmechnik >= 4)
                            {
                                Console.WriteLine("Такого действия нет");
                            }

                        }
                    }
                    else if (Druidnumber == 2)
                    {
                        while (druidmonahhp > 0)
                        {
                            Console.Clear();
                            Console.WriteLine($@"                                                                 ");
                            Console.WriteLine($@"        Твое Здоровье: {HealthPlayer}                                              ");
                            Console.WriteLine($@"                                                             ");
                            Console.WriteLine($@"                                                                                                         ");
                            Console.WriteLine($@"     Друид-Монах                                                                              ");
                            Console.WriteLine($@"       ____________                                                                        ");
                            Console.WriteLine($@"       \  9    9  /                                                           ");
                            Console.WriteLine($@"        \        /     ____________                                           ");
                            Console.WriteLine($@"         \  О   /      |           \                                  ");
                            Console.WriteLine($@"          \    /       |            \                                      ");
                            Console.WriteLine($@"            |          |                                                          ");
                            Console.WriteLine($@"            |          |                                                   ");
                            Console.WriteLine($@"            |          |                                            ");
                            Console.WriteLine($@"           /|----------|                  Здоровье: {druidmonahhp}                                       ");
                            Console.WriteLine($@"          / |          |                                        ");
                            Console.WriteLine($@"         /  |          |                                                 ");
                            Console.WriteLine($@"        /   |          |                                    ");
                            Console.WriteLine($@"            |          |                    Урон: {druidmonahdam}          ");
                            Console.WriteLine($@"            |          |                                         ");
                            Console.WriteLine($@"            |          |                                           ");
                            Console.WriteLine($@"           / \         |                                      ");
                            Console.WriteLine($@"          /   \        |                                          ");
                            Console.WriteLine($@"         /     \       |                                        ");
                            Console.WriteLine($@"        /       \      |                 Защита: {druidmonahdef}                               ");
                            Console.WriteLine($@"       /         \     |                                          ");
                            Console.WriteLine($@"  ____/           \____|                                 ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fightdruidmonah = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidmonah == 1)
                            {
                                druidmonahhp -= (DamagePlayer - druidmonahdef);
                                HealthPlayer -= (druidmonahdam - DefensePlayer);
                                if (druidmonahhp > 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                }
                            }
                            if (druidmonahhp <= 0)
                            {
                                if (HealthPlayer > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Победа!!!");
                                    Thread.Sleep(2000);
                                    nummenu -= 1;
                                    money += randcenadruidmonahdva;
                                    Console.Clear();
                                }
                                else if (HealthPlayer <= 0)
                                {
                                    Console.WriteLine("Ты умер(");
                                }
                            }

                            else if (fightdruidmonah == 2)
                            {
                                HealthPlayer -= (druidmonahdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            else if (fightdruidmonah == 3)
                            {
                                nummenu -= 1;
                                break;
                            }
                            else if (fightdruidmonah >= 4)
                            {
                                Console.WriteLine("нет такого действия");
                            }


                        }
                    }
                    else if (Druidnumber == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        while (druidkillerhp > 0) 
                        {
                            Console.WriteLine($@"    Твое Здоровье: {HealthPlayer}                                                                                  ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"                                                                                                           ");
                            Console.WriteLine($@"                                                                                                       ");
                            Console.WriteLine($@"                                                                                                          ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"               Друид-Убийца                                                               ");
                            Console.WriteLine($@"            |==============|                                                       ");
                            Console.WriteLine($@"            |  000     000 |                                        ");
                            Console.WriteLine($@"            |  090     090 |                                             ");
                            Console.WriteLine($@"            |==============|                                  ");
                            Console.WriteLine($@"            |==============|                Здоровье: {druidkillerhp}                 ");
                            Console.WriteLine($@"                   0                                      ");
                            Console.WriteLine($@"                   0                                       ");
                            Console.WriteLine($@"                   0                                       ");
                            Console.WriteLine($@"                  /0\                                                   ");
                            Console.WriteLine($@"                 / 0 \                                        ");
                            Console.WriteLine($@"                /  0  \                                           ");
                            Console.WriteLine($@"               /   0   \                             Урон: {druidkillerdam}        ");
                            Console.WriteLine($@"              /    0   =====))¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦►                                    ");
                            Console.WriteLine($@"                   0                                      ");
                            Console.WriteLine($@"                  / \                                      ");
                            Console.WriteLine($@"                 /   \                                    ");
                            Console.WriteLine($@"                /     \                                      ");
                            Console.WriteLine($@"               /       \                  Защита: {druidkillerdef}                   ");
                            Console.WriteLine($@"              /         \                                    ");
                            Console.WriteLine($@"             /           \                                   ");
                            Console.WriteLine($@"        ____/             \____                                             ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fightdruidkiller = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidkiller == 1)
                            {
                                druidkillerhp -= (DamagePlayer - druidkillerdef);
                                HealthPlayer -= (druidkillerdam - DefensePlayer);
                                if (druidmonahhp > 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                    if (druidkillerhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenadruidkilertri;
                                            Console.Clear();
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер(");
                                        }
                                    }
                                }
                                if (fightdruidkiller == 2)
                                {
                                    HealthPlayer -= (druidkillerdam - (DefensePlayer * 2));
                                    Console.Clear();
                                }
                                if (fightdruidkiller == 3)
                                {
                                    break;
                                }
                            }
                            if (fightdruidkiller == 2)
                            {
                                HealthPlayer -= (druidmonahdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            if (fightdruidkiller == 3)
                            {
                                break;
                            }
                        }
                    }
                    else if (Druidnumber >= 4)
                    {
                        nummenu -= 1;
                    }
                }
                //остров траллов
                else if (MainMenu == 5)
                {
                    Console.Clear();
                    introfortralls += 1;
                    if (introfortralls == 1)
                    {
                        Console.Write(ostrovT, " - это очень опасное масто для простых людей,");
                        Console.Write(" - ");
                        Thread.Sleep(100);
                        Console.Write("это ");
                        Thread.Sleep(100);
                        Console.Write("очень ");
                        Thread.Sleep(100);
                        Console.Write("о");
                        Thread.Sleep(100);
                        Console.Write("п");
                        Thread.Sleep(100);
                        Console.Write("а");
                        Thread.Sleep(100);
                        Console.Write("с");
                        Thread.Sleep(100);
                        Console.Write("н");
                        Thread.Sleep(100);
                        Console.Write("о");
                        Thread.Sleep(100);
                        Console.Write("е ");
                        Thread.Sleep(100);
                        Console.Write("м");
                        Thread.Sleep(100);
                        Console.Write("е");
                        Thread.Sleep(100);
                        Console.Write("с");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.WriteLine("о");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("а");
                        Thread.Sleep(100);
                        Console.Write("к ");
                        Thread.Sleep(100);
                        Console.Write("ч");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("о ");
                        Thread.Sleep(100);
                        Console.Write("б");
                        Thread.Sleep(100);
                        Console.Write("у");
                        Thread.Sleep(100);
                        Console.Write("д");
                        Thread.Sleep(100);
                        Console.Write("ь");
                        Thread.Sleep(100);
                        Console.Write("т");
                        Thread.Sleep(100);
                        Console.Write("е ");
                        Thread.Sleep(100);
                        Console.Write("вн");
                        Thread.Sleep(100);
                        Console.Write("им");
                        Thread.Sleep(100);
                        Console.Write("ат");
                        Thread.Sleep(100);
                        Console.Write("ель");
                        Thread.Sleep(100);
                        Console.Write("ней!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"         Добро Пожаловать на остров Траллов!!!                                   ");
                    Console.WriteLine($@"               Выберите на кого хотите напасть:                                      ");
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@" Здоровье:{trallohotnikhp}                 Здоровье: {trallshamanhp}                  Здоровье:{tralltankhp}                                                                    ");
                    Console.WriteLine($@" Урон:   {trallohotnikdam}                   Физ. урон:{trallshamandamphys}                   Урон:   {tralltankdam}                                                                           ");
                    Console.WriteLine($@" Защита: {trallohotnikdef}                   Маг. Урон {trallshamandammage}                   Защита: {tralltankdef}                                                                        ");
                    Console.WriteLine($@"                               Защита:  {trallshamandef}                                                             ");
                    Console.WriteLine($@"    1. Друид-Охотник                   2. Тралл-Шаман                    3. Тралл-Танк                                                            ");
                    Console.WriteLine($@"      |-------------|                      [----------]                  _____________________                                             ");
                    Console.WriteLine($@"      |  8      8   |                      [ 0     0  ]                  |     \       /      |            ");
                    Console.WriteLine($@"      |             |                      [  ------  ]                  |   000       000    |            ");
                    Console.WriteLine($@"      | 1010101010  |                      [__________]                  |   090       090    |                      ");
                    Console.WriteLine($@"      |=============|                          //        ?    ?          |   000       000    |              ");
                    Console.WriteLine($@"           |  |                               //         ______  ~       |    ----------      |                    ");
                    Console.WriteLine($@"           |  |                              //      ~  /######\  ~      |____________________|                ");
                    Console.WriteLine($@"           |  |                             //      ~  /########\~              |######|                     ");
                    Console.WriteLine($@"           |  |                            ||========= |########|  ~            |######|                               ");
                    Console.WriteLine($@"     ______|  |_______                     ||       ~  |########| ~            /|######|\                              ");
                    Console.WriteLine($@"    /      |  |       \                    ||========= |########|  ~          / |######| \                             ");
                    Console.WriteLine($@"   /       |  |        \                   ||        ~  \######/ ~           / /|######|\ \                   ");
                    Console.WriteLine($@"  /        |  |         \                  \\       ~    \____/  ~          / / |######| \ \                   ");
                    Console.WriteLine($@"|------|   |  |     =====))=========>       \\                             / /  |######|  \ \                            ");
                    Console.WriteLine($@"\      /   |  |                              \\        ?       ?          / /   |######|   \ \                 ");
                    Console.WriteLine($@" \    /    |  |                               \\                         / /    |######|    \ \              ");
                    Console.WriteLine($@"  \__/     |  |                                \\                       / /     |######|     \ \             ");
                    Console.WriteLine($@"           |  |                                 \\                     / /      |######|      \ \          ");
                    Console.WriteLine($@"          /    \                                / \                   /_/       |######|       \_\          ");
                    Console.WriteLine($@"         /      \                              /   \                            |######|                 ");
                    Console.WriteLine($@"        /        \                            /     \                           |######|                  ");
                    Console.WriteLine($@"       /          \                          /       \                         /        \                 ");
                    Console.WriteLine($@"      /            \                        /         \                       /          \                ");
                    Console.WriteLine($@"     /              \                      /           \                     /            \              ");
                    Console.WriteLine($@"    /                \                    /             \                   /              \             ");
                    Console.WriteLine($@"                                                                           /                \          ");
                    Console.WriteLine($@"                                                                          /                  \         ");
                    Console.WriteLine($@"                                                                         /                    \        ");
                    Console.WriteLine($@"                                                                   _____/                      \_____       ");
                    Console.WriteLine($@"                                                                  /____|                        |____\      ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@"                         4. Выйти в меню                                                                                               ");
                    int fighttrall = Convert.ToInt32(Console.ReadLine());
                    if (fighttrall == 1)
                    {
                        Console.Clear();

                        while (trallohotnikhp > 0)
                        {
                            if (HealthPlayerDefault < HealthPlayer)
                            {
                                HealthPlayer = HealthPlayerDefault;
                            }
                            Console.WriteLine($@"                                                                             ");
                            Console.WriteLine($@"        Здоровье: {HealthPlayer}                         ");
                            Console.WriteLine($@"                                                                                    ");
                            Console.WriteLine($@"                                          ");
                            Console.WriteLine($@"       Друид-Охотник                           ");
                            Console.WriteLine($@"      |-------------|                          ");
                            Console.WriteLine($@"      |  8      8   |                            ");
                            Console.WriteLine($@"      |             |          Здоровье:{trallohotnikhp}                  ");
                            Console.WriteLine($@"      | 1010101010  |                                 ");
                            Console.WriteLine($@"      |=============|                        ");
                            Console.WriteLine($@"           |  |                                            ");
                            Console.WriteLine($@"           |  |                                          ");
                            Console.WriteLine($@"           |  |                                    ");
                            Console.WriteLine($@"           |  |                                                 ");
                            Console.WriteLine($@"     ______|  |_______                                       ");
                            Console.WriteLine($@"    /      |  |       \                Урон:   {trallohotnikdam}                      ");
                            Console.WriteLine($@"   /       |  |        \                         ");
                            Console.WriteLine($@"  /        |  |         \                              ");
                            Console.WriteLine($@"|------|   |  |     =====))=========>                            ");
                            Console.WriteLine($@"\      /   |  |                                     ");
                            Console.WriteLine($@" \    /    |  |                                  ");
                            Console.WriteLine($@"  \__/     |  |                                  ");
                            Console.WriteLine($@"           |  |                                    ");
                            Console.WriteLine($@"          /    \                                ");
                            Console.WriteLine($@"         /      \                                 ");
                            Console.WriteLine($@"        /        \                             ");
                            Console.WriteLine($@"       /          \                                ");
                            Console.WriteLine($@"      /            \               Защита: {trallohotnikdef}              ");
                            Console.WriteLine($@"     /              \                         ");
                            Console.WriteLine($@"    /                \                          ");
                            Console.WriteLine($@"                                            ");
                            Console.WriteLine($@"                                            ");
                            Console.WriteLine($@"                                          ");
                            Console.WriteLine($@"                                           ");
                            Console.WriteLine($@"                                             ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fighttrallohotnik = Convert.ToInt32(Console.ReadLine());
                            if (fighttrallohotnik == 1)
                            {
                                trallohotnikhp -= DamagePlayer - trallohotnikdef;
                                HealthPlayer -= trallohotnikdam - DefensePlayer;
                                if (trallohotnikhp < 0)
                                {
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                   if (trallohotnikhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenatrallohotnikodin;
                                            Console.Clear();
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер...");
                                        }
                                    }
                                }
                            }
                            if (fighttrallohotnik == 2)
                            {
                                HealthPlayer -= (trallohotnikdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            if (fighttrallohotnik == 3)
                            {
                                break;
                            }
                            if (fighttrallohotnik >= 4)
                            {
                                Console.WriteLine("Такого действия нет");
                            }

                        }
                    }
                    if (fighttrall == 2)
                    {
                        Console.Clear();

                        while (trallshamanhp > 0)
                        {
                            if (HealthPlayerDefault < HealthPlayer)
                            {
                                HealthPlayer = HealthPlayerDefault;
                            }
                            Console.WriteLine($@"                                                                                           ");
                            Console.WriteLine($@"      Твое Здоровье: {HealthPlayer}                                                                             ");
                            Console.WriteLine($@"                                                                         ");
                            Console.WriteLine($@"                                                            ");
                            Console.WriteLine($@"      Тралл-Шаман                                                          ");
                            Console.WriteLine($@"      [----------]                             ");
                            Console.WriteLine($@"      [ 0     0  ]                      ");
                            Console.WriteLine($@"      [  ------  ]                        ");
                            Console.WriteLine($@"      [__________]                                   ");
                            Console.WriteLine($@"           //        ?    ?                ");
                            Console.WriteLine($@"          //         ______  ~      Здоровье: {trallshamanhp}                ");
                            Console.WriteLine($@"         //      ~  /######\  ~               ");
                            Console.WriteLine($@"        //      ~  /########\~            ");
                            Console.WriteLine($@"       ||========= |########|  ~  Физ. урон:{trallshamandamphys}               ");
                            Console.WriteLine($@"       ||       ~  |########| ~                              ");
                            Console.WriteLine($@"       ||========= |########|  ~  Маг. Урон {trallshamandammage}                             ");
                            Console.WriteLine($@"       ||        ~  \######/ ~                     ");
                            Console.WriteLine($@"        \\       ~    \____/  ~                ");
                            Console.WriteLine($@"         \\                                                     ");
                            Console.WriteLine($@"          \\        ?       ?                    ");
                            Console.WriteLine($@"           \\                                ");
                            Console.WriteLine($@"            \\                                 ");
                            Console.WriteLine($@"             \\                         ");
                            Console.WriteLine($@"             / \                       ");
                            Console.WriteLine($@"            /   \               Защита:  {trallshamandef}");
                            Console.WriteLine($@"           /     \                      ");
                            Console.WriteLine($@"          /       \                      ");
                            Console.WriteLine($@"         /         \                      ");
                            Console.WriteLine($@"        /           \                  ");
                            Console.WriteLine($@"       /             \                 ");
                            Console.WriteLine($@"                                                                     ");
                            Console.WriteLine($@"                                                                   ");
                            Console.WriteLine($@"                                                                  ");
                            Console.WriteLine($@"                                                                   ");
                            Console.WriteLine($@"                                                                    ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fighttrallshaman = Convert.ToInt32(Console.ReadLine());
                            if (fighttrallshaman == 1)
                            {
                                if (trallshamanhp > 0)
                                {
                                trallshamanhp -= (DamagePlayer - trallshamandef);
                                HealthPlayer -= (trallshamandamphys - DefensePlayer);
                                HealthPlayer -= (trallshamandammage - (DefensePlayer / 2));
                                
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                    if (trallshamanhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenatrallshamandva;
                                            Console.Clear();
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер(");
                                        }
                                    }
                                }
                            }
                            if (fighttrallshaman == 2)
                            {
                                HealthPlayer -= (trallshamandamphys - (DefensePlayer * 2));
                                Console.Clear();
                            }
                            if (fighttrallshaman == 3)
                            {
                                break;
                            }
                            if (fighttrallshaman >= 4)
                            {
                                Console.WriteLine("Такого действия нет");
                            }

                        }
                    }
                    if (fighttrall == 3)
                    {
                        Console.Clear();
                        while (tralltankhp > 0)
                        {
                            if (HealthPlayerDefault < HealthPlayer)
                            {
                                HealthPlayer = HealthPlayerDefault;
                            }
                            Console.WriteLine($@"                                                                       ");
                            Console.WriteLine($@"           Твое здоровье: {HealthPlayer}                                                                 ");
                            Console.WriteLine($@"                                                                                      ");
                            Console.WriteLine($@"                                                                ");
                            Console.WriteLine($@"                Тралл-Танк                                                            ");
                            Console.WriteLine($@"              _____________________                                             ");
                            Console.WriteLine($@"              |     \       /      |            ");
                            Console.WriteLine($@"              |   000       000    |            ");
                            Console.WriteLine($@"              |   090       090    |                      ");
                            Console.WriteLine($@"              |   000       000    |              ");
                            Console.WriteLine($@"              |    ----------      |                    ");
                            Console.WriteLine($@"              |____________________|        Здоровье:{tralltankhp}        ");
                            Console.WriteLine($@"                    |######|                     ");
                            Console.WriteLine($@"                    |######|                               ");
                            Console.WriteLine($@"                   /|######|\                              ");
                            Console.WriteLine($@"                  / |######| \                             ");
                            Console.WriteLine($@"                 / /|######|\ \                   ");
                            Console.WriteLine($@"                / / |######| \ \                   ");
                            Console.WriteLine($@"               / /  |######|  \ \                            ");
                            Console.WriteLine($@"              / /   |######|   \ \         Урон:   {tralltankdam}        ");
                            Console.WriteLine($@"             / /    |######|    \ \              ");
                            Console.WriteLine($@"            / /     |######|     \ \             ");
                            Console.WriteLine($@"           / /      |######|      \ \          ");
                            Console.WriteLine($@"          /_/       |######|       \_\          ");
                            Console.WriteLine($@"                    |######|                 ");
                            Console.WriteLine($@"                    |######|                  ");
                            Console.WriteLine($@"                   /        \                 ");
                            Console.WriteLine($@"                  /          \                ");
                            Console.WriteLine($@"                 /            \          Защита: {tralltankdef}     ");
                            Console.WriteLine($@"                /              \             ");
                            Console.WriteLine($@"               /                \          ");
                            Console.WriteLine($@"              /                  \         ");
                            Console.WriteLine($@"             /                    \        ");
                            Console.WriteLine($@"       _____/                      \_____       ");
                            Console.WriteLine($@"      /____|                        |____\      ");
                            Console.WriteLine($@"   1. Атаковать    2. Защищаться    3. Назад В Меню  ");
                            int fighttralltank = Convert.ToInt32(Console.ReadLine());
                            
                            if (tralltankhp > 0)
                            {
                                    tralltankhp -= (DamagePlayer - tralltankdef);
                                    HealthPlayer -= (tralltankdam - DefensePlayer);
                                    if (HealthPlayerDefault < HealthPlayer)
                                    {
                                        HealthPlayer = HealthPlayerDefault;
                                    }
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                    if (tralltankhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenatralltanktri;
                                            Console.Clear();
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер...");
                                        }
                                    }
                            }
                            if (fighttralltank == 2)
                            {
                                HealthPlayer -= (tralltankdam - (DefensePlayer * 2));
                                Console.Clear();
                            }
                        
                    else if (fighttralltank == 4)
                        {
                            nummenu -= 1;
                        }
                        else if (fighttralltank >= 5)
                        {
                            Console.WriteLine("Нет такого(");
                        }
                    }
                }
                }
                //обновить главное меню
                else if (MainMenu == 6)
                    {
                        Console.Clear();
                    }
                //+ деньги
                else if (MainMenu == 7)
                    {
                        money += 9999;
                    }
                else if (MainMenu == 8)
                {
                    HealthPlayerDefault += 1000000;
                    Damagep += 2000;
                    defense += 400000;
                    introforcrabs += 1;
                    introfortralls += 1;
                    introfordruids += 1;
                }
                else if (MainMenu >= 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Такого меню нет");
                    }
                Thread.Sleep(500);
                }
            }
        }
    }
