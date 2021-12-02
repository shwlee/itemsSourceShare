using ItemsSourceTest.Defines;
using ItemsSourceTest.Models;
using ItemsSourceTest.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections;
using System.Linq;
using System.Windows.Input;

namespace ItemsSourceTest.ViewModels
{
    public class AppViewModel : ObservableObject
    {
        private Member _selectedMember;

        public IEnumerable? Members { get; }

        public Member SelectedMember
        {
            get => this._selectedMember;
            set => this.SetProperty(ref this._selectedMember, value);
        }

        public AppViewModel() => this.Members = DeviceStore.Instance.OriginSource();

        private RelayCommand _setCommand;
        public ICommand SetCommand => this._setCommand ??= new RelayCommand(Set);

        private void Set()
        {
            var count = DeviceStore.Instance.SourceCount % 3;
            var type = count switch
            {
                0 => DeviceTypes.Converter,
                1 => DeviceTypes.Walker,
                2 => DeviceTypes.Drone,
                _ => throw new System.NotImplementedException(),
            };

            var newbie = new Member(type);
            DeviceStore.Instance.Add(newbie);


            //var members = this.Members.Cast<Member>().ToList();
        }

        private RelayCommand _removeCommand;

        public ICommand RemoveCommand => this._removeCommand ??= new RelayCommand(Remove);

        private void Remove()
        {
            DeviceStore.Instance.Remove(this.SelectedMember);
        }

        private RelayCommand _clearCommand;

        public ICommand ClearCommand => this._clearCommand ??= new RelayCommand(Clear);

        private void Clear()
        {
            DeviceStore.Instance.Clear();
        }
    }
}
