﻿namespace Project;

public partial class App : Application
{
	public App()
	{
		
		InitializeComponent();
		

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

		window.Created += (s, e) =>
		{
			Read read = new Read();
			read.GrabAllEmployees();
			
		};

		return window;
    }
}
