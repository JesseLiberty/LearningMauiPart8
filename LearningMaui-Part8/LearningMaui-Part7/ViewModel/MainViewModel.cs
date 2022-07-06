using LearningMaui_Part7.Model;
using System.Windows.Input;
using CommunityToolkit.Maui;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace LearningMaui_Part7.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            CreateList();
        }

        [ObservableProperty]
        private List<Result> _resultList;

        public void CreateList()
        {
            ResultList = new List<Result>();

            Result result = new Result
            {
                image = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Seal_of_New_York_%28state%29.svg/150px-Seal_of_New_York_%28state%29.svg.png",
                state = "NY",
                zip = "07748"
            };
            ResultList.Add(result);

            ResultList.Add(new Result
            {
                image = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Vermont.svg/188px-Flag_of_Vermont.svg.png",
                state = "VT",
                zip = "05143"
            });

            ResultList.Add(new Result
            {
                image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Flag_of_Connecticut.svg/188px-Flag_of_Connecticut.svg.png",
                 state = "CT",
                 zip = "06457" 
            });

            ResultList.Add(new Result
            {
                image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Flag_of_Connecticut.svg/188px-Flag_of_Connecticut.svg.png",
                state = "CT",
                zip = "06457"
            });


        }
    }
}
