namespace demo
// When running in debug mode and using Visual Studio to run the program,  
// one may miss the results as the program runs to the end and exists.  
// Since running normally, i.e. Visual Studio Ctrl-F5, will add an pause
// automatically the pause is only shown when in debug mode.  
module pause = 

    let pause () =  
      match System.Diagnostics.Debugger.IsAttached with  
      | true ->  
          printfn "\nPress any key to continue."  
          System.Console.ReadKey(true) |> ignore  
      | false -> ()  


