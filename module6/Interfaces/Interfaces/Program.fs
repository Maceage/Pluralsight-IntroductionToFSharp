type IMyInterface =
    abstract member Value: int with get

type IDerivedInterface =
    inherit IMyInterface

    abstract member Add: int -> int -> int

type MyClass() =
    interface IMyInterface with
        member x.Value with get() = 13

type MyOtherClass() =
    member this.Add x y = x + y

    interface IDerivedInterface with
        member i.Add x y = i.Add x y
        member x.Value = 42

let moc = MyOtherClass()

printfn "%A" (moc.Add 10 20)
printfn "%A" ((moc :> IMyInterface).Value)
printfn "%A" ((moc :> IDerivedInterface).Add 10 20)