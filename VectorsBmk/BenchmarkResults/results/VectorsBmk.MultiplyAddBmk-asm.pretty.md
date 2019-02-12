## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F579720h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax-6E0921Dh],dl
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`1f57aadb
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`1f57ab1c
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F579740h
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
       jae     00007ff9`1f57b931
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f57b931
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F559750h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       lea     rdx,[rsp+50h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L02
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L03
M01_L02:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L03:
       lea     r8,[rsp+38h]
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
       mov     edx,dword ptr [rsp+48h]
       dec     edx
       test    edx,edx
       jl      M01_L11
M01_L04:
       cmp     eax,dword ptr [rsp+48h]
       jae     M01_L12
       cmp     qword ptr [rsp+38h],0
       jne     M01_L05
       mov     rcx,qword ptr [rsp+40h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L06
M01_L05:
       mov     r8,qword ptr [rsp+38h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+38h]
       add     rcx,8
       mov     r8,qword ptr [rsp+40h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L06:
       cmp     eax,dword ptr [rsp+60h]
       jae     M01_L13
       cmp     qword ptr [rsp+50h],0
       jne     M01_L07
       mov     r9,qword ptr [rsp+58h]
       add     r9,r8
       jmp     M01_L08
M01_L07:
       mov     r9,qword ptr [rsp+50h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+50h]
       add     r9,8
       mov     r10,qword ptr [rsp+58h]
       add     r9,r10
       add     r9,r8
M01_L08:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+48h]
       jae     00007ff9`1f55b988
       cmp     qword ptr [rsp+38h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+40h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+38h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+38h]
       add     r9,8
       mov     r10,qword ptr [rsp+40h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L04
M01_L11:
       mov     rax,rsi
       vzeroupper
       add     rsp,68h
       pop     rsi
       pop     rdi
       ret
M01_L12:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L13:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 388
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF900883510h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],bl
       cmc
       mov     byte ptr [EC834800007FF900h],al
       sub     ch,al
       clc
       ja      00007ff9`0088449b
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`008844dc
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008B3530h
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
       jne     00007ff9`008b490b
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`008b4911
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`008b4911
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`008b4911
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF900883540h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       jne     00007ff9`00884924
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r9d,r9d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r9d,dword ptr [r8+8]
M01_L03:
       mov     r9d,r9d
       shl     r9,3
       shr     r9,5
       test    r9,0FFFFFFFF80000000h
       jne     00007ff9`00884924
       vbroadcastsd ymm0,xmm0
       xor     r10d,r10d
       lea     r11d,[r9-1]
       test    r11d,r11d
       jl      M01_L05
       inc     r11d
M01_L04:
       cmp     r10d,r9d
       jae     00007ff9`0088492a
       movsxd  rsi,r10d
       shl     rsi,5
       lea     rdi,[rcx+rsi]
       cmp     r10d,edx
       jae     00007ff9`0088492a
       add     rsi,rax
       vmovupd ymm1,ymmword ptr [rsi]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rdi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdi],ymm1
       inc     r10d
       cmp     r10d,r11d
       jne     M01_L04
M01_L05:
       mov     rax,r8
; Total bytes of code 161
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F539720h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax-6E0961Dh],dl
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`1f53aadb
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`1f53ab1c
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F539740h
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
       jae     00007ff9`1f53b931
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f53b931
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F559750h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       lea     rdx,[rsp+50h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L02
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L03
M01_L02:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L03:
       lea     r8,[rsp+38h]
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
       mov     edx,dword ptr [rsp+48h]
       dec     edx
       test    edx,edx
       jl      M01_L11
M01_L04:
       cmp     eax,dword ptr [rsp+48h]
       jae     M01_L12
       cmp     qword ptr [rsp+38h],0
       jne     M01_L05
       mov     rcx,qword ptr [rsp+40h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L06
M01_L05:
       mov     r8,qword ptr [rsp+38h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+38h]
       add     rcx,8
       mov     r8,qword ptr [rsp+40h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L06:
       cmp     eax,dword ptr [rsp+60h]
       jae     M01_L13
       cmp     qword ptr [rsp+50h],0
       jne     M01_L07
       mov     r9,qword ptr [rsp+58h]
       add     r9,r8
       jmp     M01_L08
M01_L07:
       mov     r9,qword ptr [rsp+50h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+50h]
       add     r9,8
       mov     r10,qword ptr [rsp+58h]
       add     r9,r10
       add     r9,r8
M01_L08:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+48h]
       jae     00007ff9`1f55b988
       cmp     qword ptr [rsp+38h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+40h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+38h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+38h]
       add     r9,8
       mov     r10,qword ptr [rsp+40h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L04
M01_L11:
       mov     rax,rsi
       vzeroupper
       add     rsp,68h
       pop     rsi
       pop     rdi
       ret
M01_L12:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L13:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 388
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008A3510h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],bl
       cmc
       movs    byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`008a449b
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`008a44dc
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008C3530h
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
       jne     00007ff9`008c490b
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`008c4911
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`008c4911
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`008c4911
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008C3540h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       jne     00007ff9`008c4924
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r9d,r9d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r9d,dword ptr [r8+8]
M01_L03:
       mov     r9d,r9d
       shl     r9,3
       shr     r9,5
       test    r9,0FFFFFFFF80000000h
       jne     00007ff9`008c4924
       vbroadcastsd ymm0,xmm0
       xor     r10d,r10d
       lea     r11d,[r9-1]
       test    r11d,r11d
       jl      M01_L05
       inc     r11d
M01_L04:
       cmp     r10d,r9d
       jae     00007ff9`008c492a
       movsxd  rsi,r10d
       shl     rsi,5
       lea     rdi,[rcx+rsi]
       cmp     r10d,edx
       jae     00007ff9`008c492a
       add     rsi,rax
       vmovupd ymm1,ymmword ptr [rsi]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rdi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdi],ymm1
       inc     r10d
       cmp     r10d,r11d
       jne     M01_L04
M01_L05:
       mov     rax,r8
; Total bytes of code 161
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F569720h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax-6E0931Dh],dl
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`1f56aadb
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`1f56ab1c
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F539740h
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
       jae     00007ff9`1f53b931
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f53b931
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549750h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       lea     rdx,[rsp+50h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L02
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L03
M01_L02:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L03:
       lea     r8,[rsp+38h]
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
       mov     edx,dword ptr [rsp+48h]
       dec     edx
       test    edx,edx
       jl      M01_L11
M01_L04:
       cmp     eax,dword ptr [rsp+48h]
       jae     M01_L12
       cmp     qword ptr [rsp+38h],0
       jne     M01_L05
       mov     rcx,qword ptr [rsp+40h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L06
M01_L05:
       mov     r8,qword ptr [rsp+38h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+38h]
       add     rcx,8
       mov     r8,qword ptr [rsp+40h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L06:
       cmp     eax,dword ptr [rsp+60h]
       jae     M01_L13
       cmp     qword ptr [rsp+50h],0
       jne     M01_L07
       mov     r9,qword ptr [rsp+58h]
       add     r9,r8
       jmp     M01_L08
M01_L07:
       mov     r9,qword ptr [rsp+50h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+50h]
       add     r9,8
       mov     r10,qword ptr [rsp+58h]
       add     r9,r10
       add     r9,r8
M01_L08:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+48h]
       jae     00007ff9`1f54b988
       cmp     qword ptr [rsp+38h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+40h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+38h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+38h]
       add     r9,8
       mov     r10,qword ptr [rsp+40h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L04
M01_L11:
       mov     rax,rsi
       vzeroupper
       add     rsp,68h
       pop     rsi
       pop     rdi
       ret
M01_L12:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L13:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 388
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008A3510h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],bl
       cmc
       movs    byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`008a449b
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`008a44dc
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008B3530h
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
       jne     00007ff9`008b490b
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`008b4911
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`008b4911
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`008b4911
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF900893540h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       jne     00007ff9`00894924
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r9d,r9d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r9d,dword ptr [r8+8]
M01_L03:
       mov     r9d,r9d
       shl     r9,3
       shr     r9,5
       test    r9,0FFFFFFFF80000000h
       jne     00007ff9`00894924
       vbroadcastsd ymm0,xmm0
       xor     r10d,r10d
       lea     r11d,[r9-1]
       test    r11d,r11d
       jl      M01_L05
       inc     r11d
M01_L04:
       cmp     r10d,r9d
       jae     00007ff9`0089492a
       movsxd  rsi,r10d
       shl     rsi,5
       lea     rdi,[rcx+rsi]
       cmp     r10d,edx
       jae     00007ff9`0089492a
       add     rsi,rax
       vmovupd ymm1,ymmword ptr [rsi]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rdi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdi],ymm1
       inc     r10d
       cmp     r10d,r11d
       jne     M01_L04
M01_L05:
       mov     rax,r8
; Total bytes of code 161
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549720h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax-6E0951Dh],dl
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`1f54aadb
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`1f54ab1c
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549740h
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
       jae     00007ff9`1f54b931
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f54b931
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549750h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       lea     rdx,[rsp+50h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L02
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L03
M01_L02:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L03:
       lea     r8,[rsp+38h]
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
       mov     edx,dword ptr [rsp+48h]
       dec     edx
       test    edx,edx
       jl      M01_L11
M01_L04:
       cmp     eax,dword ptr [rsp+48h]
       jae     M01_L12
       cmp     qword ptr [rsp+38h],0
       jne     M01_L05
       mov     rcx,qword ptr [rsp+40h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L06
M01_L05:
       mov     r8,qword ptr [rsp+38h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+38h]
       add     rcx,8
       mov     r8,qword ptr [rsp+40h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L06:
       cmp     eax,dword ptr [rsp+60h]
       jae     M01_L13
       cmp     qword ptr [rsp+50h],0
       jne     M01_L07
       mov     r9,qword ptr [rsp+58h]
       add     r9,r8
       jmp     M01_L08
M01_L07:
       mov     r9,qword ptr [rsp+50h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+50h]
       add     r9,8
       mov     r10,qword ptr [rsp+58h]
       add     r9,r10
       add     r9,r8
M01_L08:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+48h]
       jae     00007ff9`1f54b988
       cmp     qword ptr [rsp+38h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+40h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+38h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+38h]
       add     r9,8
       mov     r10,qword ptr [rsp+40h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L04
M01_L11:
       mov     rax,rsi
       vzeroupper
       add     rsp,68h
       pop     rsi
       pop     rdi
       ret
M01_L12:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L13:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 388
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008A3510h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],bl
       cmc
       movs    byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`008a449b
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`008a44dc
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008A3530h
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
       jne     00007ff9`008a490b
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`008a4911
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`008a4911
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`008a4911
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF900893540h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       jne     00007ff9`00894924
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r9d,r9d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r9d,dword ptr [r8+8]
M01_L03:
       mov     r9d,r9d
       shl     r9,3
       shr     r9,5
       test    r9,0FFFFFFFF80000000h
       jne     00007ff9`00894924
       vbroadcastsd ymm0,xmm0
       xor     r10d,r10d
       lea     r11d,[r9-1]
       test    r11d,r11d
       jl      M01_L05
       inc     r11d
M01_L04:
       cmp     r10d,r9d
       jae     00007ff9`0089492a
       movsxd  rsi,r10d
       shl     rsi,5
       lea     rdi,[rcx+rsi]
       cmp     r10d,edx
       jae     00007ff9`0089492a
       add     rsi,rax
       vmovupd ymm1,ymmword ptr [rsi]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rdi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdi],ymm1
       inc     r10d
       cmp     r10d,r11d
       jne     M01_L04
M01_L05:
       mov     rax,r8
; Total bytes of code 161
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F579720h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax-6E0921Dh],dl
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`1f57aadb
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`1f57ab1c
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549740h
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
       jae     00007ff9`1f54b931
       lea     r11d,[r9+3]
       cmp     r11d,r10d
       jae     00007ff9`1f54b931
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

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF91F549750h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       lea     rdx,[rsp+50h]
       lea     r9,[rsp+20h]
       mov     qword ptr [r9],rcx
       mov     qword ptr [r9+8],rax
       mov     dword ptr [r9+10h],r8d
       mov     rcx,rdx
       lea     rdx,[rsp+20h]
       call    System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Double, mscorlib],[System.Numerics.Vector`1[[System.Double, mscorlib]], System.Numerics.Vectors]](System.Span`1<Double>)
       test    rsi,rsi
       jne     M01_L02
       xor     ecx,ecx
       xor     edx,edx
       xor     eax,eax
       jmp     M01_L03
M01_L02:
       mov     eax,dword ptr [rsi+8]
       mov     rcx,rsi
       mov     edx,8
M01_L03:
       lea     r8,[rsp+38h]
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
       mov     edx,dword ptr [rsp+48h]
       dec     edx
       test    edx,edx
       jl      M01_L11
M01_L04:
       cmp     eax,dword ptr [rsp+48h]
       jae     M01_L12
       cmp     qword ptr [rsp+38h],0
       jne     M01_L05
       mov     rcx,qword ptr [rsp+40h]
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
       jmp     M01_L06
M01_L05:
       mov     r8,qword ptr [rsp+38h]
       cmp     dword ptr [r8],r8d
       mov     rcx,qword ptr [rsp+38h]
       add     rcx,8
       mov     r8,qword ptr [rsp+40h]
       add     rcx,r8
       movsxd  r8,eax
       shl     r8,5
       add     rcx,r8
M01_L06:
       cmp     eax,dword ptr [rsp+60h]
       jae     M01_L13
       cmp     qword ptr [rsp+50h],0
       jne     M01_L07
       mov     r9,qword ptr [rsp+58h]
       add     r9,r8
       jmp     M01_L08
M01_L07:
       mov     r9,qword ptr [rsp+50h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+50h]
       add     r9,8
       mov     r10,qword ptr [rsp+58h]
       add     r9,r10
       add     r9,r8
M01_L08:
       vmovupd ymm1,ymmword ptr [r9]
       vmulpd  ymm1,ymm0,ymm1
       cmp     eax,dword ptr [rsp+48h]
       jae     00007ff9`1f54b988
       cmp     qword ptr [rsp+38h],0
       jne     M01_L09
       mov     r9,qword ptr [rsp+40h]
       add     r9,r8
       jmp     M01_L10
M01_L09:
       mov     r9,qword ptr [rsp+38h]
       cmp     dword ptr [r9],r9d
       mov     r9,qword ptr [rsp+38h]
       add     r9,8
       mov     r10,qword ptr [rsp+40h]
       add     r9,r10
       add     r9,r8
M01_L10:
       vmovupd ymm2,ymmword ptr [r9]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rcx],ymm1
       inc     eax
       lea     ecx,[rdx+1]
       cmp     eax,ecx
       jne     M01_L04
M01_L11:
       mov     rax,rsi
       vzeroupper
       add     rsp,68h
       pop     rsi
       pop     rdi
       ret
M01_L12:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
M01_L13:
       call    System.ThrowHelper.ThrowIndexOutOfRangeException()
; Total bytes of code 388
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.For()
       vzeroupper
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008A3510h
       jmp     rax
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],bl
       cmc
       movs    byte ptr [rdi],byte ptr [rsi]
       add     cl,bh
       jg      M00_L00
M00_L00:
       add     byte ptr [rax-7Dh],cl
       in      al,dx
       sub     ch,al
       clc
       ja      00007ff9`008a449b
       rol     byte ptr [rcx-75h],48h
; Total bytes of code 60
```
```assembly
; VectorsBmk.MultiplyAdd.forIn(Double, Double[], Double[])
       xor     eax,eax
       mov     ecx,dword ptr [r8+8]
       test    ecx,ecx
       jle     M01_L02
       test    rdx,rdx
       setne   r9b
       movzx   r9d,r9b
       test    r9b,1
       je      M01_L01
       cmp     dword ptr [rdx+8],ecx
       jl      M01_L01
M01_L00:
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L00
       jmp     M01_L02
M01_L01:
       cmp     eax,dword ptr [rdx+8]
       jae     00007ff9`008a44dc
       movsxd  r9,eax
       vmovaps xmm1,xmm0
       vmulsd  xmm1,xmm1,mmword ptr [rdx+r9*8+10h]
       vaddsd  xmm1,xmm1,mmword ptr [r8+r9*8+10h]
       vmovsd  qword ptr [r8+r9*8+10h],xmm1
       inc     eax
       cmp     ecx,eax
       jg      M01_L01
M01_L02:
       mov     rax,r8
; Total bytes of code 112
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Vector()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008C3530h
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
       jne     00007ff9`008c490b
       vbroadcastsd ymm0,xmm0
       xor     r9d,r9d
       lea     r10d,[rcx-1]
       test    r10d,r10d
       jl      M01_L03
       mov     r11d,dword ptr [rdx+8]
       inc     r10d
M01_L02:
       cmp     r9d,ecx
       jae     00007ff9`008c4911
       movsxd  rsi,r9d
       shl     rsi,5
       add     rsi,rax
       mov     edi,r9d
       shl     edi,2
       cmp     edi,r11d
       jae     00007ff9`008c4911
       lea     ebx,[rdi+3]
       cmp     ebx,r11d
       jae     00007ff9`008c4911
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

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.VectorSpans()
       vmovsd  xmm0,qword ptr [rcx+20h]
       mov     rdx,qword ptr [rcx+8]
       mov     r8,qword ptr [rcx+10h]
       mov     rax,7FF9008C3540h
; Total bytes of code 24
```
```assembly
; VectorsBmk.MultiplyAdd.vectorSpansIn(Double, Double[], Double[])
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
       jne     00007ff9`008c4924
       test    r8,r8
       jne     M01_L02
       xor     ecx,ecx
       xor     r9d,r9d
       jmp     M01_L03
M01_L02:
       lea     rcx,[r8+10h]
       mov     r9d,dword ptr [r8+8]
M01_L03:
       mov     r9d,r9d
       shl     r9,3
       shr     r9,5
       test    r9,0FFFFFFFF80000000h
       jne     00007ff9`008c4924
       vbroadcastsd ymm0,xmm0
       xor     r10d,r10d
       lea     r11d,[r9-1]
       test    r11d,r11d
       jl      M01_L05
       inc     r11d
M01_L04:
       cmp     r10d,r9d
       jae     00007ff9`008c492a
       movsxd  rsi,r10d
       shl     rsi,5
       lea     rdi,[rcx+rsi]
       cmp     r10d,edx
       jae     00007ff9`008c492a
       add     rsi,rax
       vmovupd ymm1,ymmword ptr [rsi]
       vmulpd  ymm1,ymm0,ymm1
       vmovupd ymm2,ymmword ptr [rdi]
       vaddpd  ymm1,ymm1,ymm2
       vmovupd ymmword ptr [rdi],ymm1
       inc     r10d
       cmp     r10d,r11d
       jne     M01_L04
M01_L05:
       mov     rax,r8
; Total bytes of code 161
```

## .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT
```assembly
; VectorsBmk.MultiplyAddBmk.Axpy()
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

