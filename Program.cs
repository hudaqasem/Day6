namespace Day6
{
    internal class Program
    {
        public static void TestPoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
        }

        public static void TestEmployee(Employee2 emp)
        {
            
            emp.Name = "New Name";
            emp.Salary += 1000;
        }
        static void Main(string[] args)
        {
            #region Point
            //Point P1 = new Point(5, 6);
            //Console.WriteLine( P1.ToString()); 
            #endregion

            #region Access Modifier 
            //TypeA T1 = new TypeA(4,5,6);
            //Console.WriteLine(T1.GetF());//private 
            //Console.WriteLine(T1.G);//internal : same project 
            //Console.WriteLine(T1.H);// public  
            #endregion

            #region encapsulation 
            //Employee Emp1 = new Employee();
            //Emp1.Salary = 50000;
            //Emp1.SetName("Huda");
            //Emp1.EmpId = 1;
            //Console.WriteLine(Emp1); 
            #endregion

            #region parameterized constructor & ToString()
            //Point P1 = new Point(5, 10);
            //Console.WriteLine(P1.ToString());

            //Point P2 = new Point(20);
            //Console.WriteLine(P2.ToString());
            ///*
            // Constructors in structs are special methods used to 
            // initialize the fields of a struct when a new instance is created
            // Structs include a default parameterless constructor
            // ToString() improves code readability by providing a clear and 
            // concise representation of objects, making the code more user-friendly
            //*/ 
            #endregion

            #region Val & Ref
            //Point P1 = new Point(5, 10);
            //Console.WriteLine(P1.ToString());
            //TestPoint(P1); // not change 
            //Console.WriteLine(P1.ToString());



            //Employee2 E1 = new Employee2("Huda", 50000);
            //Console.WriteLine(E1.ToString());
            //TestEmployee(E1);
            //Console.WriteLine(E1.ToString());

            /*
             struct Stored in the stack  => passed by value 
             class Stored in the heap => passed by reference 
             */
            #endregion

            #region copy ctor
            //Employee2 E2 = new Employee2("Ali", 100);
            //Console.WriteLine(E2);
            //Employee2 CopyE2 = new Employee2(E2);
            //Console.WriteLine(CopyE2.ToString());
            //CopyE2.Name = "Yasser";
            //Console.WriteLine(E2);
            //Console.WriteLine(CopyE2); 
            #endregion

            #region Indexer
            WeeklyTemperature weeklyTemp = new WeeklyTemperature();

            //Console.WriteLine(weeklyTemp[8]);
            weeklyTemp[0] = 15;
            weeklyTemp[1] = 16;
            weeklyTemp[2] = 17;
            weeklyTemp[3] = 18;
            weeklyTemp[4] = 19;
            weeklyTemp[5] = 19.5;
            weeklyTemp[6] = 20.5;

            weeklyTemp.DisplayTemperatures();
            #endregion




        }
    }
}
