namespace Library1

open System
open WebSharper
open WebSharper.JavaScript

[<JavaScript>]
type FieldType =
    | TypeA
    | TypeB
    with member self.Test() = true