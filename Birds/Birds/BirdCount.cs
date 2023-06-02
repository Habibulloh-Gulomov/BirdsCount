using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class BirdCount
    {
        public static void LastWeek()
        {
            int[] birdarray = { 0, 2, 5, 3, 7, 8, 4 };
            foreach (var item in birdarray)
            {
                Console.WriteLine(item); ;
            }
        }
        public int[] birdsPerDay = { };
        public int num;

        public BirdCount(int[] birdsPerDay)
        {
            this.num = num;
            this.birdsPerDay = birdsPerDay;


        }

        public int Today()
        {
            //int[] birdarray = { 0, 0, 0, 0, 0, 0 };
            //for (int i = 0; i < birdsPerDay; i++)
            //{
            //    birdarray[i] = birdsPerDay[i];
            //}
            return birdsPerDay[birdsPerDay.Length - 1];

        }

        public void IncrementTodaysCount()
        {

            birdsPerDay[5] += 1;

        }

        public bool HasDayWithoutBirds()
        {
             bool boolen = false ;
            foreach (var item in birdsPerDay)
            {
                if (item == 0)
                {
                    boolen = true;
                    break;
                }
                else
                {
                    boolen = false;
                }
            }
            return boolen;


        }

        public int CountForFirstDays(int num)
        {
            int result = 0;
            for (int i = 0;i <num;i++)
            {
                result += birdsPerDay[i];
            }
            return result;

        }

        public int BusyDays()
        {
            int result = 0;
            for(int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >=5)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
