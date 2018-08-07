using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;


namespace TabsWPF
{
    public sealed class TabItem
    {
        public string Header { get; set; } //Заголовок TABItem ов
        public string Content { get; set; } //Контент TABItem ов

        public TabItem()
        {
            TabCloseButtonCommand = new RelayCommand(CloseCurrentTab, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }

        private ICommand tabCloseButtonCommand;
        private ICommand toggleExecuteCommand { get; set; }
        private bool canExecute = true;
        public string TabCloseButtonContent {get {return "X";} } //Заголовок кнопки закрытия вкладки

        public bool CanExecute {get {return this.canExecute;} set{ if (this.canExecute == value){return;} this.canExecute = value; }}
        public ICommand ToggleExecuteCommand{ get {return toggleExecuteCommand;} set{toggleExecuteCommand = value;} }
        public ICommand TabCloseButtonCommand { get {return tabCloseButtonCommand; } set{tabCloseButtonCommand = value;} }


        //Срабатывает при нажатии крестика на вкладке
        public void CloseCurrentTab(object obj)
        {
           
            TabCloseClicked(this);
        }

        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }




        public static event Action<TabItem> TabCloseClicked; //Создаем событие срабатывающее при нажатие крестика на вкладке




    }

    

}
