let o1 = Some(5)
let o2 = None

if o1 = o2 then
    printfn "Values are equal"

printfn "o1 IsSome: %b" o1.IsSome
printfn "o2 IsNone: %b" o2.IsNone

let checkOption o =
    match o with
    | Some(x) -> printfn "Options contains value %A" x
    | None -> printfn "Option doesn't have a value"

checkOption o1
checkOption o2