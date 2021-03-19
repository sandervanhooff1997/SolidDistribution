using SolidDistribution.Core.Bag.BreadBag;
using SolidDistribution.Core.Generic.Color;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag.BreadBox
{
    public class BreadBox : BaseBoxWithBag<IBreadBag>, IBreadBox
    {
        public BreadBox() : base(Colors.Black) { }
    }
}
