// now use it step by step 
let x = 42
let y = 99

//note that I cannot change the values, Immutable!
x=1
y= 12

//Start with function that takes two parameters, and subtracts
let subTwoParameters a b = a - b

//Create a new function that takes a function and one parameter
let intermediateFn = subTwoParameters x

//Then just call it with one parameters
let result  = intermediateFn y
//let result = subTwoParameters x y

printfn "result=%i" result

//Things to Note:
//It is doing x - y, not y -x
