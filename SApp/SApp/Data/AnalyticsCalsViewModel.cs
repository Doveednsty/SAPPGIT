using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using SApp.Pages;

namespace SApp.Data
{
    public class AnalyticsCalsViewModel : INotifyPropertyChanged
    {
        private AnalyticsCalcModel calcModel;

        public ObservableCollection<AnalyticsCalcModel> CalcModels { get; set; }
        public AnalyticsCalcModel CalcModel
        {
            get => calcModel;
            set
            {
                calcModel = value;
                OnPropertyChanged("CalcModel");
            }
        }

        public AnalyticsCalsViewModel()
        {
            CalcModels = new ObservableCollection<AnalyticsCalcModel>
            {
                new AnalyticsCalcModel { IdShare }
            };
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
