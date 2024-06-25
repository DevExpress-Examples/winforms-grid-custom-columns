<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630022/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E710)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Create custom columns

This example demonstrates how to create a custom grid column.

Create a [GridColumn](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.GridColumn) descendant class. If you add properties to a custom column and want to serialize them (using the `SaveLayoutTo...` method), apply the `XtraSerializableProperty` attribute.
 
```csharp
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
```

Create a descendant from the [GridColumnCollection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.GridColumnCollection) class and override the `CreateColumn` method to instantiate a custom column:

```csharp
public class MyGridColumnCollection : GridColumnCollection {
    public MyGridColumnCollection(ColumnView view) : base(view) { }
    protected override GridColumn CreateColumn() {
        return new MyGridColumn();
    }
}
```

Create a descendant from the [GridView](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView) class and override the `CreateColumnCollection` method to instantiate your column collection:

```csharp
public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
  public MyGridView() : this(null) {}
  public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) {
    // Your initialization code.
  }
  protected override string ViewName { get { return "MyGridView"; } }
  protected override GridColumnCollection CreateColumnCollection() {
    return new MyGridColumnCollection(this);
  }
}
```


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyGridColumn.cs](./CS/MyGridColumn.cs) (VB: [MyGridColumn.vb](./VB/MyGridColumn.vb))
* [MyGridControl.cs](./CS/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/MyGridControl.vb))
* [MyGridHandler.cs](./CS/MyGridHandler.cs) (VB: [MyGridHandler.vb](./VB/MyGridHandler.vb))
* [MyGridRegistration.cs](./CS/MyGridRegistration.cs) (VB: [MyGridRegistration.vb](./VB/MyGridRegistration.vb))
* [MyGridView.cs](./CS/MyGridView.cs) (VB: [MyGridView.vb](./VB/MyGridView.vb))
* [MyGridViewInfo.cs](./CS/MyGridViewInfo.cs) (VB: [MyGridViewInfo.vb](./VB/MyGridViewInfo.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
