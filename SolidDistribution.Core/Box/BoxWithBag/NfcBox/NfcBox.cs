using SolidDistribution.Core.Bag.NFCBag;
using SolidDistribution.Core.Generic.Color;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Box.BoxWithBag.NfcBox
{
    public class NfcBox : BaseBoxWithBag<INfcBag>, INfcBox
    {
        public NfcBox() : base(Colors.Red) { }
    }
}