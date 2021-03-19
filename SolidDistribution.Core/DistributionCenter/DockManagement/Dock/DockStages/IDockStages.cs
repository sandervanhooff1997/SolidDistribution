using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDistribution.Core.DistributionCenter.DockManagement.Dock.DockStages
{
    /// <summary>
    /// Different stages a dock van have
    /// </summary>
    public interface IDockStages
    {
        DockStages DockStage { get; set; }

        bool IsEmpty { get; }

        bool IsDocking { get; }

        bool IsWaitingToUnDock { get; }

        bool IsUnDocking { get; }
    }
}
