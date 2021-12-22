namespace Quiz.ViewModels

open ReactiveUI
open System.Collections.Generic
open System

type MainWindowViewModel() as self =
    inherit ViewModelBase()

    let mutable _value1:int = 0
    let mutable _value2:int = 0
    let mutable _answer:string = ""
    let mutable _point:int = 0
    let _rnd:Random = new Random()

    do self.CreateQuiz()

    member this.Value1 with get() = _value1 and set(value) = this.RaiseAndSetIfChanged(&_value1, value) |> ignore

    member this.Value2 with get() = _value2 and set(value) = this.RaiseAndSetIfChanged(&_value2, value) |> ignore

    member this.Answer with get() = _answer and set(value) = this.RaiseAndSetIfChanged(&_answer, value) |> ignore

    member this.Point with get() = _point and set(value) = this.RaiseAndSetIfChanged(&_point, value) |> ignore

    member this.CheckAnswer() =
        let mutable ans:int = 0
        if System.Int32.TryParse(this.Answer, &ans) = false then ()
            else
                this.Point <- this.Point + if ans = _value1 + _value2 then 1 else 0
                this.CreateQuiz()
                ()

    member this.CreateQuiz() =
        this.Value1 <- _rnd.Next(1, 9)
        this.Value2 <- _rnd.Next(1, 9)
        this.Answer <- ""

