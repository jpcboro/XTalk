using MvvmCross.Core.ViewModels;

namespace XTalk.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello XTalk";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
