module FSharpWeb2015.Repositories
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

let mutable Dvds: Dvd list = [ 
    {Dvd.Name="How to Train Your Dragon"; ReleaseDate= None }
    {Dvd.Name="How to Train Your Dragon 2"; ReleaseDate= None }
    ]
let mutable Values = ["hello";"hello2"]