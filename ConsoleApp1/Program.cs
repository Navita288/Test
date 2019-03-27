using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public static void Main(string[] args);
public string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public int fruits { get; set; }

    }



    public static void Main(string[] args)
    {
        //Your code goes here
        //Console.WriteLine("Hello, world!");

        Student s = new Student() { Set SetName("Ivy"), fruits = "Apple" };
        Student s1 = new Student() { Set SetName("Ryan"), fruits = "Banana" };
        Student s2 = new Student() { Set SetName("Ron"), fruits = "Orange" };
        Student s3 = new Student() { Set SetName("Melvin"), fruits = "Kiwi" };
        Student s4 = new Student() { Set SetName("Sara"), fruits = "Pineapple" };



        List<Student> list = new List<Student>();
        list.Add(s);
        list.Add(s1);
        list.Add(s2);
        list.Add(s3);
        list.Add(s4);




        int[] studentCount = new int[100];

        foreach (Student l in list)
        {

            int index = l.fruits - "banana";
            studentCount[index] = studentCount[index] + 1;

        }

        int[] sortedAgeList = new int[list.Count()];

        int currentAge = 0;
        foreach (int i in studentCount)
        {
            currentAge++;

            if (i != 0)
                for (int r = 0; r < i; r++)
                    Console.WriteLine(currentfruits);
        }
    }
            