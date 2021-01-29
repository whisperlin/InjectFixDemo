/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Brfalse,
        Callvirtvirt,
        Ldelem_R8,
        Ldtype, // custom
        Ldc_R8,
        Refanytype,
        And,
        Conv_U2,
        Conv_U,
        Ldvirtftn2,
        Ldloca,
        Ldfld,
        Ldind_R8,
        Ckfinite,
        Conv_I8,
        Conv_Ovf_U1_Un,
        Stind_I2,
        Mul_Ovf,
        Shr,
        Conv_Ovf_U4_Un,
        Refanyval,
        Break,
        Ldvirtftn,
        Conv_Ovf_U2,
        Ldind_I1,
        Bne_Un,
        Pop,
        Conv_Ovf_U8,
        Conv_Ovf_U4,
        Neg,
        Ldind_I8,
        Ldarga,
        Cpblk,
        Conv_I4,
        Stind_I8,
        Ldsfld,
        Unbox,
        Conv_U8,
        Leave,
        Conv_U1,
        //Calli,
        Ldind_I2,
        Conv_I1,
        Ldarg,
        Conv_Ovf_I2,
        Ldtoken,
        Conv_Ovf_I4,
        Shl,
        Brtrue,
        Stelem_Ref,
        Mul_Ovf_Un,
        Ldelem_Any,
        Rem_Un,
        Stind_I1,
        Stelem_I8,
        Conv_Ovf_U8_Un,
        Conv_U4,
        Conv_Ovf_U2_Un,
        Throw,
        Rethrow,
        Clt,
        Conv_R8,
        Ldind_U2,
        Switch,
        Stobj,
        Conv_Ovf_U_Un,
        Localloc,
        Volatile,
        Ldind_I,
        Add,
        Clt_Un,
        Endfilter,
        Newarr,

        //Pseudo instruction
        StackSpace,
        Ldelem_I8,
        Beq,
        Unbox_Any,
        Stind_Ref,
        Stelem_I,
        Conv_I,
        Jmp,
        Ldind_U1,
        Ceq,
        Stelem_I2,
        Callvirt,
        Conv_Ovf_I1_Un,
        Bge_Un,
        Conv_Ovf_I4_Un,
        Ldelem_R4,
        Ldelem_U1,
        Mkrefany,
        Ldflda,
        Stfld,
        Readonly,
        Stsfld,
        Cpobj,
        Br,
        Ldind_R4,
        Shr_Un,
        Add_Ovf,
        Mul,
        Ldind_U4,
        Bge,
        Ldc_I8,
        Sub,
        Bgt,
        Initblk,
        Endfinally,
        Ldc_R4,
        Blt_Un,
        No,
        Conv_Ovf_I8,
        Dup,
        Div,
        Ble,
        Stelem_I4,
        Blt,
        Conv_Ovf_I2_Un,
        Ldelem_U4,
        Stind_R4,
        Bgt_Un,
        Castclass,
        Conv_Ovf_I8_Un,
        Box,
        Ldlen,
        Conv_R4,
        Xor,
        Conv_Ovf_U,
        Ldc_I4,
        Or,
        Ldstr,
        Ldelem_I,
        Stelem_R4,
        Conv_Ovf_I_Un,
        Sizeof,
        Div_Un,
        Ldind_I4,
        Ldelem_Ref,
        Ldelem_U2,
        Stelem_I1,
        Ldelem_I4,
        Conv_R_Un,
        Conv_Ovf_I1,
        Call,
        Ble_Un,
        Nop,
        Ldobj,
        Ldftn,
        Add_Ovf_Un,
        Ldnull,
        Ldind_Ref,
        Stind_I,
        Unaligned,
        Tail,
        Conv_Ovf_U1,
        Starg,
        Stelem_R8,
        Newobj,
        Sub_Ovf,
        Newanon,
        CallExtern,
        Arglist,
        Isinst,
        Stloc,
        Conv_I2,
        Stind_R8,
        Rem,
        Initobj,
        Cgt,
        Constrained,
        Sub_Ovf_Un,
        Ldsflda,
        Ldelem_I2,
        Stind_I4,
        Ldloc,
        Ret,
        Stelem_Any,
        Ldelema,
        Not,
        Conv_Ovf_I,
        Cgt_Un,
        Ldelem_I1,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 3205565622077975408;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}