using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Windows;

namespace IDPversion3.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Symp symp = new Symp();
        Answers answ = new Answers();
        public int ans1, ans2, ans3, ans4, ans5, ans6, ans7, sum, activquest;

        public void startbtn_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            button.IsVisible = false;
            button.IsEnabled = false;
            questGrid.IsVisible = true;
            questGrid.IsEnabled = true;
            LabelContent.Content = answ.textSymp.ToString();

            activquest = 1;
            loadQuestone();
            next.Content = answ.textButtonnext.ToString();
            back.IsVisible = false; back.IsEnabled = false;
        }
        public void loadQuestone()
        {
            sympTextBlock.Text = symp.questone.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = true; answerfour.IsEnabled = true;
            answerfive.IsVisible = true; answerfive.IsEnabled = true;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ11.ToString();
            answertwo.Content = answ.answerQ12.ToString();
            answerthree.Content = answ.answerQ13.ToString();
            answerfour.Content = answ.answerQ14.ToString();
            answerfive.Content = answ.answerQ15.ToString();
        }
        public void loadQuesttwo()
        {
            sympTextBlock.Text = symp.questtwo.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = false; answerfour.IsEnabled = false;
            answerfive.IsVisible = false; answerfive.IsEnabled = false;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ21.ToString();
            answertwo.Content = answ.answerQ22.ToString();
            answerthree.Content = answ.answerQ33.ToString();
        }
        public void loadQuestthree()
        {
            sympTextBlock.Text = symp.questthree.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = true; answerfour.IsEnabled = true;
            answerfive.IsVisible = false; answerfive.IsEnabled = false;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ31.ToString();
            answertwo.Content = answ.answerQ32.ToString();
            answerthree.Content = answ.answerQ33.ToString();
            answerfour.Content = answ.answerQ34.ToString();
            answerone.Classes = new Classes("own");
            answertwo.Classes = new Classes("own");
            answerthree.Classes = new Classes("own");
            answerfour.Classes = new Classes("own");
            answerfive.Classes = new Classes("own");
            answersix.Classes = new Classes("own");
            answerseven.Classes = new Classes("own");
        }
        public void loadQuestfour()
        {
            sympTextBlock.Text = symp.questfour.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = true; answerfour.IsEnabled = true;
            answerfive.IsVisible = true; answerfive.IsEnabled = true;
            answersix.IsVisible = true; answersix.IsEnabled = true;
            answerseven.IsVisible = true; answerseven.IsEnabled = true;
            answerone.Content = answ.answerQ41.ToString();
            answertwo.Content = answ.answerQ42.ToString();
            answerthree.Content = answ.answerQ43.ToString();
            answerfour.Content = answ.answerQ44.ToString();
            answerfive.Content = answ.answerQ45.ToString();
            answersix.Content = answ.answerQ46.ToString();
            answerseven.Content = answ.answerQ47.ToString();

            answerone.Classes = new Classes("exp");
            answertwo.Classes = new Classes("exp");
            answerthree.Classes = new Classes("exp");
            answerfour.Classes = new Classes("exp");
            answerfive.Classes = new Classes("exp");
            answersix.Classes = new Classes("exp");
            answerseven.Classes = new Classes("exp");
        }
        public void loadQuestfive()
        {
            sympTextBlock.Text = symp.questfive.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = true; answerfour.IsEnabled = true;
            answerfive.IsVisible = false; answerfive.IsEnabled = false;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ51.ToString();
            answertwo.Content = answ.answerQ52.ToString();
            answerthree.Content = answ.answerQ53.ToString();
            answerfour.Content = answ.answerQ54.ToString();
            answerone.Classes = new Classes("own");
            answertwo.Classes = new Classes("own");
            answerthree.Classes = new Classes("own");
            answerfour.Classes = new Classes("own");
            answerfive.Classes = new Classes("own");
            answersix.Classes = new Classes("own");
            answerseven.Classes = new Classes("own");
        }
        public void loadQuestsix()
        {
            sympTextBlock.Text = symp.questsix.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = true; answerthree.IsEnabled = true;
            answerfour.IsVisible = true; answerfour.IsEnabled = true;
            answerfive.IsVisible = false; answerfive.IsEnabled = false;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ61.ToString();
            answertwo.Content = answ.answerQ62.ToString();
            answerthree.Content = answ.answerQ63.ToString();
            answerfour.Content = answ.answerQ64.ToString();

        }
        public void loadQuestseven()
        {
            sympTextBlock.Text = symp.questseven.ToString();
            answerone.IsVisible = true; answerone.IsEnabled = true;
            answertwo.IsVisible = true; answertwo.IsEnabled = true;
            answerthree.IsVisible = false; answerthree.IsEnabled = false;
            answerfour.IsVisible = false; answerfour.IsEnabled = false;
            answerfive.IsVisible = false; answerfive.IsEnabled = false;
            answersix.IsVisible = false; answersix.IsEnabled = false;
            answerseven.IsVisible = false; answerseven.IsEnabled = false;
            answerone.Content = answ.answerQ71.ToString();
            answertwo.Content = answ.answerQ72.ToString();

        }
        public void resetCheck()
        {
            answerone.IsChecked = false;
            answertwo.IsChecked = false;
            answerthree.IsChecked = false;
            answerfour.IsChecked = false;
            answerfive.IsChecked = false;
            answersix.IsChecked = false;
            answerseven.IsChecked = false;
        }
        public void loadresult()
        {
            sum = ans1 + ans2 + ans3 + ans4 + ans5 + ans6 + ans7;
            if (sum <= 8) questGrid.Background = Brushes.LightGreen;
            else if (sum >= 9 && sum <= 20) questGrid.Background = Brushes.Yellow;
            else if (sum >= 21) questGrid.Background = Brushes.Tomato;
            result.Text = sum.ToString() + answ.textResultpoint.ToString();
        }
        public void next_Click(object sender, RoutedEventArgs e)
        {
            if (answerone.IsChecked == true || activquest == 8 || answertwo.IsChecked == true || answerthree.IsChecked == true || answerfour.IsChecked == true || answerfive.IsChecked == true || answersix.IsChecked == true || answerseven.IsChecked == true)
            {
                if (activquest == 1)
                {
                    if (answerone.IsChecked == true) ans1 = 2;
                    else if (answertwo.IsChecked == true) ans1 = 3;
                    else if (answerthree.IsChecked == true) ans1 = 2;
                    else if (answerfour.IsChecked == true) ans1 = 1;
                    else if (answerfive.IsChecked == true) ans1 = 4;
                    resetCheck();
                    activquest++;
                    loadQuesttwo();
                    back.IsVisible = true; back.IsEnabled = true;
                }
                else if (activquest == 2)
                {
                    if (answerone.IsChecked == true) ans2 = 6;
                    else if (answertwo.IsChecked == true) ans2 = 3;
                    else if (answerthree.IsChecked == true) ans2 = 2;
                    resetCheck();
                    activquest++;
                    loadQuestthree();

                }
                else if (activquest == 3)
                {
                    if (answerone.IsChecked == true) ans3 = 6;
                    else if (answertwo.IsChecked == true) ans3 = 4;
                    else if (answerthree.IsChecked == true) ans3 = 3;
                    else if (answerfour.IsChecked == true) ans3 = 1;
                    resetCheck();
                    activquest++;
                    loadQuestfour();

                }
                else if (activquest == 4)
                {
                    if (answerone.IsChecked == true) ans4 = 3;
                    else if (answertwo.IsChecked == true) ans4 = 1;
                    else if (answerthree.IsChecked == true) ans4 = 0;
                    else if (answerfour.IsChecked == true) ans4 = 0;
                    else if (answerfive.IsChecked == true) ans4 = 2;
                    else if (answersix.IsChecked == true) ans4 = 2;
                    else if (answerseven.IsChecked == true) ans4 = 4;
                    resetCheck();
                    activquest++;
                    loadQuestfive();

                }
                else if (activquest == 5)
                {
                    if (answerone.IsChecked == true) ans5 = 1;
                    else if (answertwo.IsChecked == true) ans5 = 2;
                    else if (answerthree.IsChecked == true) ans5 = 4;
                    else if (answerfour.IsChecked == true) ans5 = 6;
                    resetCheck();
                    activquest++;
                    loadQuestsix();
                }
                else if (activquest == 6)
                {
                    if (answerone.IsChecked == true) ans6 = 0;
                    else if (answertwo.IsChecked == true) ans6 = 1;
                    else if (answerthree.IsChecked == true) ans6 = 2;
                    else if (answerfour.IsChecked == true) ans6 = 3;
                    resetCheck();
                    activquest++;
                    loadQuestseven();
                    next.Content = answ.textButtonend.ToString();
                }
                else if (activquest == 7)
                {
                    if (answerone.IsChecked == true) ans7 = 0;
                    else if (answertwo.IsChecked == true) ans7 = 3;
                    resetCheck();
                    activquest++;
                    back.IsVisible = false; back.IsEnabled = false;
                    next.Content = answ.textButtonrepeat.ToString();
                    LabelContent.Content = answ.textResult.ToString();
                    sympTextBlock.IsVisible = false; sympTextBlock.IsEnabled = false;
                    QuestStack.IsVisible = false; QuestStack.IsEnabled = false;
                    result.IsVisible = true; result.IsEnabled = true;
                    loadresult();
                }
                else if (activquest >= 8)
                {
                    result.IsVisible = false; result.IsEnabled = false;
                    sympTextBlock.IsVisible = true; sympTextBlock.IsEnabled = true;
                    QuestStack.IsVisible = true; QuestStack.IsEnabled = true;
                    activquest = 1;
                    loadQuestone();
                    LabelContent.Content = answ.textSymp.ToString();
                    next.Content = answ.textButtonnext.ToString();
                    ans1 = 0; ans2 = 0; ans3 = 0; ans4 = 0; ans5 = 0; ans6 = 0; ans7 = 0;
                    questGrid.Background = Brushes.Wheat;
                }
            }
            else
            {

            }
        }
        public void back_Click(object sender, RoutedEventArgs e)
        {
            if (activquest == 2)
            {
                ans1 = 0;
                loadQuestone();
                back.IsVisible = false; back.IsEnabled = false;
                activquest--;
            }
            else if (activquest == 3)
            {
                ans2 = 0;
                loadQuesttwo();
                activquest--;
            }
            else if (activquest == 4)
            {
                ans3 = 0;
                loadQuestthree();
                activquest--;
            }
            else if (activquest == 5)
            {
                ans4 = 0;
                loadQuestfour();
                activquest--;
            }
            else if (activquest == 6)
            {
                ans5 = 0;
                loadQuestfive();
                activquest--;
            }
            else if (activquest == 7)
            {
                ans6 = 0;
                loadQuestsix();
                LabelContent.Content = answ.textSymp.ToString();
                next.Content = answ.textButtonnext.ToString();
                activquest--;
            }
        }
    }
}
