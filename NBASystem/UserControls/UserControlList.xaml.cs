﻿using NBASystem.Model;
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

namespace NBASystem.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserControlList.xaml
    /// </summary>
    public partial class UserControlList : UserControl
    {
        public UserControlList()
        {
            InitializeComponent();
            if (DivisionContext != null)
            {
                DataContext = DivisionContext;
            }
        }

        public Division DivisionContext { get; set; }


    }
}
