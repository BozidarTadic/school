namespace Scholl.Controllers

open System
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSharp
open School.Models
open School.BL

[<ApiController>]
[<Route("[controller]")>]
type SchollColntroller (logger : ILogger<SchollColntroller>) =
    inherit ControllerBase ()

    [<HttpPost>]
    member x.Post ([<FromBody>]_value : StudentDto) =
    ()

   
