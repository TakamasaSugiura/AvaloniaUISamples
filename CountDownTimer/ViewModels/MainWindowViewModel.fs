namespace CountDownTimer.ViewModels

open ReactiveUI
open Avalonia.Threading
open System

type MainWindowViewModel() as self =
    inherit ViewModelBase()

    let mutable _minutes:int = 0
    let mutable _seconds:int = 0
    let mutable _canStart:bool = true
    let mutable _canStop:bool = false
    let mutable _canClear:bool = true
    let _timer:DispatcherTimer = new DispatcherTimer()

    do
        _timer.Interval <- new TimeSpan(0, 0, 1);
        _timer.Tick.Add(fun arg -> self.CountDown())

    member this.Greeting = "Welcome to Avalonia!"
    member this.Minutes with get() = _minutes and set(value) = this.RaiseAndSetIfChanged(&_minutes, value) |> ignore
    member this.Seconds with get() = _seconds and set(value) = this.RaiseAndSetIfChanged(&_seconds, value) |> ignore

    member this.StartTimer() = _timer.Start()

    member this.StopTimer() = _timer.Stop()

    member this.ClearTimer() =
        this.Minutes <- 0
        this.Seconds <- 0
    
    member this.CountDown() =
        let nextSeconds = this.Seconds - 1
        let nextMinutes = this.Minutes - if nextSeconds < 0 then 1 else 0
        this.Minutes <- if nextMinutes > -1 then nextMinutes else 0
        this.Seconds <- if nextSeconds > -1 then nextSeconds else if nextMinutes > -1 then 59 else 0
        if nextSeconds < 0 && nextMinutes < 0 then
            do
                _timer.Stop()
