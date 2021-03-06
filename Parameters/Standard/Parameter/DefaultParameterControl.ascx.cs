using DNNStuff.SQLViewPro.Services.Data;
using System.Collections.Generic;

namespace DNNStuff.SQLViewPro.StandardParameters
{
	
	public partial class DefaultParameterControl : Controls.ParameterControlBase
	{
		
#region  Web Form Designer Generated Code
		
		//This call is required by the Web Form Designer.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			
		}
		
		private void Page_Init(System.Object sender, System.EventArgs e)
		{
			//CODEGEN: This method call is required by the Web Form Designer
			//Do not modify it using the code editor.
			InitializeComponent();
		}
		
#endregion
		
#region  Page
		private void Page_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
#endregion
		
#region  Base Method Implementations
		public override List<string> Values
		{
			get
			{
				return new List<string>(new string[] {txtParameter.Text});
			}
			set
			{
				if (value.Count > 0)
				{
					txtParameter.Text = value[0].ToString();
				}
				else
				{
					txtParameter.Text = "";
				}
			}
		}
		
		public override void LoadRuntimeSettings()
		{
			var obj = (DefaultParameterSettings) (Serialization.DeserializeObject(Settings.ParameterConfig, typeof(DefaultParameterSettings)));
			txtParameter.Text = TokenReplacement.ReplaceTokens(obj.Default, null, null);
		}
#endregion
		
	}
	
}

