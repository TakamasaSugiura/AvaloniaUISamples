namespace ImageViewer.ViewModels

open ReactiveUI
open System
open Avalonia.Controls

type MainWindowViewModel() =
    inherit ViewModelBase()

    member this.Greeting = "Welcome to Avalonia!"

    member this.OpenCommand(window:Window) =
        this.GetFileName(window) |> Async.RunSynchronously

    member this.GetFileName(window:Window) =
        async{
            let dlg = new OpenFileDialog()
            let! fileName = dlg.ShowAsync(window) |> Async.AwaitTask
            ()
        }

    member this.ExitCommand(window:Window) =
        window.Close()