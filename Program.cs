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
            int x = 1;
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
            int maghar1 = 1;
            int maghar2 = 2;
            int maghar3 = 5;
            int maghar4 = 10;
            int maghar5 = 25;
            int magdam1 = 8;
            int magdam2 = 15;
            int magdam3 = 30;
            int magcena1 = 75;
            int magcena2 = 100;
            int magcena3 = 150;
            int magcena4 = 200;
            int magcena5 = 400;
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
            int introforcrabs = 0;
            int introfordruids = 0;
            int introfortralls = 0;
            string antidef = "Анти броня";
            int antidefhar = 10;
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
            int defmag = 0;
            float HealthPlayerDefault = 20;
            float vampiricbuy = 0;
            int defenseart = 0;
            int damageart = 0;
            int healthart = 0;
            float Damageforvamp = Damagep;
            float HealthPlayer = 20;
            int xpmax = 36000;
            int xp = 0;
            int level = 1;
            int leveldam2 = 0;
            int leveldam3 = 0;
            int leveldam4 = 0;
            int leveldam5 = 0;
            int leveldam6 = 0;
            int leveldam7 = 0;
            int leveldam8 = 0;
            int leveldam9 = 0;
            int leveldam10 = 0;
            int andef = 0;
            int mana = 100;
            int manamax = 100;
            
            int fireblastmanacoast = 60;
            int chaosmeteormanacoast = 45;
            int chaosmeteorproverka = 0;
            int fireblastproverka = 0;
            void proverkahp()
            {
                if (HealthPlayer >= HealthPlayerDefault)
                {
                    HealthPlayer = HealthPlayerDefault;
                }
            }
            void proverkamp()
            {
                if (mana > manamax)
                {
                   mana = manamax;
                }
            }
            void proverkaxp()
            {
                if (xp > xpmax)
                {
                    xp = xpmax;
                }
            }
            //расходники
            int malayaapt = 0;
            int srapt = 0;
            int bolapt = 0;
            int malayamana = 0;
            int srmana = 0;
            int bolmana = 0;
            int manaiapt = 0;
            //хп
            int malayaapthp = 10;
            int srapthp = 25;
            int bolapthp = 50;
            //мана
            int malayamanamn = 25;
            int srmanamn = 50;
            int bolmanamn = 100;
            //двойная бутыль
            int manaiapthp = 50;
            int manaiaptmn = 50;
            //метод использования предметов
            void usemalayaapt()
            {
                if (malayaapt > 0)
                {
                malayaapt -=1;
                HealthPlayer += malayaapthp;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usesrapt()
            {
                if (srapt > 0)
                {
                srapt -=1;
                HealthPlayer += srapthp;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usebolapt()
            {
                if (bolapt > 0)
                {
                bolapt -=1;
                HealthPlayer += bolapthp;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usemalayamana()
            {
                if (malayamana > 0)
                {
                    malayamana -=1;
                    mana += malayamanamn;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usesrmana()
            {
                if (srmana > 0)
                {
                    srmana -= 1;
                    mana += srmanamn;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usebolmana()
            {
                if (bolmana > 0)
                {
                    bolmana -= 1;
                    mana += bolmanamn;
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
            }
            void usedouble()
            {
                if (manaiapt > 0)
                {
                    manaiapt -= 1;
                    mana += manaiaptmn;
                    HealthPlayer += manaiapthp; 
                }
                else
                {
                    Console.WriteLine("У вас нет этого предмета");
                }
               
            }
            string sposobnostcm = "Способность не изучена";
            string sposobnostfb = "Способность не изучена";
            void invent()
            {
                Console.Clear();
                    Console.WriteLine($@"     Здоровье: {HealthPlayer}/{HealthPlayerDefault}   Маны: {mana}/{manamax} ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  1. Использовать Малую Аптечку: {malayaapt} штук      ");
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  2. Использовать Среднюю Аптечку: {srapt} штук        ");
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  3. Использовать Большую Аптечку: {bolapt} штук        ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  4. Использовать Малую Бутыль: {malayamana} штук        ");
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  5. Использовать Среднюю Бутыль: {srmana} штук        ");
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  6. Использовать Большую Бутыль: {bolmana} штук        ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"  7. Использовать Магическое Зелье: {manaiapt} штук        ");
                    Console.WriteLine($@"     -----------------------------------       ");
                    Console.WriteLine($@"                                               ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@" 8. Назад                                      ");
                    Console.WriteLine($@"                                               ");
                    int inventorymenu = Convert.ToInt32(Console.ReadLine());
                    if (inventorymenu == 1)
                    {
                        usemalayaapt();
                    }
                    else if (inventorymenu == 2)
                    {
                        usesrapt();
                    }
                    else if (inventorymenu == 3)
                    {
                        usebolapt();
                    }
                    else if (inventorymenu == 4)
                    {
                        usemalayamana();
                    }
                    else if (inventorymenu == 5)
                    {
                        usesrmana();
                    }
                    else if (inventorymenu == 6)
                    {
                        usebolmana();
                    }
                    else if (inventorymenu == 7)
                    {
                        usedouble();
                    }
                    proverkahp();
                    Thread.Sleep(500);
                    Console.Clear();
            }
            //threading
            void xppersec()
            {
                while (xp <= 36000)
                { 
                xp += 1;
                Thread.Sleep(1000);
                }
            } 
            //магия
            int defaultmagdam = 0;
            void usemag()
            {
                                Console.Clear();
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"  1. Chaos Meteor: {sposobnostcm}  ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"  2. Fire Blast: {sposobnostfb}    ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"                                   ");
                                Console.WriteLine($@"  3. Назад                         ");
            }
            //thread
            Thread threadxp = new Thread(xppersec);
            threadxp.Start();
            string introostrovK = ostrovK + " - это очень опасное место для простых людей,\n\tтак что будьте внимательней!!!";
            string introdruidD = "Друиды - жрецы у древних кельтских народов, организованные в виде замкнутого, но не наследственного сословия \n\t\tБудьте аккуратны!!!";
            string introTralls = ostrovT + " - это очень опасное место для простых людей,\n\tбудьте внимаетельней!!!";
            while (HealthPlayer > 0)
            {
                string[] netmani = {"Нет маны", "Не хватает маны", "Маны НЕТ!!!", "НЕТТ МАНЫ!"};
                Random netmanirand = new Random();
                int netmanirandom = netmanirand.Next(netmani.Length);
                //проверка способности метеор
                if (chaosmeteorproverka == 0)
                {
                   sposobnostcm = "Способность не изучена";
                }
                else if (chaosmeteorproverka == 1)
                {
                   sposobnostcm = "Способность изучена";
                }
                //проверка файрбласта
                if (fireblastproverka == 0)
                {
                    sposobnostfb = "Способность не изучена";
                }
                else if (fireblastproverka == 1)
                {
                    sposobnostfb = "Способность изучена";
                }
                int levels = level;
                if ((xp >= 0) && (xp <= 3599))
                {
                    level = 1;
                }
                else if ((xp >= 3600) && (xp <= 7199))
                {
                    level = 2;
                    leveldam2 += 1;
                    if (leveldam2 == 1)
                    {
                        Damagep += 15;
                        defense += 7;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 7200) && (xp <= 10799))
                {
                    level = 3;
                    leveldam3 += 1;
                    if (leveldam3 == 1)
                    {
                        Damagep += 50;
                        defense += 15;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 10800) && (xp <= 14399))
                {
                    level = 4;
                    leveldam4 += 1;
                    if (leveldam4 == 1)
                    {
                        Damagep += 150;
                        defense += 30;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 14400) && (xp <= 17999))
                {
                    level = 5;
                    leveldam5 += 1;
                    if (leveldam5 == 1)
                    {
                        Damagep += 225;
                        defense += 65;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 18000) && (xp <= 21599))
                {
                    level = 6;
                    leveldam6 += 1;
                    if (leveldam6 == 1)
                    {
                        Damagep += 300;
                        defense += 80;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 21600) && (xp <= 25199))
                {
                    level = 7;
                    leveldam7 += 1;
                    if (leveldam7 == 1)
                    {
                        Damagep += 400;
                        defense += 100;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 25200) && (xp <= 28799))
                {
                    level = 8;
                    leveldam8 += 1;
                    if (leveldam8 == 1)
                    {
                        Damagep += 550;
                        defense += 150;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 28800) && (xp <= 32399))
                {
                    level = 9;
                    leveldam9 += 1;
                    if (leveldam9 == 1)
                    {
                        Damagep += 675;
                        defense += 300;
                        HealthPlayerDefault += 10;
                    }
                }
                else if ((xp >= 32400) && (xp <= 36000))
                {
                    level = 10;
                    leveldam10 += 1;
                    if (leveldam10 == 1)
                    {
                        Damagep += 800;
                        defense += 450;
                    }
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
                proverkahp();
                proverkamp();
                proverkaxp();
                //крабы
                // обыкновенный
                int kripscrabobikshpmax = 20;
                int kripscrabobikshp = 20;
                int kripscrabsobikdam = 3;
                int kripscrabsobikdef = 1;
                // элитный
                int kripscrabelitehpmax = 100;
                int kripscrabelitehp = 100;
                int kripscrabelitedam = 20;
                int kripscrabelitedef = 35;
                // король
                int kripscrabkorolhpmax = 350;
                int kripscrabkorolhp = 350;
                int kripscrabkoroldam = 45;
                int kripscrabkoroldef = 60;
                //друиды
                // друид-мечник
                int druidmechnikhpmax = 500;
                int druidmechnikhp = 500;
                int druidmechnikdam = 105;
                int druidmechnikdef = 100;
                // друид-монах
                int druidmonahhpmax = 1500;
                int druidmonahhp = 1500;
                int druidmonahdam = 80;
                int druidmonahdef = 365;
                // друид-убийца
                int druidkillerhpmax = 800;
                int druidkillerhp = 800;
                int druidkillerdam = 550;
                int druidkillerdef = 100;
                // траллы
                // тралл-охотник
                int trallohotnikhpmax = 1500;
                int trallohotnikhp = 1500;
                int trallohotnikdam = 650;
                int trallohotnikdef = 200;
                // тралл-Шаман
                int trallshamanhpmax = 1550;
                int trallshamanhp = 1550;
                int trallshamandamphys = 100;
                int trallshamandammage = 650;
                int trallshamandef = 500;
                // тралл-танк
                int tralltankhpmax = 30000;
                int tralltankhp = 30000;
                int tralltankdam = 500;
                int tralltankdef = 1500;
                float DefensePlayer = defense;
                string[] smile = { " ", "W", "-", "о", "О" };
                Random randomsmile = new Random();
                int randsmile = randomsmile.Next(smile.Length);
                int chaosmeteordam = 50 + defaultmagdam;
                int fireblastdam = 75 + defaultmagdam;
                //Главное меню
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine($"                 Привет,{NAME}, это игровое меню, здесь ты можешь                     ");
                Console.WriteLine($"                   приодеть персонажа, а так же фармить с лагерей крипов               ");
                Console.WriteLine($"                                                    Куда отправимся?                   ");
                Console.WriteLine($"  Твой уровень: {level}   | {xp} / {xpmax}                                                                   ");
                Console.WriteLine($@"                            _______                 <---Общая броня головы: {obschdefheaditog}              ");
                Console.WriteLine($@"                           /       \                   Мана персонажа: {mana} / {manamax}                   ");
                Console.WriteLine($@"                          /         \             Здоровье персонажа: {HealthPlayer}/{HealthPlayerDefault}  ");
                Console.WriteLine($@"                          |          |           Урон персонажа {DamagePlayer}                              ");
                Console.WriteLine($@"                          |  -    -  |                 Вампиризм: {vampiricplushp}                          ");
                Console.WriteLine($@"                          |          |             Броня: {DefensePlayer}                                   ");
                Console.WriteLine($@"                          |    {smile[randsmile]}     |            Маг броня: {defmag}                      ");
                Console.WriteLine($@"                           \         /                                                                      ");
                Console.WriteLine($@"                            \       /    |                Золото: {money} (§)                               ");
                Console.WriteLine($@"                             \     /     |                 Всего анти защиты: {andef}                              7. Инвентарь       ");
                Console.WriteLine($@"                                |        |                                                                  ");
                Console.WriteLine($@"                                |        ┬              <--- Общий урон с меча:                             ");
                Console.WriteLine($@"                         =======|========|                                  {obschdam}                      ");
                Console.WriteLine($@"                                |        |        Хар-ики  с артефактов:                                    ");
                Console.WriteLine($@"                                |        |                          хп: {artefakthp}                        ");
                Console.WriteLine($@"                              /   \                                 урон: {artefaktdam}                     ");
                Console.WriteLine($@"                             /     \                                защита: {artefaktdef}                   ");
                Console.WriteLine($@"                            /       \                               Доп. маг. дамаг:{defaultmagdam}                                 ");
                Console.WriteLine($@"                           /         \                 <------Общая броня с ног:                            ");
                Console.WriteLine($@"                         ---         ---                                 {obschdefarmitog}                  ");
                Console.WriteLine($"                                                                      ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"                       Способность Chaos meteor: {sposobnostcm}                                      ");
                Console.WriteLine($"                                                                       ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"                       Способность Fireblast: {sposobnostfb}                                      ");
                Console.WriteLine($"                                                                       ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($@"                                     (6). Расходники +                                        ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"      (1). Магазин обычных вещей                           (2). Магазин артефактов    ");
                Console.WriteLine(@"         |-------------|                                     |-------------|          ");
                Console.WriteLine(@"         |             |                                     |             |          ");
                Console.WriteLine(@"         |             |                                     |             |          ");
                Console.WriteLine(@"         |      ☻      |                                     |     *_*     |          ");
                Console.WriteLine(@"         |-------------|                                     |-------------|          ");
                Console.WriteLine(@"         |             |                                     |             |          ");
                Console.WriteLine(@"         ---------------                                     ---------------          ");
                Console.WriteLine(@"                                                                                      ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("               ---- ▲ ------- ▲  ▲                                                    ");
                Console.WriteLine("        --------- ▲ ---------- -----                                                  ");
                Console.WriteLine("    --------  ------------- ▲ ---                                                     ");
                Console.WriteLine("      ------------- ▲    -----------                                                  ");
                Console.WriteLine($@"           (3). {ostrovK}  -------                                                  ");
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
                    Console.WriteLine($"\n2. Мечи --|========>");
                    Console.WriteLine("");
                    Console.WriteLine($@"3. Сапоги /\");
                    Console.WriteLine($"\n4. Анти маг. вещи ^%&");
                    Console.WriteLine($"\n5. Назад");
                    int ShopMenu = Convert.ToInt32(Console.ReadLine());
                    if (ShopMenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($@"Раздел Шлемов /==\ денег: {money}");
                        Console.WriteLine($@"  1. Деревянный Шлем /--\                  стоимость: {cena1} §              (+{harakteristiki1} защиты)           ");
                        Console.WriteLine($@"   2. Улучшенный Деревянный Шлем /-11-\     стоимость: {cena2} §              (+{harakteristiki2} защиты)           ");
                        Console.WriteLine($@"    3. Каменный Шлем \-1-/                  стоимость: {cena3} §              (+{harakteristiki3} защиты)           ");
                        Console.WriteLine($@"     4. Шлем Матфея Великого /--\            стоимость: {cena4} §              (+{harakteristiki4} защиты)           ");
                        Console.WriteLine($@"      5. Железный Шлем \-2-\                  стоимость: {cena5} §              (+{harakteristiki5} защиты)           ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"       6. Линовый Шлем \--/                    стоимость: {cena6} §              (+{harakteristiki6} защиты)          ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"        7.  Шлем Берсерка /-+-\                 стоимость: {cena7} §              (+{harakteristiki7} защиты)          ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"         8. Проклятый Шлем 0000000000            стоимость: {cena8} §              (+{harakteristiki8} защиты)          ");
                        Console.WriteLine($@"          9. Повязка Иллидана -~~-                стоимость: {cena9} §              (+{harakteristiki9} защиты)          ");
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
                        Console.WriteLine($@"  1. Деревянный Меч -----|==========>     стоимость: {cena1} §              (+{harakteristiki1} физического урона)           ");
                        Console.WriteLine($@"   2. Улучшенный Деревянный Меч -----+==========>     стоимость: {cena2} §  (+{harakteristiki2} физического урона)           ");
                        Console.WriteLine($@"    3. Каменный Меч   -----)---------->              стоимость: {cena3} § (+{harakteristiki3} физического урона)           ");
                        Console.WriteLine($@"     4. Меч Матфея Великого    ------)=========>     стоимость: {cena4} § (+{harakteristiki4} физического урона)           ");
                        Console.WriteLine($@"      5. Железный Меч   ---)=========>               стоимость: {cena5} § (+{harakteristiki5} физического урона)           ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"        6. Линовый Меч       ---)=========--       стоимость: {cena6} § (+{harakteristiki6} физического урона)             ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"          7.Меч Берсерка ========)¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦¦►              стоимость: {cena7} § (+{harakteristiki7} физического урона)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"           8. Проклятый Меч  =======()=========================>           стоимость: {cena8} § (+{harakteristiki8} физического урона)    ");
                        Console.WriteLine($@"             ");
                        Console.WriteLine($@"             9. Кровавая Коса Великой Элуны    --------------------╕                                                 ");
                        Console.WriteLine($@"                                                                   │      стоимость: {cena9} § (+{harakteristiki9} физического урона)    ");
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
                    else if (ShopMenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($@"Раздел АМ вещей денег: {money}");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@" 1. Манта Волшебника |\  стоимость: {magcena1} §  (+{maghar1} маг. защиты)            ");
                        Console.WriteLine($@"  2. Улучшенная Манта Волшебника |\\  стоимость: {magcena2} §  (+{maghar2} маг. защиты)");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($@"   3. Ion Shell () стоимость: {magcena3} §  (+{maghar3} маг. защиты)                ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($@"    4. Сфера Анти Мага (=)стоимость: {magcena4} §  (+{maghar4} маг. защиты)                        ");
                        Console.WriteLine($@"     5. Плащ Анти Мага |\\\ стоимость: {magcena5} §  (+{maghar5} маг. защиты)              ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.WriteLine($@"                                                                                      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($@"     Напиши: 10, чтобы вернуться назад                                                ");
                        int shopmenudlyaam = Convert.ToInt32(Console.ReadLine());
                        if (shopmenudlyaam == 1)
                        {
                            if (money >= magcena1)
                            {
                                money -= magcena1;
                                defmag += maghar1;
                            }
                            else if (money < magcena1)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyaam == 2)
                        {
                            if (money >= magcena2)
                            {
                                money -= magcena2;
                                defmag += maghar2;
                            }
                            else if (money < magcena2)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyaam == 3)
                        {
                            if (money >= magcena3)
                            {
                                money -= magcena3;
                                defmag += maghar3;
                            }
                            else if (money < magcena3)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyaam == 4)
                        {
                            if (money >= magcena4)
                            {
                                money -= magcena4;
                                defmag += maghar4;
                            }
                            else if (money < magcena4)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                        else if (shopmenudlyaam == 5)
                        {
                            if (money >= magcena5)
                            {
                                money -= magcena5;
                                defmag += maghar5;
                            }
                            else if (money < magcena5)
                            {
                                Console.WriteLine("Не хватает золота");
                            }
                        }
                    }
                    else if (ShopMenu >= 5)
                    {
                        nummenu -= 1;
                    }
                }
                //артефакты
                else if (MainMenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine($@"магазин артефактов  |   денег: {money}§");
                    Console.WriteLine($"1. {antidef} стоимость: {cena7} § (-{antidefhar} брони у противника) ");
                    Console.WriteLine($"\n2. {ahatofhealth} стоимость: {cena5} § (+{ahatofhealthhp} здоровье)  ");
                    Console.WriteLine($"\n3. {bloodamulet} стоимость: {cena6} § (+{bloodamuletdam} к физ урону)  ");
                    Console.WriteLine($"\n4. {ringofprotection} стоимость: {cena1} § (+{ringofprotectiondef} защиты)");
                    Console.WriteLine($"\n5. {palka} стоимость: {cena0} § (+{palkadam} урона) ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\n6. {darovanieoflean} стоимость: {cena6} § (+{darovanieofleanhp} здоровья, +{darovanieofleandam} физ урона, +{darovanieofleandef} защиты)");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\n7. {stoneofdemon} стоимость: {cenaartdemona} § (+{stoneofdemondam} физ урона)");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n8. Магазин Магических Артефактов");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("     Напиши: 10, чтобы вернуться назад                                                                                 ");
                    int artefaktsshop = Convert.ToInt32(Console.ReadLine());
                    if (artefaktsshop == 1)
                    {
                        if (money >= cena7)
                        {
                            andef += antidefhar;
                            money -= cena7;
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
                    else if (artefaktsshop == 8)
                    {
                        Console.Clear();
                        Console.WriteLine($@"  Магазин Маг. Артефактов | денег: {money}                                              ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  1. Kaya             Стоимость: {cena4} § (+{magdam1} маг урона)                            ");
                        Console.WriteLine($@"                                                                                        ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  2. Timeless Relic   Стоимость: {cena7} § (+{magdam2} маг урона)                                ");
                        Console.WriteLine($@"                                                                                        ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  3. Psycho Cloack    Стоимость: {magcena3} § (+{magdam3} маг урона)                             ");
                        Console.WriteLine($@"                                                                                        ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  4. Книга Изучения   Стоимость: {magcena4} § (Изучает способность: Chaos Meteor маг. урон: {chaosmeteordam} | Мана: {chaosmeteormanacoast})");
                        Console.WriteLine($@"                                                                                        ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  5. Книга Изучения   Стоимость: {magcena5} § (Изучает способность: Fireblast маг. урон: {fireblastdam} | Мана: {fireblastmanacoast})");
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  5. Книга знаний Стоимость: {magcena2} §(+50 максимальной маны )");
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"  ----------------------------------------                                              ");
                        Console.ForegroundColor = ConsoleColor.White;Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@"                                                                                        ");
                        Console.WriteLine($@" 7. Назад                                                                                       ");
                        int magshop = Convert.ToInt32(Console.ReadLine());
                        if (magshop == 1)
                        {
                            if (money >= cena4)
                            {
                            money -= cena4;
                            defaultmagdam += magdam1;
                            }    
                            else if (money < cena4)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                        else if (magshop == 2)
                        {
                            if (money >= cena7)
                            {
                            money -= cena7;
                            defaultmagdam += magdam2;
                            }
                            else if (money < cena7)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                        else if (magshop == 3)
                        {
                            if (money >= magcena3)
                            { 
                            money -= magcena3;
                            defaultmagdam += magdam3;
                                }
                            else if (money < magcena3)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                        else if (magshop == 4)
                        {
                            if (money >= magcena4)
                            { 
                                if (chaosmeteorproverka == 0)
                                {
                                money -= magcena4;
                                chaosmeteorproverka += 1;
                                }
                                else if (chaosmeteorproverka == 1)
                                {
                                Console.WriteLine("у тебя оно уже есть");
                                }
                            }
                            else if (money < magcena4)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                        else if (magshop == 5)
                        {
                            if (money >= magcena5) 
                            { 
                                if (fireblastproverka == 0)
                                  {
                                fireblastproverka += 1;
                                money -= magcena5;
                                  }
                                 else if (fireblastproverka == 1)
                                  {
                                Console.WriteLine("у тебя оно уже есть");
                                  }
                            }
                            else if (money < magcena5)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                        else if (magshop == 6)
                        {
                            if (money >= magcena2)
                            {
                                money -= magcena2;
                                manamax += 50;
                            }
                            else if (money < magcena2)
                            {
                                Console.WriteLine("Нет Денег");
                            }
                        }
                    }
                }   
                //остров крабов
                else if (MainMenu == 3)
                {
                    Console.Clear();
                    introforcrabs += 1;
                    if (introforcrabs == 1) 
                        {
                        foreach(char introshechka1 in introostrovK)
                            {
                             Console.Write(introshechka1);
                            Thread.Sleep(30);
                            }
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
                            Console.WriteLine($@" Здоровье: {HealthPlayer}/{HealthPlayerDefault}    Мана: {mana}/{manamax}      ");
                            Console.WriteLine($@"        /---------------\          краб обыкновенный                                            ");
                            Console.WriteLine($@"       /   1       1     \         Здоровье:  {kripscrabobikshp} / {kripscrabobikshpmax}                                             ");
                            Console.WriteLine($@"      /-------------------\        Защита: {kripscrabsobikdef}                                                                  ");
                            Console.WriteLine($@"     /    \           /    \       Урон:  {kripscrabsobikdam}                                              ");
                            Console.WriteLine($@"    /                       \                                                    ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь  4. Назад В Меню  ");
                            int fightcrabsodin = Convert.ToInt32(Console.ReadLine());
                            if (fightcrabsodin == 1)
                            {
                                proverkahp();
                                Console.Clear();
                                kripscrabobikshp -= DamagePlayer - (kripscrabsobikdef - andef);
                                HealthPlayer -= (kripscrabsobikdam - DefensePlayer);
                                if (kripscrabobikshp > 0)
                                {
                                    proverkahp();
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
                                        xp += 10;
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
                                HealthPlayer -= (kripscrabsobikdam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int viborsposobnobikscrab = Convert.ToInt32(Console.ReadLine());
                                if (viborsposobnobikscrab == 1)
                                {
                                        if (chaosmeteorproverka == 1)
                                        {
                                        if (mana > chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            kripscrabobikshp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (kripscrabobikshp > 0)
                                              {
                                                Console.Clear();
                                              }
                                            else if (kripscrabobikshp <= 0)
                                                   {
                                                  if (HealthPlayer > 0) {
                                                          Console.WriteLine("Победа!!!");
                                                          Thread.Sleep(2000);
                                                          money += randcenacrabsobik;
                                                          nummenu -= 1;
                                                          Console.Clear();
                                                          xp += 10;
                                                         }
                                                  else if (HealthPlayer <= 0)
                                                  {
                                                Console.WriteLine("Ты умер(");
                                                  }
                                            }
                                           
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    } 
                                    Console.Clear();
                                }
                                else if (viborsposobnobikscrab == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana > fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            kripscrabobikshp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (kripscrabobikshp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (kripscrabobikshp <= 0)
                                            {
                                                   if (HealthPlayer > 0) 
                                                   {
                                                          Console.WriteLine("Победа!!!");
                                                          Thread.Sleep(2000);
                                                          money += randcenacrabsobik;
                                                          nummenu -= 1;
                                                          Console.Clear();
                                                          xp += 10;
                                                   }
                                                  else if (HealthPlayer <= 0)
                                                  {
                                                         Console.WriteLine("Ты умер(");
                                                  }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                }
                                else if (viborsposobnobikscrab == 3)
                                {

                                }
                                Console.Clear();
                            }
                             else if (fightcrabsodin == 3)
                            {
                                proverkahp();
                                Console.Clear();
                            }
                            else if (fightcrabsodin == 4)
                            {
                                Console.Clear();
                                invent();
                            }
                            else if (fightcrabsodin == 5)
                            {
                                break;
                            }
                            else if (fightcrabsodin >= 6)
                            {
                                Console.WriteLine("Нет такого действия(");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                            else if (fightcrabsodin == 3)
                            {
                                invent();
                            }
                            else if (fightcrabsodin == 4)
                            {
                                 break;
                            }
                            else if (fightcrabsodin >= 5)
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
                            proverkahp();
                            if (kripscrabelitehp > kripscrabelitehpmax)
                                {
                                    kripscrabelitehp = kripscrabelitehpmax;
                                }
                            if (HealthPlayer <= 0)
                            {
                                Environment.Exit(0);
                            }
                            Console.WriteLine($@" Здоровье: {HealthPlayer}/{HealthPlayerDefault}    Мана: {mana}/{manamax}      ");
                            Console.WriteLine($@"                                                                                ");
                            Console.WriteLine($@"       /================================\          /           Элитный Краб     ");
                            Console.WriteLine($@"      /                                  \        /    Здоровье: {kripscrabelitehp}/{kripscrabelitehpmax}               ");
                            Console.WriteLine($@" |---/       0##0               0##0      \------/     Защита: {kripscrabelitedef}                 ");
                            Console.WriteLine($@" |  /                                      \           Урон: {kripscrabelitedam}                   ");
                            Console.WriteLine($@"   /----------------------------------------\          Золото: от 10 до 15                          ");
                            Console.WriteLine($@"  /                                          \                                  ");
                            Console.WriteLine($@"                                                                                ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь   4. Назад В Меню  ");
                            int fightcrabsdva = Convert.ToInt32(Console.ReadLine());
                            if (fightcrabsdva == 1)
                            {
                                proverkahp();
                                Console.Clear();
                                kripscrabelitehp -= DamagePlayer - (kripscrabelitedef - andef);
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
                                        xp += 50;
                                    }
                                    else if (HealthPlayer <= 0)
                                    {
                                        Console.WriteLine("Ты умер(");
                                    }
                                }
                            }
                            else if (fightcrabsdva == 2)
                            {
                                if (kripscrabelitehp > 0)
                                {
                                    Console.Clear();
                                }
                                HealthPlayer -= (kripscrabelitedam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int viborsposobnelitecrab = Convert.ToInt32(Console.ReadLine());
                                if (viborsposobnelitecrab == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana > chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            kripscrabelitehp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (kripscrabelitehp > 0)
                                              {
                                                Console.Clear();
                                              }
                                            else if (kripscrabelitehp <= 0)
                                                   {
                                                   if (HealthPlayer > 0) {
                                                          Console.WriteLine("Победа!!!");
                                                          Thread.Sleep(2000);
                                                          money += randcenacrabselite;
                                                          nummenu -= 1;
                                                          Console.Clear();
                                                          xp += 50;
                                                         }
                                                  else if (HealthPlayer <= 0)
                                                  {
                                                Console.WriteLine("Ты умер(");
                                              }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (viborsposobnelitecrab == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana > fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            kripscrabelitehp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (kripscrabelitehp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (kripscrabelitehp <= 0)
                                            {
                                                   if (HealthPlayer > 0) 
                                                   {
                                                          Console.WriteLine("Победа!!!");
                                                          Thread.Sleep(2000);
                                                          money += randcenacrabselite;
                                                          nummenu -= 1;
                                                          Console.Clear();
                                                          xp += 50;
                                                   }
                                                  else if (HealthPlayer <= 0)
                                                  {
                                                         Console.WriteLine("Ты умер(");
                                                  }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (fireblastproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostfb);
                                        Thread.Sleep(400);
                                        Console.Clear();
                                    }
                                }
                                else if (viborsposobnelitecrab == 3)
                                { 
                                }
                            }
                            else if (fightcrabsdva == 3)
                            {
                                Console.Clear();
                                invent();
                            }
                            else if (fightcrabsdva == 4)
                            {
                                break;
                            }
                        }
                    }
                    else if (fightcrabs == 3)
                    {
                        Console.Clear();
                        while (kripscrabobikshp > 0)
                        {
                            Console.WriteLine($@" Здоровье: {HealthPlayer}/{HealthPlayerDefault}    Мана: {mana}/{manamax}      ");
                            Console.WriteLine($@"               |-_-_-_-_-_-_-_-_-_-|               Король Крабов                                                    ");
                            Console.WriteLine($@"               | /               \ |               Здоровье: {kripscrabkorolhp} / {kripscrabkorolhpmax}                            ");
                            Console.WriteLine($@"               |/                 \|               Защита:  {kripscrabkoroldef}                            ");
                            Console.WriteLine($@"               |___________________|               Урон: {kripscrabkoroldam}                             ");
                            Console.WriteLine($@"           _-------------------------------_                                                                  ");
                            Console.WriteLine($@"          /       0               0         \                |                   ");
                            Console.WriteLine($@"         /       090             090         \               |                    ");
                            Console.WriteLine($@"        /         0               0           \--------------+----------       ");
                            Console.WriteLine($@"       /=======================================\             |                    ");
                            Console.WriteLine($@"      /                                         \            |                   ");
                            Console.WriteLine($@"     /                                           \                              ");
                            Console.WriteLine($@"    /                                             \                              ");
                            Console.WriteLine($@"                                                     Золото: от 20 до 25         ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии  3. Инвентарь   4. Назад В Меню  ");
                            int fightcrabstri = Convert.ToInt32(Console.ReadLine());
                            if (HealthPlayer <= 0)
                            {
                                Console.WriteLine("Ты проиграл...");
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                            }
                            else if (fightcrabstri == 1)
                            {
                                kripscrabkorolhp -= DamagePlayer - (kripscrabkoroldef - andef);
                                HealthPlayer -= (kripscrabkoroldam - DefensePlayer);
                                Console.Clear();
                                if (kripscrabkorolhp > 0)
                                {
                                    proverkahp();
                                    Console.Clear();
                                    if (kripscrabkorolhp > kripscrabkorolhpmax)
                                    {
                                        kripscrabkorolhp = kripscrabkorolhpmax;
                                    }
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
                                        xp += 100;
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
                                 if (kripscrabkorolhp > 0)
                                 {
                                    Console.Clear();
                                 }
                                HealthPlayer -= (kripscrabkoroldam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int viborsposobnkorolcrab = Convert.ToInt32(Console.ReadLine());
                                if (viborsposobnkorolcrab == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                      if (mana > chaosmeteormanacoast)
                                      {
                                            Console.Clear();
                                            kripscrabkorolhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                        if (kripscrabkorolhp > 0)
                                        {
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
                                              xp += 100;
                                              break;
                                            }
                                            else if (HealthPlayer <= 0)
                                            {
                                                Console.WriteLine("Ты умер(");
                                            }
                                          }
                                      }
                                      else if (mana < chaosmeteormanacoast)
                                      {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                      }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (viborsposobnkorolcrab == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana > fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            kripscrabkorolhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (kripscrabkorolhp > 0)
                                            {
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
                                                      xp += 100;
                                                      break;
                                                   }
                                                  else if (HealthPlayer <= 0)
                                                  {
                                                         Console.WriteLine("Ты умер(");
                                                  }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                }
                            }
                            else if (fightcrabstri == 3)
                            {
                                invent();
                            }
                            else if (fightcrabstri == 4)
                            {
                                 break;
                            }
                            else if (fightcrabstri >= 5)
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
                        foreach (char druidintrolol in introdruidD)
                        {
                            Console.Write(druidintrolol);
                            Thread.Sleep(50);
                        }
                        Thread.Sleep(3000);
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" \n 4. Выйти                                             ");
                    int Druidnumber = Convert.ToInt32(Console.ReadLine());
                    if (Druidnumber == 1)
                    {
                        Console.Clear();

                        while (druidmechnikhp > 0)
                        {
                            proverkahp();
                            if (druidmechnikhp > druidmechnikhpmax)
                            {
                                druidmechnikhp = druidmechnikhpmax;
                            }
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"                                                                                                               ");
                            Console.WriteLine($@"     Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                                                                                            ");
                            Console.WriteLine($@"                                                                                                               ");
                            Console.WriteLine($@"                                                                                                                  ");
                            Console.WriteLine($@"     Друид-Мечник                                         ");
                            Console.WriteLine($@"                                                             ");
                            Console.WriteLine($@"       |-------|                                             ");
                            Console.WriteLine($@"       | 0   0 |                                             ");
                            Console.WriteLine($@"       |       |                                             ");
                            Console.WriteLine($@"        \  -  /                 Здоровье: {druidmechnikhp} / {druidmechnikhpmax}   ");
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
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь 4. Назад В Меню  ");
                            int fightdruidmechnik = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidmechnik == 1)
                            {
                                druidmechnikhp -= DamagePlayer - (druidmechnikdef - andef);
                                HealthPlayer -= (druidmechnikdam - DefensePlayer);
                                if (kripscrabobikshp > 0)
                                {
                                    proverkahp();
                                    Console.WriteLine("Ты проиграл...");
                                    Console.Clear();
                                    if (druidmechnikhp > druidkillerhpmax)
                                    {
                                        druidmechnikhp = druidkillerhpmax;
                                    }
                                }
                                else if (druidmechnikhp <= 0)
                                  {
                                   if (HealthPlayer > 0)
                                   {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenadruidmechnikodin;
                                            Console.Clear();
                                            xp += 200;
                                   }
                                   else if (HealthPlayer <= 0)
                                   {
                                      Console.WriteLine("Ты умер(");
                                   }
                                }
                            }
                            else if (fightdruidmechnik == 2)
                            {
                                HealthPlayer -= (druidmechnikdam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int druidmechniksposvib = Convert.ToInt32((Console.ReadLine()));
                                if (druidmechniksposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana > chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            druidmechnikhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (druidmechnikhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidmechnikhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenadruidmechnikodin;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 200;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (druidmechniksposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana > fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            druidmechnikhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (druidmechnikhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidmechnikhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenadruidmechnikodin;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 250;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (druidmechniksposvib == 3)
                                    {

                                    }
                                    Console.Clear();
                                }
                            }
                            else if (fightdruidmechnik == 3)
                            {
                                invent();
                            }
                            else if (fightdruidmechnik >= 4)
                            {
                                break;
                            }
                        }
                    }
                    else if (Druidnumber == 2)
                    {
                        while (druidmonahhp > 0)
                        {
                            Console.Clear();
                            Console.WriteLine($@"                                                                 ");
                            Console.WriteLine($@"  Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                                              ");
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
                            Console.WriteLine($@"           /|----------|                  Здоровье: {druidmonahhp} / {druidmonahhpmax}                                      ");
                            Console.WriteLine($@"          / |          |                                        ");
                            Console.WriteLine($@"         /  |          |                                                 ");
                            Console.WriteLine($@"        /   |          |                                    ");
                            Console.WriteLine($@"            |          |                    Урон: {druidmonahdam} ");
                            Console.WriteLine($@"            |          |                                          ");
                            Console.WriteLine($@"            |          |                                          ");
                            Console.WriteLine($@"           / \         |                                          ");
                            Console.WriteLine($@"          /   \        |                                          ");
                            Console.WriteLine($@"         /     \       |                                          ");
                            Console.WriteLine($@"        /       \      |                 Защита: {druidmonahdef}  ");
                            Console.WriteLine($@"       /         \     |                                          ");
                            Console.WriteLine($@"  ____/           \____|                                          ");
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь 4. Назад В Меню  ");
                            int fightdruidmonah = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidmonah == 1)
                            {
                                druidmonahhp -= DamagePlayer - (druidmonahdef - andef);
                                HealthPlayer -= (druidmonahdam - DefensePlayer);
                                if (druidmonahhp > 0)
                                {
                                    proverkahp();
                                    Console.Clear();
                                    if (druidmonahhp > druidmonahhpmax)
                                    {
                                        druidmonahhp = druidmonahhpmax;
                                    }
                                }
                                else if (druidmonahhp <= 0)
                                {
                                    if (HealthPlayer > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Победа!!!");
                                        Thread.Sleep(2000);
                                        nummenu -= 1;
                                        money += randcenadruidmonahdva;
                                        Console.Clear();
                                        xp += 350;
                                    }
                                    else if (HealthPlayer <= 0)
                                    {
                                        Console.WriteLine("Ты умер(");
                                    }
                                }
                            }
                            else if (fightdruidmonah == 2)
                            {
                                HealthPlayer -= (druidmonahdam - DefensePlayer);
                                proverkahp();   
                                usemag();
                                int druidmonahsposvib = Convert.ToInt32(Console.ReadLine());
                                if (druidmonahsposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            druidmonahhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (druidmonahhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidmonahhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenadruidmonahdva;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 200;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (druidmonahsposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana >= fireblastmanacoast)
                                        {

                                            Console.Clear();
                                            druidmonahhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (druidmonahhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidmonahhp <= 0)
                                            {
                                             if (HealthPlayer > 0)
                                            {
                                                Console.WriteLine("Победа!!!");
                                                Thread.Sleep(2000);
                                                money += randcenadruidmonahdva;
                                                nummenu -= 1;
                                                Console.Clear();
                                                xp += 200;
                                            }
                                            else if (HealthPlayer <= 0)
                                            {
                                                Console.WriteLine("Ты умер(");
                                            }
                                            }
                                            
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                        }
                                    }
                                    else if (fireblastproverka == 0)
                                    {
                                        
                                            Console.Clear();
                                            Console.WriteLine(sposobnostfb);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                    }
                                }
                            }
                            else if (fightdruidmonah == 3)
                            {
                                invent();
                            }
                            else if (fightdruidmonah >= 4)
                            {
                                break;
                            }
                        }
                    }
                    else if (Druidnumber == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        while (druidkillerhp > 0)
                        {
                            proverkahp();
                            Console.WriteLine($@"  Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                          ");
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
                            Console.WriteLine($@"            |==============|                Здоровье: {druidkillerhp} / {druidkillerhpmax}                 ");
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
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь   4. Назад В Меню  ");
                            int fightdruidkiller = Convert.ToInt32(Console.ReadLine());
                            if (fightdruidkiller == 1)
                            {
                                
                                druidkillerhp -= DamagePlayer - (druidkillerdef - andef);
                                HealthPlayer -= (druidkillerdam - DefensePlayer);
                                if (druidkillerhp > druidkillerhpmax)
                                    {
                                        druidkillerhp = druidkillerhpmax;
                                    }
                                else if (druidkillerhp <= 0)
                                    {

                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenadruidkilertri;
                                            Console.Clear();
                                            xp += 400;
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер(");
                                        }
                                    }
                            }
                            else if (fightdruidkiller == 2)
                            {
                                HealthPlayer -= (druidkillerdam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int druidkillersposvib = Convert.ToInt32(Console.ReadLine());
                                if (druidkillersposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            druidkillerhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (druidkillerhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidkillerhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenadruidkilertri;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 200;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (druidkillersposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            druidkillerhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (druidkillerhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (druidkillerhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenadruidkilertri;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 200;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostfb);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                            else if (fightdruidkiller == 3)
                            {
                                invent();
                            }
                        }
                            else if (fightdruidkiller == 3)
                            {
                                invent();
                            }
                            else if (fightdruidkiller == 4)
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
                        foreach (char ostrovTrall in introTralls)
                        {
                            Console.Write(ostrovTrall);
                            Thread.Sleep(50);
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"         Добро Пожаловать на остров Траллов!!!                                   ");
                    Console.WriteLine($@"               Выберите на кого хотите напасть:                                      ");
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($" Здоровье:{trallohotnikhp}                 Здоровье: {trallshamanhp}                  \tЗдоровье:{tralltankhp}                                                                    ");
                    Console.WriteLine($" Урон:   {trallohotnikdam}                   Физ. урон:{trallshamandamphys}           \t        Урон:   {tralltankdam}                                                                           ");
                    Console.WriteLine($" Защита: {trallohotnikdef}                   Маг. Урон {trallshamandammage}           \t        Защита: {tralltankdef}                                                                        ");
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
                            if (trallohotnikhp > trallohotnikhpmax)
                            {
                                trallohotnikhp = trallohotnikhpmax;
                            }
                            Console.Clear();
                            proverkahp();
                            Console.WriteLine($@"                                                                             ");
                            Console.WriteLine($@"       Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                             ");
                            Console.WriteLine($@"                                                                                    ");
                            Console.WriteLine($@"                                          ");
                            Console.WriteLine($@"       Друид-Охотник                           ");
                            Console.WriteLine($@"      |-------------|                          ");
                            Console.WriteLine($@"      |  8      8   |                            ");
                            Console.WriteLine($@"      |             |          Здоровье:{trallohotnikhp} / {trallohotnikhpmax}                 ");
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
                            Console.WriteLine($@"   1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь 4. Назад В Меню  ");
                            int fighttrallohotnik = Convert.ToInt32(Console.ReadLine());
                            if (fighttrallohotnik == 1)
                            {
                                trallohotnikhp -= DamagePlayer - (trallohotnikdef - andef);
                                HealthPlayer -= trallohotnikdam - DefensePlayer;
                                if (trallohotnikhp < 0)
                                {
                                   proverkahp();
                                   if (trallohotnikhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenatrallohotnikodin;
                                            Console.Clear();
                                            xp += 5000;
                                        }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер...");
                                        }
                                    }
                                }
                            }
                            else if (fighttrallohotnik == 2)
                            {
                                HealthPlayer -= trallohotnikdam - DefensePlayer;
                                proverkahp();
                                usemag();
                                if (trallohotnikhp > trallohotnikhpmax)
                                {
                                    trallohotnikhp = trallohotnikhpmax;
                                }
                                int trallohotniksposvib = Convert.ToInt32((Console.ReadLine()));
                                if (trallohotniksposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            trallohotnikhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                          if (trallohotnikhp > 0)
                                          {
                                                Console.Clear();
                                          }
                                          else if (trallohotnikhp <= 0)
                                          {
                                                Console.Clear();
                                            if (HealthPlayer > 0)
                                            {
                                                Console.WriteLine("Победа!!!");
                                                Thread.Sleep(2000);
                                                money += randcenatrallohotnikodin;
                                                nummenu -= 1;
                                                Console.Clear();
                                                xp += 1500;
                                            }
                                            else if (HealthPlayer <= 0)
                                            {
                                                Console.WriteLine("Ты умер(");
                                            }
                                          }
                                        }
                                        else if (mana <= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (trallohotniksposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana >= fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            trallohotnikhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (trallohotnikhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (trallohotnikhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenatrallohotnikodin;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 1500;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                        }
                                    }
                                    else if (fireblastproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostfb);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (trallohotniksposvib >= 3)
                                {
                                    Console.WriteLine("Нет такого!!!");
                                }
                            }
                            else if (fighttrallohotnik == 3)
                            {
                                invent();
                            }
                            else if (fighttrallohotnik >= 4)
                            {
                                break;
                            }
                        }
                    }
                    if (fighttrall == 2)
                    {
                        Console.Clear();
                        while (trallshamanhp > 0)
                        {
                            proverkahp();
                            if (trallshamanhp > trallshamanhpmax)
                            {
                                trallshamanhp = trallshamanhpmax;
                            }
                            Console.WriteLine($@"                                                                                           ");
                            Console.WriteLine($@"  Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                                                                               ");
                            Console.WriteLine($@"                                                                         ");
                            Console.WriteLine($@"                                                            ");
                            Console.WriteLine($@"      Тралл-Шаман                                                          ");
                            Console.WriteLine($@"      [----------]                             ");
                            Console.WriteLine($@"      [ 0     0  ]                      ");
                            Console.WriteLine($@"      [  ------  ]                        ");
                            Console.WriteLine($@"      [__________]                                   ");
                            Console.WriteLine($@"           //        ?    ?                ");
                            Console.WriteLine($@"          //         ______  ~      Здоровье: {trallshamanhp} / {trallshamanhpmax}               ");
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
                            Console.WriteLine($@"  1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь 4. Назад В Меню  ");
                            int fighttrallshaman = Convert.ToInt32(Console.ReadLine());
                            if (fighttrallshaman == 1)
                            {
                                if (trallshamanhp > 0)
                                {
                                trallshamanhp -= (DamagePlayer - (trallshamandef - andef));
                                HealthPlayer -= (trallshamandamphys - DefensePlayer);
                                HealthPlayer -= (trallshamandammage - (DefensePlayer / 3 + defmag));
                                    proverkahp();
                                    if (trallshamanhp <= 0)
                                    {
                                        if (HealthPlayer > 0)
                                        {
                                            Console.WriteLine("Победа!!!");
                                            Thread.Sleep(2000);
                                            nummenu -= 1;
                                            money += randcenatrallshamandva;
                                            Console.Clear();
                                            xp += 10000;
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
                                HealthPlayer -= (trallshamandamphys - DefensePlayer);
                                HealthPlayer -= (trallshamandammage - (DefensePlayer / 3 + defmag));
                                proverkahp();
                                usemag();
                                int trallshamansposvib = Convert.ToInt32(Console.ReadLine());
                                if (trallshamansposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            trallshamanhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (trallshamanhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (trallshamanhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenatrallshamandva;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 10000;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                            Console.Clear();
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (trallshamansposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana >= fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            trallshamanhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (trallshamanhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (trallshamanhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenatrallshamandva;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 10000;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                            Console.Clear();
                                        }
                                    }
                                    else if (fireblastproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostfb);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                            }
                            if (fighttrallshaman == 3)
                            {
                                invent();
                            }
                            if (fighttrallshaman >= 4)
                            {
                                break;
                            }
                        }
                    }
                    if (fighttrall == 3)
                    {
                        Console.Clear();
                        while (tralltankhp > 0)
                        {
                            proverkahp();
                            if (tralltankhp > tralltankhpmax)
                            {
                                tralltankhp = tralltankhpmax;
                            }
                            Console.WriteLine($@"                                                                       ");
                            Console.WriteLine($@"           Твое Здоровье: {HealthPlayer} / {HealthPlayerDefault} Мана: {mana} / {manamax}                                                      ");
                            Console.WriteLine($@"                                                                                      ");
                            Console.WriteLine($@"                                                                ");
                            Console.WriteLine($@"                Тралл-Танк                                                            ");
                            Console.WriteLine($@"              _____________________                                             ");
                            Console.WriteLine($@"              |     \       /      |            ");
                            Console.WriteLine($@"              |   000       000    |            ");
                            Console.WriteLine($@"              |   090       090    |                      ");
                            Console.WriteLine($@"              |   000       000    |              ");
                            Console.WriteLine($@"              |    ----------      |                    ");
                            Console.WriteLine($@"              |____________________|        Здоровье:{tralltankhp} / {tralltankhpmax}       ");
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
                            Console.WriteLine($@"  1. Атаковать  2. Атаковать с помощью магии   3. Инвентарь 4. Назад В Меню  ");
                            int fighttralltank = Convert.ToInt32(Console.ReadLine());
                            if (fighttralltank == 1)
                            {
                            if (tralltankhp > 0)
                            {
                                    tralltankhp -= (DamagePlayer - (tralltankdef - andef));
                                    HealthPlayer -= (tralltankdam - DefensePlayer);
                                    proverkahp();
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
                                        xp += 36000;
                                    }
                                        else if (HealthPlayer <= 0)
                                        {
                                            Console.WriteLine("Ты умер...");
                                        }
                                    }
                            }
                            }
                            else if (fighttralltank == 2)
                            {
                                HealthPlayer -= (tralltankdam - DefensePlayer);
                                proverkahp();
                                usemag();
                                int tralltanksposvib = Convert.ToInt32(Console.ReadLine());
                                if (tralltanksposvib == 1)
                                {
                                    if (chaosmeteorproverka == 1)
                                    {
                                        if (mana >= chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            tralltankhp -= chaosmeteordam;
                                            mana -= chaosmeteormanacoast;
                                            if (tralltankhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (tralltankhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenatralltanktri;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 36000;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana < chaosmeteormanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                            Console.Clear();
                                        }
                                    }
                                    else if (chaosmeteorproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostcm);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (tralltanksposvib == 2)
                                {
                                    if (fireblastproverka == 1)
                                    {
                                        if (mana >= fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            tralltankhp -= fireblastdam;
                                            mana -= fireblastmanacoast;
                                            if (tralltankhp > 0)
                                            {
                                                Console.Clear();
                                            }
                                            else if (tralltankhp <= 0)
                                            {
                                                if (HealthPlayer > 0)
                                                {
                                                    Console.WriteLine("Победа!!!");
                                                    Thread.Sleep(2000);
                                                    money += randcenatralltanktri;
                                                    nummenu -= 1;
                                                    Console.Clear();
                                                    xp += 36000;
                                                }
                                                else if (HealthPlayer <= 0)
                                                {
                                                    Console.WriteLine("Ты умер(");
                                                }
                                            }
                                        }
                                        else if (mana <= fireblastmanacoast)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($@"{netmani[netmanirandom]}");
                                            Thread.Sleep(1500);
                                            Console.Clear();
                                        }
                                    }
                                    else if (fireblastproverka == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(sposobnostfb);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                            else if (fighttralltank == 3)
                            {
                                invent();
                            }
                            else if (fighttralltank == 4)
                            {
                                break;
                            }
                            }   
                            else if (fighttralltank == 3)
                            {
                                invent();
                            }
                            else if (fighttralltank == 4)
                            {
                                break;
                            }
                        }
                    }
                }
                //аптечка
                else if (MainMenu == 6)
                    {
                    Console.Clear();
                    Console.WriteLine($@"    У тебя {HealthPlayer} / {HealthPlayerDefault} здоровья                      ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@"   1. Малая Аптечка (+{malayaapthp} hp) Стоимость: 30 §                                    ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.WriteLine($@"   2. Простая Аптечка (+{srapthp} hp) Стоимость: 75 §                                  ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.WriteLine($@"   3. Большая Аптечка (+{bolapthp} hp) Стоимость: 125 §                                 ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($@"   4. Малая Бутыль Маны (+{malayamanamn} mp) Стоимость: 30 §                                ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.WriteLine($@"   5. Средняя Бутыль Маны (+{srmanamn} mp) Стоимость: 75 §                              ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.WriteLine($@"   6. Большая Бутыль Маны (+{bolmanamn} mp) Стоимость: 125 §                            ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($@"   7. Магическое Зелье (+{manaiapthp} hp, +{manaiaptmn} mp) Стоимость: 200 §                          ");
                    Console.WriteLine($@"  ------------------------------                                                ");
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@"                                                                                ");
                    Console.WriteLine($@"                                                                                ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($@"  8. Назад                                                                              ");
                    Console.WriteLine($@"                                                                                ");
                    int apteka = Convert.ToInt32(Console.ReadLine());
                    if (apteka == 1)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 30;
                            malayaapt += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 30;
                        HealthPlayer += malayaapthp;
                        }    
                    }
                    else if (apteka == 2)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 75;
                            srapt += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 75;
                        HealthPlayer += srapthp;
                        }    
                    }
                    else if (apteka == 3)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 125;
                            bolapt += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 125;
                        HealthPlayer += bolapthp;
                        }    
                    }
                    else if (apteka == 4)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 30;
                            malayamana += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 30;
                        mana += malayamanamn;
                        }    
                    }
                    else if (apteka == 5)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 75;
                            srmana += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 75;
                        mana += srmanamn;
                        }    
                    }
                    else if (apteka == 6)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 125;
                            bolmana += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 125;
                        mana += bolmanamn;
                        }    
                    }
                    else if (apteka == 7)
                    {
                        Console.WriteLine("Вам с собой? (В инвентарь?) да/нет");
                        string ssoboi = Console.ReadLine();
                        if (ssoboi == "да" || ssoboi == "Да" || ssoboi == "дА" || ssoboi == "ДА")
                        {
                            money -= 200;
                            manaiapt += 1;
                        }
                        else if (ssoboi == "НЕТ" || ssoboi == "НЕт" ||ssoboi == "НеТ" ||ssoboi == "нЕТ" ||ssoboi == "Нет" ||ssoboi == "неТ" ||ssoboi == "нЕт" ||ssoboi == "нет" )
                        {
                        money -= 200;
                        mana += manaiaptmn;
                        HealthPlayer += manaiapthp;
                        }    
                    }
                }
                //инвентарь             
                else if (MainMenu == 7)
                {
                    invent();
                }
                //+ все читы
                else if (MainMenu == 9016)
                {
                    money += 10000;
                }
                else if (MainMenu == 228)
                    {
                        money += 9999;
                        xp += 1000;
                        chaosmeteorproverka = 1;
                        fireblastproverka = 1;
                        manamax += 9999;
                        mana += 9999;
                        DefensePlayer += 40;
                        HealthPlayerDefault += 2000;
                        HealthPlayer *= 100;
                    introforcrabs += 1;
                    introfortralls += 1;
                    introfordruids += 1;
                }
                else if (MainMenu == 1337)
                {
                    HealthPlayerDefault += 1000000;
                    Damagep += 2000;
                    defense += 400000;
                    introforcrabs += 1;
                    introfortralls += 1;
                    introfordruids += 1;
                }
                else if (MainMenu == 609)
                {
                    defense += 400000;
                    HealthPlayerDefault += 1000000;
                }
                else if (MainMenu == 1488)
                {
                    chaosmeteorproverka = 1;
                    fireblastproverka = 1;
                    bolmana+=1000;
                    HealthPlayerDefault+=10000;
                    HealthPlayer+=10000;
                    DefensePlayer+=5000;
                    manamax += 10000;
                    mana += 10000;
                    introforcrabs += 1;
                    introfortralls += 1;
                    introfordruids += 1;
                    money += 10000;
                }
                else if (MainMenu == 123)
                {
                    money = 0;
                }
                else if (MainMenu >= 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Такого меню нет");
                    }
                Thread.Sleep(500);
            }
        }
    }
}
