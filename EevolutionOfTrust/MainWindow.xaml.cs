using System;
using System.Windows;
using EevolutionOfTrust.Characters;

namespace EevolutionOfTrust
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Обмануть
        /// </summary>
        private void ButtonCheat_Click(object sender, RoutedEventArgs e)
        {
            DataBank.PlayerChoise = false;

            if (DataBank.GameTurn < 5)
            {
                if (Simulator.Action(DataBank.PreviousPlayerChoise))
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 3}";

                    BorderLeft.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    BorderBottom.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
            }   // Симулятор
            else if (DataBank.GameTurn < 9)
            {
                if (!Cheater.Action())
                {
                    BorderBottom.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
            }   // Обманщик
            else if (DataBank.GameTurn < 13)
            {
                if (Naive.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 3}";

                    BorderLeft.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
            }   // Наивный
            else if (DataBank.GameTurn < 17)
            {
                if (Malignant.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 3}";

                    BorderLeft.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    BorderBottom.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
                Malignant.CheatedAtLeastOnce = true;
            }   // Злопамятный
            else if (DataBank.GameTurn < 24)
            {
                if (Detective.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 3}";

                    BorderLeft.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    BorderBottom.BorderYellow();
                    labelYouCheated.LabelYellow();
                    labelHeCheated.LabelYellow();
                }

                Detective.DetectiveStepCount++;
            }   // Детектив

            DataBank.PreviousPlayerChoise = DataBank.PlayerChoise;

            ImageCurrentEnemy.SetImage();
        }
        /// <summary>
        /// Довериться
        /// </summary>
        private void ButtonTrust_Click(object sender, RoutedEventArgs e)
        {
            DataBank.PlayerChoise = true;

            if (DataBank.GameTurn < 5)
            {
                if (Simulator.Action(DataBank.PreviousPlayerChoise))
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 2}";

                    BorderTop.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) - 1}";

                    BorderRight.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
            }   // Симулятор
            else if (DataBank.GameTurn < 9)
            {
                if (!Cheater.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) - 1}";

                    BorderRight.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
            }   // Обманщик
            else if (DataBank.GameTurn < 13)
            {
                if (Naive.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 2}";

                    BorderTop.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
            }   // Наивный
            else if (DataBank.GameTurn < 17)
            {
                if (Malignant.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 2}";

                    BorderTop.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) - 1}";

                    BorderRight.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeCheated.LabelYellow();
                }
            }   // Злопамятный
            else if (DataBank.GameTurn < 24)
            {
                if (Detective.Action())
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) + 2}";

                    BorderTop.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeTrusted.LabelYellow();
                }
                else
                {
                    labelYouTotalScoreValue.Content = $"{Convert.ToInt32(labelYouTotalScoreValue.Content) - 1}";

                    BorderRight.BorderYellow();
                    labelYouTrusted.LabelYellow();
                    labelHeCheated.LabelYellow();
                }

                Detective.DetectiveStepCount++;

            }   // Детектив

            DataBank.PreviousPlayerChoise = DataBank.PlayerChoise;

            ImageCurrentEnemy.SetImage();
        }
    }
}