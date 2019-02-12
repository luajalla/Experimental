## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`1f56a6b0]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569370h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbp+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,ebp
       vmovsd  xmm1,qword ptr [rsp+60h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 69
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F549378h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbx+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`1f54ab18]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`1f57a6f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**Method got most probably inlined**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`008a42b8]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008A3380h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      00007ff9`008a429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     r14d,dword ptr [rsi+8]
       mov     ecx,r14d
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,r14d
       vmovsd  xmm1,qword ptr [rbp+10h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 71
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008C3388h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       repe    cmps byte ptr [rsi],byte ptr [rdi]
       add     cl,bh
       jg      00007ff9`008c429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`008c4318]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`008b42f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**No ILOffsetMap found**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`1f53a6b0]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F549370h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbx+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,ebp
       vmovsd  xmm1,qword ptr [rsp+60h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 69
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F549378h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbx+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`1f54ab18]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`1f57a6f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**Method got most probably inlined**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`008c42b8]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008B3380h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs dword ptr [rdi],dword ptr [rsi]
       add     cl,bh
       jg      00007ff9`008b429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     r14d,dword ptr [rsi+8]
       mov     ecx,r14d
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,r14d
       vmovsd  xmm1,qword ptr [rbp+10h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 71
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008A3388h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      00007ff9`008a429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`008a4318]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`008a42f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**No ILOffsetMap found**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`1f56a6b0]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F549370h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbx+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,ebp
       vmovsd  xmm1,qword ptr [rsp+60h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 69
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F579378h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rsi+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`1f57ab18]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`1f57a6f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**Method got most probably inlined**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`008842b8]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF900893380h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     mov dword ptr [56415500007FF900h],eax
; Total bytes of code 67
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     r14d,dword ptr [rsi+8]
       mov     ecx,r14d
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,r14d
       vmovsd  xmm1,qword ptr [rbp+10h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 71
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008B3388h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs dword ptr [rdi],dword ptr [rsi]
       add     cl,bh
       jg      00007ff9`008b429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`008b4318]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`008b42f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**No ILOffsetMap found**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`1f57a6b0]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F539370h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rdx+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,ebp
       vmovsd  xmm1,qword ptr [rsp+60h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 69
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569378h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rbp+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`1f56ab18]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`1f54a6f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**Method got most probably inlined**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`008842b8]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008B3380h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs dword ptr [rdi],dword ptr [rsi]
       add     cl,bh
       jg      00007ff9`008b429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     r14d,dword ptr [rsi+8]
       mov     ecx,r14d
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,r14d
       vmovsd  xmm1,qword ptr [rbp+10h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 71
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008A3388h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      00007ff9`008a429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`008a4318]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`008b42f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**No ILOffsetMap found**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`1f56a6b0]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**Method got most probably inlined**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F579370h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rsi+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,ebp
       vmovsd  xmm1,qword ptr [rsp+60h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 69
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F579378h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rdx],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rcx-46h],cl
       nop
       adc     ebp,dword ptr [rsi+1Fh]
       stc
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`1f57ab18]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`1f54a6f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**Method got most probably inlined**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       mov     qword ptr [rsp+20h],rsi
       mov     dword ptr [rsp+28h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 45
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpbyIn()
       vmovsd  xmm1,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+8]
       mov     rsi,qword ptr [rcx+10h]
       vmovsd  xmm0,qword ptr [00007ff9`008842b8]
       vmovsd  qword ptr [rsp+20h],xmm0
       mov     qword ptr [rsp+28h],rsi
       mov     dword ptr [rsp+30h],1
       mov     ecx,dword ptr [r8+8]
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 61
```
**No ILOffsetMap found**
VectorsBmk.MKL.cblas_daxpby(Int32, Double, Double[], Int32, Double, Double[], Int32)

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.AxpyOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008B3380h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs dword ptr [rdi],dword ptr [rsi]
       add     cl,bh
       jg      00007ff9`008b429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklAxpyOut(Double, Double[], Double[], Double[])
       mov     dword ptr [rsp+20h],1
       mov     r14d,dword ptr [rsi+8]
       mov     ecx,r14d
       mov     rdx,rbx
       mov     r9,rdi
       mov     r8d,1
       call    VectorsBmk.MKL.cblas_dcopy(Int32, Double[], Int32, Double[], Int32)
       mov     qword ptr [rsp+20h],rdi
       mov     dword ptr [rsp+28h],1
       mov     ecx,r14d
       vmovsd  xmm1,qword ptr [rbp+10h]
       mov     r8,rsi
       mov     r9d,1
       call    VectorsBmk.MKL.cblas_daxpy(Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rbx
; Total bytes of code 71
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddRowOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF9008B3388h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ch
       rep     movs dword ptr [rdi],dword ptr [rsi]
       add     cl,bh
       jg      00007ff9`008b429f
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.mklMataddRowOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     dword ptr [rsp+20h],ecx
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],rdx
       mov     dword ptr [rsp+38h],ecx
       vmovsd  xmm0,qword ptr [00007ff9`008b4318]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],r8
       mov     ecx,dword ptr [r8+8]
       mov     dword ptr [rsp+50h],ecx
       mov     qword ptr [rsp+58h],rsi
       mov     ecx,dword ptr [rsi+8]
       mov     dword ptr [rsp+60h],ecx
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       mov     r9d,1
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 94
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddMklMiniBmk.MataddColOut()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     r9,qword ptr [rcx+8]
       mov     rdx,qword ptr [rcx+10h]
       mov     rsi,qword ptr [rcx+18h]
       mov     dword ptr [rsp+20h],1
       vmovsd  qword ptr [rsp+28h],xmm0
       mov     qword ptr [rsp+30h],r9
       mov     dword ptr [rsp+38h],1
       vmovsd  xmm0,qword ptr [00007ff9`008942f0]
       vmovsd  qword ptr [rsp+40h],xmm0
       mov     qword ptr [rsp+48h],rdx
       mov     dword ptr [rsp+50h],1
       mov     qword ptr [rsp+58h],rsi
       mov     dword ptr [rsp+60h],1
       mov     r9d,dword ptr [r9+8]
       mov     ecx,52h
       mov     edx,4Eh
       mov     r8d,4Eh
       call    VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)
       mov     rax,rsi
; Total bytes of code 116
```
**No ILOffsetMap found**
VectorsBmk.MKL.MKL_Domatadd(Char, Char, Char, Int32, Int32, Double, Double[], Int32, Double, Double[], Int32, Double[], Int32)

