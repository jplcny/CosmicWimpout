﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    abstract class Die
    {
        protected ArrayList sides = new ArrayList();
        protected string dieValue = "";
        protected string[] dieSides = new string[NUMBER_OF_SIDES];
        protected const int NUMBER_OF_SIDES = 6;
        protected Boolean isLocked;

        public void SetDieValue(int valueToSet)
        {
            if (valueToSet >= 0 && valueToSet < NUMBER_OF_SIDES)
            {
                this.dieValue = this.dieSides[valueToSet];
            }
            isLocked = false;
        }

        public string GetDieValue()
        {
            return this.dieValue;
        }

        public Boolean GetLockedStatus()
        {
            return this.isLocked;
        }
    }
}
