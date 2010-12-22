﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClosedXML.Excel
{
    public enum XLFillPatternValues
    {
        DarkDown,
        DarkGray,
        DarkGrid,
        DarkHorizontal,
        DarkTrellis,
        DarkUp,
        DarkVertical,
        Gray0625,
        Gray125,
        LightDown,
        LightGray,
        LightGrid,
        LightHorizontal,
        LightTrellis,
        LightUp,
        LightVertical,
        MediumGray,
        None,
        Solid
    }

    public interface IXLFill:IEquatable<IXLFill>
    {
        XLColor BackgroundColor { get; set; }

        XLColor PatternColor { get; set; }

        XLColor PatternBackgroundColor { get; set; }

        XLFillPatternValues PatternType { get; set; }
    }
}
