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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        //Here the method which sets up the game while opening
        private void SetUpGame()
        {
            //Creating a list pair of emoji
            List<string> animalEmoji = new List<string>()
            {
                "☠", "☠",
                "👻", "👻",
                "🐯", "🐯",
                "🐺", "🐺",
                "🐶", "🐶",
                "🐵", "🐵",
                "😺", "😺",
                "👽", "👽",
            };

            //initializing a new random object named random
            Random random = new Random();

            //loop that assigns each text block from the main grid control a emoji picking randomly from the list of emoji
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //sets the index as random from the max number of emoji available in animalEmoji List
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
