let empty = []

let intList = [12; 1; 15; 27]
printfn "%A" intList

let addItem xs x = x :: xs

let newIntList = addItem intList 42

printfn "%A" newIntList

printfn "%A" (["hi"; "there"] @ ["how"; "are"; "you"])

printfn "%A" newIntList.Head
printfn "%A" newIntList.Tail
printfn "%A" newIntList.Tail.Tail.Head

for i in newIntList do
    printfn "%A" i

let rec listLength (l: 'a list) =
    if l.IsEmpty then 0
        else 1 + (listLength l.Tail)

printfn "%d" (listLength newIntList)

let rec listLength' l =
    match l with
    | [] -> 0
    | x :: xs -> 1 + (listLength' xs)

printfn "%d" (listLength' newIntList)

let rec listLength'' = function
    | [] -> 0
    | x :: xs -> 1 + (listLength' xs)

let rec takeFromList n l =
    match n, l with
    | 0, _ -> []
    | _, [] -> []
    | _, (x :: xs) -> x :: (takeFromList (n - 1) xs)

printfn "%A" (takeFromList 2 newIntList)