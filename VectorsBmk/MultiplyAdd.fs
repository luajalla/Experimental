namespace VectorsBmk

open System
open System.Numerics
open System.Runtime.InteropServices
open BenchmarkDotNet.Attributes


/// Functions to perform multiply-add operations in two forms:
/// - Out of place: zs <- a * xs + ys    (functions have suffix Out)
/// - In place:     ys <- a * xs + ys    (functions have suffix In)
module MultiplyAdd =
    /// Length of the largest  aligned double[] of length <= n.  
    let inline lengthAlignedLeq n = (n / Vector<double>.Count) * Vector<double>.Count
    /// Length of the smallest aligned double[] of length >= n.
    let inline lengthAlignedGeq n = lengthAlignedLeq (n + Vector<double>.Count - 1)
    
    /// In place
    let forIn (a : double) (xs : double[]) (ys : double[]) =
        for i = 0 to ys.Length - 1 do
            ys.[i] <- a * xs.[i] + ys.[i]
        ys


    /// Out of place
    let forOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        for i = 0 to zs.Length - 1 do
            zs.[i] <- a * xs.[i] + ys.[i]
        zs

    
    /// Out of place, arrays are not aligned, vector multiplier and inputs are not spans.    
    let vectorNotAlignedOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        let nAligned = lengthAlignedLeq xs.Length
        let zsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(xs, 0, nAligned))
        let aVector  = Vector(a)
        let v        = Vector<double>.Count
        
        for i = 0 to zsVector.Length - 1 do
            zsVector.[i] <- aVector * Vector(xs, i * v) + Vector(ys, i * v)
        
        for i = nAligned to zs.Length - 1 do
            zs.[i] <- a * xs.[i] + ys.[i]
        zs


    /// Out of place, arrays are aligned, scalar multiplier and inputs are not spans.
    let vectorScalarOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        let zsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(xs))
        let v        = Vector<double>.Count
        
        for i = 0 to zsVector.Length - 1 do
            zsVector.[i] <- a * Vector(xs, i * v) + Vector(ys, i * v)
        zs


    /// In place, arrays are aligned, vector multiplier and inputs are not spans.
    let vectorIn (a : double) (xs : double[]) (ys : double[]) =
        let ysVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(ys))
        let aVector  = Vector(a)
        let v        = Vector<double>.Count
            
        for i = 0 to ysVector.Length - 1 do
            ysVector.[i] <- aVector * Vector(xs, i * v) + ysVector.[i]
        ys

    
    /// Out of place, arrays are aligned, vector multiplier and inputs are not spans.
    let vectorOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        let zsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(xs))
        let aVector  = Vector(a)
        let v        = Vector<double>.Count
            
        for i = 0 to zsVector.Length - 1 do
            zsVector.[i] <- aVector * Vector(xs, i * v) + Vector(ys, i * v)
        zs

    
    /// In place, arrays are aligned, vector multiplier and inputs are spans.
    let vectorSpansIn (a : double) (xs : double[]) (ys : double[]) =
        let xsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(xs))
        let ysVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(ys))
        let aVector  = Vector(a)
            
        for i = 0 to ysVector.Length - 1 do
            ysVector.[i] <- aVector * xsVector.[i] + ysVector.[i]
        ys


    /// Out of place, arrays are aligned, vector multiplier and inputs are spans.
    let vectorSpansOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        let xsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(xs))
        let ysVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(ys))
        let zsVector = MemoryMarshal.Cast<double, Vector<double>>(Span<double>(zs))
        let aVector  = Vector(a)
            
        for i = 0 to zsVector.Length - 1 do
            zsVector.[i] <- aVector * xsVector.[i] + ysVector.[i]
        zs


    /// In place, CBLAS daxpy 
    let mklAxpyIn (a : double) (xs : double[]) (ys : double[]) =
        MKL.cblas_daxpy (xs.Length, a, xs, 1, ys, 1)
        ys

    
    /// In place, CBLAS daxpby
    let mklAxpbyIn (a : double) (xs : double[]) (ys : double[]) =
        MKL.cblas_daxpby(xs.Length, a, xs, 1, 1.0, ys, 1)
        ys
        
    
    /// Out of place, CBLAS dcopy + daxpy 
    let mklAxpyOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        MKL.cblas_dcopy (xs.Length, ys, 1, zs, 1)
        MKL.cblas_daxpy (xs.Length, a, xs, 1, zs, 1)
        ys

    
    /// Out of place, mkl_domatcopy with "matrix" dimensions 1 x n
    let mklMataddRowOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        MKL.MKL_Domatadd ('R', 'N', 'N', 1, xs.Length, a, xs, xs.Length, 1.0, ys, ys.Length, zs, zs.Length)
        zs


    /// Out of place, mkl_domatcopy with "matrix" dimensions n x 1
    let mklMataddColOut (a : double) (xs : double[]) (ys : double[]) (zs : double[]) =
        MKL.MKL_Domatadd ('R', 'N', 'N', xs.Length, 1, a, xs, 1, 1.0, ys, 1, zs, 1)
        zs
        

    /// Out of place, Vector function vdAdd
    let mklVdAddOut (xs : double[]) (ys : double[]) (zs : double[]) =
        MKL.vdAdd(xs.Length, xs, ys, zs)
        zs


[<RequireQualifiedAccess>]
module TestInputs =
    let notAligned n =
        let rng = Random 42
        let xs  = Array.init n (fun _ -> rng.NextDouble())
        let ys  = Array.init n (fun _ -> rng.NextDouble())
        let zs  = Array.zeroCreate<double> n
        xs, ys, zs
    
    
    let alignedFrom (xs : double[]) =
        let n         = MultiplyAdd.lengthAlignedGeq xs.Length 
        let xsAligned = Array.zeroCreate n
        Array.Copy(xs, xsAligned, xs.Length)
        xsAligned


[<AllStatisticsColumn>]
[<DisassemblyDiagnoser; MemoryDiagnoser>]
[<ClrJob; CoreJob(baseline = true)>]
type MultiplyAddVectorMiniBmk() =
    let mutable xsNotAligned = Unchecked.defaultof<_>
    let mutable ysNotAligned = Unchecked.defaultof<_>
    let mutable zsNotAligned = Unchecked.defaultof<_>
    let mutable xs           = Unchecked.defaultof<_>
    let mutable ys           = Unchecked.defaultof<_>
    let mutable zs           = Unchecked.defaultof<_>

    [<Params(4, 100, 103, 1003, 100003)>]
    member val N = 0 with get, set
   
    [<Params(1.5)>]
    member val K = 0.0 with get, set
    
    [<GlobalSetup>] 
    member this.Setup() =
        let x, y, z = TestInputs.notAligned this.N
        xsNotAligned <- x
        ysNotAligned <- y
        zsNotAligned <- z
        xs           <- TestInputs.alignedFrom x
        ys           <- TestInputs.alignedFrom y
        zs           <- TestInputs.alignedFrom z

    
    [<Benchmark(Baseline = true)>]
    member this.NotAlignedOut() =
        MultiplyAdd.vectorNotAlignedOut this.K xsNotAligned ysNotAligned zsNotAligned

    [<Benchmark>]
    member this.AlignedOut() =
        MultiplyAdd.vectorOut this.K xs ys zs 
    
    [<Benchmark>]
    member this.SpansOut() =
        MultiplyAdd.vectorSpansOut this.K xs ys zs

    [<Benchmark>]
    member this.ScalarOut() =
        MultiplyAdd.vectorScalarOut this.K xs ys zs

    [<Benchmark>]
    member this.AlignedIn() =
        MultiplyAdd.vectorIn this.K xs ys
        

[<AllStatisticsColumn>]
[<DisassemblyDiagnoser; MemoryDiagnoser>]
[<ClrJob; CoreJob(baseline = true)>]
type AddMklMiniBmk() =
    let mutable xs = Unchecked.defaultof<_>
    let mutable ys = Unchecked.defaultof<_>
    let mutable zs = Unchecked.defaultof<_>

    [<Params(4, 100, 103, 1003, 100003)>]
    member val N = 0 with get, set
    
    [<GlobalSetup>] 
    member this.Setup() =
        let x, y, z = TestInputs.notAligned this.N
        xs <- TestInputs.alignedFrom x
        ys <- TestInputs.alignedFrom y
        zs <- TestInputs.alignedFrom z

    [<Benchmark(Baseline = true)>]
    member this.Axpy() =
        MultiplyAdd.mklAxpyOut 1.0 xs ys zs 
    
    [<Benchmark>]
    member this.VdAdd() =
        MultiplyAdd.mklVdAddOut xs ys zs


    
[<AllStatisticsColumn>]
[<DisassemblyDiagnoser; MemoryDiagnoser>]
[<ClrJob; CoreJob(baseline = true)>]
type MultiplyAddMklMiniBmk() =
    let mutable xs = Unchecked.defaultof<_>
    let mutable ys = Unchecked.defaultof<_>
    let mutable zs = Unchecked.defaultof<_>

    [<Params(4, 100, 103, 1003, 100003)>]
    member val N = 0 with get, set
   
    [<Params(1.5)>]
    member val K = 0.0 with get, set
    
    [<GlobalSetup>] 
    member this.Setup() =
        let x, y, z = TestInputs.notAligned this.N
        xs <- TestInputs.alignedFrom x
        ys <- TestInputs.alignedFrom y
        zs <- TestInputs.alignedFrom z

    [<Benchmark(Baseline = true)>]
    member this.AxpyIn() =
        MultiplyAdd.mklAxpyIn this.K xs ys 
    
    [<Benchmark>]
    member this.AxpbyIn() =
        MultiplyAdd.mklAxpbyIn this.K xs ys
        
    [<Benchmark>]
    member this.AxpyOut() =
        MultiplyAdd.mklAxpyOut this.K xs ys zs
    
    [<Benchmark>]    
    member this.MataddRowOut() =
        MultiplyAdd.mklMataddRowOut this.K xs ys zs
    
    [<Benchmark>]    
    member this.MataddColOut() =
        MultiplyAdd.mklMataddColOut this.K xs ys zs
        
    
[<AllStatisticsColumn>]
[<DisassemblyDiagnoser; MemoryDiagnoser>]
[<ClrJob; CoreJob(baseline = true)>]
type MultiplyAddBmk() =
    let mutable xs = Unchecked.defaultof<_>
    let mutable ys = Unchecked.defaultof<_>
    let mutable zs = Unchecked.defaultof<_>

    [<Params(4, 100, 103, 1003, 100003)>]
    member val N = 0 with get, set
   
    [<Params(1.5)>]
    member val K = 0.0 with get, set
    
    [<GlobalSetup>] 
    member this.Setup() =
        let x, y, z = TestInputs.notAligned this.N
        xs <- TestInputs.alignedFrom x
        ys <- TestInputs.alignedFrom y
        zs <- TestInputs.alignedFrom z

    [<Benchmark(Baseline = true)>]
    member this.For() =
        MultiplyAdd.forIn this.K xs ys

    [<Benchmark>]    
    member this.Vector() =
        MultiplyAdd.vectorIn this.K xs ys

    [<Benchmark>]    
    member this.VectorSpans() =
        MultiplyAdd.vectorSpansIn this.K xs ys
    
    [<Benchmark>]
    member this.Axpy() =
        MultiplyAdd.mklAxpyIn this.K xs ys