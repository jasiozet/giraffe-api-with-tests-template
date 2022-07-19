open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Logic
open Giraffe.ViewEngine

let indexView =
  html [] [
    head [] [ title [] [ str "Giraffe Sample" ] ]
    body [] [
      h1 [] [ str "I |> F#" ]
      p [ _class "some-css-class"; _id "someId" ] [ str "Hello World" ]
    ]
  ]

let defaultPage = htmlView indexView
let getHttpFromOperation operation (a,b) =
  ExecuteBasicOperation operation a b |> text

let webApp =
  choose [
    routef "/mul/%i/%i" (getHttpFromOperation Multiplication)
    routef "/add/%i/%i" (getHttpFromOperation Addition)
    route "/json"   >=> json {| Message="Hello World"; Language="F#" |}
    route "/"       >=> defaultPage
  ]

let configureApp (app : IApplicationBuilder) =
    // Add Giraffe to the ASP.NET Core pipeline
    app.UseGiraffe webApp

let configureServices (services : IServiceCollection) =
    // Add Giraffe dependencies
    services.AddGiraffe() |> ignore

[<EntryPoint>]
let main _ =
    Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                    |> ignore)
        .Build()
        .Run()
    0

//Tests:
//http://localhost:5000/add/2/3 => 5
//http://localhost:5000/mul/2/3 => 6
//http://localhost:5000/json => {"language":"F#","message":"Hello World"}
//http://localhost:5000/anyRoute => htmled I |> F# Hello World