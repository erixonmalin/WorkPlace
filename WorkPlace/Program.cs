using System;
using System.Collections.Generic;

namespace WorkPlace
{
    class Program
    {
        static void Main(string[] args)
        {   //New objects
            Employee E1 = new Employee() { ID = 101, Name = "Carro", Gender = "Female", Salary = 31000 };
            Employee E2 = new Employee() { ID = 102, Name = "Lena", Gender = "Female", Salary = 31500 };
            Employee E3 = new Employee() { ID = 103, Name = "Bill", Gender = "Male", Salary = 30000 };
            Employee E4 = new Employee() { ID = 104, Name = "Jonas", Gender = "Male", Salary = 31700 };
            Employee E5 = new Employee() { ID = 105, Name = "Kicki", Gender = "Female", Salary = 32000 };

            //Part 1: new stack
            Stack<Employee> StackEmp = new Stack<Employee>();
            StackEmp.Push(E1);
            StackEmp.Push(E2);
            StackEmp.Push(E3);
            StackEmp.Push(E4);
            StackEmp.Push(E5);

            foreach (Employee item in StackEmp)
            {
                Console.WriteLine("Items left in the Stack = " + StackEmp.Count);
                Console.WriteLine($"{item.ID}, {item.Name }, {item.Gender }, {item.Salary }");
            }
            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine("------------------------------");


            //Pop Method
            Console.WriteLine("Retrive Using Pop Method");

            Console.WriteLine($"{E1.ID}, {E1.Name }, {E1.Gender }, {E1.Salary }");
            StackEmp.Pop();

            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine($"{E2.ID}, {E2.Name }, {E2.Gender }, {E2.Salary }");
            StackEmp.Pop();

            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine($"{E3.ID}, {E3.Name }, {E3.Gender }, {E3.Salary }");
            StackEmp.Pop();

            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine($"{E4.ID}, {E4.Name }, {E4.Gender }, {E4.Salary }");
            StackEmp.Pop();

            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine($"{E5.ID}, {E5.Name }, {E5.Gender }, {E5.Salary }");
            StackEmp.Pop();
            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine("------------------------------");

            
            StackEmp.Push(E1);
            StackEmp.Push(E2);
            StackEmp.Push(E3);
            StackEmp.Push(E4);
            StackEmp.Push(E5);

            //Peek Method
            Console.WriteLine("Retrive Using Peek Method");
            Employee ES = StackEmp.Peek();
            foreach (Employee item in StackEmp)
            {
                Console.WriteLine($"{item.ID}, {item.Name }, {item.Gender }, {item.Salary }");
                Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"{E5.ID}, {E5.Name }, {E5.Gender }, {E5.Salary }");
            Console.WriteLine("Items left in the stack = " + StackEmp.Count);

            Console.WriteLine($"{E2.ID}, {E2.Name }, {E2.Gender }, {E2.Salary }");
            Console.WriteLine("Items left in the stack = " + StackEmp.Count);
            Console.WriteLine("------------------------------");

            if (StackEmp.Contains(E3))
            {
                Console.WriteLine($"Item {E3.Name} is in the stack");
            }

            //Part 2: new list
            List<Employee> EmpList = new List<Employee>();
            
                EmpList.Add(E1);
                EmpList.Add(E2);
                EmpList.Add(E3);
                EmpList.Add(E4);
                EmpList.Add(E5);


            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exists in the list.");
            }

            Employee emp = EmpList.Find(El => El.Gender == "Male");
            Console.WriteLine($"The first object with gender male is: {emp.Name}");

            var employee = EmpList.FindAll(El => El.Gender == "Male");

            foreach (Employee e in employee)
            {
                Console.WriteLine($"Object with gender male: {e.Name}");
            }
        }
    }
}
