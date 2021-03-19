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
    public class DistributionCenter : IDistributionCenter
    {
        public DistributionCenter(
            string name, 
            IDockManagement dockManagement,
            IEnumerable<IFreezerCart> freezerCarts,
            IEnumerable<ICoolingCart> coolingCarts,
            IEnumerable<IRegularCart> regularCarts,
            IEnumerable<IGenericCart> genericCarts)
        {
            Name = name;
            DockManagement = dockManagement;
            FreezerCarts = freezerCarts;
            CoolingCarts = coolingCarts;
            RegularCarts = regularCarts;
            GenericCarts = genericCarts;
        }

        public string Name { get; private set; }

        public IDockManagement DockManagement { get; private set; }

        public IEnumerable<IFreezerCart> FreezerCarts { get; private set; }

        public IEnumerable<ICoolingCart> CoolingCarts { get; private set; }

        public IEnumerable<IRegularCart> RegularCarts { get; private set; }

        public IEnumerable<IGenericCart> GenericCarts { get; private set; }
    }
}
