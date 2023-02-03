using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace matchgame;

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

    private void SetUpGame()
    {
        List<string> animalEmoji = new List<string>()
        {
            "🦂","🦂",
            "🐦","🐦",
            "🐌","🐌",
            "💕","💕",
            "🤷","🤷",
            "‍♀️" ,"♀️" ,
            "🙌","🙌",
            "🐜","🐜",
        };


        Random rnd = new Random();

        foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
        {
            int index= rnd.Next(animalEmoji.Count);
            string nextEmeoji = animalEmoji[index];
            textBlock.Text = nextEmeoji;
            animalEmoji.RemoveAt(index);
        }

    }
}
