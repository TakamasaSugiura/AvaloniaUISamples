namespace ImageViewer.Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml
open ImageViewer.ViewModels

type MainWindow () as this = 
    inherit Window ()

    do this.InitializeComponent()


    member private this.InitializeComponent() =
#if DEBUG
        this.AttachDevTools()
#endif
        AvaloniaXamlLoader.Load(this)
