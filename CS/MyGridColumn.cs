using System;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace MyXtraGrid {

    public class MyGridColumn : GridColumn {
        public MyGridColumn() { }

        string customDataValue = string.Empty;

        [XtraSerializableProperty()]
        public string CustomData {
            get { return customDataValue; }
            set { customDataValue = value; }
        }

        protected override void Assign(GridColumn column) {
            base.Assign(column);
            if(column is MyGridColumn) {
                this.CustomData = ((MyGridColumn)column).CustomData;
            }
        }
    }

    public class MyGridColumnCollection : GridColumnCollection {
        public MyGridColumnCollection(ColumnView view) : base(view) { }

        protected override GridColumn CreateColumn() {
            return new MyGridColumn();
        }
    }
}