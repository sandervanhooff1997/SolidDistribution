using SolidDistribution.Core.Bag.FreezerBag;
using SolidDistribution.Core.Bag.NFCBag;
using SolidDistribution.Core.Generic.Color;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag.FreezerBox
{
    public class FreezerBox : BaseBoxWithBag<IFreezerBag>, IFreezerBox
    {
        public FreezerBox() : base(Colors.Blue) { }
    }
}