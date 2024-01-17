using Avalonia.Controls;

using CommunityToolkit.Mvvm.ComponentModel;

using TestRepo.ViewModels;

namespace TestRepo;

public sealed partial class GroupBoxViewModel : ViewModelBase
{
#region Variables
	[ObservableProperty]
	private string text = string.Empty;

	[ObservableProperty]
	private Control? content = null;

	[ObservableProperty]
	private Control? header = null;
#endregion
// ------------------------------------------------------------------------------------ //
#region Properties

#endregion
// ------------------------------------------------------------------------------------ //
#region Constructors
	public GroupBoxViewModel ()
	{
		
	}
// ------------------------------------------------------------------------------------ //
#endregion
// ------------------------------------------------------------------------------------ //
#region Methods
	
#endregion
// ------------------------------------------------------------------------------------ //
#region Handled Events
	
#endregion
// ------------------------------------------------------------------------------------ //
#region Events

#endregion
// ------------------------------------------------------------------------------------ //
}