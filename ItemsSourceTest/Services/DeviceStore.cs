using ItemsSourceTest.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace ItemsSourceTest.Services
{
    public class DeviceStore
    {
        private ObservableCollection<Member> Source { get; } = new ObservableCollection<Member>();

        private static Lazy<DeviceStore> _instance = new Lazy<DeviceStore>(() => new DeviceStore());

        public static DeviceStore Instance = _instance.Value;

        public int SourceCount => this.Source.Count;

        public ICollectionView OriginSource(Predicate<object>? filter = null)
        {
            var source = new CollectionViewSource { Source = this.Source }.View;
            source.Filter = filter;
            return source;
        }

        public void Add(Member newbie)
        {
            this.Source!.Add(newbie);
        }

        public void Remove(Member member)
        {
            this.Source!.Remove(member);
        }

        public void Clear()
        {
            this.Source.Clear();
        }
    }
}
