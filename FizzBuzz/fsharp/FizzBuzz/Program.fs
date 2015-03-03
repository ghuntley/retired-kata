// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let numbers = [1..100]

// option #2
// numbers |> printThree |> printFive |> printThreeFive

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code



