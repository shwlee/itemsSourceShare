using ItemsSourceTest.Services;
using System;
using System.Collections;

namespace ItemsSourceTest.ViewModels
{
    public abstract class BasePositionViewModel
    {
        public IEnumerable? Members { get; }

        public BasePositionViewModel(Predicate<object> filter) => this.Members = DeviceStore.Instance.OriginSource(filter);
    }
}
