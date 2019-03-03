// Learn more about F# at http://fsharp.org

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open System.IO

[<EntryPoint>]
let main _ =
    let contentRoot = Directory.GetCurrentDirectory()
    WebHostBuilder()
        .UseKestrel()
        .UseWebRoot(contentRoot)
        .Configure(fun app ->
            app.UseStaticFiles() |> ignore)
        .Build()
        .Run()
    0
