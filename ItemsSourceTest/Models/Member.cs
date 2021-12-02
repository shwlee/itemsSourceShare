using ItemsSourceTest.Defines;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ItemsSourceTest.Models
{
    public class Member : ObservableObject
    {
        public DeviceTypes Type { get; }

        public Member(DeviceTypes type) => this.Type = type;
    }
}
