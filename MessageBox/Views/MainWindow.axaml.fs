namespace MessageBox.Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml
open MessageBox.ViewModels

type MainWindow () as this = 
    inherit Window ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
#if DEBUG
        this.AttachDevTools()
#endif
        AvaloniaXamlLoader.Load(this)
        this.DataContext <- new MainWindowViewModel(Window = this)