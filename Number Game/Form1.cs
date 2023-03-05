using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            String level_name = Level.SelectedItem.ToString();

            Game_interface interface_1 = new Game_interface();


            int number = 0;

            if (level_name == "1")
            {

                number = interface_1.Level1();

              label1.Text = "Enter a guess less than ? " + number;

                

                if (!textBox1.Text.Equals("") )
                {
                    int num = int.Parse(textBox1.Text);

                    input_guess(num, number);

                }


            }

            if (level_name == "2")
            {
                number = interface_1.Level2();

                label1.Text = "Enter a guess less than ? " + number;
                if (!textBox1.Text.Equals(""))
                {
                    int num_2 = int.Parse(textBox1.Text);

                    input_guess(num_2, number);
                }
            }
            if (level_name == "3")
            {
                number = interface_1.Level3();

                label1.Text = "Enter a guess less than ? " + number;
              
                if (!textBox1.Text.Equals(""))
                {
                    int num_3 = int.Parse(textBox1.Text);

                    input_guess(num_3, number);
                }
            }
            if (level_name == "4")
            {
                number = interface_1.Level4();

                label1.Text = "Enter a guess less than ? " + number;

               

                if (!textBox1.Text.Equals(""))
                {
                    int num_4 = int.Parse(textBox1.Text);

                    input_guess(num_4, number);
                }
            }
            if (level_name == "5")
            {
                number = interface_1.Level5(); 

                label1.Text = "Enter a guess less than ? " + number;

               
                if (!textBox1.Text.Equals(""))
                {

                    int num_5 = int.Parse(textBox1.Text);

                    input_guess(num_5, number);
                }
            }


        }

        public void input_guess(int num , int number)
        {

            int correct_guesses = 0;   // statistics to cout the number of guesses.

            int incorrect_guess = 0;


            if (num < number)
            {
                label1.Text = "Your guess  of " + num + " is too low ";

                incorrect_guess += 1;  //Count the guesses that are lower than the actual number. 

                int.Parse(textBox1.Text);

                //Add them to a statistics array method.

            }
            else if (num > number)
            {

                label1.Text = "Your guess is too high.";

                incorrect_guess += 1; //Count the guesses that are higher  than the actual number. 
                                      //  Add them to a statistics array method.  
                int.Parse(textBox1.Text);
            }
            else if (num.Equals(number))
            {
                label1.Text = "Your guess is  just right.";

                correct_guesses += 1;    //Count the guesses that are equal to the actual number. 

                int.Parse(textBox1.Text);
            }//Add them to a statistics array method.
        }
        public int get_level( )
        {
            int current_level = 0;
            Game_interface interface_1 = new Game_interface();
            if (Level.SelectedItem.ToString().Equals("1"))
            {
                current_level = interface_1.Level1();

                return current_level;

            }
            if (Level.SelectedItem.ToString().Equals("2"))
            {
                current_level = interface_1.Level2();

                return current_level;

            }

            if (Level.SelectedItem.ToString().Equals("3"))
            {
                current_level = interface_1.Level3();

                return current_level;

            }
            if (Level.SelectedItem.ToString().Equals("4"))
            {
                current_level = interface_1.Level4();

                return current_level;

            }
            if (Level.SelectedItem.ToString().Equals("5"))
            {
                current_level = interface_1.Level5();

                return current_level;

            }

            return current_level;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Game_interface interface_1 = new Game_interface();

            int number = get_level();

            int num = int.Parse(textBox1.Text);

            input_guess(num, number);

            button1.Text = "Guess";

            button2.Text = "Quit";



        }

    }
}
