using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;

using TestRepo.ViewModels;

namespace TestRepo;

public sealed partial class MyControlViewModel : ViewModelBase
{
#region Variables
	[ObservableProperty]
	private	string												nameFilter					= string.Empty;
#endregion
// ------------------------------------------------------------------------------------ //
#region Properties

#endregion
// ------------------------------------------------------------------------------------ //
#region Constructors
	public MyControlViewModel ()
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