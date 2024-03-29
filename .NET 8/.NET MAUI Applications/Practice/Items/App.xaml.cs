﻿using Items.Services;

namespace Items;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
    }

    protected override void OnStart() { }

    protected override void OnSleep() { }

    protected override void OnResume() { }
}