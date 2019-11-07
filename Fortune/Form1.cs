using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortune
{
    public partial class Form1 : Form
    {
        private static Random random = new Random(DateTime.Now.Millisecond);

        string[] FortuneCards = new string[23];
        string[] FortuneMessages = new string[23]; //setting array up

       

        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Reveal_Click(object sender, EventArgs e)
        {
            int[] luckynumbers = GenerateRandomLuckyNumbers();
            string displayFortuneMessage = 
                "Your fortune card is: " +
                "\nYour reading means: " +
                "\nYour lucky numbers are: " + string.Join(", ", luckynumbers);
          //when you use \n it represents a new line \t will give you tab so if you want to indent the text
            
            
            
            MessageBox.Show(displayFortuneMessage, "Your fortune card");
        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
        public static int[] GenerateRandomLuckyNumbers()
        {
            int[] luckyNumbers = new int[6]; //[] sets amnt of numbers wanted for array
            for (int i = 0; i < 6; i++)
            {
                luckyNumbers[i] = random.Next(1, 49);//
            }
            return luckyNumbers;
        }

        //TODO: private static void will be placing data into arrays, putting messages with the cards

    }
}
