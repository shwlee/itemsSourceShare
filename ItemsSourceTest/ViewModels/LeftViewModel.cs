using ItemsSourceTest.Models;

namespace ItemsSourceTest.ViewModels
{
    public class LeftViewModel : BasePositionViewModel
    {
        public LeftViewModel() : base((e) => (e as Member)?.Type == Defines.DeviceTypes.Walker) { }
    }
}
