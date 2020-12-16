// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

module problems =
    let ar = Array.create 100 0
    let rec fibo_naive x=
        if x < 3 then 
            1
        else 
            fibo_naive (x-1) + fibo_naive (x-2)
            
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

    let fib_sum_iter lim =
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
    
    printfn "%d" (problems.fibo 45)
    printfn "%d" (problems.fibo_sum 45)
    printfn "%d" (problems.fib_sum_iter 4000000)
    ///printfn "%d" (problems.fibo_naive 45)


    0 // return an integer exit code