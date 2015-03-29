namespace FSharpWeb2015.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http
type Dvd = FSharpWeb2015.Dvd

/// Retrieves values.
[<RoutePrefix("api/dvds")>]
type DvdsController() =
    inherit ApiController()
    let dvds = FSharpWeb2015.Repositories.Dvds
    /// Gets all values.
    [<Route("")>]
    member x.Get() = dvds

    /// Gets the value with index id.
    [<Route("{id:int}")>]
    member x.Get(id) : IHttpActionResult =
        if id > dvds.Length - 1 then
            x.BadRequest() :> _
        else x.Ok(dvds.[id]) :> _
    [<HttpPost>]
    member x.Post(value:Dvd) : string = 
        if dvds.Contains(value) then
            "Already exists"
        else
            FSharpWeb2015.Repositories.Dvds <- value :: dvds
            "Added"