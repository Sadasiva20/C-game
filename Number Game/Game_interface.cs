using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    internal class Game_interface
    {

        public String get_playername { get; set; }

        public String set_playername { get; set; }

        public int get_score { get; set; }

        public int set_score { get; set; }

        public int num_misses { get; set; }

        public int num_guesses { get; set; }

        public int correct_guesses { get; set; }


        public int Level1()
        {
            Random new_num = new Random();

            int number = new_num.Next(0,50);

            return number;

        }
        public int Level2()
        {

            Random new_num = new Random();

            int number = new_num.Next( 60, 100);

            return number;
        }

        public int Level3()
        {
            Random new_num = new Random();

           

            int number = new_num.Next(300,450);

            return number;
        }
        public int Level4()
        {
            Random new_num = new Random();


            int number = new_num.Next(500, 800);

            return number;
        }
        public int Level5()
        {

            Random new_num = new Random();


            int number = new_num.Next( 1000 ,  1500);

            return number;


        }

        

        public void  add_item(int item)
        {

               ArrayList array_1 = new ArrayList();

               array_1.Add(item);

            for (int count = 0; count < array_1.Capacity; count++)
            {

               
                 
            }



        }
    }


   


}
