open System.Collections.Generic

let isInList (list: 'a list) v =
    let lookupTable = new HashSet<'a>(list)
    printfn "Lookup table created, looking up value"
    lookupTable.Contains v

printfn "%b" (isInList ["hi"; "there"; "oliver"] "there")
printfn "%b" (isInList ["hi"; "there"; "oliver"] "anna")

let isInListClever = isInList ["hi"; "there"; "oliver"]
printfn "%b" (isInListClever "there")
printfn "%b" (isInListClever "anna")


let constructLookup (list: 'a list) =
    let lookupTable = new HashSet<'a>(list)
    printfn "Lookup table created"
    fun v ->
        printfn "Performing lookup"
        lookupTable.Contains v

let isInListClever' = constructLookup ["hi"; "there"; "oliver"]
printfn "%b" (isInListClever' "there")
printfn "%b" (isInListClever' "anna")