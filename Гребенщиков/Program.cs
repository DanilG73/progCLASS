using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class Bird
        {
            public string Name;
            public string Color;
            public int Age;
            public float Wingspan;
            public bool CanFly;

            public void MakeSound()
            {
                Console.WriteLine("чик чирик");

            }

            public void eat()
            {
                Console.WriteLine("Птица ест");

            }

            public void fly()
            {
                if (CanFly)
                    Console.WriteLine("Птица летает");
                else
                    Console.WriteLine("Птица не летает");
            }

            public Bird()
            {
                Name = "На данный момент мы не знаем но прилагаем все усилия по решению данной проблемы.";
                Color = "Unknow";
                Age = 0;
                Wingspan = 0.0f;
                CanFly = true;
            }


            public Bird(string name, string color, int age)
            {
                Name = name;
                Color = color;
                Age = age;
                Wingspan = 0.0f;
                CanFly = true;
            }


            public Bird(string name, string color, int age, float wingspan, bool canfly)
            {
                Name = name;
                Color = color;
                Age = age;
                Wingspan = wingspan;
                CanFly = canfly;
            }
            
        }
        class Programm
        {
            static void Main()
            {
                Bird bird1 = new Bird();
                bird1.Name = "Sparrow";
                bird1.Color = "Brown";
                bird1.Age = 2;
                bird1.Wingspan = 15.0f;
                bird1.CanFly = true;

                Bird bird2 = new Bird();
                {
                    bird2.Name = "Blue Jay";
                    bird2.Color = "Blue";
                    bird2.Age = 3;
                    bird2.Wingspan = 18.0f;
                    bird2.CanFly = true;
                }
                Bird bird3 = new Bird();
                {
                    bird3.Name = "Robin";
                    bird3.Color = "Red";
                    bird3.Age = 1;
                    bird3.Wingspan = 22.0f;
                    bird3.CanFly = true;
                }
                Bird bird4 = new Bird();
                {
                    bird4.Name = "Blackbird";
                    bird4.Color = "BLack";
                    bird4.Age = 4;
                    bird4.Wingspan = 20.0f;
                    bird4.CanFly = true;
                }
                Bird bird5 = new Bird();
                {
                    bird5.Name = "Crow";
                    bird5.Color = "BLack";
                    bird5.Age = 5;
                    bird5.Wingspan = 85.0f;
                    bird5.CanFly = true;
                }
                Console.WriteLine($"Name: {bird1.Name} \n Color: {bird1.Color} \n Age :{bird1.Age} \n Wingsapn :{bird1.Wingspan} \n CanFly :{bird1.CanFly} \n");
                Console.WriteLine($"Name: {bird2.Name} \n Color: {bird2.Color} \n Age :{bird2.Age} \n Wingsapn :{bird2.Wingspan} \n CanFly :{bird2.CanFly} \n");
                Console.WriteLine($"Name: {bird3.Name} \n Color: {bird3.Color} \n Age :{bird3.Age} \n Wingsapn :{bird3.Wingspan} \n CanFly :{bird3.CanFly} \n");
                Console.WriteLine($"Name: {bird4.Name} \n Color: {bird4.Color} \n Age :{bird4.Age} \n Wingsapn :{bird4.Wingspan} \n CanFly :{bird4.CanFly} \n");
                Console.WriteLine($"Name: {bird5.Name} \n Color: {bird5.Color} \n Age :{bird5.Age} \n Wingsapn :{bird5.Wingspan} \n CanFly :{bird5.CanFly} \n");
                Console.ReadKey();

            }
            

            
           
        }
       

    }

        
   


    

}



