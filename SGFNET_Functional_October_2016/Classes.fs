//Namespace, pretty simple
namespace demo

//references, not that it comes AFTER the namespace
open FSharp.Data

//Type, not that it comes BEFORE the modules that may use that type
//This sets up a statically typed access to everything of the same type
type podcastData = XmlProvider<"http://107.170.56.222/podcast/rss.xml">

//Module, you don't have to indent, but you will get a message if you don't
module classes = 
    let xml = podcastData.Load("http://107.170.56.222/podcast/rss.xml")
    //let xml = podcastData.Load("http://thehistoryofbyzantium.libsyn.com/rss")

    printfn "Author:%s" xml.Channel.Author

    for item in xml.Channel.Items do        
        printfn "Title:%s" item.Title
    
    demo.pause.pause()