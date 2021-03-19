using SolidDistribution.Core.Grocery.NfcBagGrocery;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Bag.NFCBag
{
    /// <summary>
    /// A Nfc bag to store nfc bag groceries.
    /// </summary>
    public interface INfcBag : IBag<INfcBagGrocery>
    {
    }
}
