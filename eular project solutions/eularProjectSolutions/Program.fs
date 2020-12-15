// Learn more about F# at http://fsharp.org

open System
module eular_project=
    let prob1_basic x=
        let numbers=[1..x-1]
        let mutable sum=0
        for i in numbers do
            if i%3 = 0 || i%5 = 0 then
                sum <- sum+i

        
        printfn "eular problem 1 the sum is %i" sum
    
     
    let prob1_imp1 x=
        let numbers=[ for a in 1 .. x-1 do if a % 3 = 0 || a % 5 = 0 then yield a]
        let sum = List.fold(+) 0 numbers
        
        printfn "eular problem 1 the sum is %i" sum

    let is_divisible x = x % 3 = 0 || x % 5 = 0

    let prob1_imp2 x=
        let numbers=List.filter is_divisible [1..x-1]
        let sum = List.fold(+) 0 numbers
        
        printfn "eular problem 1 the sum is %i" sum

    let prob1_imp3 x=
        let numbers=List.filter is_divisible [1..x-1]
        let sum = List.sum numbers
        printfn "eular problem 1 the sum is %i" sum
    

    let get_sum x=
        [1..x-1]
        |> List.filter is_divisible 
        |> List.sum

    let prob1_imp4 x=
        let sum = get_sum x
        printfn "eular problem 1 the sum is %i" sum
    //prob1 1000
[<EntryPoint>]
let main argv =

    eular_project.prob1_basic 1000
    eular_project.prob1_imp1 1000
    eular_project.prob1_imp2 1000
    eular_project.prob1_imp3 1000
    eular_project.prob1_imp4 1000
    
    0 // return an integer exit code
