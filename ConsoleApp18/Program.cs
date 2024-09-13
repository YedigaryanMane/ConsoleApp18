using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    internal class Program
    {
       

        public static void AddPlanet(string[] planets,int id,string name,string oldName,int numOfSatellites)
        {
            int index = GetFirstEmptyIndex(planets);
                planets[index] = id.ToString();
                planets[index + 1] = name;
                planets[index + 2] = oldName;
                planets[index + 3] = numOfSatellites.ToString();
        }

        public static int GetFirstEmptyIndex(string[] planets)
        {
            for(int i = 0; i < planets.Length; i++)
            {
                if (planets[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void RemovePlanet(string[] planets, int id)
        {
            int removeIndex = GetIdToStartRemove(planets, id);
            planets[removeIndex] = null;
            planets[removeIndex + 1] = null;
            planets[removeIndex+2] = null;
            planets[removeIndex+3] =null;
        }

        public static int GetIdToStartRemove(string[] planets,int id)
        {
            for(int i = 0;i < planets.Length;i+=4)
            {
                if (planets[i] == id.ToString())
                {
                    return i;
                }
            }
            return -1;
        }

        public static void UptadePlanet(string[] planets, int id, string name, string oldName, int numOfSatellites)
        {
            for (int i = 0; i < planets.Length; i++)
            {
                if (planets[i] == id.ToString())
                {

                    planets[i + 1] = name;
                    planets[i + 2] = oldName;
                    planets[i + 3] = numOfSatellites.ToString();
                }
            }
        }
        public static void PrintPlanets(string[] planets)
        {
            for (int i = 0; i < planets.Length; i++) 
            {
                if(planets[i] != null)
                {
                    Console.WriteLine(planets[i]);
                }
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            string[] planets = new string[1000];
            AddPlanet(planets, 1, "Merkuri", "Paylacu", 0);
            AddPlanet(planets, 2, "Venera", "Arusyak", 0);
            AddPlanet(planets, 3, "Erkir", "Erkir", 1);
            AddPlanet(planets, 4, "Mars", "Hrat", 2);
            AddPlanet(planets, 5, "Yupiter", "Lusntag", 67);
            PrintPlanets(planets);
            RemovePlanet(planets, 3);
            PrintPlanets(planets);
            UptadePlanet(planets, 4, "Saturn", "Erevak",62);
            PrintPlanets(planets);
            Console.ReadLine();
        }
    }
}
