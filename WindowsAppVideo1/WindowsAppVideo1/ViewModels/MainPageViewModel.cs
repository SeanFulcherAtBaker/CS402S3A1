using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace WindowsAppVideo1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.Any())
            {

            }

            var key = parameter as string;
            if (SessionState.ContainsKey(key))
            {
                //easy way
            }
            else
            {
                //hard way
            }
            //mode = NavigationMode.Back;
            return base.OnNavigatedToAsync(parameter, mode, state);
        }
        public override Task OnNavigatedFromAsync(IDictionary<string, object> pageState, bool suspending)
        {
            if(suspending)
            {
                pageState["FirstName"] = "Sean";
            }
            return base.OnNavigatedFromAsync(pageState, suspending);
        }
        public override Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = true;
            return base.OnNavigatingFromAsync(args);
        }
    }
    
}

