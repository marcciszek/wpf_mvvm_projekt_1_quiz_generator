﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm_projekt_1_quiz_generator.ViewModel.BaseClass
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChange(params string[] namesOfProperty)
        {
            if (PropertyChanged != null)
            {
                foreach (var propertyName in namesOfProperty)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
