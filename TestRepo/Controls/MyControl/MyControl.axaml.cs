using Avalonia.Controls;
using System;
using TestRepo;

namespace TestRepo;

public partial class MyControl : UserControl
{
#region Variables
	private MyControlViewModel vm = default!;
#endregion
// ------------------------------------------------------------------------------------ //
#region Properties

#endregion
// ------------------------------------------------------------------------------------ //
#region Constructors
	public MyControl ()
	{
		InitializeComponent ();

		DataContextChanged += MyControl_DataContextChanged;

		DataContext = new MyControlViewModel ();
	}
// ------------------------------------------------------------------------------------ //
#endregion
// ------------------------------------------------------------------------------------ //
#region Methods

#endregion
// ------------------------------------------------------------------------------------ //
#region Handled Events
	private		void		MyControl_DataContextChanged			(object? sender, EventArgs e)
	{
		vm = (MyControlViewModel)DataContext!;
	}
// ------------------------------------------------------------------------------------ //
#endregion
// ------------------------------------------------------------------------------------ //
#region Events

#endregion
// ------------------------------------------------------------------------------------ //
}