using System;
using System.Collections.Generic;

namespace OOP2
{
    public class AttributeBonus
    {
        public List<int> bonusRawList { get; private set; }
        public List<double> bonusMultiplyerList { get; private set; }


        public AttributeBonus()
        {
            bonusRawList = new List<int>();
            bonusMultiplyerList = new List<double>();
        }

        public AttributeBonus(int input)
        {
            bonusRawList = new List<int>(){input};
            bonusMultiplyerList = new List<double>();
        }

        public AttributeBonus(double input)
        {
            bonusRawList = new List<int>();
            bonusMultiplyerList = new List<double>() {input};
        }

        public void Add(int bonusRaw)
        {
            this.bonusRawList.Add(bonusRaw);

        }

        public void Add(double bonusMultiplyer)
        {
            this.bonusMultiplyerList.Add(bonusMultiplyer);

        }


        public void recieveUpdate(int newBonusRaw)
        {
            //bonusRaw += newBonusRaw;
        }

    }
}