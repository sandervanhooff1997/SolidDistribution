using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.Generic.Maximum
{
    /// <summary>
    /// Has a maximum
    /// </summary>
    public interface IMaximum
    {
        int Maximum { get; }

        bool AllowedToAdd { get; }
    }
}
