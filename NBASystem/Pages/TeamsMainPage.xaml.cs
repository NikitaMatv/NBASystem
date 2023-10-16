using NBASystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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

namespace NBASystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeamsMainPage.xaml
    /// </summary>
    public partial class TeamsMainPage : Page
    {
        public TeamsMainPage()
        {
            InitializeComponent();
            LVGrid.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 3).ToList();
            LVGrid1.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 2).ToList();
            LVGrid2.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 1).ToList();
            LVGrid3.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 5).ToList();
            LVGrid4.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 6).ToList();
            LVGrid5.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 4).ToList();

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var team = (sender as TextBlock).DataContext as Team;
            if (team == null) 
            {
                return; 
            }

            NavigationService.Navigate(new TeamDetailPage(team, 0));
            


        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var team = (sender as TextBlock).DataContext as Team;
            if (team == null)
            {
                return;
            }

            NavigationService.Navigate(new TeamDetailPage(team, 1));
        }

        private void TextBlock_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var team = (sender as TextBlock).DataContext as Team;
            if (team == null)
            {
                return;
            }

            NavigationService.Navigate(new TeamDetailPage(team, 2));
        }
    }
}
