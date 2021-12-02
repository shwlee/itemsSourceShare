using ItemsSourceTest.Models;

namespace ItemsSourceTest.ViewModels
{
    public class MiddleViewModel : BasePositionViewModel
    {
        public MiddleViewModel() : base((e) => (e as Member)?.Type == Defines.DeviceTypes.Converter) {}
    }
}
