using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruthi_Edel_Targil_2.Models
{
    public abstract class Tower
    {

        public double Width { get; set; }  
        public double Height { get; set; }

        public Tower(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double Perimeter();
      
        public abstract string Towerdescription(int x);
        /// <summary>
        /// print the tower description
        /// </summary>
        /// <param name="x">Setting the option to print the triangle (not needed for other tower types):
        /// </param>
        public void Print(int x=1)
        {
            string descerption = "---The Tower description is---"+'\n'+
                "---"+this.GetType().Name + " Tower:--- \n" +
                this.Towerdescription(x)+
                "\n-------GoodLuck--------";
            Console.ForegroundColor = ConsoleColor.Blue; // Set text color to green
            Console.WriteLine(descerption);
            Console.ResetColor(); // Reset
           
        }
      

    }
}
