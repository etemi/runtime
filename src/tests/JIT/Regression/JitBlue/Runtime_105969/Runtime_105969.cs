// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using Xunit;

// Generated by Fuzzlyn v2.2 on 2024-08-04 15:50:11
// Run on X64 Linux
// Seed: 9513455124659677293-vectort,vector128,vector256,vector512,x86aes,x86avx,x86avx2,x86avx512bw,x86avx512bwvl,x86avx512cd,x86avx512cdvl,x86avx512dq,x86avx512dqvl,x86avx512f,x86avx512fvl,x86avx512fx64,x86avx512vbmi,x86avx512vbmivl,x86bmi1,x86bmi1x64,x86bmi2,x86bmi2x64,x86fma,x86lzcnt,x86lzcntx64,x86pclmulqdq,x86popcnt,x86popcntx64,x86sse,x86ssex64,x86sse2,x86sse2x64,x86sse3,x86sse41,x86sse41x64,x86sse42,x86sse42x64,x86ssse3,x86x86base
// Reduced from 26.0 KiB to 1.1 KiB in 00:00:56
// Debug: Outputs <0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0>
// Release: Outputs <0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0>

public class Runtime_105969
{
    public static byte s_5;

    [Fact]
    public static void TestEntryPoint()
    {
        if (Avx512BW.IsSupported)
        {
            var vr16 = Vector512.CreateScalar(s_5);
            var vr17 = Vector512.Create<byte>(1);
            var vr18 = (byte)0;
            var vr19 = Vector512.CreateScalar(vr18);
            var vr20 = Vector128.Create<byte>(0);
            var vr21 = Avx512BW.BroadcastScalarToVector512(vr20);
            var vr22 = Vector256.Create<byte>(1);
            var vr23 = Avx512F.InsertVector256(vr21, vr22, 0);
            var vr24 = Vector512.Create(249, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0);
            var vr25 = Avx512BW.BlendVariable(vr19, vr23, vr24); 
            var vr26 = Avx512BW.Min(vr17, vr25);
            Vector512<byte> vr27 = Avx512BW.UnpackLow(vr16, vr26);
            Vector512<byte> expected = Vector512.Create(0, (byte)1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Assert.Equal(expected, vr27);
        }
    }
}
