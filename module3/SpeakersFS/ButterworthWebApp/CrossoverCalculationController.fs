namespace ButterworthWebApp.Controllers

open System.Web
open System.Web.Mvc

open ButterworthWebApp.Models

[<HandleError>]
type CrossoverCalculationController() =
    inherit Controller()

    [<HttpGet>]
    member x.Index() =
        let calcRequest = 
            CrossoverCalculationRequest(
                CrossoverType = CrossoverType.Butterworth,
                ButterworthOrder = ButterworthOrder.First,
                CrossoverFrequency = 400.0,
                Impedance = 8.0)

        x.View(calcRequest) :> ActionResult

    [<HttpPost>]
    member x.Index(calcRequest: CrossoverCalculationRequest) = 
        if not x.ModelState.IsValid then (x.View(calcRequest) :> ActionResult)
        else
            match calcRequest.CrossoverType with 
            | CrossoverType.Butterworth ->
                x.View("ButterworthResult", ButterworthCalculationResult(calcRequest)) :> ActionResult
            | _ -> x.View(calcRequest) :> ActionResult