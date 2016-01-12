let createDisposable f =
    { new System.IDisposable with member x.Dispose() = f() }

let outerFunction() =
    use disposable = createDisposable (fun () -> printfn "Now disposing of myself")
    printfn "In outer function"

outerFunction()

let outerFunction'() =
    using (createDisposable (fun () -> printfn "Now disposing of myself"))
        (fun d -> printfn "Acting on the disposable object now")
    printfn "In outer function '"

outerFunction'()