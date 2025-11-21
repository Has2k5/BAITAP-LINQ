using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Xuat()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }
   


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student(1, "An", 14),
            new Student(2, "Bao", 17),
            new Student(3, "Anh Tuan", 18),
            new Student(4, "Minh", 16),
            new Student(5, "A Huy", 19)
        };
            //a. In danh sách học sinh
            Console.WriteLine("a. Danh sach hoc sinh:");
            students.ForEach(s => s.Xuat());
            Console.WriteLine();

            //b. In danh sách học sinh từ 15 đến 18 tuổi
            Console.WriteLine("b. Học sinh tu 15 đen 18 tuoi:");
            var from15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in from15To18)
            s.Xuat();
            Console.WriteLine();

            //c. In danh sách học sinh có tên bắt đầu bằng 'A'
            Console.WriteLine("c. Hoc Sinh Bat Dau Bàn Chu 'A':");
            var startWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in startWithA)
                s.Xuat();
            Console.WriteLine();


            // d. Tổng tuổi của học sinh trong danh sách
            Console.WriteLine("d. Tong tuoi cua tat ca hoc sinh:");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine("Tổng tuổi = " + totalAge);
            Console.WriteLine();


            // e. Học sinh có tuổi lớn nhất
            Console.WriteLine("e. Hoc Sinh Lon Tuoi Nhat:");
            int maxAge = students.Max(s => s.Age);
            var oldest = students.Where(s => s.Age == maxAge);
            foreach (var s in oldest)
                s.Xuat();
            Console.WriteLine();


            // f. Sắp xếp danh sách theo tuổi tăng dần
            Console.WriteLine("f. Danh sách sau khi sap xep theo tuoi tang dan:");
            var sorted = students.OrderBy(s => s.Age);
            foreach (var s in sorted)
                s.Xuat();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    
}
