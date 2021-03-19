using SolidDistribution.Core.Bag.CoolBag;
using SolidDistribution.Core.Generic.Color;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag.Coolbox
{
    public class CoolBox : BaseBoxWithBag<ICoolBag>, ICoolBox
    {
        public CoolBox() : base(Colors.Black) { }
}
}
