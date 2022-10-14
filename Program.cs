namespace Idiacamp
{
    public static class Program
    {
        public static bool check = false;

        public static void Main(string[] args)
        {
            homepage();
        }

        public static void homepage()
        {
            int menu1;
            do
            {
                Console.WriteLine("======WELCOME======");
                Console.WriteLine("===Idia camp 2022===");
                Console.WriteLine("Is the user login??");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Console.Write("Select... ");
                menu1 = int.Parse(Console.ReadLine());
                if (menu1 == 1)
                {
                    Login();
                }
                else if (menu1 == 2)
                {
                    NotLogin();
                }
            }while(menu1>2);
        }

        public static void Login()
        {
            int menu2;
            do
            {
                Console.WriteLine("1.Register for the event");
                Console.WriteLine("2.log out");
                Console.Write("Select... ");
                menu2 = int.Parse(Console.ReadLine());
                if (menu2 == 1)
                {
                    Register();              
                }   
                else if (menu2 == 2)
                {
                    homepage();
                }
            }while(menu2>2);
        }

        public static void NotLogin()
        {
            int menu3;
            do
            {
                Console.WriteLine("1.Register for the event");
                Console.Write("Select... ");
                menu3 = int.Parse(Console.ReadLine());
                if (menu3 == 1)
                {
                    Register(); 
                }   
            }while(menu3>1);
        }

        public static void Register()
        {
            int menu4;
            do
            {
                Console.WriteLine("1.Scholar");
                Console.WriteLine("2.Students");
                Console.WriteLine("3.teachers");
                Console.Write("Select... ");
                menu4 = int.Parse(Console.ReadLine());
                if(menu4 == 1)
                {
                    Scholar();
                }
                else if (menu4 == 2)
                {
                    Student();
                }
                else if (menu4 == 3)
                {
                    Teachers();
                }
            }while(menu4>3);
        }

        public static void Scholar()
        {
            int menu5;
            do
            {
                Console.WriteLine("Name prefix :");
                Console.WriteLine("1.Mr.");
                Console.WriteLine("2.Mrs.");
                Console.WriteLine("3.Miss");
                Console.Write("Select... ");
                menu5 = int.Parse(Console.ReadLine());
                if(menu5 == 1)
                {
                    Console.WriteLine("Name prefix : Mr.");
                }
                else if (menu5 == 2)
                {
                    Console.WriteLine("Name prefix : Mrs.");
                }
                else if (menu5 == 3)
                {
                    Console.WriteLine("Name prefix : Miss ");
                }
            }while(menu5>3); 

                Console.Write("Name :");
                Console.ReadLine(); 
                Console.Write("Surname :");
                Console.ReadLine(); 
                Console.Write("StudentID :");
                Console.ReadLine(); 
                Console.Write("Age :");
                Console.ReadLine(); 
                Console.Write("Alledrgy :");
                Console.ReadLine();

            int menu6;
            do
            {   
                Console.WriteLine("Religion :");
                Console.WriteLine("1.Buddhist");
                Console.WriteLine("2.Christ");
                Console.WriteLine("3.Islam");
                Console.WriteLine("4.other");
                menu6 = int.Parse(Console.ReadLine());
                if(menu6 == 1)
                {
                    Console.WriteLine("Religion : Buddhist");
                }
                else if (menu6 == 2)
                {
                    Console.WriteLine("Religion : Christ");
                }
                else if (menu6 == 3)
                {
                    Console.WriteLine("Religion : Islam");
                }
                else if (menu6 == 4)
                {
                    Console.WriteLine("other");
                }
            }while(menu6>4);

            int menu7;
            do
            {
                Console.WriteLine("Are you an admin? :");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                menu7 = int.Parse(Console.ReadLine());
                if(menu7 == 1)
                {
                    Console.Write("Email :");
                    Console.ReadLine();
                    Console.Write("password :");
                    Console.ReadLine();
                    Login();
                }
                else if (menu7 == 2)
                {
                    Login();
                }
            }while(menu7>2);
            
        }

        public static void Student()
        {
            int menu8;
            do
            {
                Console.WriteLine("Name prefix :");
                Console.WriteLine("1.Mr.");
                Console.WriteLine("2.Mrs.");
                Console.WriteLine("3.Miss");
                Console.Write("Select... ");
                menu8 = int.Parse(Console.ReadLine());
                if(menu8 == 1)
                {
                    Console.WriteLine("Name prefix : Mr.");
                }
                else if (menu8 == 2)
                {
                    Console.WriteLine("Name prefix : Mrs.");
                }
                else if (menu8 == 3)
                {
                    Console.WriteLine("Name prefix : Miss ");
                }
            }while(menu8>3); 

                Console.Write("Name :");
                Console.ReadLine(); 
                Console.Write("Surname :");
                Console.ReadLine();  
                Console.Write("Age :");
                Console.ReadLine();

            int menu9;
            do
            {
                Console.WriteLine("Class :");
                Console.WriteLine("1.M4.");
                Console.WriteLine("2.M5.");
                Console.WriteLine("3.M6.");
                Console.Write("Select... ");
                menu9 = int.Parse(Console.ReadLine());
                if(menu9 == 1)
                {
                    Console.WriteLine("Class : M4.");
                }
                else if (menu9 == 2)
                {
                    Console.WriteLine("Class : M5.");
                }
                else if (menu9 == 3)
                {
                    Console.WriteLine("Class : M6.");
                }
            }while(menu9>3); 

                Console.Write("Alledrgy :");
                Console.ReadLine();

            int menu10;
            do
            {   
                Console.WriteLine("Religion :");
                Console.WriteLine("1.Buddhist");
                Console.WriteLine("2.Christ");
                Console.WriteLine("3.Islam");
                Console.WriteLine("4.other");
                menu10 = int.Parse(Console.ReadLine());
                if(menu10 == 1)
                {
                    Console.WriteLine("Religion : Buddhist");
                }
                else if (menu10 == 2)
                {
                    Console.WriteLine("Religion : Christ");
                }
                else if (menu10 == 3)
                {
                    Console.WriteLine("Religion : Islam");
                }
                else if (menu10 == 4)
                {
                    Console.WriteLine("other");
                }
            }while(menu10>4);

                Console.WriteLine("School :");
                Console.ReadLine();
        }

        public static void Teachers()
        {
            int menu11;
            do
            {
                Console.WriteLine("Name prefix :");
                Console.WriteLine("1.Mr.");
                Console.WriteLine("2.Mrs.");
                Console.WriteLine("3.Miss");
                Console.Write("Select... ");
                menu11 = int.Parse(Console.ReadLine());
                if(menu11 == 1)
                {
                    Console.WriteLine("Name prefix : Mr.");
                }
                else if (menu11 == 2)
                {
                    Console.WriteLine("Name prefix : Mrs.");
                }
                else if (menu11 == 3)
                {
                    Console.WriteLine("Name prefix : Miss ");
                }
            }while(menu11>3); 

                Console.Write("Name :");
                Console.ReadLine(); 
                Console.Write("Surname :");
                Console.ReadLine();
                Console.Write("Age :");
                Console.ReadLine();

            int menu12;
            do
            {
                Console.WriteLine("Position :");
                Console.WriteLine("1.dean");
                Console.WriteLine("2.head of department");
                Console.WriteLine("3.full-time teacher");
                Console.Write("Select... ");
                menu12 = int.Parse(Console.ReadLine());
                if(menu12 == 1)
                {
                    Console.WriteLine("Position : dean");
                }
                else if (menu12 == 2)
                {
                    Console.WriteLine("Position : head of department");
                }
                else if (menu12 == 3)
                {
                    Console.WriteLine("Position : full-time teacher");
                }
            }while(menu12>3); 
                Console.Write("Alledrgy :");
                Console.ReadLine();

            int menu13;
            do
            {   
                Console.WriteLine("Religion :");
                Console.WriteLine("1.Buddhist");
                Console.WriteLine("2.Christ");
                Console.WriteLine("3.Islam");
                Console.WriteLine("4.other");
                menu13 = int.Parse(Console.ReadLine());
                if(menu13 == 1)
                {
                    Console.WriteLine("Religion : Buddhist");
                }
                else if (menu13 == 2)
                {
                    Console.WriteLine("Religion : Christ");
                }
                else if (menu13 == 3)
                {
                    Console.WriteLine("Religion : Islam");
                }
                else if (menu13 == 4)
                {
                    Console.WriteLine("other");
                }
            }while(menu13>4);

            int menu14;
            do
            {
                Console.Write("Did you bring the car? :");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                menu14 = int.Parse(Console.ReadLine());
                if(menu14 == 1)
                {
                    Console.Write("Car registration :");
                    Console.ReadLine();
                }
                else if (menu14 == 2)
                {
                    Console.WriteLine("Next");
                }
            }while(menu14>2);

            int menu15;
            do
            {
                Console.WriteLine("Are you an admin? :");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                menu15 = int.Parse(Console.ReadLine());
                if(menu15 == 1)
                {
                    Console.Write("Email :");
                    Console.ReadLine();
                    Console.Write("password :");
                    Console.ReadLine();
                    Login();
                }
                else if (menu15 == 2)
                {
                    Login();
                }
            }while(menu15>2);  
        }
        
    }
}
    

