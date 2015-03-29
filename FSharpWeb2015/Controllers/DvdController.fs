namespace FSharpWeb2015.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

type DvdController() =
    inherit Controller()
    member this.Index () = this.View()
    member this.Add () = this.View()
    [<HttpPost>]
    member this.Add (value:string) = 
        FSharpWeb2015.Repositories.Values <- value :: FSharpWeb2015.Repositories.Values
