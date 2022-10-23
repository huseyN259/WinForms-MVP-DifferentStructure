using WinF_MVP.Models;
using WinF_MVP.Interfaces;
using WinF_MVP.Repositories;

namespace WinF_MVP.Presenters;

internal class MainPresenter
{
	private readonly BindingSource _bindingSource;
	private readonly IMainView _mainView;
	private readonly IAddView _addView;
	private readonly IUpdateView _updateView;
	private readonly IStudentRepository _repository;

	public MainPresenter(IMainView mainView, IAddView addView, IUpdateView updateView, IStudentRepository repository)
	{
		_mainView = mainView;
		_addView = addView;
		_updateView = updateView;
		_repository = repository;


		// Binding Source
		_bindingSource = new();


		// Events
		_bindingSource.DataSource = _repository.GetList();
		_mainView.SetStudentListBindingSource(_bindingSource);
		_mainView.SearchEvent += _mainView_SearchEvent;
		_mainView.DeleteEvent += _mainView_DeleteEvent;
		_mainView.AddEvent += _mainView_AddEvent;
		_mainView.UpdateEvent += _mainView_UpdateEvent;
	}

	private void _mainView_SearchEvent(object? sender, EventArgs e)
	{
		var searchValue = _mainView.SearchValue;

		bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(searchValue);
		_bindingSource.DataSource = isNullOrWhiteSpace switch
		{
			true => _repository.GetList(),
			false => _repository.GetList(s => s.FirstName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)
			|| s.LastName.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
		};
	}

	private void _mainView_DeleteEvent(object? sender, EventArgs e)
	{
		var deletedItem = _bindingSource.Current as Student;

		if (deletedItem is null)
			return;

		_repository.Remove(deletedItem);
		_bindingSource.Remove(deletedItem);

		MessageBox.Show("Successful...", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private void _mainView_AddEvent(object? sender, EventArgs e)
	{
		var result = _addView.ShowDialog();

		if (result == DialogResult.Cancel)
			return;

		var student = new Student()
		{
			FirstName = _addView.FirstName,
			LastName = _addView.LastName,
			DateOfBirth = _addView.BirthDate,
			Score = (float)_addView.Score
		};

		_repository.Add(student);
		_bindingSource.Add(student);

		MessageBox.Show("Successful...", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private void _mainView_UpdateEvent(object? sender, EventArgs e)
	{
		var student = _bindingSource.Current as Student;

		if (student is null)
		{
			MessageBox.Show("An Error Occured...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		_updateView.FirstName = student.FirstName;
		_updateView.LastName = student.LastName;
		_updateView.BirthDate = student.DateOfBirth;
		_updateView.Score = (decimal)student.Score;

		var result = _updateView.ShowDialog();

		if (result == DialogResult.Cancel)
			return;

		student.FirstName = _updateView.FirstName;
		student.LastName = _updateView.LastName;
		student.DateOfBirth = _updateView.BirthDate;
		student.Score = (float)_updateView.Score;

		_repository.Update(student);
		_bindingSource.ResetCurrentItem();

		MessageBox.Show("Successful...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}