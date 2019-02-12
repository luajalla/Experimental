open BenchmarkDotNet.Configs
open BenchmarkDotNet.Running

open VectorsBmk


[<EntryPoint>]
let main argv =
    BenchmarkRunner.Run<MultiplyAddVectorMiniBmk>(DefaultConfig.Instance) |> ignore
    BenchmarkRunner.Run<MultiplyAddMklMiniBmk>(DefaultConfig.Instance) |> ignore
    BenchmarkRunner.Run<MultiplyAddBmk>(DefaultConfig.Instance) |> ignore
    0