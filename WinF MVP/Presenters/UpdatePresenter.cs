using System.Text;
using System.Text.RegularExpressions;
using WinF_MVP.Interfaces;

namespace WinF_MVP.Presenters;

internal class UpdatePresenter
{
    private IUpdateView _updateView;

    public UpdatePresenter(IUpdateView updateView)
    {
        _updateView = updateView;

        _updateView.SaveEvent += _updateView_SaveEvent;
        _updateView.CancelEvent += _updateView_CancelEvent;
    }

    private void _updateView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        if (_updateView.FirstName.Length < 3)
			sb.Append($"{nameof(_updateView.FirstName)} is wrong\n");

		if (_updateView.LastName.Length < 3)
			sb.Append($"{nameof(_updateView.LastName)} is wrong\n");

		if (DateTime.Now.Year - _updateView.BirthDate.Year < 18)
			sb.Append($"{nameof(_updateView.BirthDate)} is wrong\n");

		if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ((Form)_updateView).DialogResult = DialogResult.OK;
    }

    private void _updateView_CancelEvent(object? sender, EventArgs e) 
        => ((Form)_updateView).DialogResult = DialogResult.Cancel;
}
