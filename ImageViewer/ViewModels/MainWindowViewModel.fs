namespace ImageViewer.ViewModels

open ReactiveUI
open System
open Avalonia.Controls
open Avalonia.Media.Imaging

type MainWindowViewModel() =
    inherit ViewModelBase()
    let mutable _imageSource:Bitmap = null

    member this.ImageSource with get() = _imageSource and set(value) = this.RaiseAndSetIfChanged(&_imageSource, value) |> ignore

    member this.OpenCommand(window:Window) =
        let ret = this.GetFileName(window) |> Async.RunSynchronously
        if ret = null || ret.Length = 0 then
            ()
        try
            let bmp = new Bitmap(ret.[0])
            this.ImageSource <- bmp
        with
            | _ as ex -> Console.WriteLine(ex.ToString())

    member this.GetFileName(window:Window): Async<string[]> =
        async{
            let dlg = new OpenFileDialog()
            let! fileName = dlg.ShowAsync(window) |> Async.AwaitTask
            return fileName
        }

    member this.ExitCommand(window:Window) =
        window.Close()