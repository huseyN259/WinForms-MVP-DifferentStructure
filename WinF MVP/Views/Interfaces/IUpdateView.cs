namespace WinF_MVP.Interfaces;

internal interface IUpdateView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Score { get; set; }
    DateTime BirthDate { get; set; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    DialogResult ShowDialog();
    DialogResult DialogResult { get; set; }
}