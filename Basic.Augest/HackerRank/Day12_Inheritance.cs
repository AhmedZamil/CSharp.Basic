using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.HackerRank
{
    public static class Day12_Inheritance
    {
        public static void Solution() 
        {

            string[] inputs = Console.ReadLine().Split(" ");
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32 (inputs[2]);

            int numScores = Convert.ToInt32 (Console.ReadLine());
            inputs = Console.ReadLine().Split(" ");

            int[] scores = new int[numScores];

            for (int i= 0;i < numScores;i++)
            { 
            scores[i]= Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);

            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");

        }
    }

    public class Person {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName,string lastName,int id) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;        
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }

    }

    public class Student : Person {

        private int[] testScores;

        public Student(string firstName,string lastName, int id, int[] scores) 
        { 
            this.firstName=firstName;
            this.lastName=lastName;
            this.id=id;
            this.testScores = scores;
         }

        public string Calculate() {

            var average = testScores.Average();

            var result = inBetween(average, 100, 90) ? "O" :
                         inBetween(average, 90, 80) ? "E" :
                         inBetween(average, 80, 70) ? "A" :
                         inBetween(average, 70, 55) ? "P" :
                         inBetween(average, 55, 40) ? "D" : "T";

            return result;
        }

        private bool inBetween(double average , int max,int min) {

            return min <= average && max >= average;
        }
    
    }
}
