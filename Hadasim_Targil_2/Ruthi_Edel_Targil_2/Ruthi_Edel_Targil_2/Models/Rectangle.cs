using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruthi_Edel_Targil_2.Models
{
    public class Rectangle : Tower
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }
        /// <summary>
        /// calculate the tower perimeter
        /// </summary>
        /// <returns>calculated perimeter</returns>
        public override double Perimeter()
        {
           return (this.Height)*2+this.Width*2;
        }
        /// <summary>
        /// calculate the tower surface
        /// </summary>
        /// <returns>calculated sureface</returns>
        public  double SureFace()
        {
            return this.Width*this.Height;
        }





        /// <summary>
        /// print the rectangle description 
        /// </summary>
        /// <param name="x">not needed</param>
        /// <returns>string value of the tower description</returns>
        public override string Towerdescription(int x=1)
        {
           if(Math.Abs(this.Height-this.Width)>5)
            {
                return " SurFace : " + this.SureFace();
            }
            else
            {
                return " Perimeter : " + this.Perimeter();
            }
          
        }
    }
}
