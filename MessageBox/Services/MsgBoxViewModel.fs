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
    let mutable _buttonResult:ButtonResult = ButtonResult.Cancel

    member this.Window with get() = _window and set(value) = this.RaiseAndSetIfChanged(&_window, value) |> ignore
    member this.OkButtonVisible = _okButtonVisible
    member this.CancelButtonVisible = _cancelButtonVisible
    member this.Message = _message
    member this.ButtonResult = _buttonResult
    member this.OkCommand() =
        _buttonResult <- ButtonResult.Ok
        this.CloseWindow()
    member this.CancelCommand() =
        _buttonResult <- ButtonResult.Cancel
        this.CloseWindow()

    member this.CloseWindow() =
        if _window = null then
            ()
        else
            _window.Close()
        