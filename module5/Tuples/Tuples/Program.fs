let t1 = 12, 5, 7
let v1, v2, _ = t1

let t2 = "hi", true

printfn "%A" (fst t2)
printfn "%A" (snd t2)

let third t =
    let _, _, r = t
    r

printfn "%A" (third t1)

let third' (_, _, r) = r
printfn "%A" (third' t1)