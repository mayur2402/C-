using System;
namespace MsgBoxExample
{
	public partial class MsgBoxExampleForm : Form
	{
		//Constructor, called when the class is initialised.
		public MsgBoxExampleForm()
		{
			InitializeComponent();
		}
		//Called whenever the button is clicked.
		private void btnShowMessageBox_Click(object sender, EventArgs e)
		{
			CustomMsgBox.Show($"I'm a {nameof(CustomMsgBox)}!", "MSG", "OK");
		}
	}
}
