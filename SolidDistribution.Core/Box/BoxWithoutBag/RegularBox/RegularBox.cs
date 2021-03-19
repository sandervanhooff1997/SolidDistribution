using SolidDistribution.Core.Generic.Color;
using SolidDistribution.Core.Grocery.RegularBoxGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithoutBag.RegularBox
{
    public class RegularBox : BaseBoxWithoutBag<IRegularBoxGrocery>, IRegularBox
    {
        public RegularBox() : base(Colors.Blue) { }
    }
}
