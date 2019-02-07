// Learn more about F# at http://fsharp.org
open EFCore.Model
open CompostionRoot
open System
open System.Linq

[<EntryPoint>]
let main argv =
    let newUser = {id=3; username = "CMDUser"; email = "user@fSharp.com"; password = "test"; createdate = DateTime.Now}

    printfn "attempting to add user"
    addUserAccount newUser
    printfn "Hello World from F#!"
    

    0 // return an integer exit code
