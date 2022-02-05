namespace MessageBox.ViewModels

open MessageBox.Services
open MessageBox.Enums

type MainWindowViewModel() =
    inherit ViewModelBase()

    member this.ButtonCommand() =
        let service = new DialogService()
        service.ShowDialog(this.Window, "aaaaa", ButtonType.Ok)
