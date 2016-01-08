module SpeakersFS.ButterworthTests

open System
open SpeakersFS
open Xunit

let check (expected: float) (actual: float) = 
    Assert.Equal(expected, Math.Round(actual, 2))

module FirstOrder = 
    [<Fact>]
    let firstOrderCapacitance_100Hz_8Ohm() = 
        check 198.75 (Butterworth.firstOrderCapacitance 100.0 8.0)

    [<Fact>]
    let firstOrderCapacitance_400Hz_8Ohm() =
        check 49.69 (Butterworth.firstOrderCapacitance 400.0 8.0)

    [<Fact>]
    let firstOrderCapacitance_2000Hz_8Ohm() =
        check 9.94 (Butterworth.firstOrderCapacitance 2000.0 8.0)

    [<Fact>]
    let firstOrderCapacitance_100Hz_4Ohm() = 
        check 397.5 (Butterworth.firstOrderCapacitance 100.0 4.0)

    [<Fact>]
    let firstOrderCapacitance_400Hz_4Ohm() =
        check 99.38 (Butterworth.firstOrderCapacitance 400.0 4.0)

    [<Fact>]
    let firstOrderCapacitance_2000Hz_4Ohm() =
        check 19.88 (Butterworth.firstOrderCapacitance 2000.0 4.0)


    [<Fact>]
    let firstOrderInductance_100Hz_8Ohm() = 
        check 12.74 (Butterworth.firstOrderInductance 100.0 8.0)

    [<Fact>]
    let firstOrderInductance_400Hz_8Ohm() = 
        check 3.18 (Butterworth.firstOrderInductance 400.0 8.0)

    [<Fact>]
    let firstOrderInductance_2000Hz_8Ohm() = 
        check 0.64 (Butterworth.firstOrderInductance 2000.0 8.0)

    [<Fact>]
    let firstOrderInductance_100Hz_4Ohm() = 
        check 6.37 (Butterworth.firstOrderInductance 100.0 4.0)

    [<Fact>]
    let firstOrderInductance_400Hz_4Ohm() = 
        check 1.59 (Butterworth.firstOrderInductance 400.0 4.0)

    [<Fact>]
    let firstOrderInductance_2000Hz_4Ohm() = 
        check 0.32 (Butterworth.firstOrderInductance 2000.0 4.0)

module SecondOrder = 
    [<Fact>]
    let secondOrderCapacitance_100Hz_8Ohm() = 
        check 140.63 (Butterworth.secondOrderCapacitance 100.0 8.0)

    [<Fact>]
    let secondOrderCapacitance_400Hz_8Ohm() =
        check 35.16 (Butterworth.secondOrderCapacitance 400.0 8.0)

    [<Fact>]
    let secondOrderCapacitance_2000Hz_8Ohm() =
        check 7.03 (Butterworth.secondOrderCapacitance 2000.0 8.0)

    [<Fact>]
    let secondOrderCapacitance_100Hz_4Ohm() = 
        check 281.25 (Butterworth.secondOrderCapacitance 100.0 4.0)

    [<Fact>]
    let secondOrderCapacitance_400Hz_4Ohm() =
        check 70.31 (Butterworth.secondOrderCapacitance 400.0 4.0)

    [<Fact>]
    let secondOrderCapacitance_2000Hz_4Ohm() =
        check 14.06 (Butterworth.secondOrderCapacitance 2000.0 4.0)


    [<Fact>]
    let secondOrderInductance_100Hz_8Ohm() = 
        check 18.01 (Butterworth.secondOrderInductance 100.0 8.0)

    [<Fact>]
    let secondOrderInductance_400Hz_8Ohm() = 
        check 4.50 (Butterworth.secondOrderInductance 400.0 8.0)

    [<Fact>]
    let secondOrderInductance_2000Hz_8Ohm() = 
        check 0.90 (Butterworth.secondOrderInductance 2000.0 8.0)

    [<Fact>]
    let secondOrderInductance_100Hz_4Ohm() = 
        check 9.00 (Butterworth.secondOrderInductance 100.0 4.0)

    [<Fact>]
    let secondOrderInductance_400Hz_4Ohm() = 
        check 2.25 (Butterworth.secondOrderInductance 400.0 4.0)

    [<Fact>]
    let secondOrderInductance_2000Hz_4Ohm() = 
        check 0.45 (Butterworth.secondOrderInductance 2000.0 4.0)
    