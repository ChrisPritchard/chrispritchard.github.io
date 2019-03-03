
open System.IO
open FSharp.Markdown

let convertFile path =
    let content = File.ReadAllText path
    let parsed = Markdown.Parse content
    let html = Markdown.WriteHtml parsed
    let fileName = Path.GetFileNameWithoutExtension path
    File.WriteAllText (fileName + ".html", html)

[<EntryPoint>]
let main argv =
    let dir = if argv.Length > 0 then argv.[0] else "."
    Directory.GetFiles (dir, "*.md")
    |> Seq.iter convertFile
    0
