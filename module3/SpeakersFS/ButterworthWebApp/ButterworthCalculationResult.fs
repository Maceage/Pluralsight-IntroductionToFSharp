namespace ButterworthWebApp.Models

open SpeakersFS

type ButterworthCalculationResult(request: CrossoverCalculationRequest) = 
    do if request.CrossoverType <> CrossoverType.Butterworth then failwith "Invalid crossover type"

    let capacitance =
        match request.ButterworthOrder with
        | ButterworthOrder.First -> Butterworth.firstOrderCapacitance request.CrossoverFrequency request.Impedance
        | ButterworthOrder.Second -> Butterworth.secondOrderCapacitance request.CrossoverFrequency request.Impedance
        | _ -> failwith "Unknown Butterworth order"

    let inductance =
        match request.ButterworthOrder with
        | ButterworthOrder.First -> Butterworth.firstOrderInductance request.CrossoverFrequency request.Impedance
        | ButterworthOrder.Second -> Butterworth.secondOrderInductance request.CrossoverFrequency request.Impedance
        | _ -> failwith "Unknown Butterworth order"

    member x.Capacitance = capacitance
    member x.Inductance = inductance
    
    member x.CrossoverType = request.CrossoverType
    member x.ButterworthOrder = request.ButterworthOrder
    member x.CrossoverFrequency = request.CrossoverFrequency
    member x.Impedance = request.Impedance