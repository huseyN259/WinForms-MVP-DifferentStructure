using WinF_MVP.Interfaces;

namespace WinF_MVP.Views;

public partial class UpdateView : Form, IUpdateView
{
    public UpdateView()
    {
        InitializeComponent();
    }

    public string FirstName
    {
        get => txt_first_name.Text;
        set => txt_first_name.Text = value;
    }

    public string LastName
    {
        get => txt_last_name.Text;
        set => txt_last_name.Text = value;
    }
  
    public decimal Score
    {
        get => num_score.Value;
        set => num_score.Value = value;
    }

    public DateTime BirthDate
    {
        get => monthCalendar1.SelectionStart;
        set => monthCalendar1.SelectionStart= value;
    }

    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    private void btn_save_Click(object sender, EventArgs e) 
        => SaveEvent?.Invoke(sender, e);
    private void btn_cancel_Click(object sender, EventArgs e) 
        => CancelEvent?.Invoke(sender, e);
}
