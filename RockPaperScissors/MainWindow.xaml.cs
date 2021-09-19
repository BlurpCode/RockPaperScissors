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
            determineResult();
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "Paper";
            determineResult();
        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "Scissors";
            determineResult();
        }

        //Calculate the results
        private void determineResult() {
            computerSelection();
            if (userChoice == computerChoice)
            {
                //Tie
                tbResults.Text = "Tie. You both selected " + userChoice;
                btnPlay.Visibility = Visibility.Visible;
            }
            else
            {
                switch (computerChoice)
                {
                    case "Rock":
                        if (userChoice == "Paper")
                        {
                            //User Wins
                            printResult("User", "Computer");
                        }
                        else
                        {
                            //User Loses
                            printResult("Computer", "User");
                        }
                        break;
                    case "Paper":
                        if (userChoice == "Scissors")
                        {
                            //User Wins
                            printResult("User", "Computer");
                        }
                        else
                        {
                            //User Loses
                            printResult("Computer", "User");
                        }
                        break;
                    case "Scissors":
                        if (userChoice == "Rock")
                        {
                            //User Wins
                            printResult("User", "Computer");
                        }
                        else
                        {
                            //User Loses
                            printResult("Computer", "User");
                        }
                        break;
                }
            }
        }

        //Uses a random number generator to select either rock, paper or scissors
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

        //Prints the result on Screen
        private void printResult(string winner, string loser) {
            btnPlay.Visibility = Visibility.Visible;
            tbResults.Text = winner+" wins. You threw "+userChoice+" and the computer threw "+computerChoice;
        }

        //Function to let the player Play again
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Visibility = Visibility.Hidden;
            tbResults.Text = "";
        }
    }
}
