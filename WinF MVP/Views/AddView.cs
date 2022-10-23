using WinF_MVP.Interfaces;

namespace WinF_MVP.Views;

public partial class AddView : Form, IAddView
{
    public AddView()
    {
        InitializeComponent();
    }

    public string FirstName => txt_first_name.Text;
    public string LastName => txt_last_name.Text;
    public decimal Score => num_score.Value;
    public DateTime BirthDate => monthCalendar1.SelectionStart;

    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    private void btn_save_Click(object sender, EventArgs e) 
        => SaveEvent?.Invoke(sender, e);
    private void btn_cancel_Click(object sender, EventArgs e) 
        => CancelEvent?.Invoke(sender, e);
}