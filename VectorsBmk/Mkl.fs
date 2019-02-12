[<RequireQualifiedAccess>]
module VectorsBmk.MKL

open System.Runtime.InteropServices

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void cblas_daxpy (int n, double a, [<In>] double[] x, int incx, [<In; Out>] double[] y, int incy)

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void cblas_dcopy (int n, [<In>] double[] x, int incx, [<Out>] double[] y, int incy)

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void cblas_dscal (int n, double a, double[] x, int incx);

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void cblas_daxpby (int n, double a, [<In>] double[] x, int incx, double b, [<In; Out>] double[] y, int incy)

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void MKL_Dimatcopy (char ordering, char trans, int rows, int cols, double alpha,
                           [<In; Out>] double[] AB, int lda, int ldb);

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void MKL_Domatcopy (char ordering, char trans, int rows, int cols, double alpha,
                           [<In>] double[] A, int lda, [<Out>] double[] B, int ldb);

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void MKL_Domatcopy2 (char ordering, char trans, int rows, int cols, double alpha,
                            [<In>] double[] A, int lda, int stridea, [<Out>] double[] B, int ldb, int strideb);

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void MKL_Domatadd (char ordering, char transa, char transb, int m, int n, double alpha,
                          [<In>] double[] A, int lda, double beta, [<In>] double[] B, int ldb,
                          [<Out>] double[] C, int ldc);

[<DllImport("Experimental.Mkl.dll", CallingConvention=CallingConvention.Cdecl)>]
extern void vdAdd(int n, double[] a, double[] b, double[] y);