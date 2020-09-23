using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Zoo
    {
        public List<Cage> CageList { get; set; }
        public Zoo()
        {
            CageList = new List<Cage>();
        }
        public void AddCage(Cage c)
        {
            CageList.Add(c);
        }
        public void RemoveCage(int c)
        {
            for (int i = 0; i < CageList.Count; i++)
            {
                if (CageList[i].CageNumber == c)
                {
                    CageList.RemoveAt(i);
                }
            }
        }
    }
}
