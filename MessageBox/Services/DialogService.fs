namespace MessageBox.Services

open Avalonia.Controls
open MessageBox.Enums

type DialogService() =
     member this.ShowDialog(owner: Window, message: string, buttonType: ButtonType) =
        let dlg = new MsgBox()
        
        dlg.DataContext <- new MsgBoxViewModel(message, buttonType, Window = dlg)

        dlg.ShowDialog(owner)