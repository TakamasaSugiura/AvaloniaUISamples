namespace MessageBox.Services

open ReactiveUI
open MessageBox.Enums
open Avalonia.Controls

type MsgBoxViewModel(message: string, buttonType: ButtonType) =
    inherit ReactiveObject()
    let mutable _window: Window = null
    let _message:string = message
    let _okButtonVisible = true
    let _cancelButtonVisible = if buttonType = ButtonType.Ok then false else true

    member this.Window with get() = _window and set(value) = this.RaiseAndSetIfChanged(&_window, value) |> ignore

    member this.Message = _message