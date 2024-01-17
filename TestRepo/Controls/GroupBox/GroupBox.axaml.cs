using Avalonia.Controls;

using System;

namespace TestRepo;

public partial class GroupBox : UserControl
{
#region Variables
	private GroupBoxViewModel vm = default!;
#endregion
// ------------------------------------------------------------------------------------ //
#region Properties
	public string Text
	{
		get => ((GroupBoxViewModel)DataContext!).Text;
		set => ((GroupBoxViewModel)DataContext!).Text = value;
	}
#endregion
// ------------------------------------------------------------------------------------ //
#region Constructors
	public GroupBox ()
	{
		InitializeComponent ();

		DataContextChanged += GroupBox_DataContextChanged;

		DataContext = new GroupBoxViewModel ();
	}
// ------------------------------------------------------------------------------------ //
#endregion
// ------------------------------------------------------------------------------------ //
#region Methods

#endregion
// ------------------------------------------------------------------------------------ //
#region Handled Events
	private		void		GroupBox_DataContextChanged			(object? sender, EventArgs e)
	{
		vm = (GroupBoxViewModel)DataContext!;
	}
// ------------------------------------------------------------------------------------ //
#endregion
// ------------------------------------------------------------------------------------ //
#region Events

#endregion
// ------------------------------------------------------------------------------------ //
}