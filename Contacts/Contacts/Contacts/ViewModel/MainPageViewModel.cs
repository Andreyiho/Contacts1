using Acr.UserDialogs;
using Contacts.Model;
using Contacts.Services.Repository;
using Contacts.Services.Settings;
using Contacts.View;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts.ViewModel
{
    class MainPageViewModel : BindableBase
    {
        private ISettingsManager _settingsManager;
        private IRepository _repository;
        private readonly INavigationService _navigationService;
        public MainPageViewModel(ISettingsManager settingsManager, 
            IRepository repository, INavigationService navigetionServis)
        {
            _settingsManager = settingsManager;
            _repository = repository;
            _navigationService = navigetionServis;


        }
        #region ---Public Propertise ---
        public ICommand SignUpTapCommand => new Command(OnSignUpTapCommand);

        public ICommand SignInTapCommand => new Command(OnSignInTapCommand);

  

        public ICommand ClickCommand => new Command(OClickCommand);

      




        #endregion
      

        #region --- Public Methods ---

        
        #endregion
        #region --- Overrides ---
        
        #endregion
        #region ---Private Helpers ---
        private async void OClickCommand(object obj)
        {
            await _navigationService.NavigateAsync("SignUpView");
        }
        private void OnSignUpTapCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private void OnSignInTapCommand(object obj)
        {
            throw new NotImplementedException();
        }
       
        

       

        #endregion
        //protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        //{
        //    base.OnPropertyChanged(args);
        //    if(args.PropertyName == nameof(Count))
        //    {
        //        _settingsManager.Count = Count;
        //    }
        //}
        //private void OnIncrementButtonTap()
        //{
        //    Count++;
        //}
    }
}
