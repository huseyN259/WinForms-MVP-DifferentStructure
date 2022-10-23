using WinF_MVP.Interfaces;

namespace WinF_MVP.Views;

public partial class MainView : Form,IMainView
{
    public MainView()
    {
        InitializeComponent();
    }

    public string SearchValue => txt_search.Text;

    public event EventHandler SearchEvent;
    public event EventHandler AddEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;

    public void SetStudentListBindingSource(BindingSource source) 
        => lBoxStudents.DataSource = source;
    private void btn_search_Click(object sender, EventArgs e) 
        => SearchEvent?.Invoke(sender, e);
    private void btn_add_Click(object sender, EventArgs e) 
        => AddEvent?.Invoke(sender, e);
    private void btn_update_Click(object sender, EventArgs e) 
        => UpdateEvent?.Invoke(sender, e);
    private void btn_del_Click(object sender, EventArgs e) 
        => DeleteEvent?.Invoke(sender, e);
}