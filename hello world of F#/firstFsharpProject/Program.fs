// Learn more about F# at http://fsharp.org

open System

let firstHelloWorld (name: string) =
    
    "Hello world, my name is " + string(name)

[<EntryPoint>]
let main argv =
    for name in argv do
        
        printfn "Hello World from F#!"
        let ret = firstHelloWorld name
        printfn "%s" ret
    0 // return an integer exit code
