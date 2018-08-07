using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace TabsWPF
{
    sealed class ViewModel
    {
        public ObservableCollection<TabItem> Tabs { get; set; }

        public ViewModel()
        {
            Tabs = new ObservableCollection<TabItem>();
            TabItem.TabCloseClicked += TabCloseClicked;//Присваиваем событию TabCloseClicked обработчик, в котором будем его обрабатывать.                        
        }


        //Обработчик события нажатия крестика на вкладке TABitem
        private void TabCloseClicked(TabItem currentItem)
        {
           Tabs.Remove(currentItem);
        }
    }
}
