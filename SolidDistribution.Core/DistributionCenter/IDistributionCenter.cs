using SolidDistribution.Core.Cart.CoolingCart;
using SolidDistribution.Core.Cart.FreezerCart;
using SolidDistribution.Core.Cart.GenericCart;
using SolidDistribution.Core.Cart.RegularCart;
using SolidDistribution.Core.DistributionCenter.DockManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter
{
    /// <summary>
    /// A central place to distribute groceries from.
    /// </summary>
    public interface IDistributionCenter
    {
        string Name { get; }

        IDockManagement DockManagement { get; }

        /// <summary>
        /// All freezer carts stored in a freezy freezer
        /// </summary>
        IEnumerable<IFreezerCart> FreezerCarts { get; }

        /// <summary>
        /// All cooling carts stored in a cool cooler
        /// </summary>
        IEnumerable<ICoolingCart> CoolingCarts { get; }

        /// <summary>
        /// All regular carts stored in a normal climate
        /// </summary>
        IEnumerable<IRegularCart> RegularCarts { get; }

        /// <summary>
        /// All carts that have mixed boxes (freezer + cooling + regular)
        /// These carts are distributed to the customer
        /// </summary>
        IEnumerable<IGenericCart> GenericCarts { get; }
    }
}
