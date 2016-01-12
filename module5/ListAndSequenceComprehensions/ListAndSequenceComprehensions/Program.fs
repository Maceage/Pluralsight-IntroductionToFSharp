let output x = printfn "%A" x

let ints = [7..13]
output ints

let oddValues = [1..2..20]
output oddValues

let values step max = [1..step..max]
output (values 2 20)

let ints' = seq { 7..13 }
output ints'

output [ for x in 7..13 -> x, x * x ]
output [ for x in 7..13 ->
                            printfn "Return new value now"
                            x, x * x ]

let yieldedValues =
    seq {
        yield 3;
        yield 42;
        for i in 1..3 do
            yield i
        yield! [5; 7; 8]
    }

output (List.ofSeq yieldedValues)

let yieldedStrings =
    seq {
        yield "this"
        yield "that"
    }

output yieldedStrings