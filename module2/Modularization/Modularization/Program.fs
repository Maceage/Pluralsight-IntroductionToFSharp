module Mace.Demo.Calculator.Program

[<EntryPoint>]
let main args =
    printfn ("add 5 and 3 is %d") (Adder.add 5 3)
    0