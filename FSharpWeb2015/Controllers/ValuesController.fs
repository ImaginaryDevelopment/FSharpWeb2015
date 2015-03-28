namespace FSharpWeb2015.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

/// Retrieves values.
[<RoutePrefix("api/values")>]
type ValuesController() =
    inherit ApiController()
    let mutable values = ["value1";"value2"]

    /// Gets all values.
    [<Route("")>]
    member x.Get() = values

    /// Gets the value with index id.
    [<Route("{id:int}")>]
    member x.Get(id) : IHttpActionResult =
        if id > values.Length - 1 then
            x.BadRequest() :> _
        else x.Ok(values.[id]) :> _
    [<HttpPost>]
    member x.Post(value:string) : string = 
        if values.Contains(value) then
            "Already exists"
        else
            FSharpWeb2015.Repositories.Values <- value :: FSharpWeb2015.Repositories.Values
            "Added"