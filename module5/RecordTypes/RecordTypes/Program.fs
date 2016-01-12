type Rectangle =
    { Width: float; Height: float }

let rect1 = { Width = 5.3; Height = 3.4 }

type Circle = 
    { mutable Radius: float }

    member x.RadiusSquare with get() = x.Radius * x.Radius
    member x.CalcArea() = System.Math.PI * x.RadiusSquare

let c1 = { Radius = 3.3 }

c1.Radius <- 5.4

type Ellipse =
    { RadiusX: float; RadiusY: float }
    member x.GrowX dx = { x with RadiusX = x.RadiusX + dx }
    member x.GrowY dy = { x with RadiusY = x.RadiusY + dy }

let zeroCircle = function
    | { Radius = 0.0 } -> true
    | _ -> false

printfn "%A" (zeroCircle c1)

let isSquare = function
    | { Width = width; Height = height; } -> width = height
    | _ -> false