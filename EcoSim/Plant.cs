using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EcoSim
{
    public class Plant
    {
        private int foodAmt;
        private int life;
        private Image sprite;


        public Plant()
        {
            foodAmt = 0;
            life = 0;
        }

        public Plant(int foodAmt, int life, Image sprite)
        {
            foodAmt = this.foodAmt;
            life = this.life;
            sprite = this.sprite;
        }


        /// <summary>
        /// This determines whether the animal is placed in a Valid Environment.
        /// </summary>
        public bool isValidEnvironment()
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// Get/Set for the plant image.
        /// </summary>
        public Image Image
        {
            get
            {
                return sprite;
            }
            set
            {
                sprite = value;
            }
        }

        /// <summary>
        /// Get/Set for the amount of food a plant has to provide.
        /// </summary>
        public int FoodAmount
        {
            get
            {
                return foodAmt;
            }
            set
            {
                foodAmt = value;
            }
        }


        /// <summary>
        /// Get/Set for plant lifespan.
        /// </summary>
        public int LifeSpan
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
            }
        }

    }
}
