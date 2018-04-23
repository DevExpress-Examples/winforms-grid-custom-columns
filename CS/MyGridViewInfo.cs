using System;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MyXtraGrid {
	public class MyGridViewInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo {
		public MyGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView gridView) : base(gridView) {}

		
		public override int CalcRowHeight(Graphics graphics, int rowHandle, int min, int level, bool useCache, GridColumnsInfo columns) {
			return base.CalcRowHeight(graphics, rowHandle, min - 2, level, useCache, columns);
		}
	}
}
