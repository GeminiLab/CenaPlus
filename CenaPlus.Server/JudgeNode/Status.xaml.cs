﻿using System;
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

namespace CenaPlus.Server.JudgeNode
{
    /// <summary>
    /// Interaction logic for Status.xaml
    /// </summary>
    public partial class Status : UserControl
    {
        public Status()
        {
            InitializeComponent();
            Judge.Env.CoreStatusUpdated += Env_CoreStatusUpdated;
            TaskListBox.ItemsSource = Judge.Env.Cores;
        }

        void Env_CoreStatusUpdated(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(() => TaskListBox.Items.Refresh()));
        }
    }
}
