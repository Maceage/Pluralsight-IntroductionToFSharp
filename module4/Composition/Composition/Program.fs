let add x y = x + y
let mult x y = x * y
let square x = x * x

let add' = fun x y -> x + y
// (int -> int -> int)
let add'' x = fun y -> x + y
// int -> (int -> int)

let add10'' = add'' 10
printfn "%d" (add10'' 32)

let add10 = add 10
printfn "%d" (add10 32)

let addmultiplevalues a b c d = a + b + c + d

let result = addmultiplevalues 10

let result2 = result 15

let mult5 = mult 5

let calcResult = mult5 (add10 17)
let calcResult' = 17 |> add10 |> mult5

let add10mult5 = add10 >> mult5

let calcResult'' = add10mult5 17