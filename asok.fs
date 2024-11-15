// #let square x = x*x
// #let cube x = x*x*x
// #let sign x=
//    #        if x>0 then"positive"
//     #       else if x<0 then "negative"
//            else"Zero"

// let passFive f=(f-5)
// printfn "%A" (passFive square)
// printfn "%A" (passFive cube)
// printfn "%A" (passFive sign)   
open System        
let x = fun n -> n*n
let square = [2;3;4;5] |> List.map x
printfn "%A" square 