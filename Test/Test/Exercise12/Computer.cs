﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise12
{
    public class Computer
    {

        private List<String> ingredients = new List<String>();

        public Computer()
        {

            // prepareBun
            // prepareVegg
            // prepareMain
            // prepareTopping		
            // preparePriceLabel	
        }

        public void PrepareBun(String vegg)
        {
            ingredients.Add(vegg);
        }

        public void PrepareVegg(String vegg)
        {
            ingredients.Add(vegg);
        }

        public void PrepareMain(String main)
        {
            ingredients.Add(main);
        }

        public void PrepareTopping(String topping)
        {
            ingredients.Add(topping);
        }

        public void PreparePriceLabel(String price)
        {
            ingredients.Add(price);
        }
    }
}
