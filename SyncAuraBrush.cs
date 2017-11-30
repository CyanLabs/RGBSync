using System.Collections.Generic;
using RGB.NET.Core;
using RGB.NET.Devices.Asus;

namespace RGBSync
{
    public class SyncAuraBrush : AbstractBrush
    {
        #region Properties & Fields

        private AsusMainboardRGBDevice _device;
        private Color _currentColor;

        #endregion

        #region Constructors

        public SyncAuraBrush(AsusMainboardRGBDevice device)
        {
            this._device = device;
        }

        #endregion

        #region Methods

        public override void PerformRender(Rectangle rectangle, IEnumerable<BrushRenderTarget> renderTargets)
        {
            _currentColor = _device?.GetColors()[0] ?? Color.Transparent;

            base.PerformRender(rectangle, renderTargets);
        }

        protected override Color GetColorAtPoint(Rectangle rectangle, BrushRenderTarget renderTarget)
        {
            return _currentColor;
        }

        #endregion
    }


}
