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