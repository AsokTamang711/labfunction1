// // // printfn " Hello world"

// // // let a = 5
// // // // to make something mutable
// // // let mutable b = "asok"
// // // //to store a new value
// // // b <- "khadka"

// // // printfn "%s" (a.ToString())
// // // printfn "%s" b

// // // let add a b = a + b
// // // let result = add 4 5
// // // printfn "%s" (result.ToString())

// // // let multiply = fun a b -> a * b
// // // let result1 = multiply 4 5
// // // printfn "%s" (result1.ToString())

// // // let multiply2 a b = a * b
// // // let result2 = multiply 5 6
// // // printfn "%s" (result2.ToString())

// // // [ 1..100 ] |> List.sum |> printf "sum-%d"
// // l

// //let square x = x*x
// //let cube x = x*x*x
// //let sign x =
//   //  if x>0 then "positive"
//    // else if x<0 then "negative"
//     //else "Zero"
// //let passFive f  = (f -5)
// //printfn "%A" (passFive square)   
// //printfn "%A" (passFive cube)     
// //printfn "%A" (passFive sign)      

// //printfn "%A" res
    
// //let Asok x y = x+y
// //printfn "%A" (curriedAdd 5 10)

// //let toupleAdd (x,y) = x+y
// //printfn "%A" (toupleAdd(10,5))
// //let double = fun x-> x * 2
// //let x = double 5
// //printfn "%A" x
// //open System        
// //let x = fun n -> n*n
// //let square = [2;3;4;5] |> List.map x
// //printfn "%A" square






////      LAB    1            
// //----------------------------- LAB1
// //1)A)
// // open System

// // let applyExponent value exponent = 
// //     Math.Pow(value, exponent)


// // let result = applyExponent 4 3
// // printfn "Result: %f" result  
// //B)
// open System
// let power exponent value = pown value exponent

// let square = power 2
// let cube = power 3

// printfn "Square of 4: %d" (square 4)
// printfn "Cube of 2: %d" (cube 2)
// Tail-recursive function to compute the product of a list




//2a
// open System
// let rec productOfListTailRecursive list accumulator =
//     match list with
//     | [] -> accumulator
//     | head :: tail -> productOfListTailRecursive tail (accumulator * head)


// let productOfList list =
//     productOfListTailRecursive list 1


// let numbers = [1; 2; 3; 4; 5]
// let result = productOfList numbers


// printfn "The product of the list is: %d" result




//3a
// // Tail-recursive function to calculate the product of all odd numbers
// open System
// let rec productOfOddsTailRecursive n accumulator =
//     match n with
//     | 1 -> accumulator   
//     | _ -> productOfOddsTailRecursive (n - 2) (accumulator * n) 

// let productOfOdds n =
//     productOfOddsTailRecursive n 1

// let result = productOfOdds 11


// printfn "The product of all odd numbers from 11 to 1 is: %d" result
// Original list of names with extra spaces

//4a
// open System
// let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]


// let trimmedNames = names |> List.map (fun name -> name.Trim())


// printfn "Trimmed Names:"
// trimmedNames |> List.iter (printfn "%s")


// Create a sequence of the first 700 positive integers
//5
// open System
// let sequence = seq { 1 .. 700 }


// let numbers = sequence |> Seq.toList


// let filteredNumbers = numbers |> List.filter (fun n -> n % 7 = 0 && n % 5 = 0)

// let sumOfFilteredNumbers = filteredNumbers |> List.fold (+) 0


// printfn "The sum of all numbers divisible by both 7 and 5 is: %d" sumOfFilteredNumbers



//6
// List of names
// open System
// let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// let filteredNames = 
//     names 
//     |> List.filter (fun name -> name.ToLower().Contains("i"))


// let concatenatedNames = 
//     filteredNames 
//     |> List.fold (fun acc name -> acc + name) ""

// printfn "Concatenated names: %s" concatenatedNames



