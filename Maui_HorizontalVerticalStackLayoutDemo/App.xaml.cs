﻿namespace Maui_HorizontalVerticalStackLayoutDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VerticalStackLayoutDemo();
        }
    }
}
