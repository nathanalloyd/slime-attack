using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace slime_attack
{
    class Game
    {
        public void Start()
        {
            Title = "Slime Attack";
            CursorVisible = false;
            ForegroundColor = ConsoleColor.Green;
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"


         ██████  ██▓     ██▓ ███▄ ▄███▓▓█████      ▄▄▄     ▄▄▄█████▓▄▄▄█████▓ ▄▄▄       ▄████▄   ██ ▄█▀
        ▒██   ▒  ▓██▒    ▓██▒▓██▀█▀ ██▒▓█   ▀     ▒████▄   ▓  ██▒ ▓▒▓  ██▒ ▓▒▒████▄    ▒██▀ ▀█   ██▄█▒ 
        ░ ▓██▄   ▒██░    ▒██▒▓██░   ▓██░▒███      ▒██  ▀█▄ ▒ ▓██░ ▒░▒ ▓██░ ▒░▒██  ▀█▄  ▒▓█    ▄ ▓███▄░ 
          ▒   ██▒▒██░    ░██░▒██    ▒██ ▒▓█  ▄    ░██▄▄▄▄██░ ▓██▓ ░ ░ ▓██▓ ░ ░██▄▄▄▄██ ▒▓▓▄ ▄██▒▓██ █▄ 
        ▒██████▒▒░██████▒░██░▒██▒   ░██▒░▒████▒    ▓█   ▓██▒ ▒██▒ ░   ▒██▒ ░  ▓█   ▓██▒▒ ▓███▀ ░▒██▒ █▄
        ▒ ▒▓▒ ▒ ░░ ▒░▓  ░░▓  ░ ▒░   ░  ░░░ ▒░ ░    ▒▒   ▓▒█░ ▒ ░░     ▒ ░░    ▒▒   ▓▒█░░ ░▒ ▒  ░▒ ▒▒ ▓▒
        ░ ░▒  ░ ░░ ░ ▒  ░ ▒ ░░  ░      ░ ░ ░  ░     ▒   ▒▒ ░   ░        ░      ▒   ▒▒ ░  ░  ▒   ░ ░▒ ▒░
        ░  ░  ░    ░ ░    ▒ ░░      ░      ░        ░   ▒    ░        ░        ░   ▒   ░        ░ ░░ ░ 
              ░      ░  ░ ░         ░      ░  ░         ░  ░                       ░  ░░ ░      ░  ░   
                                                                                       ░               

         A giant slime is attacking! You must defeat it before everything you know and love is destroyed.
         Use the ARROW KEYS to highlight the desired action, and press ENTER to select the action. Your
         village is counting on you. Good Luck!
";
            
            string[] options = { "\t [Play]", "\t [About]", "\t [Exit]" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;                   
            }
        }

        private void GameOver()
        {
            Clear();
            WriteLine(@"



                    ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
                   ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
                  ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
                  ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
                  ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
                   ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
                    ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
                  ░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
                        ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                                       ░                   
");
            WriteLine("\t Press any key to return to the Main Menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void Attack()
        {
            Clear();
            WriteLine(@"    



                            |\
                            | \        /|
                            |  \____  / |
                           /|__/AMMA\/  |
                         /AMMMMMMMMMMM\_|
                     ___/AMMMMMMMMMMMMMMA
                     \   |MVKMMM/ .\MMMMM\
                      \__/MMMMMM\  /MMMMMM---
                      |MMMMMMMMMMMMMMMMMM|  /
                      |MMMM/. \MM.--MMMMMM\/
                      /\MMM\  /MM\  |MMMMMM   ___
                     /  |MMMMMMMMM\ |MMMMMM--/   \-.
                    /___/MMMMMMMMMM\|M.--M/___/_|   \
                         \VMM/\MMMMMMM\  |      /\ \/
                          \V/  \MMMMMMM\ |     /_  /
                            |  /MMMV'   \|    |/ _/
                            | /              _/  /
                            |/              /| \'
                                           /_  /
                                           /  /


");
            WriteLine("");
            WriteLine("\t You attack the slime causing 1 damage.");
            WriteLine("\t You manage to free your weapon from the ooze and prepare for the next blow.");
            WriteLine("");
            WriteLine("\t The slime attacks you, coating you in acid! You took 1 damage.");
            WriteLine("\t Your armor manages to protect you from disintegration, for now...");
            WriteLine("");
            WriteLine("\t Press any key to continue.");
            ReadKey(true);
            RunFirstChoice();
        }

        private void Item()
        {
            Clear();
            WriteLine(@"    


                                                                           .''''.
                                                                          /,.--. )
                                                     .'``.        __   __((\- -(\)
                                            _______.'     \_.-''''  ``'  /)) - .\|
                           __....::::::::::'''''''/    .   \'''''''::::::(/ `-'`.)
                        .:'::.  .  o ~ .  ~  o ~ /    /     '.o ~ . _.....--- `  \
                         ':. ':::::.___.____,___/   ,'_\      \ _.-'___..___..._,'
                           ':.  o~  `::::::::::::::::::::::::::::::::::::::::'  (\
                            `':.  o ~  o   ..   o  ,  ~  \ . o~   -.  ~   .'.:'\'(
                               ':.  ,..   o  ~   o  . ,  'o.    ~ o   ~ o'.:'  \(/
                                 '.   o   ~   .    ~    o ~ ',o :  :  .' .' ('\/ |
                                   '-._    ~    o  , o  ,  .  ~._ _.o_.-'  \/ ) (
                                       '- .._  .    ~    ~      _.. -'
                                             ''' - .,.,. - '''
                                                  (:' .:)
                                                   :| '|
                                                   |. ||
                                                   || :|
                                                   :| |'
                                                   || :|
                                                   '| ||
                                                   |: ':
                                                   || :|
                                             __..--:| |'--..__
                                       _...-'  _.' |' :| '.__ '-..._
                                     / -  ..---    '''''   ---...  _ \
                                     \  _____  ..--   --..     ____  /
                                      '-----....._________.....-----'
                            


");
            WriteLine("");
            WriteLine("\t You drink a fairy potion, restoring 5 hitpoints. You feel your strength return.");
            WriteLine("\t You thank the fairy as she flies off before returning your attention to the giant slime.");
            WriteLine("");
            WriteLine("\t The slime attacks you, coating you in acid! You took 1 damage.");
            WriteLine("\t Your armor manages to protect you from disintegration, for now...");
            WriteLine("");
            WriteLine("\t Press any key to continue.");
            ReadKey(true);
            RunFirstChoice();
        }

        private void Escape()
        {
            Clear();
            WriteLine(@"

                                                    ░░░░                    
                                                    ▒▒▒▒                    
                                  ░░░░              ▓▓▓▓▒▒                  
                                  ▒▒▓▓▒▒░░            ██▒▒░░                
                              ░░░░    ▒▒▓▓▒▒░░░░      ▒▒▒▒░░                
                              ▓▓▓▓▒▒▒▒░░░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░░░░░              
                              ▒▒░░░░▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒░░              
                              ░░██▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒              
                                  ░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒░░            
                                    ▒▒▒▒▒▒██▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░    
                                  ▓▓▓▓▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▒▒▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░
                                  ░░▓▓▓▓████████▓▓██▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░░░
                                    ░░░░    ░░▒▒▓▓██████▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒
                                      ░░    ░░░░  ░░    ░░░░▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒
                                      ░░      ░░░░░░            ▓▓▓▓▓▓▓▓▓▓▓▓
                                            ░░░░░░░░              ░░▓▓██▓▓▓▓
                                        ░░  ░░░░░░░░                    ▒▒██
                                        ░░    ░░░░░░                        
                                          ░░░░░░░░░░                        
                                          ░░░░░░░░░░                        
                                          ░░░░░░░░░░                        
                                          ░░░░░░░░░░                        
                                          ░░░░░░░░░░                        
                                          ░░░░░░░░░░                        
                                            ░░░░░░░░                        
                                            ░░▒▒▒▒                          



");
            WriteLine("\t You are overcome with terror and attempt to run. Unfortunately, your back is unprotected.");
            WriteLine("\t You watch in horror as your body begins to melt away. Your final thoughts are of your loved ones");
            WriteLine("\t who will soon share your fate. Despair fades to nothingness as you are embraced by the void.");
            WriteLine("");
            WriteLine("\t Press any key to continue.");
            ReadKey(true);
            GameOver();
        }
        private void ExitGame()
        {
            WriteLine("");
            WriteLine("\t Thank you for playing. Press any key to exit.");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("");
            WriteLine("");
            WriteLine("\t This game was created by Nathan Lloyd. I hope you enjoy it!");
            WriteLine("");
            WriteLine("\t Assets used from http://patorjk.com/software/taag, https://www.asciiart.eu/,");
            WriteLine("\t and https://textart.sh/topic/slime.");
            WriteLine("");
            WriteLine("\t Press any key to return to the main menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void RunFirstChoice()
        {
            string prompt = @"     
                                                                                       
                                            
                                                       ░░░░░░░░░░░░░░░░░░░░                            
                                                  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      
                                              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒                
                                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                
                                    ░░░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░            
                                  ░░░░░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒            
                                ░░░░░░░░░░░░░░░░░░▒▒██░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒          
                              ░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░▒▒▓▓░░░░░░░░░░░░░░░░▒▒▒▒▒▒          
                              ░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░▓▓██░░░░░░░░░░░░░░░░░░░░▒▒▓▓        
                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░░▒▒▓▓        
                          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░░▒▒▓▓        
                          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                      ░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                      ░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                      ░░░░░░░░░░▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                      ░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                    ░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▓▓      
                    ░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░▓▓▒▒▓▓▓▓▓▓▒▒▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▓▓      
                    ░░░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▓▓      
                    ░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                    ░░░░░░▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░░░▓▓▓▓████████▓▓░░░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                  ░░░░░░░░▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░░░▓▓████████████░░░░░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                  ░░░░░░░░▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░░░▓▓████████████░░░░░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                  ░░░░░░░░░░▒▒▒▒▓▓▓▓▓▓▓▓░░░░▓▓████████████░░▓▓░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                  ▒▒░░░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓░░▒▒▓▓▓▓▓▓██████▓▓░░▓▓░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▓▓      
                  ▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░▓▓▓▓▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓      
                  ▒▒▒▒▒▒░░░░░░░░░░░░▒▒░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▓▓▓▓      
                ░░░░░░▒▒▒▒░░▒▒░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒    
              ░░░░  ░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒░░░░░░▒▒  
            ░░░░░░░░░░░░░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒░░░░░░▒▒▒▒▒▒
            ░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒
            ░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▓▓
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒▒▒▒▒▓▓▓▓
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░▒▒▒▒▒▒░░▒▒▒▒▒▒▓▓▓▓▓▓  
                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          
                                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    
                                          

                                      Slime Health [####################]


         The slime glares menacingly at you. What do you do?
        
         Health [##########]
";
            string[] options = { "\t [Attack]", "\t [Item]", "\t [Escape]" };
            Menu attackMenu = new Menu(prompt, options);
            int selectedIndex = attackMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Attack();
                    break;
                case 1:
                    Item();
                    break;
                case 2:
                    Escape();
                    break;
            }
        }
    }
}
