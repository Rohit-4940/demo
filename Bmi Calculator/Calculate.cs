using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_Calculator
{
    class Calculate// class having the public access specifier 
    {
        public void bcalculate() // bcalculate is the method of the calculate class
        {
            Console.Title = "BMI Calculator";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------BMI Calculator------------- \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please Enter the Weight in kg: ");
            double kg = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please Enter the Height in Meter: ");
            double meter = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gender (m/f):");
            string Genders = Console.ReadLine();

            if (kg>0 && meter>0) {
                double BMI = kg / (meter * meter);
                BMI = Math.Round(BMI, 2);
                Console.Beep();
                Console.WriteLine("your weight is:" + BMI);
                //if the calculator can`t handle the user input 

                if (BMI < 17.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry Buddy I can`t be able to measure your BMI");
                }

                //Female 
                if (BMI >= 17.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("IF you Were Female you are Anorexia"); }
               else  if (BMI >= 19.1)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("IF you Were Female you are Underweight"); }
                else if (BMI >= 19.1 && BMI <= 25.8 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("IF you Were Female you are In Normal Range"); }
                else if (BMI >= 25.8 && BMI <= 27.3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("IF you Were Female you are Marginally overweight"); }
                else if (BMI >= 27.3 && BMI <= 32.3 )
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("IF you Were Female you are overweight"); }
                else if (BMI > 32.3 )
                {
                     Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("IF you Were Female you are Very Overweight or Obese"); }

                //male
                if (BMI >= 17.5 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("IF you Were male you are Anorexia"); }
                else if (BMI >= 20.7 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    Console.WriteLine("IF you Were male you are Underweight"); }
                else if (BMI >= 20.7 && BMI <= 26.4 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    Console.WriteLine("IF you Were male you are In Normal Range"); }
                else if (BMI >= 26.4 && BMI <= 27.8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("IF you Were male you are Marginally Overweight"); }
               else  if (BMI >= 27.8 && BMI <= 31.1 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("IF you Were male you are Overweight"); }
                else if (BMI > 31.1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    Console.WriteLine("IF you Were male you are very Overweight or Obese"); }

                Console.ReadLine();
            }
        }
    }
}
