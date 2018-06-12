﻿namespace NewLife.MySql.Common
{
    /// <summary>数据类型</summary>
    public enum MySqlDbType
    {
        /// <summary>货币型</summary>
        Decimal = 0,

        /// <summary>字节</summary>
        Byte = 1,

        /// <summary>整数</summary>
        Int16 = 2,

        /// <summary>整数</summary>
        Int32 = 3,

        /// <summary>整数</summary>
        Int64 = 8,

        /// <summary>浮点数</summary>
        Float = 4,

        /// <summary>浮点数</summary>
        Double = 5,

        /// <summary>时间日期</summary>
        DateTime = 12,

        /// <summary>字符串</summary>
        VarString = 15,

        /// <summary>枚举</summary>
        Enum = 247,

        /// <summary>字符串</summary>
        VarChar = 253,

        /// <summary>字符串</summary>
        String = 254,

        /// <summary>整数</summary>
        UInt16 = 502,

        /// <summary>整数</summary>
        UInt32 = 503,

        /// <summary>整数</summary>
        UInt64 = 508,
  
        /// <summary>字符串</summary>
        TinyText = 749,

        /// <summary>字符串</summary>
        MediumText = 750,

        /// <summary>字符串</summary>
        LongText = 751,

        /// <summary>字符串</summary>
        Text = 752,
    };
}