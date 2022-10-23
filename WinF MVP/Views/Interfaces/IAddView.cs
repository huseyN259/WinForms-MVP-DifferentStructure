namespace WinF_MVP.Interfaces;

internal interface IAddView
{
    string FirstName { get; }
    string LastName { get; }
    decimal Score { get; }
    DateTime BirthDate { get; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
    
    DialogResult ShowDialog();
    DialogResult DialogResult { get; set; }
}