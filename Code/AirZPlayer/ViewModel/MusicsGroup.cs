﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirZPlayer
{
    class MusicsGroup: ViewModelBase
    {
        private string _name;
        private bool _isDefault;
        private ObservableCollection<MusicInfoViewModel> _musicInfos;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        public bool IsDefault
        {
            get
            {
                return _isDefault;
            }

            set
            {
                if (_isDefault != value)
                {
                    _isDefault = value;
                    RaisePropertyChanged(nameof(IsDefault));
                }
            }
        }

        public ObservableCollection<MusicInfoViewModel> MusicInfos
        {
            get
            {
                return _musicInfos ?? (_musicInfos = new ObservableCollection<MusicInfoViewModel>());
            }

            set
            {
                if (_musicInfos != value)
                {
                    _musicInfos = value;
                    if (value == null)
                    {
                        _musicInfos = new ObservableCollection<MusicInfoViewModel>();
                    }
                    RaisePropertyChanged(nameof(MusicInfos));
                }
            }
        }
    }
}
