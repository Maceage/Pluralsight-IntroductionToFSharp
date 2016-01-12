open System
open System.Threading

let rec fact x =
    if x = 1 then 1
    else x * (fact (x - 1))

printfn "%d" (fact 5)

let rec fnA() = fnB()
and fnB() = fnA()

let showValues() =
    let r = Random()
    let rec dl() =
        printfn "%d" (r.Next())
        Thread.Sleep(1000)
        dl()

    dl() // Will result in a stack overflow due to method calls

//    while true do
//        printfn "%d" (r.Next())
//        Thread.Sleep(1000)

showValues()