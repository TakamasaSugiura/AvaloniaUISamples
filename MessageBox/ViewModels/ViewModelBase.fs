namespace MessageBox.ViewModels

open ReactiveUI
open Avalonia.Controls

type ViewModelBase() =
    inherit ReactiveObject()

    let mutable _window: Window = null

    member this.Window with get() = _window and set(value) = this.RaiseAndSetIfChanged(&_window, value) |> ignore