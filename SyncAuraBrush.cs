using RGB.NET.Core;
using System.Diagnostics;

namespace RGBSync
{
    public class SyncBrush : AbstractBrush
    {
        #region Properties & Fields

        private readonly Led _syncLed;

        #endregion

        #region Constructors

        public SyncBrush(Led syncLed)
        {
            this._syncLed = syncLed;
        }

        #endregion

        #region Methods

        protected override Color GetColorAtPoint(Rectangle rectangle, BrushRenderTarget renderTarget)
        {
            
            return _syncLed.Color;
        }

        #endregion
    }
}
