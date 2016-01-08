type CarType =
    | Tricar = 0
    | StandardFourWheeler = 1
    | HeavyLoadCarrier = 2
    | ReallyLargeTruck = 3
    | CrazyHugeMythicalMonster = 4
    | WeirdContraption = 5

type Car(color: string, wheelCount: int) = 
    do
        if wheelCount < 3 then
            failwith "We assume that cars must have at least three wheels"
        if wheelCount > 99 then
            failwith "That's crazy!"

    let carType =
        match wheelCount with
        | 3 -> CarType.Tricar
        | 4 -> CarType.StandardFourWheeler
        | 6 -> CarType.HeavyLoadCarrier
        | x when x % 2 = 1 -> CarType.WeirdContraption
        | _ -> CarType.CrazyHugeMythicalMonster

    let mutable passengerCount = 0

    new() = Car("red", 4)

    member x.Move() = printfn "The %s car (%A) is moving" color carType
    member x.CarType = carType

    member x.PassengerCount with get() = passengerCount and set v = passengerCount <- v

let car = Car()
car.Move()

let greenCar = Car("green", 3)
greenCar.Move()

printfn "Green car has type %A" greenCar.CarType

printfn "Car has %d passengers on board" car.PassengerCount

car.PassengerCount <- 2
printfn "Car has %d passengers on board" car.PassengerCount