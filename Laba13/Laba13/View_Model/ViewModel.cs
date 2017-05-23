using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba13.View_Model
{
    class ViewModel: ViewModelBase
    {
        public ObservableCollection<Subjects> collection { get; set; }

        public ViewModel(List<Model.Subjects> list)
        {
            collection = new ObservableCollection<Subjects>(list.Select(a => new Subjects(a)));
        }

    }
}
