exception MyCustomException of int * string
    with
        override x.Message =
            let (MyCustomException(i , s)) = upcast x
            sprintf "Int: %d Str %s" i s

//raise (MyCustomException(10, "Error!"))

//failwith "Some error has occurred"

let rec fact x =
    if x < 0 then invalidArg "X" "Value must be >= 0"
    match x with
    | 0 -> 1
    | _ -> x * (fact (x - 1))

let output (o: obj) =
    try
        let os = o :?> string
        printfn "Object is %s" os
    with
    | :? System.InvalidCastException as ex -> printfn "Can't cast, message was: %s" ex.Message

output 35

let result =
    try
        Some(10 / 0)
    with
    | :? System.DivideByZeroException -> None

printfn "%A" result

try
    raise (MyCustomException(3, "text"))
with
| MyCustomException(i, s) -> printfn "Caught custom exception with %d, %s" i s

let getValue() =
    try
        printfn "Returning Value"
        42
    finally
        printfn "In the finally block now"