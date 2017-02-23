namespace MetaCrash

open System
open WebSharper
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.Sitelets
open Library1
open Library2
    
[<JavaScript>]
module Client =
    open WebSharper.UI.Next.Client

    let page (meta: Meta) =
        text "Hello world"

module Site =
    open WebSharper.UI.Next.Server
    
    type MainPage = Templating.Template<"Main.html">

    [<Website>]
    let Main =
        let meta = 
            {
                Field = FieldType.TypeA
            }

        Application.SinglePage (fun ctx -> Content.Page(MainPage.Doc("Test", [ client <@ Client.page meta @> ])))


module SelfHostedServer =

    open global.Owin
    open Microsoft.Owin.Hosting
    open Microsoft.Owin.StaticFiles
    open Microsoft.Owin.FileSystems
    open WebSharper.Owin

    [<EntryPoint>]
    let Main args =
        let rootDirectory, url =
            "..", "http://localhost:9001/"
        use server = WebApp.Start(url, fun appB ->
            appB.UseStaticFiles(
                    StaticFileOptions(
                        FileSystem = PhysicalFileSystem(rootDirectory)))
                .UseSitelet(rootDirectory, Site.Main)
            |> ignore)
        stdout.WriteLine("Serving {0}", url)
        stdin.ReadLine() |> ignore
        0
