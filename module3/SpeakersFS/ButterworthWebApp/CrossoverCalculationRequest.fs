namespace ButterworthWebApp.Models

open System.ComponentModel
open System.ComponentModel.DataAnnotations

open SpeakersFS

type CrossoverType = 
    | Unknown = 0
    | Butterworth = 1

type ButterworthOrder = 
    | Unknown = 0
    | First = 1
    | Second = 2

type CrossoverCalculationRequest() = 
    let mutable crossoverType = CrossoverType.Unknown
    let mutable butterworthOrder = ButterworthOrder.Unknown
    let mutable crossoverFrequency = 0.0
    let mutable impedance = 0.0

    [<Required>]
    [<EnumInvalidValue(CrossoverType.Unknown)>]
    [<EnumDataType(typeof<CrossoverType>)>]
    [<DisplayName("Crossover type")>]
    member x.CrossoverType with get() = crossoverType and set v = crossoverType <- v

    [<Required>]
    [<EnumInvalidValue(ButterworthOrder.Unknown)>]
    [<EnumDataType(typeof<ButterworthOrder>)>]
    [<DisplayName("Butterworth 'order'")>]
    member x.ButterworthOrder with get() = butterworthOrder and set v = butterworthOrder <- v

    [<Required>]
    [<DisplayName("Crossover frequency")>]
    member x.CrossoverFrequency with get() = crossoverFrequency and set v = crossoverFrequency <- v

    [<Required>]
    [<DisplayName("Impedance")>]
    member x.Impedance with get() = impedance and set v = impedance <- v

