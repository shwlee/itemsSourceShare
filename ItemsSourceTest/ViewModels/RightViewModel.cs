using ItemsSourceTest.Models;

namespace ItemsSourceTest.ViewModels
{
    public class RightViewModel : BasePositionViewModel
    {
        public RightViewModel() : base((e) => (e as Member)?.Type == Defines.DeviceTypes.Drone) { }
    }
}
