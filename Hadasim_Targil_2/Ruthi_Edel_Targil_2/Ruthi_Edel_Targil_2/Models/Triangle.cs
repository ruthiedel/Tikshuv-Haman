using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruthi_Edel_Targil_2.Models
{
    public class Triangle : Tower
    {
        public double Scele { get; set; }

        public Triangle(double width, double height) : base(width, height)
        {
            double temp = Math.Pow(height,2)+Math.Pow(width/2,2);
            Scele = Math.Sqrt(temp);
        }


        /// <summary>
        /// calculate the tower perimeter
        /// </summary>
        /// <returns>calculated perimeter</returns>
        public override double Perimeter()
        {
            return Scele * 2 + Width;
        }

        /// <summary>
        /// print the tower description
        /// </summary>
        /// <param name="x">Setting the option to print the triangle:
        /// 1 => triangle's perimeter
        /// otherwise => draw triangle
        /// </param>
        /// <returns>string value of the tower description</returns>
        public override string Towerdescription(int x)
        {
           
         if(x==1)
            return Perimeter().ToString();
         if ((int)Width % 2 == 0 || Width > Height * 2)
                return "Triangle can not be printed";
         return PrintTriangle();
                    
        }
       
        /// <summary>
        /// draw the tower
        /// </summary>
        /// <returns>string value of the tower paint</returns>
        private string PrintTriangle()
        {
            if(Width==1)
            {
                return Level((int)Height,1);
            }
            int numOfOddNumber = ((int)Width - 2) / 2;
            if(numOfOddNumber == 0)
            {
                numOfOddNumber = 1;
            }
            int numOfRepeat = ((int)Height - 2) / numOfOddNumber;
            int leftOvers = ((int)Height - 2) % numOfOddNumber;

            if (Height == 2)
            {
                numOfOddNumber = 0;
                numOfRepeat = 0;
            }
            string tower = DrawTower(numOfRepeat, numOfOddNumber, leftOvers);
            return tower;   
        }
        /// <summary>
        /// draw the tower 
        /// </summary>
        /// <param name="numberOfRepeat">times for each level to be repeated</param>
        /// <param name="numOfOddNumber">number of odd nuber that the levels can be instaed the top an dthe buttom</param>
        /// <param name="leftOvers">number of the extra levels for the level draw with 3 *</param>
        /// <returns></returns>
        private string DrawTower(int numberOfRepeat, int numOfOddNumber, int leftOvers)
        {
            string head = Level(1, 1);
            for (int i = 1; i <= numOfOddNumber; i++)
            {
                if (i == 1)
                {
                    head = head + Level(numberOfRepeat + leftOvers, i * 2 + 1);
                }
                else
                {
                    head = head + Level(numberOfRepeat, i * 2 + 1);
                }
            }
            head=head + Level(1, (int)Width);

            return head;
        }
        /// <summary>
        /// print one level of the tower 
        /// </summary>
        /// <param name="numOfRepeat"></param>
        /// <param name="numOfTavs"></param>
        /// <returns></returns>
        private string Level(int numOfRepeat,int numOfTavs)
        {
            string line = string.Concat(Enumerable.Repeat(" ", ((int)Width - numOfTavs) / 2)) + string.Concat(Enumerable.Repeat("*", numOfTavs)) + string.Concat(Enumerable.Repeat(" ", ((int)Width - numOfTavs) / 2)) + "\n";
            return string.Concat(Enumerable.Repeat(line, numOfRepeat));

        }

    }
}
