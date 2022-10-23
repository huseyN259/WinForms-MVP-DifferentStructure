using System.Text;
using System.Text.RegularExpressions;
using WinF_MVP.Interfaces;

namespace WinF_MVP.Presenters;

internal class AddPresenter
{
    private IAddView _addView;

    public AddPresenter(IAddView addView)
    {
        _addView = addView;

        _addView.SaveEvent += _addView_SaveEvent;
        _addView.CancelEvent += _addView_CancelEvent;
    }

    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

		if (_addView.FirstName.Length < 3)
			sb.Append($"{nameof(_addView.FirstName)} is wrong\n");

		if (_addView.LastName.Length < 3)
			sb.Append($"{nameof(_addView.LastName)} is wrong\n");

		if (DateTime.Now.Year - _addView.BirthDate.Year < 18)
			sb.Append($"{nameof(_addView.BirthDate)} is wrong\n");

		if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _addView.DialogResult = DialogResult.OK;
    }

    private void _addView_CancelEvent(object? sender, EventArgs e)
        => _addView.DialogResult = DialogResult.Cancel;
}