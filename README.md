# F# Giraffe API with tests template

## How to use it

Clone the repo!

## Requirements

[dotNET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Editor capable of working with F#, I personally recommend:
* [Visual Studio Code](https://code.visualstudio.com/) and [Ionide plugin](https://ionide.io/)

Other options:
* [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* [Rider](https://www.jetbrains.com/rider/)

## Stuff inside API

* [Giraffe](https://giraffe.wiki/)

Take a look at similar
* [Saturn template](https://github.com/jasiozet/saturn-api-with-tests-template)
* [Falco template](https://github.com/jasiozet/falco-api-with-tests-template)

## Stuff inside TESTS
* [xUnit](https://xunit.net/)
* [FsUnit](https://fsprojects.github.io/FsUnit/)

## How to run:
* api - ```cd api && dotnet run```
* tests - ```cd tests && dotnet test```

## What if I don't want tests?

Just remove the ```tests``` folder!

## Why make this template?

Comparison with Saturn template I already made
This template is meant a nice fresh start, without much complication

## Routes to test:
* http://localhost:5000/add/2/3 => 5
* http://localhost:5000/mul/2/3 => 6
* http://localhost:5000/json => {"language":"F#","message":"Hello World"}
* http://localhost:5000/anyRoute => htmled I |> F# Hello World
