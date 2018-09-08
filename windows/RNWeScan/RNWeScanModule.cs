using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace We.Scan.RNWeScan
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWeScanModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNWeScanModule"/>.
        /// </summary>
        internal RNWeScanModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNWeScan";
            }
        }
    }
}
