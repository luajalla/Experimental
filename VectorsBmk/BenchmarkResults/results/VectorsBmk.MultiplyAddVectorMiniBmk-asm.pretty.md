## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569410h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,ebp
       sar     ecx,2
       mov     r14d,ecx
       shl     r14d,2
       test    ebp,ebp
       jb      M01_L07
       cmp     ebp,r14d
       jb      M01_L07
       mov     ecx,r14d
       mov     rdx,rsi
       mov     eax,8
       lea     r8,[rsp+48h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rdx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],ecx
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vbroadcastsd ymm0,xmm6
       xor     eax,eax
       mov     ecx,dword ptr [rsp+58h]
       dec     ecx
       test    ecx,ecx
       jl      M01_L03
M01_L00:
       cmp     eax,dword ptr [rsp+58h]
       jae     M01_L08
       cmp     qword ptr [rsp+48h],0
       jne     M01_L01
       mov     rdx,qword ptr [rsp+50h]
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
       jmp     M01_L02
M01_L01:
       mov     rdx,qword ptr [rsp+48h]
       cmp     dword ptr [rdx],edx
       mov     rdx,qword ptr [rsp+48h]
       add     rdx,8
       mov     r8,qword ptr [rsp+50h]
       add     rdx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
M01_L02:
       mov     r8d,eax
       shl     r8d,2
       cmp     r8d,ebp
       jae     00007ff9`1f56baa9
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f56baa9
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       cmp     r8d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       cmp     r9d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdx],ymm1
       inc     eax
       lea     edx,[rcx+1]
       cmp     eax,edx
       jne     M01_L00
M01_L03:
       mov     ecx,r14d
       mov     eax,dword ptr [rbx+8]
       cmp     eax,r14d
       jle     M01_L06
       test    rdi,rdi
       setne   dl
       movzx   edx,dl
       test    dl,1
       je      M01_L05
       cmp     ebp,eax
       setge   dl
       movzx   edx,dl
       test    ecx,ecx
       setge   r8b
       movzx   r8d,r8b
       and     edx,r8d
       cmp     dword ptr [rdi+8],eax
       setge   r8b
       movzx   r8d,r8b
       test    r8d,edx
       je      M01_L05
M01_L04:
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L04
       jmp     M01_L06
M01_L05:
       cmp     ecx,ebp
       jae     00007ff9`1f56baa9
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       cmp     ecx,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       cmp     ecx,eax
       jae     00007ff9`1f56baa9
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L05
M01_L06:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+60h]
       vzeroupper
       add     rsp,70h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
M01_L07:
       mov     ecx,1
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 457
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F569428h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     ebp,dword ptr [rsi+8]
       mov     eax,ebp
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+80h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L05
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L06
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+40h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r8d,eax
       shl     r8d,2
       mov     ebp,dword ptr [rsi+8]
       cmp     r8d,ebp
       jae     00007ff9`1f56b8d1
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f56b8d1
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       mov     r10d,dword ptr [rdi+8]
       cmp     r8d,r10d
       jae     00007ff9`1f56b8d1
       cmp     r9d,r10d
       jae     00007ff9`1f56b8d1
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vzeroupper
       add     rsp,58h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 261
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F549438h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     ecx,ecx
       xor     eax,eax
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       mov     r8d,dword ptr [rdx+8]
       mov     rcx,rdx
       mov     eax,8
M01_L01:
       lea     rdx,[rsp+70h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rdi,rdi
       jne     M01_L02
       xor     edi,edi
       xor     ecx,ecx
       xor     edx,edx
       jmp     M01_L03
M01_L02:
       mov     edx,dword ptr [rdi+8]
       mov     ecx,8
M01_L03:
       lea     rax,[rsp+58h]
       lea     r8,[rsp+28h]
       mov     qword ptr [r8],rdi
       mov     qword ptr [r8+8],rcx
       mov     dword ptr [r8+10h],edx
       mov     rcx,rax
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L04
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L05
M01_L04:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L05:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+0A0h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L13
M01_L06:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L14
       cmp     qword ptr [rsp+40h],0
       jne     M01_L07
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L08
M01_L07:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L08:
       cmp     eax,dword ptr [rsp+80h]
       jae     M01_L15
       cmp     qword ptr [rsp+70h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+78h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+70h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+70h]
       add     r9,8
       mov     r10,qword ptr [rsp+78h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+68h]
       jae     00007ff9`1f54b98b
       cmp     qword ptr [rsp+58h],0
       jne     M01_L11
       mov     r9,qword ptr [rsp+60h]
       add     r9,r8
       jmp     M01_L12
M01_L11:
       mov     r9,qword ptr [rsp+58h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+58h]
       add     r9,8
       mov     r10,qword ptr [rsp+60h]
       add     r9,r10
       add     r9,r8
M01_L12:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L06
M01_L13:
       mov     rax,rsi
       vzeroupper
       add     rsp,88h
       pop     rsi
       pop     rdi
       ret
M01_L14:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L15:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 449
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F559418h
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
       add     al,ch
       and     ebx,dword ptr [rbx+5E5F5Dh]
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+88h]
       lea     r9,[rsp+48h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+48h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       xor     ebp,ebp
       mov     ecx,dword ptr [rsp+98h]
       lea     r14d,[rcx-1]
       test    r14d,r14d
       jl      M01_L05
M01_L02:
       cmp     ebp,dword ptr [rsp+98h]
       jae     M01_L06
       cmp     qword ptr [rsp+88h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+90h]
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+88h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+88h]
       add     rcx,8
       mov     r8,qword ptr [rsp+90h]
       add     rcx,r8
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
M01_L04:
       mov     r12d,ebp
       shl     r12d,2
       cmp     r12d,dword ptr [rsi+8]
       jae     00007ff9`1f55b92b
       lea     r13d,[r12+3]
       cmp     r13d,dword ptr [rsi+8]
       jae     00007ff9`1f55b92b
       vmovupd ymm1,ymmword ptr [rsi+r12*8+10h]
       lea     rcx,[rsp+60h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+20h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+20h]
       call    System.Numerics.Vector`1[[System.Double, mscorlib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       cmp     r12d,dword ptr [rdi+8]
       jae     00007ff9`1f55b92b
       cmp     r13d,dword ptr [rdi+8]
       jae     00007ff9`1f55b92b
       vmovupd ymm0,ymmword ptr [rdi+r12*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+60h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r15],ymm1
       inc     ebp
       lea     eax,[r14+1]
       cmp     ebp,eax
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+0A0h]
       vzeroupper
       add     rsp,0B8h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r12
       pop     r13
       pop     r14
       pop     r15
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 335
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF91F549420h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    rdi,rdi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rdi+8]
       mov     rcx,rdi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+70h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L07
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L08
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r9d,eax
       shl     r9d,2
       mov     r10d,dword ptr [rsi+8]
       cmp     r9d,r10d
       jae     00007ff9`1f54b8e1
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f54b8e1
       vmovupd ymm1,ymmword ptr [rsi+r9*8+10h]
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L09
       cmp     qword ptr [rsp+40h],0
       jne     M01_L05
       mov     r9,qword ptr [rsp+48h]
       add     r9,r8
       jmp     M01_L06
M01_L05:
       mov     r9,qword ptr [rsp+40h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+40h]
       add     r9,8
       mov     r10,qword ptr [rsp+48h]
       add     r9,r10
       add     r9,r8
M01_L06:
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L07:
       mov     rax,rdi
       vzeroupper
       add     rsp,58h
       pop     rsi
       pop     rdi
       ret
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L09:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 301
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF90BAC3440h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     eax,ecx
       sar     eax,1Fh
       and     eax,3
       add     eax,ecx
       sar     eax,2
       mov     r10d,eax
       shl     r10d,2
       test    ecx,ecx
       jb      M01_L06
       cmp     ecx,r10d
       jb      M01_L06
       lea     rax,[rdx+10h]
       mov     r11d,r10d
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     M01_L05
       vbroadcastsd ymm1,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L01
       mov     ebx,dword ptr [r8+8]
       inc     edi
M01_L00:
       cmp     esi,r11d
       jae     00007ff9`0bac49f4
       movsxd  rbp,esi
       shl     rbp,5
       add     rbp,rax
       mov     r14d,esi
       shl     r14d,2
       cmp     r14d,ecx
       jae     00007ff9`0bac49f4
       lea     r15d,[r14+3]
       cmp     r15d,ecx
       jae     00007ff9`0bac49f4
       vmovupd ymm2,ymmword ptr [rdx+r14*8+10h]
       cmp     r14d,ebx
       jae     00007ff9`0bac49f4
       cmp     r15d,ebx
       jae     00007ff9`0bac49f4
       vmovupd ymm3,ymmword ptr [r8+r14*8+10h]
       vmulpd  ymm2,ymm1,ymm2
       vaddpd  ymm2,ymm2,ymm3
       vmovupd ymmword ptr [rbp],ymm2
       inc     esi
       cmp     esi,edi
       jne     M01_L00
M01_L01:
       mov     edi,r10d
       mov     eax,dword ptr [r9+8]
       cmp     eax,r10d
       jle     M01_L04
       test    r8,r8
       setne   r11b
       movzx   r11d,r11b
       test    r11b,1
       je      M01_L03
       cmp     eax,ecx
       setle   r10b
       movzx   r10d,r10b
       test    edi,edi
       setge   r11b
       movzx   r11d,r11b
       and     r10d,r11d
       mov     r11d,dword ptr [r8+8]
       cmp     r11d,eax
       setge   r11b
       movzx   r11d,r11b
       test    r11d,r10d
       je      M01_L03
M01_L02:
       movsxd  rcx,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+rcx*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+rcx*8+10h]
       vmovsd  qword ptr [r9+rcx*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L02
       jmp     M01_L04
M01_L03:
       cmp     edi,ecx
       jae     00007ff9`0bac49f4
       movsxd  r10,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r10*8+10h]
       mov     r11d,dword ptr [r8+8]
       cmp     edi,r11d
       jae     00007ff9`0bac49f4
       vaddsd  xmm1,xmm1,mmword ptr [r8+r10*8+10h]
       cmp     edi,eax
       jae     00007ff9`0bac49f4
       vmovsd  qword ptr [r9+r10*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L03
M01_L04:
       mov     rax,r9
       vzeroupper
       add     rsp,28h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       pop     r15
       ret
M01_L05:
       call    coreclr!GetCLRRuntimeHost+0x857e0
M01_L06:
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int     3
; Total bytes of code 389
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAC3458h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     r10d,dword ptr [rdx+8]
       mov     ecx,r10d
M01_L01:
       mov     r10d,ecx
       shl     r10,3
       mov     rcx,r10
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bac491a
       vbroadcastsd ymm0,xmm0
       xor     r11d,r11d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     esi,dword ptr [rdx+8]
       mov     edi,dword ptr [r8+8]
       inc     r10d
M01_L02:
       cmp     r11d,ecx
       jae     00007ff9`0bac4920
       movsxd  rbx,r11d
       shl     rbx,5
       add     rbx,rax
       mov     ebp,r11d
       shl     ebp,2
       cmp     ebp,esi
       jae     00007ff9`0bac4920
       lea     r14d,[rbp+3]
       cmp     r14d,esi
       jae     00007ff9`0bac4920
       vmovupd ymm1,ymmword ptr [rdx+rbp*8+10h]
       cmp     ebp,edi
       jae     00007ff9`0bac4920
       cmp     r14d,edi
       jae     00007ff9`0bac4920
       vmovupd ymm2,ymmword ptr [r8+rbp*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbx],ymm1
       inc     r11d
       cmp     r11d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r9
; Total bytes of code 159
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAF3468h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     ecx,dword ptr [rdx+8]
M01_L01:
       mov     edx,ecx
       shl     rdx,3
       shr     rdx,5
       test    rdx,0FFFFFFFF80000000h
       jne     00007ff9`0baf494e
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r10d,r10d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r10d,dword ptr [r8+8]
M01_L03:
       mov     r8d,r10d
       shl     r8,3
       shr     r8,5
       test    r8,0FFFFFFFF80000000h
       jne     00007ff9`0baf494e
       test    r9,r9
       jne     M01_L04
       xor     r10d,r10d
       xor     r11d,r11d
       jmp     M01_L05
M01_L04:
       lea     r10,[r9+10h]
       mov     r11d,dword ptr [r9+8]
M01_L05:
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     00007ff9`0baf494e
       vbroadcastsd ymm0,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L07
       inc     edi
M01_L06:
       cmp     esi,r11d
       jae     00007ff9`0baf4954
       movsxd  rbx,esi
       shl     rbx,5
       lea     rbp,[r10+rbx]
       cmp     esi,edx
       jae     00007ff9`0baf4954
       lea     r14,[rax+rbx]
       vmovupd ymm1,ymmword ptr [r14]
       vmulpd  ymm1,ymm0,ymm1
       cmp     esi,r8d
       jae     00007ff9`0baf4954
       lea     r14,[rcx+rbx]
       vmovupd ymm2,ymmword ptr [r14]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbp],ymm1
       inc     esi
       cmp     esi,edi
       jne     M01_L06
M01_L07:
       mov     rax,r9
; Total bytes of code 211
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BB03448h
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
       add     al,ch
       shl     dword ptr [rbx+5E5FAAh],cl
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       lea     rcx,[rsi+10h]
       mov     eax,dword ptr [rsi+8]
       mov     r8d,eax
M01_L01:
       mov     rax,rcx
       mov     ecx,r8d
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bb0499f
       mov     ebp,ecx
       mov     rcx,rax
       mov     rax,rcx
       mov     ecx,ebp
       mov     rbp,rax
       mov     r14d,ecx
       xor     r15d,r15d
       lea     r12d,[r14-1]
       test    r12d,r12d
       jl      M01_L03
M01_L02:
       cmp     r15d,r14d
       jae     00007ff9`0bb049a5
       movsxd  rcx,r15d
       shl     rcx,5
       lea     r13,[rcx+rbp]
       mov     eax,r15d
       shl     eax,2
       mov     ecx,dword ptr [rsi+8]
       cmp     eax,ecx
       jae     00007ff9`0bb049a5
       lea     edx,[rax+3]
       mov     dword ptr [rsp+2Ch],edx
       cmp     edx,ecx
       jae     00007ff9`0bb049a5
       mov     dword ptr [rsp+28h],eax
       vmovupd ymm1,ymmword ptr [rsi+rax*8+10h]
       lea     rcx,[rsp+50h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+30h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+30h]
       call    System.Numerics.Vector`1[[System.Double, System.Private.CoreLib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       mov     eax,dword ptr [rdi+8]
       mov     edx,dword ptr [rsp+28h]
       cmp     edx,eax
       jae     00007ff9`0bb049a5
       mov     ecx,dword ptr [rsp+2Ch]
       cmp     ecx,eax
       jae     00007ff9`0bb049a5
       vmovupd ymm0,ymmword ptr [rdi+rdx*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+50h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r13],ymm1
       inc     r15d
       lea     eax,[r12+1]
       cmp     r15d,eax
       jne     M01_L02
M01_L03:
       mov     rax,rbx
; Total bytes of code 240
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF90BAF3450h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    r8,r8
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[r8+10h]
       mov     ecx,dword ptr [r8+8]
M01_L01:
       mov     ecx,ecx
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0baf48fb
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`0baf4901
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`0baf4901
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`0baf4901
       vmovupd ymm1,ymmword ptr [rdx+rdi*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rsi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rsi],ymm1
       inc     r9d
       cmp     r9d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r8
; Total bytes of code 134
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569410h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,ebp
       sar     ecx,2
       mov     r14d,ecx
       shl     r14d,2
       test    ebp,ebp
       jb      M01_L07
       cmp     ebp,r14d
       jb      M01_L07
       mov     ecx,r14d
       mov     rdx,rsi
       mov     eax,8
       lea     r8,[rsp+48h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rdx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],ecx
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vbroadcastsd ymm0,xmm6
       xor     eax,eax
       mov     ecx,dword ptr [rsp+58h]
       dec     ecx
       test    ecx,ecx
       jl      M01_L03
M01_L00:
       cmp     eax,dword ptr [rsp+58h]
       jae     M01_L08
       cmp     qword ptr [rsp+48h],0
       jne     M01_L01
       mov     rdx,qword ptr [rsp+50h]
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
       jmp     M01_L02
M01_L01:
       mov     rdx,qword ptr [rsp+48h]
       cmp     dword ptr [rdx],edx
       mov     rdx,qword ptr [rsp+48h]
       add     rdx,8
       mov     r8,qword ptr [rsp+50h]
       add     rdx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
M01_L02:
       mov     r8d,eax
       shl     r8d,2
       cmp     r8d,ebp
       jae     00007ff9`1f56baa9
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f56baa9
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       cmp     r8d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       cmp     r9d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdx],ymm1
       inc     eax
       lea     edx,[rcx+1]
       cmp     eax,edx
       jne     M01_L00
M01_L03:
       mov     ecx,r14d
       mov     eax,dword ptr [rbx+8]
       cmp     eax,r14d
       jle     M01_L06
       test    rdi,rdi
       setne   dl
       movzx   edx,dl
       test    dl,1
       je      M01_L05
       cmp     ebp,eax
       setge   dl
       movzx   edx,dl
       test    ecx,ecx
       setge   r8b
       movzx   r8d,r8b
       and     edx,r8d
       cmp     dword ptr [rdi+8],eax
       setge   r8b
       movzx   r8d,r8b
       test    r8d,edx
       je      M01_L05
M01_L04:
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L04
       jmp     M01_L06
M01_L05:
       cmp     ecx,ebp
       jae     00007ff9`1f56baa9
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       cmp     ecx,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       cmp     ecx,eax
       jae     00007ff9`1f56baa9
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L05
M01_L06:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+60h]
       vzeroupper
       add     rsp,70h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
M01_L07:
       mov     ecx,1
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 457
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F579428h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     ebp,dword ptr [rsi+8]
       mov     eax,ebp
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+80h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L05
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L06
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+40h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r8d,eax
       shl     r8d,2
       mov     ebp,dword ptr [rsi+8]
       cmp     r8d,ebp
       jae     00007ff9`1f57b8d1
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f57b8d1
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       mov     r10d,dword ptr [rdi+8]
       cmp     r8d,r10d
       jae     00007ff9`1f57b8d1
       cmp     r9d,r10d
       jae     00007ff9`1f57b8d1
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vzeroupper
       add     rsp,58h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 261
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F559438h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     ecx,ecx
       xor     eax,eax
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       mov     r8d,dword ptr [rdx+8]
       mov     rcx,rdx
       mov     eax,8
M01_L01:
       lea     rdx,[rsp+70h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rdi,rdi
       jne     M01_L02
       xor     edi,edi
       xor     ecx,ecx
       xor     edx,edx
       jmp     M01_L03
M01_L02:
       mov     edx,dword ptr [rdi+8]
       mov     ecx,8
M01_L03:
       lea     rax,[rsp+58h]
       lea     r8,[rsp+28h]
       mov     qword ptr [r8],rdi
       mov     qword ptr [r8+8],rcx
       mov     dword ptr [r8+10h],edx
       mov     rcx,rax
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L04
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L05
M01_L04:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L05:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+0A0h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L13
M01_L06:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L14
       cmp     qword ptr [rsp+40h],0
       jne     M01_L07
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L08
M01_L07:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L08:
       cmp     eax,dword ptr [rsp+80h]
       jae     M01_L15
       cmp     qword ptr [rsp+70h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+78h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+70h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+70h]
       add     r9,8
       mov     r10,qword ptr [rsp+78h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+68h]
       jae     00007ff9`1f55b98b
       cmp     qword ptr [rsp+58h],0
       jne     M01_L11
       mov     r9,qword ptr [rsp+60h]
       add     r9,r8
       jmp     M01_L12
M01_L11:
       mov     r9,qword ptr [rsp+58h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+58h]
       add     r9,8
       mov     r10,qword ptr [rsp+60h]
       add     r9,r10
       add     r9,r8
M01_L12:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L06
M01_L13:
       mov     rax,rsi
       vzeroupper
       add     rsp,88h
       pop     rsi
       pop     rdi
       ret
M01_L14:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L15:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 449
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F579418h
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
       add     al,ch
       and     ebx,dword ptr [rbx+5E5F5Bh]
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+88h]
       lea     r9,[rsp+48h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+48h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       xor     ebp,ebp
       mov     ecx,dword ptr [rsp+98h]
       lea     r14d,[rcx-1]
       test    r14d,r14d
       jl      M01_L05
M01_L02:
       cmp     ebp,dword ptr [rsp+98h]
       jae     M01_L06
       cmp     qword ptr [rsp+88h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+90h]
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+88h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+88h]
       add     rcx,8
       mov     r8,qword ptr [rsp+90h]
       add     rcx,r8
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
M01_L04:
       mov     r12d,ebp
       shl     r12d,2
       cmp     r12d,dword ptr [rsi+8]
       jae     00007ff9`1f57b92b
       lea     r13d,[r12+3]
       cmp     r13d,dword ptr [rsi+8]
       jae     00007ff9`1f57b92b
       vmovupd ymm1,ymmword ptr [rsi+r12*8+10h]
       lea     rcx,[rsp+60h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+20h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+20h]
       call    System.Numerics.Vector`1[[System.Double, mscorlib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       cmp     r12d,dword ptr [rdi+8]
       jae     00007ff9`1f57b92b
       cmp     r13d,dword ptr [rdi+8]
       jae     00007ff9`1f57b92b
       vmovupd ymm0,ymmword ptr [rdi+r12*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+60h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r15],ymm1
       inc     ebp
       lea     eax,[r14+1]
       cmp     ebp,eax
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+0A0h]
       vzeroupper
       add     rsp,0B8h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r12
       pop     r13
       pop     r14
       pop     r15
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 335
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF91F569420h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    rdi,rdi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rdi+8]
       mov     rcx,rdi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+70h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L07
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L08
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r9d,eax
       shl     r9d,2
       mov     r10d,dword ptr [rsi+8]
       cmp     r9d,r10d
       jae     00007ff9`1f56b8e1
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f56b8e1
       vmovupd ymm1,ymmword ptr [rsi+r9*8+10h]
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L09
       cmp     qword ptr [rsp+40h],0
       jne     M01_L05
       mov     r9,qword ptr [rsp+48h]
       add     r9,r8
       jmp     M01_L06
M01_L05:
       mov     r9,qword ptr [rsp+40h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+40h]
       add     r9,8
       mov     r10,qword ptr [rsp+48h]
       add     r9,r10
       add     r9,r8
M01_L06:
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L07:
       mov     rax,rdi
       vzeroupper
       add     rsp,58h
       pop     rsi
       pop     rdi
       ret
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L09:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 301
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF90BB03440h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     eax,ecx
       sar     eax,1Fh
       and     eax,3
       add     eax,ecx
       sar     eax,2
       mov     r10d,eax
       shl     r10d,2
       test    ecx,ecx
       jb      M01_L06
       cmp     ecx,r10d
       jb      M01_L06
       lea     rax,[rdx+10h]
       mov     r11d,r10d
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     M01_L05
       vbroadcastsd ymm1,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L01
       mov     ebx,dword ptr [r8+8]
       inc     edi
M01_L00:
       cmp     esi,r11d
       jae     00007ff9`0bb049f4
       movsxd  rbp,esi
       shl     rbp,5
       add     rbp,rax
       mov     r14d,esi
       shl     r14d,2
       cmp     r14d,ecx
       jae     00007ff9`0bb049f4
       lea     r15d,[r14+3]
       cmp     r15d,ecx
       jae     00007ff9`0bb049f4
       vmovupd ymm2,ymmword ptr [rdx+r14*8+10h]
       cmp     r14d,ebx
       jae     00007ff9`0bb049f4
       cmp     r15d,ebx
       jae     00007ff9`0bb049f4
       vmovupd ymm3,ymmword ptr [r8+r14*8+10h]
       vmulpd  ymm2,ymm1,ymm2
       vaddpd  ymm2,ymm2,ymm3
       vmovupd ymmword ptr [rbp],ymm2
       inc     esi
       cmp     esi,edi
       jne     M01_L00
M01_L01:
       mov     edi,r10d
       mov     eax,dword ptr [r9+8]
       cmp     eax,r10d
       jle     M01_L04
       test    r8,r8
       setne   r11b
       movzx   r11d,r11b
       test    r11b,1
       je      M01_L03
       cmp     eax,ecx
       setle   r10b
       movzx   r10d,r10b
       test    edi,edi
       setge   r11b
       movzx   r11d,r11b
       and     r10d,r11d
       mov     r11d,dword ptr [r8+8]
       cmp     r11d,eax
       setge   r11b
       movzx   r11d,r11b
       test    r11d,r10d
       je      M01_L03
M01_L02:
       movsxd  rcx,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+rcx*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+rcx*8+10h]
       vmovsd  qword ptr [r9+rcx*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L02
       jmp     M01_L04
M01_L03:
       cmp     edi,ecx
       jae     00007ff9`0bb049f4
       movsxd  r10,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r10*8+10h]
       mov     r11d,dword ptr [r8+8]
       cmp     edi,r11d
       jae     00007ff9`0bb049f4
       vaddsd  xmm1,xmm1,mmword ptr [r8+r10*8+10h]
       cmp     edi,eax
       jae     00007ff9`0bb049f4
       vmovsd  qword ptr [r9+r10*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L03
M01_L04:
       mov     rax,r9
       vzeroupper
       add     rsp,28h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       pop     r15
       ret
M01_L05:
       call    coreclr!GetCLRRuntimeHost+0x857e0
M01_L06:
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int     3
; Total bytes of code 389
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAF3458h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     r10d,dword ptr [rdx+8]
       mov     ecx,r10d
M01_L01:
       mov     r10d,ecx
       shl     r10,3
       mov     rcx,r10
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0baf491a
       vbroadcastsd ymm0,xmm0
       xor     r11d,r11d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     esi,dword ptr [rdx+8]
       mov     edi,dword ptr [r8+8]
       inc     r10d
M01_L02:
       cmp     r11d,ecx
       jae     00007ff9`0baf4920
       movsxd  rbx,r11d
       shl     rbx,5
       add     rbx,rax
       mov     ebp,r11d
       shl     ebp,2
       cmp     ebp,esi
       jae     00007ff9`0baf4920
       lea     r14d,[rbp+3]
       cmp     r14d,esi
       jae     00007ff9`0baf4920
       vmovupd ymm1,ymmword ptr [rdx+rbp*8+10h]
       cmp     ebp,edi
       jae     00007ff9`0baf4920
       cmp     r14d,edi
       jae     00007ff9`0baf4920
       vmovupd ymm2,ymmword ptr [r8+rbp*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbx],ymm1
       inc     r11d
       cmp     r11d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r9
; Total bytes of code 159
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAD3468h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     ecx,dword ptr [rdx+8]
M01_L01:
       mov     edx,ecx
       shl     rdx,3
       shr     rdx,5
       test    rdx,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r10d,r10d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r10d,dword ptr [r8+8]
M01_L03:
       mov     r8d,r10d
       shl     r8,3
       shr     r8,5
       test    r8,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r9,r9
       jne     M01_L04
       xor     r10d,r10d
       xor     r11d,r11d
       jmp     M01_L05
M01_L04:
       lea     r10,[r9+10h]
       mov     r11d,dword ptr [r9+8]
M01_L05:
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       vbroadcastsd ymm0,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L07
       inc     edi
M01_L06:
       cmp     esi,r11d
       jae     00007ff9`0bad4954
       movsxd  rbx,esi
       shl     rbx,5
       lea     rbp,[r10+rbx]
       cmp     esi,edx
       jae     00007ff9`0bad4954
       lea     r14,[rax+rbx]
       vmovupd ymm1,ymmword ptr [r14]
       vmulpd  ymm1,ymm0,ymm1
       cmp     esi,r8d
       jae     00007ff9`0bad4954
       lea     r14,[rcx+rbx]
       vmovupd ymm2,ymmword ptr [r14]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbp],ymm1
       inc     esi
       cmp     esi,edi
       jne     M01_L06
M01_L07:
       mov     rax,r9
; Total bytes of code 211
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAF3448h
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
       add     al,ch
       shl     dword ptr [rbx+5E5FABh],cl
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       lea     rcx,[rsi+10h]
       mov     eax,dword ptr [rsi+8]
       mov     r8d,eax
M01_L01:
       mov     rax,rcx
       mov     ecx,r8d
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0baf499f
       mov     ebp,ecx
       mov     rcx,rax
       mov     rax,rcx
       mov     ecx,ebp
       mov     rbp,rax
       mov     r14d,ecx
       xor     r15d,r15d
       lea     r12d,[r14-1]
       test    r12d,r12d
       jl      M01_L03
M01_L02:
       cmp     r15d,r14d
       jae     00007ff9`0baf49a5
       movsxd  rcx,r15d
       shl     rcx,5
       lea     r13,[rcx+rbp]
       mov     eax,r15d
       shl     eax,2
       mov     ecx,dword ptr [rsi+8]
       cmp     eax,ecx
       jae     00007ff9`0baf49a5
       lea     edx,[rax+3]
       mov     dword ptr [rsp+2Ch],edx
       cmp     edx,ecx
       jae     00007ff9`0baf49a5
       mov     dword ptr [rsp+28h],eax
       vmovupd ymm1,ymmword ptr [rsi+rax*8+10h]
       lea     rcx,[rsp+50h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+30h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+30h]
       call    System.Numerics.Vector`1[[System.Double, System.Private.CoreLib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       mov     eax,dword ptr [rdi+8]
       mov     edx,dword ptr [rsp+28h]
       cmp     edx,eax
       jae     00007ff9`0baf49a5
       mov     ecx,dword ptr [rsp+2Ch]
       cmp     ecx,eax
       jae     00007ff9`0baf49a5
       vmovupd ymm0,ymmword ptr [rdi+rdx*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+50h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r13],ymm1
       inc     r15d
       lea     eax,[r12+1]
       cmp     r15d,eax
       jne     M01_L02
M01_L03:
       mov     rax,rbx
; Total bytes of code 240
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF90BAE3450h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    r8,r8
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[r8+10h]
       mov     ecx,dword ptr [r8+8]
M01_L01:
       mov     ecx,ecx
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bae48fb
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`0bae4901
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`0bae4901
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`0bae4901
       vmovupd ymm1,ymmword ptr [rdx+rdi*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rsi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rsi],ymm1
       inc     r9d
       cmp     r9d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r8
; Total bytes of code 134
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569410h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,ebp
       sar     ecx,2
       mov     r14d,ecx
       shl     r14d,2
       test    ebp,ebp
       jb      M01_L07
       cmp     ebp,r14d
       jb      M01_L07
       mov     ecx,r14d
       mov     rdx,rsi
       mov     eax,8
       lea     r8,[rsp+48h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rdx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],ecx
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vbroadcastsd ymm0,xmm6
       xor     eax,eax
       mov     ecx,dword ptr [rsp+58h]
       dec     ecx
       test    ecx,ecx
       jl      M01_L03
M01_L00:
       cmp     eax,dword ptr [rsp+58h]
       jae     M01_L08
       cmp     qword ptr [rsp+48h],0
       jne     M01_L01
       mov     rdx,qword ptr [rsp+50h]
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
       jmp     M01_L02
M01_L01:
       mov     rdx,qword ptr [rsp+48h]
       cmp     dword ptr [rdx],edx
       mov     rdx,qword ptr [rsp+48h]
       add     rdx,8
       mov     r8,qword ptr [rsp+50h]
       add     rdx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
M01_L02:
       mov     r8d,eax
       shl     r8d,2
       cmp     r8d,ebp
       jae     00007ff9`1f56baa9
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f56baa9
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       cmp     r8d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       cmp     r9d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdx],ymm1
       inc     eax
       lea     edx,[rcx+1]
       cmp     eax,edx
       jne     M01_L00
M01_L03:
       mov     ecx,r14d
       mov     eax,dword ptr [rbx+8]
       cmp     eax,r14d
       jle     M01_L06
       test    rdi,rdi
       setne   dl
       movzx   edx,dl
       test    dl,1
       je      M01_L05
       cmp     ebp,eax
       setge   dl
       movzx   edx,dl
       test    ecx,ecx
       setge   r8b
       movzx   r8d,r8b
       and     edx,r8d
       cmp     dword ptr [rdi+8],eax
       setge   r8b
       movzx   r8d,r8b
       test    r8d,edx
       je      M01_L05
M01_L04:
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L04
       jmp     M01_L06
M01_L05:
       cmp     ecx,ebp
       jae     00007ff9`1f56baa9
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       cmp     ecx,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       cmp     ecx,eax
       jae     00007ff9`1f56baa9
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L05
M01_L06:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+60h]
       vzeroupper
       add     rsp,70h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
M01_L07:
       mov     ecx,1
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 457
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F579428h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     ebp,dword ptr [rsi+8]
       mov     eax,ebp
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+80h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L05
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L06
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+40h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r8d,eax
       shl     r8d,2
       mov     ebp,dword ptr [rsi+8]
       cmp     r8d,ebp
       jae     00007ff9`1f57b8d1
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f57b8d1
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       mov     r10d,dword ptr [rdi+8]
       cmp     r8d,r10d
       jae     00007ff9`1f57b8d1
       cmp     r9d,r10d
       jae     00007ff9`1f57b8d1
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vzeroupper
       add     rsp,58h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 261
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F569438h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     ecx,ecx
       xor     eax,eax
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       mov     r8d,dword ptr [rdx+8]
       mov     rcx,rdx
       mov     eax,8
M01_L01:
       lea     rdx,[rsp+70h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rdi,rdi
       jne     M01_L02
       xor     edi,edi
       xor     ecx,ecx
       xor     edx,edx
       jmp     M01_L03
M01_L02:
       mov     edx,dword ptr [rdi+8]
       mov     ecx,8
M01_L03:
       lea     rax,[rsp+58h]
       lea     r8,[rsp+28h]
       mov     qword ptr [r8],rdi
       mov     qword ptr [r8+8],rcx
       mov     dword ptr [r8+10h],edx
       mov     rcx,rax
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L04
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L05
M01_L04:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L05:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+0A0h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L13
M01_L06:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L14
       cmp     qword ptr [rsp+40h],0
       jne     M01_L07
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L08
M01_L07:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L08:
       cmp     eax,dword ptr [rsp+80h]
       jae     M01_L15
       cmp     qword ptr [rsp+70h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+78h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+70h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+70h]
       add     r9,8
       mov     r10,qword ptr [rsp+78h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+68h]
       jae     00007ff9`1f56b98b
       cmp     qword ptr [rsp+58h],0
       jne     M01_L11
       mov     r9,qword ptr [rsp+60h]
       add     r9,r8
       jmp     M01_L12
M01_L11:
       mov     r9,qword ptr [rsp+58h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+58h]
       add     r9,8
       mov     r10,qword ptr [rsp+60h]
       add     r9,r10
       add     r9,r8
M01_L12:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L06
M01_L13:
       mov     rax,rsi
       vzeroupper
       add     rsp,88h
       pop     rsi
       pop     rdi
       ret
M01_L14:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L15:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 449
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F559418h
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
       add     al,ch
       and     ebx,dword ptr [rbx+5E5F5Dh]
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+88h]
       lea     r9,[rsp+48h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+48h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       xor     ebp,ebp
       mov     ecx,dword ptr [rsp+98h]
       lea     r14d,[rcx-1]
       test    r14d,r14d
       jl      M01_L05
M01_L02:
       cmp     ebp,dword ptr [rsp+98h]
       jae     M01_L06
       cmp     qword ptr [rsp+88h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+90h]
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+88h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+88h]
       add     rcx,8
       mov     r8,qword ptr [rsp+90h]
       add     rcx,r8
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
M01_L04:
       mov     r12d,ebp
       shl     r12d,2
       cmp     r12d,dword ptr [rsi+8]
       jae     00007ff9`1f55b92b
       lea     r13d,[r12+3]
       cmp     r13d,dword ptr [rsi+8]
       jae     00007ff9`1f55b92b
       vmovupd ymm1,ymmword ptr [rsi+r12*8+10h]
       lea     rcx,[rsp+60h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+20h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+20h]
       call    System.Numerics.Vector`1[[System.Double, mscorlib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       cmp     r12d,dword ptr [rdi+8]
       jae     00007ff9`1f55b92b
       cmp     r13d,dword ptr [rdi+8]
       jae     00007ff9`1f55b92b
       vmovupd ymm0,ymmword ptr [rdi+r12*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+60h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r15],ymm1
       inc     ebp
       lea     eax,[r14+1]
       cmp     ebp,eax
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+0A0h]
       vzeroupper
       add     rsp,0B8h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r12
       pop     r13
       pop     r14
       pop     r15
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 335
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF91F549420h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    rdi,rdi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rdi+8]
       mov     rcx,rdi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+70h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L07
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L08
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r9d,eax
       shl     r9d,2
       mov     r10d,dword ptr [rsi+8]
       cmp     r9d,r10d
       jae     00007ff9`1f54b8e1
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f54b8e1
       vmovupd ymm1,ymmword ptr [rsi+r9*8+10h]
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L09
       cmp     qword ptr [rsp+40h],0
       jne     M01_L05
       mov     r9,qword ptr [rsp+48h]
       add     r9,r8
       jmp     M01_L06
M01_L05:
       mov     r9,qword ptr [rsp+40h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+40h]
       add     r9,8
       mov     r10,qword ptr [rsp+48h]
       add     r9,r10
       add     r9,r8
M01_L06:
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L07:
       mov     rax,rdi
       vzeroupper
       add     rsp,58h
       pop     rsi
       pop     rdi
       ret
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L09:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 301
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF90BAE3440h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     eax,ecx
       sar     eax,1Fh
       and     eax,3
       add     eax,ecx
       sar     eax,2
       mov     r10d,eax
       shl     r10d,2
       test    ecx,ecx
       jb      M01_L06
       cmp     ecx,r10d
       jb      M01_L06
       lea     rax,[rdx+10h]
       mov     r11d,r10d
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     M01_L05
       vbroadcastsd ymm1,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L01
       mov     ebx,dword ptr [r8+8]
       inc     edi
M01_L00:
       cmp     esi,r11d
       jae     00007ff9`0bae49f4
       movsxd  rbp,esi
       shl     rbp,5
       add     rbp,rax
       mov     r14d,esi
       shl     r14d,2
       cmp     r14d,ecx
       jae     00007ff9`0bae49f4
       lea     r15d,[r14+3]
       cmp     r15d,ecx
       jae     00007ff9`0bae49f4
       vmovupd ymm2,ymmword ptr [rdx+r14*8+10h]
       cmp     r14d,ebx
       jae     00007ff9`0bae49f4
       cmp     r15d,ebx
       jae     00007ff9`0bae49f4
       vmovupd ymm3,ymmword ptr [r8+r14*8+10h]
       vmulpd  ymm2,ymm1,ymm2
       vaddpd  ymm2,ymm2,ymm3
       vmovupd ymmword ptr [rbp],ymm2
       inc     esi
       cmp     esi,edi
       jne     M01_L00
M01_L01:
       mov     edi,r10d
       mov     eax,dword ptr [r9+8]
       cmp     eax,r10d
       jle     M01_L04
       test    r8,r8
       setne   r11b
       movzx   r11d,r11b
       test    r11b,1
       je      M01_L03
       cmp     eax,ecx
       setle   r10b
       movzx   r10d,r10b
       test    edi,edi
       setge   r11b
       movzx   r11d,r11b
       and     r10d,r11d
       mov     r11d,dword ptr [r8+8]
       cmp     r11d,eax
       setge   r11b
       movzx   r11d,r11b
       test    r11d,r10d
       je      M01_L03
M01_L02:
       movsxd  rcx,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+rcx*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+rcx*8+10h]
       vmovsd  qword ptr [r9+rcx*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L02
       jmp     M01_L04
M01_L03:
       cmp     edi,ecx
       jae     00007ff9`0bae49f4
       movsxd  r10,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r10*8+10h]
       mov     r11d,dword ptr [r8+8]
       cmp     edi,r11d
       jae     00007ff9`0bae49f4
       vaddsd  xmm1,xmm1,mmword ptr [r8+r10*8+10h]
       cmp     edi,eax
       jae     00007ff9`0bae49f4
       vmovsd  qword ptr [r9+r10*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L03
M01_L04:
       mov     rax,r9
       vzeroupper
       add     rsp,28h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       pop     r15
       ret
M01_L05:
       call    coreclr!GetCLRRuntimeHost+0x857e0
M01_L06:
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int     3
; Total bytes of code 389
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAE3458h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     r10d,dword ptr [rdx+8]
       mov     ecx,r10d
M01_L01:
       mov     r10d,ecx
       shl     r10,3
       mov     rcx,r10
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bae491a
       vbroadcastsd ymm0,xmm0
       xor     r11d,r11d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     esi,dword ptr [rdx+8]
       mov     edi,dword ptr [r8+8]
       inc     r10d
M01_L02:
       cmp     r11d,ecx
       jae     00007ff9`0bae4920
       movsxd  rbx,r11d
       shl     rbx,5
       add     rbx,rax
       mov     ebp,r11d
       shl     ebp,2
       cmp     ebp,esi
       jae     00007ff9`0bae4920
       lea     r14d,[rbp+3]
       cmp     r14d,esi
       jae     00007ff9`0bae4920
       vmovupd ymm1,ymmword ptr [rdx+rbp*8+10h]
       cmp     ebp,edi
       jae     00007ff9`0bae4920
       cmp     r14d,edi
       jae     00007ff9`0bae4920
       vmovupd ymm2,ymmword ptr [r8+rbp*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbx],ymm1
       inc     r11d
       cmp     r11d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r9
; Total bytes of code 159
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BB03468h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     ecx,dword ptr [rdx+8]
M01_L01:
       mov     edx,ecx
       shl     rdx,3
       shr     rdx,5
       test    rdx,0FFFFFFFF80000000h
       jne     00007ff9`0bb0494e
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r10d,r10d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r10d,dword ptr [r8+8]
M01_L03:
       mov     r8d,r10d
       shl     r8,3
       shr     r8,5
       test    r8,0FFFFFFFF80000000h
       jne     00007ff9`0bb0494e
       test    r9,r9
       jne     M01_L04
       xor     r10d,r10d
       xor     r11d,r11d
       jmp     M01_L05
M01_L04:
       lea     r10,[r9+10h]
       mov     r11d,dword ptr [r9+8]
M01_L05:
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     00007ff9`0bb0494e
       vbroadcastsd ymm0,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L07
       inc     edi
M01_L06:
       cmp     esi,r11d
       jae     00007ff9`0bb04954
       movsxd  rbx,esi
       shl     rbx,5
       lea     rbp,[r10+rbx]
       cmp     esi,edx
       jae     00007ff9`0bb04954
       lea     r14,[rax+rbx]
       vmovupd ymm1,ymmword ptr [r14]
       vmulpd  ymm1,ymm0,ymm1
       cmp     esi,r8d
       jae     00007ff9`0bb04954
       lea     r14,[rcx+rbx]
       vmovupd ymm2,ymmword ptr [r14]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbp],ymm1
       inc     esi
       cmp     esi,edi
       jne     M01_L06
M01_L07:
       mov     rax,r9
; Total bytes of code 211
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAF3448h
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
       add     al,ch
       shl     dword ptr [rbx+5E5FABh],cl
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       lea     rcx,[rsi+10h]
       mov     eax,dword ptr [rsi+8]
       mov     r8d,eax
M01_L01:
       mov     rax,rcx
       mov     ecx,r8d
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0baf499f
       mov     ebp,ecx
       mov     rcx,rax
       mov     rax,rcx
       mov     ecx,ebp
       mov     rbp,rax
       mov     r14d,ecx
       xor     r15d,r15d
       lea     r12d,[r14-1]
       test    r12d,r12d
       jl      M01_L03
M01_L02:
       cmp     r15d,r14d
       jae     00007ff9`0baf49a5
       movsxd  rcx,r15d
       shl     rcx,5
       lea     r13,[rcx+rbp]
       mov     eax,r15d
       shl     eax,2
       mov     ecx,dword ptr [rsi+8]
       cmp     eax,ecx
       jae     00007ff9`0baf49a5
       lea     edx,[rax+3]
       mov     dword ptr [rsp+2Ch],edx
       cmp     edx,ecx
       jae     00007ff9`0baf49a5
       mov     dword ptr [rsp+28h],eax
       vmovupd ymm1,ymmword ptr [rsi+rax*8+10h]
       lea     rcx,[rsp+50h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+30h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+30h]
       call    System.Numerics.Vector`1[[System.Double, System.Private.CoreLib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       mov     eax,dword ptr [rdi+8]
       mov     edx,dword ptr [rsp+28h]
       cmp     edx,eax
       jae     00007ff9`0baf49a5
       mov     ecx,dword ptr [rsp+2Ch]
       cmp     ecx,eax
       jae     00007ff9`0baf49a5
       vmovupd ymm0,ymmword ptr [rdi+rdx*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+50h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r13],ymm1
       inc     r15d
       lea     eax,[r12+1]
       cmp     r15d,eax
       jne     M01_L02
M01_L03:
       mov     rax,rbx
; Total bytes of code 240
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF90BAD3450h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    r8,r8
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[r8+10h]
       mov     ecx,dword ptr [r8+8]
M01_L01:
       mov     ecx,ecx
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bad48fb
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`0bad4901
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`0bad4901
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`0bad4901
       vmovupd ymm1,ymmword ptr [rdx+rdi*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rsi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rsi],ymm1
       inc     r9d
       cmp     r9d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r8
; Total bytes of code 134
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F569410h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,ebp
       sar     ecx,2
       mov     r14d,ecx
       shl     r14d,2
       test    ebp,ebp
       jb      M01_L07
       cmp     ebp,r14d
       jb      M01_L07
       mov     ecx,r14d
       mov     rdx,rsi
       mov     eax,8
       lea     r8,[rsp+48h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rdx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],ecx
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vbroadcastsd ymm0,xmm6
       xor     eax,eax
       mov     ecx,dword ptr [rsp+58h]
       dec     ecx
       test    ecx,ecx
       jl      M01_L03
M01_L00:
       cmp     eax,dword ptr [rsp+58h]
       jae     M01_L08
       cmp     qword ptr [rsp+48h],0
       jne     M01_L01
       mov     rdx,qword ptr [rsp+50h]
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
       jmp     M01_L02
M01_L01:
       mov     rdx,qword ptr [rsp+48h]
       cmp     dword ptr [rdx],edx
       mov     rdx,qword ptr [rsp+48h]
       add     rdx,8
       mov     r8,qword ptr [rsp+50h]
       add     rdx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
M01_L02:
       mov     r8d,eax
       shl     r8d,2
       cmp     r8d,ebp
       jae     00007ff9`1f56baa9
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f56baa9
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       cmp     r8d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       cmp     r9d,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdx],ymm1
       inc     eax
       lea     edx,[rcx+1]
       cmp     eax,edx
       jne     M01_L00
M01_L03:
       mov     ecx,r14d
       mov     eax,dword ptr [rbx+8]
       cmp     eax,r14d
       jle     M01_L06
       test    rdi,rdi
       setne   dl
       movzx   edx,dl
       test    dl,1
       je      M01_L05
       cmp     ebp,eax
       setge   dl
       movzx   edx,dl
       test    ecx,ecx
       setge   r8b
       movzx   r8d,r8b
       and     edx,r8d
       cmp     dword ptr [rdi+8],eax
       setge   r8b
       movzx   r8d,r8b
       test    r8d,edx
       je      M01_L05
M01_L04:
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L04
       jmp     M01_L06
M01_L05:
       cmp     ecx,ebp
       jae     00007ff9`1f56baa9
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       cmp     ecx,dword ptr [rdi+8]
       jae     00007ff9`1f56baa9
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       cmp     ecx,eax
       jae     00007ff9`1f56baa9
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L05
M01_L06:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+60h]
       vzeroupper
       add     rsp,70h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
M01_L07:
       mov     ecx,1
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 457
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F539428h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     ebp,dword ptr [rsi+8]
       mov     eax,ebp
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+80h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L05
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L06
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+40h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r8d,eax
       shl     r8d,2
       mov     ebp,dword ptr [rsi+8]
       cmp     r8d,ebp
       jae     00007ff9`1f53b8d1
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f53b8d1
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       mov     r10d,dword ptr [rdi+8]
       cmp     r8d,r10d
       jae     00007ff9`1f53b8d1
       cmp     r9d,r10d
       jae     00007ff9`1f53b8d1
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vzeroupper
       add     rsp,58h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 261
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F559438h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     ecx,ecx
       xor     eax,eax
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       mov     r8d,dword ptr [rdx+8]
       mov     rcx,rdx
       mov     eax,8
M01_L01:
       lea     rdx,[rsp+70h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rdi,rdi
       jne     M01_L02
       xor     edi,edi
       xor     ecx,ecx
       xor     edx,edx
       jmp     M01_L03
M01_L02:
       mov     edx,dword ptr [rdi+8]
       mov     ecx,8
M01_L03:
       lea     rax,[rsp+58h]
       lea     r8,[rsp+28h]
       mov     qword ptr [r8],rdi
       mov     qword ptr [r8+8],rcx
       mov     dword ptr [r8+10h],edx
       mov     rcx,rax
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L04
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L05
M01_L04:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L05:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+0A0h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L13
M01_L06:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L14
       cmp     qword ptr [rsp+40h],0
       jne     M01_L07
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L08
M01_L07:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L08:
       cmp     eax,dword ptr [rsp+80h]
       jae     M01_L15
       cmp     qword ptr [rsp+70h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+78h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+70h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+70h]
       add     r9,8
       mov     r10,qword ptr [rsp+78h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+68h]
       jae     00007ff9`1f55b98b
       cmp     qword ptr [rsp+58h],0
       jne     M01_L11
       mov     r9,qword ptr [rsp+60h]
       add     r9,r8
       jmp     M01_L12
M01_L11:
       mov     r9,qword ptr [rsp+58h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+58h]
       add     r9,8
       mov     r10,qword ptr [rsp+60h]
       add     r9,r10
       add     r9,r8
M01_L12:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L06
M01_L13:
       mov     rax,rsi
       vzeroupper
       add     rsp,88h
       pop     rsi
       pop     rdi
       ret
M01_L14:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L15:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 449
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F569418h
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
       add     al,ch
       and     ebx,dword ptr [rbx+5E5F5Ch]
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+88h]
       lea     r9,[rsp+48h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+48h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       xor     ebp,ebp
       mov     ecx,dword ptr [rsp+98h]
       lea     r14d,[rcx-1]
       test    r14d,r14d
       jl      M01_L05
M01_L02:
       cmp     ebp,dword ptr [rsp+98h]
       jae     M01_L06
       cmp     qword ptr [rsp+88h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+90h]
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+88h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+88h]
       add     rcx,8
       mov     r8,qword ptr [rsp+90h]
       add     rcx,r8
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
M01_L04:
       mov     r12d,ebp
       shl     r12d,2
       cmp     r12d,dword ptr [rsi+8]
       jae     00007ff9`1f56b92b
       lea     r13d,[r12+3]
       cmp     r13d,dword ptr [rsi+8]
       jae     00007ff9`1f56b92b
       vmovupd ymm1,ymmword ptr [rsi+r12*8+10h]
       lea     rcx,[rsp+60h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+20h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+20h]
       call    System.Numerics.Vector`1[[System.Double, mscorlib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       cmp     r12d,dword ptr [rdi+8]
       jae     00007ff9`1f56b92b
       cmp     r13d,dword ptr [rdi+8]
       jae     00007ff9`1f56b92b
       vmovupd ymm0,ymmword ptr [rdi+r12*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+60h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r15],ymm1
       inc     ebp
       lea     eax,[r14+1]
       cmp     ebp,eax
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+0A0h]
       vzeroupper
       add     rsp,0B8h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r12
       pop     r13
       pop     r14
       pop     r15
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 335
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF91F569420h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    rdi,rdi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rdi+8]
       mov     rcx,rdi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+70h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L07
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L08
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r9d,eax
       shl     r9d,2
       mov     r10d,dword ptr [rsi+8]
       cmp     r9d,r10d
       jae     00007ff9`1f56b8e1
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f56b8e1
       vmovupd ymm1,ymmword ptr [rsi+r9*8+10h]
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L09
       cmp     qword ptr [rsp+40h],0
       jne     M01_L05
       mov     r9,qword ptr [rsp+48h]
       add     r9,r8
       jmp     M01_L06
M01_L05:
       mov     r9,qword ptr [rsp+40h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+40h]
       add     r9,8
       mov     r10,qword ptr [rsp+48h]
       add     r9,r10
       add     r9,r8
M01_L06:
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L07:
       mov     rax,rdi
       vzeroupper
       add     rsp,58h
       pop     rsi
       pop     rdi
       ret
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L09:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 301
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF90BAC3440h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     eax,ecx
       sar     eax,1Fh
       and     eax,3
       add     eax,ecx
       sar     eax,2
       mov     r10d,eax
       shl     r10d,2
       test    ecx,ecx
       jb      M01_L06
       cmp     ecx,r10d
       jb      M01_L06
       lea     rax,[rdx+10h]
       mov     r11d,r10d
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     M01_L05
       vbroadcastsd ymm1,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L01
       mov     ebx,dword ptr [r8+8]
       inc     edi
M01_L00:
       cmp     esi,r11d
       jae     00007ff9`0bac49f4
       movsxd  rbp,esi
       shl     rbp,5
       add     rbp,rax
       mov     r14d,esi
       shl     r14d,2
       cmp     r14d,ecx
       jae     00007ff9`0bac49f4
       lea     r15d,[r14+3]
       cmp     r15d,ecx
       jae     00007ff9`0bac49f4
       vmovupd ymm2,ymmword ptr [rdx+r14*8+10h]
       cmp     r14d,ebx
       jae     00007ff9`0bac49f4
       cmp     r15d,ebx
       jae     00007ff9`0bac49f4
       vmovupd ymm3,ymmword ptr [r8+r14*8+10h]
       vmulpd  ymm2,ymm1,ymm2
       vaddpd  ymm2,ymm2,ymm3
       vmovupd ymmword ptr [rbp],ymm2
       inc     esi
       cmp     esi,edi
       jne     M01_L00
M01_L01:
       mov     edi,r10d
       mov     eax,dword ptr [r9+8]
       cmp     eax,r10d
       jle     M01_L04
       test    r8,r8
       setne   r11b
       movzx   r11d,r11b
       test    r11b,1
       je      M01_L03
       cmp     eax,ecx
       setle   r10b
       movzx   r10d,r10b
       test    edi,edi
       setge   r11b
       movzx   r11d,r11b
       and     r10d,r11d
       mov     r11d,dword ptr [r8+8]
       cmp     r11d,eax
       setge   r11b
       movzx   r11d,r11b
       test    r11d,r10d
       je      M01_L03
M01_L02:
       movsxd  rcx,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+rcx*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+rcx*8+10h]
       vmovsd  qword ptr [r9+rcx*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L02
       jmp     M01_L04
M01_L03:
       cmp     edi,ecx
       jae     00007ff9`0bac49f4
       movsxd  r10,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r10*8+10h]
       mov     r11d,dword ptr [r8+8]
       cmp     edi,r11d
       jae     00007ff9`0bac49f4
       vaddsd  xmm1,xmm1,mmword ptr [r8+r10*8+10h]
       cmp     edi,eax
       jae     00007ff9`0bac49f4
       vmovsd  qword ptr [r9+r10*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L03
M01_L04:
       mov     rax,r9
       vzeroupper
       add     rsp,28h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       pop     r15
       ret
M01_L05:
       call    coreclr!GetCLRRuntimeHost+0x857e0
M01_L06:
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int     3
; Total bytes of code 389
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAD3458h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     r10d,dword ptr [rdx+8]
       mov     ecx,r10d
M01_L01:
       mov     r10d,ecx
       shl     r10,3
       mov     rcx,r10
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bad491a
       vbroadcastsd ymm0,xmm0
       xor     r11d,r11d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     esi,dword ptr [rdx+8]
       mov     edi,dword ptr [r8+8]
       inc     r10d
M01_L02:
       cmp     r11d,ecx
       jae     00007ff9`0bad4920
       movsxd  rbx,r11d
       shl     rbx,5
       add     rbx,rax
       mov     ebp,r11d
       shl     ebp,2
       cmp     ebp,esi
       jae     00007ff9`0bad4920
       lea     r14d,[rbp+3]
       cmp     r14d,esi
       jae     00007ff9`0bad4920
       vmovupd ymm1,ymmword ptr [rdx+rbp*8+10h]
       cmp     ebp,edi
       jae     00007ff9`0bad4920
       cmp     r14d,edi
       jae     00007ff9`0bad4920
       vmovupd ymm2,ymmword ptr [r8+rbp*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbx],ymm1
       inc     r11d
       cmp     r11d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r9
; Total bytes of code 159
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAD3468h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     ecx,dword ptr [rdx+8]
M01_L01:
       mov     edx,ecx
       shl     rdx,3
       shr     rdx,5
       test    rdx,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r10d,r10d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r10d,dword ptr [r8+8]
M01_L03:
       mov     r8d,r10d
       shl     r8,3
       shr     r8,5
       test    r8,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r9,r9
       jne     M01_L04
       xor     r10d,r10d
       xor     r11d,r11d
       jmp     M01_L05
M01_L04:
       lea     r10,[r9+10h]
       mov     r11d,dword ptr [r9+8]
M01_L05:
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       vbroadcastsd ymm0,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L07
       inc     edi
M01_L06:
       cmp     esi,r11d
       jae     00007ff9`0bad4954
       movsxd  rbx,esi
       shl     rbx,5
       lea     rbp,[r10+rbx]
       cmp     esi,edx
       jae     00007ff9`0bad4954
       lea     r14,[rax+rbx]
       vmovupd ymm1,ymmword ptr [r14]
       vmulpd  ymm1,ymm0,ymm1
       cmp     esi,r8d
       jae     00007ff9`0bad4954
       lea     r14,[rcx+rbx]
       vmovupd ymm2,ymmword ptr [r14]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbp],ymm1
       inc     esi
       cmp     esi,edi
       jne     M01_L06
M01_L07:
       mov     rax,r9
; Total bytes of code 211
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAC3448h
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
       add     al,ch
       shl     dword ptr [rbx+5E5FAEh],cl
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       lea     rcx,[rsi+10h]
       mov     eax,dword ptr [rsi+8]
       mov     r8d,eax
M01_L01:
       mov     rax,rcx
       mov     ecx,r8d
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bac499f
       mov     ebp,ecx
       mov     rcx,rax
       mov     rax,rcx
       mov     ecx,ebp
       mov     rbp,rax
       mov     r14d,ecx
       xor     r15d,r15d
       lea     r12d,[r14-1]
       test    r12d,r12d
       jl      M01_L03
M01_L02:
       cmp     r15d,r14d
       jae     00007ff9`0bac49a5
       movsxd  rcx,r15d
       shl     rcx,5
       lea     r13,[rcx+rbp]
       mov     eax,r15d
       shl     eax,2
       mov     ecx,dword ptr [rsi+8]
       cmp     eax,ecx
       jae     00007ff9`0bac49a5
       lea     edx,[rax+3]
       mov     dword ptr [rsp+2Ch],edx
       cmp     edx,ecx
       jae     00007ff9`0bac49a5
       mov     dword ptr [rsp+28h],eax
       vmovupd ymm1,ymmword ptr [rsi+rax*8+10h]
       lea     rcx,[rsp+50h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+30h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+30h]
       call    System.Numerics.Vector`1[[System.Double, System.Private.CoreLib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       mov     eax,dword ptr [rdi+8]
       mov     edx,dword ptr [rsp+28h]
       cmp     edx,eax
       jae     00007ff9`0bac49a5
       mov     ecx,dword ptr [rsp+2Ch]
       cmp     ecx,eax
       jae     00007ff9`0bac49a5
       vmovupd ymm0,ymmword ptr [rdi+rdx*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+50h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r13],ymm1
       inc     r15d
       lea     eax,[r12+1]
       cmp     r15d,eax
       jne     M01_L02
M01_L03:
       mov     rax,rbx
; Total bytes of code 240
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF90BB03450h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    r8,r8
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[r8+10h]
       mov     ecx,dword ptr [r8+8]
M01_L01:
       mov     ecx,ecx
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bb048fb
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`0bb04901
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`0bb04901
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`0bb04901
       vmovupd ymm1,ymmword ptr [rdx+rdi*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rsi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rsi],ymm1
       inc     r9d
       cmp     r9d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r8
; Total bytes of code 134
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF91F539410h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ebp,dword ptr [rsi+8]
       mov     ecx,ebp
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,ebp
       sar     ecx,2
       mov     r14d,ecx
       shl     r14d,2
       test    ebp,ebp
       jb      M01_L07
       cmp     ebp,r14d
       jb      M01_L07
       mov     ecx,r14d
       mov     rdx,rsi
       mov     eax,8
       lea     r8,[rsp+48h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rdx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],ecx
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vbroadcastsd ymm0,xmm6
       xor     eax,eax
       mov     ecx,dword ptr [rsp+58h]
       dec     ecx
       test    ecx,ecx
       jl      M01_L03
M01_L00:
       cmp     eax,dword ptr [rsp+58h]
       jae     M01_L08
       cmp     qword ptr [rsp+48h],0
       jne     M01_L01
       mov     rdx,qword ptr [rsp+50h]
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
       jmp     M01_L02
M01_L01:
       mov     rdx,qword ptr [rsp+48h]
       cmp     dword ptr [rdx],edx
       mov     rdx,qword ptr [rsp+48h]
       add     rdx,8
       mov     r8,qword ptr [rsp+50h]
       add     rdx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rdx,r8
M01_L02:
       mov     r8d,eax
       shl     r8d,2
       cmp     r8d,ebp
       jae     00007ff9`1f53baa9
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f53baa9
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       cmp     r8d,dword ptr [rdi+8]
       jae     00007ff9`1f53baa9
       cmp     r9d,dword ptr [rdi+8]
       jae     00007ff9`1f53baa9
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdx],ymm1
       inc     eax
       lea     edx,[rcx+1]
       cmp     eax,edx
       jne     M01_L00
M01_L03:
       mov     ecx,r14d
       mov     eax,dword ptr [rbx+8]
       cmp     eax,r14d
       jle     M01_L06
       test    rdi,rdi
       setne   dl
       movzx   edx,dl
       test    dl,1
       je      M01_L05
       cmp     ebp,eax
       setge   dl
       movzx   edx,dl
       test    ecx,ecx
       setge   r8b
       movzx   r8d,r8b
       and     edx,r8d
       cmp     dword ptr [rdi+8],eax
       setge   r8b
       movzx   r8d,r8b
       test    r8d,edx
       je      M01_L05
M01_L04:
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L04
       jmp     M01_L06
M01_L05:
       cmp     ecx,ebp
       jae     00007ff9`1f53baa9
       movsxd  rdx,ecx
       vmovaps xmm0,xmm6
       vmulsd  xmm0,xmm0,mmword ptr [rsi+rdx*8+10h]
       cmp     ecx,dword ptr [rdi+8]
       jae     00007ff9`1f53baa9
       vaddsd  xmm0,xmm0,mmword ptr [rdi+rdx*8+10h]
       cmp     ecx,eax
       jae     00007ff9`1f53baa9
       vmovsd  qword ptr [rbx+rdx*8+10h],xmm0
       inc     ecx
       cmp     eax,ecx
       jg      M01_L05
M01_L06:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+60h]
       vzeroupper
       add     rsp,70h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
M01_L07:
       mov     ecx,1
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 457
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F559428h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     ebp,dword ptr [rsi+8]
       mov     eax,ebp
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+80h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L05
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L06
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+40h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r8d,eax
       shl     r8d,2
       mov     ebp,dword ptr [rsi+8]
       cmp     r8d,ebp
       jae     00007ff9`1f55b8d1
       lea     r9d,[r8+3]
       cmp     r9d,ebp
       jae     00007ff9`1f55b8d1
       vmovupd ymm1,ymmword ptr [rsi+r8*8+10h]
       mov     r10d,dword ptr [rdi+8]
       cmp     r8d,r10d
       jae     00007ff9`1f55b8d1
       cmp     r9d,r10d
       jae     00007ff9`1f55b8d1
       vmovupd ymm2,ymmword ptr [rdi+r8*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vzeroupper
       add     rsp,58h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 261
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F579438h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     ecx,ecx
       xor     eax,eax
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       mov     r8d,dword ptr [rdx+8]
       mov     rcx,rdx
       mov     eax,8
M01_L01:
       lea     rdx,[rsp+70h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rdi,rdi
       jne     M01_L02
       xor     edi,edi
       xor     ecx,ecx
       xor     edx,edx
       jmp     M01_L03
M01_L02:
       mov     edx,dword ptr [rdi+8]
       mov     ecx,8
M01_L03:
       lea     rax,[rsp+58h]
       lea     r8,[rsp+28h]
       mov     qword ptr [r8],rdi
       mov     qword ptr [r8+8],rcx
       mov     dword ptr [r8+10h],edx
       mov     rcx,rax
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L04
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L05
M01_L04:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L05:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+28h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+28h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+0A0h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L13
M01_L06:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L14
       cmp     qword ptr [rsp+40h],0
       jne     M01_L07
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L08
M01_L07:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L08:
       cmp     eax,dword ptr [rsp+80h]
       jae     M01_L15
       cmp     qword ptr [rsp+70h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+78h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+70h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+70h]
       add     r9,8
       mov     r10,qword ptr [rsp+78h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+68h]
       jae     00007ff9`1f57b98b
       cmp     qword ptr [rsp+58h],0
       jne     M01_L11
       mov     r9,qword ptr [rsp+60h]
       add     r9,r8
       jmp     M01_L12
M01_L11:
       mov     r9,qword ptr [rsp+58h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+58h]
       add     r9,8
       mov     r10,qword ptr [rsp+60h]
       add     r9,r10
       add     r9,r8
M01_L12:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L06
M01_L13:
       mov     rax,rsi
       vzeroupper
       add     rsp,88h
       pop     rsi
       pop     rdi
       ret
M01_L14:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L15:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 449
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF91F569418h
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
       add     al,ch
       and     ebx,dword ptr [rbx+5E5F5Ch]
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+88h]
       lea     r9,[rsp+48h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+48h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       xor     ebp,ebp
       mov     ecx,dword ptr [rsp+98h]
       lea     r14d,[rcx-1]
       test    r14d,r14d
       jl      M01_L05
M01_L02:
       cmp     ebp,dword ptr [rsp+98h]
       jae     M01_L06
       cmp     qword ptr [rsp+88h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+90h]
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
       jmp     M01_L04
M01_L03:
       mov     rcx,qword ptr [rsp+88h]
       cmp     dword ptr [rcx],ecx
       mov     rcx,qword ptr [rsp+88h]
       add     rcx,8
       mov     r8,qword ptr [rsp+90h]
       add     rcx,r8
       movsxd  r8,ebp
       shl     r8,5
       lea     r15,[rcx+r8]
M01_L04:
       mov     r12d,ebp
       shl     r12d,2
       cmp     r12d,dword ptr [rsi+8]
       jae     00007ff9`1f56b92b
       lea     r13d,[r12+3]
       cmp     r13d,dword ptr [rsi+8]
       jae     00007ff9`1f56b92b
       vmovupd ymm1,ymmword ptr [rsi+r12*8+10h]
       lea     rcx,[rsp+60h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+20h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+20h]
       call    System.Numerics.Vector`1[[System.Double, mscorlib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       cmp     r12d,dword ptr [rdi+8]
       jae     00007ff9`1f56b92b
       cmp     r13d,dword ptr [rdi+8]
       jae     00007ff9`1f56b92b
       vmovupd ymm0,ymmword ptr [rdi+r12*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+60h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r15],ymm1
       inc     ebp
       lea     eax,[r14+1]
       cmp     ebp,eax
       jne     M01_L02
M01_L05:
       mov     rax,rbx
       vmovaps xmm6,xmmword ptr [rsp+0A0h]
       vzeroupper
       add     rsp,0B8h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r12
       pop     r13
       pop     r14
       pop     r15
       ret
M01_L06:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 335
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF91F549420h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    rdi,rdi
       jne     M01_L00
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L01
M01_L00:
       mov     eax,dword ptr [rdi+8]
       mov     rcx,rdi
       mov     edx,8
M01_L01:
       lea     r8,[rsp+40h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rdx
       mov     dword ptr [r9+10h],eax
       mov     rcx,r8
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       vmovsd  xmm0,qword ptr [rsp+70h]
       vbroadcastsd ymm0,xmm0
       xor     eax,eax
       mov     edx,dword ptr [rsp+50h]
       dec     edx
       test    edx,edx
       jl      M01_L07
M01_L02:
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L08
       cmp     qword ptr [rsp+40h],0
       jne     M01_L03
       mov     rcx,qword ptr [rsp+48h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L04
M01_L03:
       mov     r8,qword ptr [rsp+40h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+40h]
       add     rcx,8
       mov     r8,qword ptr [rsp+48h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L04:
       mov     r9d,eax
       shl     r9d,2
       mov     r10d,dword ptr [rsi+8]
       cmp     r9d,r10d
       jae     00007ff9`1f54b8e1
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f54b8e1
       vmovupd ymm1,ymmword ptr [rsi+r9*8+10h]
       cmp     eax,dword ptr [rsp+50h]
       jae     M01_L09
       cmp     qword ptr [rsp+40h],0
       jne     M01_L05
       mov     r9,qword ptr [rsp+48h]
       add     r9,r8
       jmp     M01_L06
M01_L05:
       mov     r9,qword ptr [rsp+40h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+40h]
       add     r9,8
       mov     r10,qword ptr [rsp+48h]
       add     r9,r10
       add     r9,r8
M01_L06:
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L02
M01_L07:
       mov     rax,rdi
       vzeroupper
       add     rsp,58h
       pop     rsi
       pop     rdi
       ret
M01_L08:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L09:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
       int     3
; Total bytes of code 301
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.NotAlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     r9,qword ptr [rcx+18h]
       mov     rax,7FF90BAD3440h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorNotAlignedOut(Double, Double[], Double[], Double[])
       mov     ecx,dword ptr [rdx+8]
       mov     eax,ecx
       sar     eax,1Fh
       and     eax,3
       add     eax,ecx
       sar     eax,2
       mov     r10d,eax
       shl     r10d,2
       test    ecx,ecx
       jb      M01_L06
       cmp     ecx,r10d
       jb      M01_L06
       lea     rax,[rdx+10h]
       mov     r11d,r10d
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     M01_L05
       vbroadcastsd ymm1,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L01
       mov     ebx,dword ptr [r8+8]
       inc     edi
M01_L00:
       cmp     esi,r11d
       jae     00007ff9`0bad49f4
       movsxd  rbp,esi
       shl     rbp,5
       add     rbp,rax
       mov     r14d,esi
       shl     r14d,2
       cmp     r14d,ecx
       jae     00007ff9`0bad49f4
       lea     r15d,[r14+3]
       cmp     r15d,ecx
       jae     00007ff9`0bad49f4
       vmovupd ymm2,ymmword ptr [rdx+r14*8+10h]
       cmp     r14d,ebx
       jae     00007ff9`0bad49f4
       cmp     r15d,ebx
       jae     00007ff9`0bad49f4
       vmovupd ymm3,ymmword ptr [r8+r14*8+10h]
       vmulpd  ymm2,ymm1,ymm2
       vaddpd  ymm2,ymm2,ymm3
       vmovupd ymmword ptr [rbp],ymm2
       inc     esi
       cmp     esi,edi
       jne     M01_L00
M01_L01:
       mov     edi,r10d
       mov     eax,dword ptr [r9+8]
       cmp     eax,r10d
       jle     M01_L04
       test    r8,r8
       setne   r11b
       movzx   r11d,r11b
       test    r11b,1
       je      M01_L03
       cmp     eax,ecx
       setle   r10b
       movzx   r10d,r10b
       test    edi,edi
       setge   r11b
       movzx   r11d,r11b
       and     r10d,r11d
       mov     r11d,dword ptr [r8+8]
       cmp     r11d,eax
       setge   r11b
       movzx   r11d,r11b
       test    r11d,r10d
       je      M01_L03
M01_L02:
       movsxd  rcx,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+rcx*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+rcx*8+10h]
       vmovsd  qword ptr [r9+rcx*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L02
       jmp     M01_L04
M01_L03:
       cmp     edi,ecx
       jae     00007ff9`0bad49f4
       movsxd  r10,edi
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r10*8+10h]
       mov     r11d,dword ptr [r8+8]
       cmp     edi,r11d
       jae     00007ff9`0bad49f4
       vaddsd  xmm1,xmm1,mmword ptr [r8+r10*8+10h]
       cmp     edi,eax
       jae     00007ff9`0bad49f4
       vmovsd  qword ptr [r9+r10*8+10h],xmm1
       inc     edi
       cmp     eax,edi
       jg      M01_L03
M01_L04:
       mov     rax,r9
       vzeroupper
       add     rsp,28h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       pop     r15
       ret
M01_L05:
       call    coreclr!GetCLRRuntimeHost+0x857e0
M01_L06:
       call    System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int     3
; Total bytes of code 389
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAE3458h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     r10d,dword ptr [rdx+8]
       mov     ecx,r10d
M01_L01:
       mov     r10d,ecx
       shl     r10,3
       mov     rcx,r10
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bae491a
       vbroadcastsd ymm0,xmm0
       xor     r11d,r11d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     esi,dword ptr [rdx+8]
       mov     edi,dword ptr [r8+8]
       inc     r10d
M01_L02:
       cmp     r11d,ecx
       jae     00007ff9`0bae4920
       movsxd  rbx,r11d
       shl     rbx,5
       add     rbx,rax
       mov     ebp,r11d
       shl     ebp,2
       cmp     ebp,esi
       jae     00007ff9`0bae4920
       lea     r14d,[rbp+3]
       cmp     r14d,esi
       jae     00007ff9`0bae4920
       vmovupd ymm1,ymmword ptr [rdx+rbp*8+10h]
       cmp     ebp,edi
       jae     00007ff9`0bae4920
       cmp     r14d,edi
       jae     00007ff9`0bae4920
       vmovupd ymm2,ymmword ptr [r8+rbp*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbx],ymm1
       inc     r11d
       cmp     r11d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r9
; Total bytes of code 159
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.SpansOut()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAD3468h
; Total bytes of code 28
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansOut(Double, Double[], Double[], Double[])
       test    rdx,rdx
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[rdx+10h]
       mov     ecx,dword ptr [rdx+8]
M01_L01:
       mov     edx,ecx
       shl     rdx,3
       shr     rdx,5
       test    rdx,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r10d,r10d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r10d,dword ptr [r8+8]
M01_L03:
       mov     r8d,r10d
       shl     r8,3
       shr     r8,5
       test    r8,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       test    r9,r9
       jne     M01_L04
       xor     r10d,r10d
       xor     r11d,r11d
       jmp     M01_L05
M01_L04:
       lea     r10,[r9+10h]
       mov     r11d,dword ptr [r9+8]
M01_L05:
       mov     r11d,r11d
       shl     r11,3
       shr     r11,5
       test    r11,0FFFFFFFF80000000h
       jne     00007ff9`0bad494e
       vbroadcastsd ymm0,xmm0
       xor     esi,esi
       lea     edi,[r11-1]
       test    edi,edi
       jl      M01_L07
       inc     edi
M01_L06:
       cmp     esi,r11d
       jae     00007ff9`0bad4954
       movsxd  rbx,esi
       shl     rbx,5
       lea     rbp,[r10+rbx]
       cmp     esi,edx
       jae     00007ff9`0bad4954
       lea     r14,[rax+rbx]
       vmovupd ymm1,ymmword ptr [r14]
       vmulpd  ymm1,ymm0,ymm1
       cmp     esi,r8d
       jae     00007ff9`0bad4954
       lea     r14,[rcx+rbx]
       vmovupd ymm2,ymmword ptr [r14]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rbp],ymm1
       inc     esi
       cmp     esi,edi
       jne     M01_L06
M01_L07:
       mov     rax,r9
; Total bytes of code 211
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.ScalarOut()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     r9,qword ptr [rcx+30h]
       mov     rax,7FF90BAD3448h
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
       add     al,ch
       shl     dword ptr [rbx+5E5FADh],cl
; Total bytes of code 63
```
```assembly
; VectorsBmk.MultiplyAdd.vectorScalarOut(Double, Double[], Double[], Double[])
       test    rsi,rsi
       jne     M01_L00
       xor     ecx,ecx
       xor     r8d,r8d
       jmp     M01_L01
M01_L00:
       lea     rcx,[rsi+10h]
       mov     eax,dword ptr [rsi+8]
       mov     r8d,eax
M01_L01:
       mov     rax,rcx
       mov     ecx,r8d
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bad499f
       mov     ebp,ecx
       mov     rcx,rax
       mov     rax,rcx
       mov     ecx,ebp
       mov     rbp,rax
       mov     r14d,ecx
       xor     r15d,r15d
       lea     r12d,[r14-1]
       test    r12d,r12d
       jl      M01_L03
M01_L02:
       cmp     r15d,r14d
       jae     00007ff9`0bad49a5
       movsxd  rcx,r15d
       shl     rcx,5
       lea     r13,[rcx+rbp]
       mov     eax,r15d
       shl     eax,2
       mov     ecx,dword ptr [rsi+8]
       cmp     eax,ecx
       jae     00007ff9`0bad49a5
       lea     edx,[rax+3]
       mov     dword ptr [rsp+2Ch],edx
       cmp     edx,ecx
       jae     00007ff9`0bad49a5
       mov     dword ptr [rsp+28h],eax
       vmovupd ymm1,ymmword ptr [rsi+rax*8+10h]
       lea     rcx,[rsp+50h]
       vmovaps xmm0,xmm6
       vmovupd ymmword ptr [rsp+30h],ymm1
       vmovaps xmm1,xmm0
       lea     r8,[rsp+30h]
       call    System.Numerics.Vector`1[[System.Double, System.Private.CoreLib]].op_Multiply(Double, System.Numerics.Vector`1<Double>)
       mov     eax,dword ptr [rdi+8]
       mov     edx,dword ptr [rsp+28h]
       cmp     edx,eax
       jae     00007ff9`0bad49a5
       mov     ecx,dword ptr [rsp+2Ch]
       cmp     ecx,eax
       jae     00007ff9`0bad49a5
       vmovupd ymm0,ymmword ptr [rdi+rdx*8+10h]
       vmovupd ymm1,ymmword ptr [rsp+50h]
       vaddpd  ymm1,ymm1,ymm0
       vmovupd ymmword ptr [r13],ymm1
       inc     r15d
       lea     eax,[r12+1]
       cmp     r15d,eax
       jne     M01_L02
M01_L03:
       mov     rax,rbx
; Total bytes of code 240
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddVectorMiniBmk.AlignedIn()
       vmovsd  xmm0,qword ptr [rcx+38h]
       mov     rdx,qword ptr [rcx+20h]
       mov     r8,qword ptr [rcx+28h]
       mov     rax,7FF90BAE3450h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorIn(Double, Double[], Double[])
       test    r8,r8
       jne     M01_L00
       xor     eax,eax
       xor     ecx,ecx
       jmp     M01_L01
M01_L00:
       lea     rax,[r8+10h]
       mov     ecx,dword ptr [r8+8]
M01_L01:
       mov     ecx,ecx
       shl     rcx,3
       shr     rcx,5
       test    rcx,0FFFFFFFF80000000h
       jne     00007ff9`0bae48fb
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`0bae4901
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`0bae4901
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`0bae4901
       vmovupd ymm1,ymmword ptr [rdx+rdi*8+10h]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rsi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rsi],ymm1
       inc     r9d
       cmp     r9d,r10d
       jne     M01_L02
M01_L03:
       mov     rax,r8
; Total bytes of code 134
```

