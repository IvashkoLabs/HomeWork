using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class StudentList
    {
        private string[] firstNames;
        private string[] middleNames;
        private string[] lastNames;
        private int AmountOfStudens;
        
        public StudentList(int maxStudents)
        {
            firstNames = new string[maxStudents];
            middleNames = new string[maxStudents];
            lastNames = new string[maxStudents];
            AmountOfStudens = maxStudents; 
        }

        public string GetFullName(int index) 
        {
            string fullname = firstNames[index] +" " + middleNames[index] + " " + lastNames[index];
            return fullname;
        }
        public int GetAmountOfStudent() 
        {
            return AmountOfStudens;
        }
        public void RenameStudent(int Index, string Fname, string Mname, string Lname) 
        {
            if (Fname != "") { firstNames[Index] = Fname; }
            if (Mname != "") { middleNames[Index] = Mname; }
            if (Lname != "") { lastNames[Index] = Lname; }
        }
        public void PrintAll()
        {
            Console.WriteLine("\nList of students:");
            for (int i = 0; i < AmountOfStudens; i++)
            {
                Console.WriteLine($"\n{i + 1} | {firstNames[i]} | {middleNames[i]} | {lastNames[i]}");
            }
        }
    }
}

