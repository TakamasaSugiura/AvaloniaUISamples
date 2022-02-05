namespace ImageViewer.ViewModels

open ReactiveUI
open System
open Avalonia.Controls

type MainWindowViewModel() =
    inherit ViewModelBase()

    member this.Greeting = "Welcome to Avalonia!"

    member this.OpenCommand(window:Window) =
        let ret = this.GetFileName(window) |> Async.RunSynchronously
        ()

    member this.GetFileName(window:Window): Async<string[]> =
        async{
            let dlg = new OpenFileDialog()
            let! fileName = dlg.ShowAsync(window) |> Async.AwaitTask
            return fileName
        }

    member this.ExitCommand(window:Window) =
        window.Close()