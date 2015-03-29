namespace FSharpWeb2015.ViewModels
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

type ODataBoundLink = { AnchorClass:string; BaseUrl:string; Href:string; Json:string}
