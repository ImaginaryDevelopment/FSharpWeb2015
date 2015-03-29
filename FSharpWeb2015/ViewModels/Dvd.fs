namespace FSharpWeb2015
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

type Dvd = {Name:string; ReleaseDate: DateTime option;}