/*using System;
class Program
{
    

    static void Main(string[] args)
    {
        int x = 10; int y = 20;
        swap_with_ref(ref x, ref y);
        Console.WriteLine($"Swap with ref x:{x},y:{y}");
        swap_with_out(out x, out y);
        Console.WriteLine($"Swap with out x:{x},y:{y}");

    }
    public static void swap_with_ref(ref int x, ref int y)
    {
        int x1 = x;
        x = y;
        y = x1;
    }
    public static void swap_with_out(out int x, out int y)
    {
        x = 10;
       int  x1=x;
        y = 20;
        x = y;
        y = x1;
    }
}
*/
using OfficeOpenXml;
using System;
using System.Collections.Generic;

namespace Question
{
    public class Person
    {
        public string Name1 { get; set; }
        public string Age1 { get; set; }
        public string email1 { get; set; }
        public string gender1 { get; set; }
        public string job1 { get; set; }

        public Person(string Name = "O", string Age = "A", string email = "E", string gender = "U", string job = "I")
        {
            Name1 = Name;
            Age1 = Age;
            email1 = email;
            gender1 = gender;
            job1 = job;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Name: " + Name1);
            Console.WriteLine("Age: " + Age1);
            Console.WriteLine("Email: " + email1);
            Console.WriteLine("Gender: " + gender1);
            Console.WriteLine("Job: " + job1);
        }
    }

    public class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\lenovo\Downloads\AGI Problem2Task3.xlsx";
            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first worksheet (index 0)
                List<Person> peopleList = new List<Person>();
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++)
                {
                    Person person1 = new Person(
                        Convert.ToString(worksheet.Cells[row, 1].Value),
                        Convert.ToString(worksheet.Cells[row, 2].Value),
                        Convert.ToString(worksheet.Cells[row, 3].Value),
                        Convert.ToString(worksheet.Cells[row, 4].Value),
                        Convert.ToString(worksheet.Cells[row, 5].Value)
                    );

                    peopleList.Add(person1);
                    peopleList[row-2].DisplayValue();

                    Console.WriteLine();
                }
            }
        }
    }
}