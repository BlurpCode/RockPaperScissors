using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String userChoice { get; set; }
        public String computerChoice { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "Rock";
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "Paper";
        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "Scissors";
        }

        private void determineResult() {
            computerSelection();
            if (userChoice == computerChoice)
            {
                //Tie
            }
            else
            {
                switch (computerChoice)
                {
                    case "Rock":
                        if (userChoice == "Paper")
                        {
                            //User Wins
                        }
                        else
                        {
                            //User Loses
                        }
                        break;
                    case "Paper":
                        if (userChoice == "Scissors")
                        {
                            //User Wins
                        }
                        else
                        {
                            //User Loses
                        }
                        break;
                    case "Scissors":
                        if (userChoice == "Rock")
                        {
                            //User Wins
                        }
                        else
                        {
                            //User Loses
                        }
                        break;
                }
            }
        }

        private void computerSelection() {
            Random rand = new Random();
            int randNum = rand.Next(1, 3);

            switch (randNum)
            {
                case 1:
                    computerChoice = "Rock";
                    break;
                case 2:
                    computerChoice = "Paper";
                    break;
                case 3:
                    computerChoice = "Scissors";
                    break;
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
