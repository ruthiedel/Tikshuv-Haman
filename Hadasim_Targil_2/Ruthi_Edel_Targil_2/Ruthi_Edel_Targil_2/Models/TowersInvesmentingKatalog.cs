using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruthi_Edel_Targil_2.Models
{
    public static class TowersInvesmentingKatalog

    {
        private  static Tower tower;
        /// <summary>
        /// manage a digital katalog that showes towers according to the user requiments
        /// </summary>
        public static void ManageKatalog()
        {
            
            Console.WriteLine("for rectangle enter 1 for triangle enter 2");
            int towerOption = int.Parse(Console.ReadLine());
            double height;
            double width;
            while (towerOption == 1 || towerOption == 2)
            {
                Console.WriteLine("enter height and then width");
                height = double.Parse(Console.ReadLine());
                width = double.Parse(Console.ReadLine());
                PrintTowerOptions(height, width, towerOption);
                Console.WriteLine("for rectangle enter 1 for triangle enter 2");
                towerOption = int.Parse(Console.ReadLine());
            }

        }

        /// <summary>
        /// print the chosen tower
        /// </summary>
        /// <param name="height">tower height</param>
        /// <param name="width">tower width</param>
        /// <param name="towerOption">options of the printed tower type 1=> rectangle , 2 => triangle</param>
        private static void PrintTowerOptions(double height, double width, int towerOption)
        {
            switch (towerOption)
            {
                case 1:
                    tower = new Rectangle(width, height);
                    tower.Print();
                    break;
                case 2:
                    tower = new Triangle(width, height);
                    Console.WriteLine("for printing surface enter 1 for draw triangle enter 2");
                    int trianglePrintOption = int.Parse(Console.ReadLine());
                    tower.Print(trianglePrintOption);
                    break;
            }

        }
    }
}
