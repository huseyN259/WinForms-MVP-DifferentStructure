using WinF_MVP.Interfaces;
using WinF_MVP.Presenters;
using WinF_MVP.Repositories;
using WinF_MVP.Views;

namespace WinF_MVP;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        IMainView mainView = new MainView();
        IAddView addView = new AddView();
        IUpdateView updateView = new UpdateView();
        IStudentRepository repository = new EfStudentRepository();
        
        new MainPresenter(mainView, addView, updateView, repository);
        new AddPresenter(addView);
        new UpdatePresenter(updateView);

        Application.Run((Form)mainView);
    }
}