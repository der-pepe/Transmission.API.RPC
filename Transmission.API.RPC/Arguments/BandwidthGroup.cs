using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transmission.API.RPC.Common;

namespace Transmission.API.RPC.Arguments
{
    /// <summary>
    /// Bandwidth group
    /// </summary>
    public class BandwidthGroup : ArgumentsBase
    {
        /// <summary>
        /// True if session upload limits are honored
        /// </summary>
        public bool HonorsSessionLimits { get { return GetValue<bool>("honorsSessionLimits"); } set { this["honorsSessionLimits"] = value; } }

        /// <summary>
		/// Bandwidth group name
        /// </summary>
        public string Name { get { return GetValue<string>("name"); } set { this["name"] = value; } }

        /// <summary>
        /// true if speed download limit is enabled
        /// </summary>
        public bool SpeedLimitDownloadEnabled { get { return GetValue<bool>("speed-limit-down-enabled"); } set { this["speed-limit-down-enabled"] = value; } }

        /// <summary>
        /// max global download speed (KBps)
        /// </summary>
        public int SpeedLimitDownload { get { return GetValue<int>("speed-limit-down"); } set { this["speed-limit-down"] = value; } }


        /// <summary>
        /// True if session upload limits are honored
        /// </summary>
        public bool SpeedLimitUploadEnabled { get { return GetValue<bool>("speed-limit-up-enabled"); } set { this["speed-limit-up-enabled"] = value; } }

        /// <summary>
        /// max global upload speed (KBps)
        /// </summary>
        public int SpeedLimitUpload { get { return GetValue<int>("speed-limit-up"); } set { this["speed-limit-up"] = value; } }

    }
}
