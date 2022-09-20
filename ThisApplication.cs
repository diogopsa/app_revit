
using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System.Collections.Generic;
using System.Linq;

namespace diogo
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.DB.Macros.AddInId("F1FC7E94-6873-4314-9CB8-506D63F7D6D1")]
	public partial class ThisApplication
	{
		private void Module_Startup(object sender, EventArgs e)
		{

		}

		private void Module_Shutdown(object sender, EventArgs e)
		{

		}

		#region Revit Macros generated code
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(Module_Startup);
			this.Shutdown += new System.EventHandler(Module_Shutdown);
		}
		#endregion
		public void teste()
		{
			var uidoc = this.ActiveUIDocument;
			var doc = uidoc.Document;
			var sel = uidoc.Selection;

			var refParede = sel.PickObject(ObjectType.Element);
			var parede = doc.GetElement(refParede);

			var area_parametro = parede.get_Parameter(BuiltInParameter.HOST_AREA_COMPUTED);
			var areaParede = area_parametro.AsDouble();
			TaskDialog.Show("Área da parede selecionada", areaParede.ToString());
		}
	}
}