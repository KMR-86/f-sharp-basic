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

    let rec fibo x=
        //printfn "%i" x
        if x < 3 then 1
        else fibo (x-1) + fibo (x-2)
    

module eular_problem_2=
    let ar = Array.create 100 0
    let rec fibo x=
        if ar.[x]<>0 then ar.[x]
        else
            if x < 3 then 
                ar.[x]<-1
                ar.[x]
            else 
                ar.[x]<-fibo (x-1) + fibo (x-2)
                ar.[x]
    
    let fibo_sum x =
        let fibo_seq=(fibo x)
        let mutable sum = 0
        for el in ar do
            if el < 4000000 && el%2=0 then sum<-sum+el
            else sum<-sum+0
        
        sum

    let fibo_sum_iter lim =
         let fib_ar = Array.create 100 0
         fib_ar.[0]<-1
         fib_ar.[1]<-1
         let mutable fibsum = 0
         for i in 2..40 do
            fib_ar.[i] <- fib_ar.[i-1] + fib_ar.[i-2]
            if fib_ar.[i] < lim && fib_ar.[i] % 2=0 then fibsum <- fibsum + fib_ar.[i]
            
         fibsum


[<EntryPoint>]
let main argv =

    printfn "%d" (eular_problem_2.fibo_sum 45)
    printfn "%d" (eular_problem_2.fibo_sum_iter 4000000)
    

    
    
    0 // return an integer exit code
