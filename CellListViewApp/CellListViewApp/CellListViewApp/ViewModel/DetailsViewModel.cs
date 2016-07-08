using System.ComponentModel;


namespace CellListViewApp.ViewModel
{
	public class DetailsViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _text;

		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				_text = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
			}
		}

		public DetailsViewModel(string details)
		{
			this.Text = details;
		}
	}
}