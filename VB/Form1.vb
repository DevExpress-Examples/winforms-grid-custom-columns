Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace MyXtraGrid

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private myGridControl1 As MyGridControl

        Private dataSet1 As DataSet

        Private dataTable1 As DataTable

        Private dataColumn1 As DataColumn

        Private myGridColumn1 As MyGridColumn

        Private myGridView1 As MyGridView

        Private propertyGrid1 As PropertyGrid

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            propertyGrid1.SelectedObject = myGridColumn1
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            myGridControl1 = New MyGridControl()
            dataTable1 = New DataTable()
            dataColumn1 = New DataColumn()
            myGridView1 = New MyGridView()
            myGridColumn1 = New MyGridColumn()
            dataSet1 = New DataSet()
            propertyGrid1 = New PropertyGrid()
            CType(myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            myGridControl1.DataSource = dataTable1
            myGridControl1.Dock = DockStyle.Fill
            ' 
            ' myGridControl1.EmbeddedNavigator
            ' 
            myGridControl1.EmbeddedNavigator.Name = ""
            myGridControl1.Location = New System.Drawing.Point(0, 0)
            myGridControl1.MainView = myGridView1
            myGridControl1.Name = "myGridControl1"
            myGridControl1.Size = New System.Drawing.Size(336, 274)
            myGridControl1.TabIndex = 0
            myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {myGridView1})
            ' 
            ' dataTable1
            ' 
            dataTable1.Columns.AddRange(New DataColumn() {dataColumn1})
            dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            dataColumn1.ColumnName = "Column1"
            ' 
            ' myGridView1
            ' 
            myGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb((CByte(212)), (CByte(212)), (CByte(212)))
            myGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
            myGridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
            myGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
            myGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
            myGridView1.Appearance.ColumnFilterButton.Options.UseFont = True
            myGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
            myGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.LightGray
            myGridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.WhiteSmoke
            myGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.LightGray
            myGridView1.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
            myGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
            myGridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = True
            myGridView1.Appearance.DetailTip.BackColor = System.Drawing.Color.FromArgb((CByte(255)), (CByte(255)), (CByte(225)))
            myGridView1.Appearance.DetailTip.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.DetailTip.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.DetailTip.Options.UseBackColor = True
            myGridView1.Appearance.DetailTip.Options.UseFont = True
            myGridView1.Appearance.DetailTip.Options.UseForeColor = True
            myGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb((CByte(243)), (CByte(243)), (CByte(243)))
            myGridView1.Appearance.Empty.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.Empty.ForeColor = System.Drawing.Color.White
            myGridView1.Appearance.Empty.Options.UseBackColor = True
            myGridView1.Appearance.Empty.Options.UseFont = True
            myGridView1.Appearance.Empty.Options.UseForeColor = True
            myGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb((CByte(223)), (CByte(223)), (CByte(223)))
            myGridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
            myGridView1.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            myGridView1.Appearance.EvenRow.Options.UseBackColor = True
            myGridView1.Appearance.EvenRow.Options.UseFont = True
            myGridView1.Appearance.EvenRow.Options.UseForeColor = True
            myGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb((CByte(212)), (CByte(208)), (CByte(200)))
            myGridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb((CByte(118)), (CByte(170)), (CByte(225)))
            myGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb((CByte(212)), (CByte(208)), (CByte(200)))
            myGridView1.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            myGridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
            myGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
            myGridView1.Appearance.FilterCloseButton.Options.UseFont = True
            myGridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
            myGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb((CByte(28)), (CByte(80)), (CByte(135)))
            myGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb((CByte(212)), (CByte(208)), (CByte(200)))
            myGridView1.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
            myGridView1.Appearance.FilterPanel.Options.UseBackColor = True
            myGridView1.Appearance.FilterPanel.Options.UseFont = True
            myGridView1.Appearance.FilterPanel.Options.UseForeColor = True
            myGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb((CByte(58)), (CByte(58)), (CByte(58)))
            myGridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.FixedLine.Options.UseBackColor = True
            myGridView1.Appearance.FixedLine.Options.UseFont = True
            myGridView1.Appearance.FixedLine.Options.UseForeColor = True
            myGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb((CByte(255)), (CByte(255)), (CByte(225)))
            myGridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.FocusedCell.Options.UseBackColor = True
            myGridView1.Appearance.FocusedCell.Options.UseFont = True
            myGridView1.Appearance.FocusedCell.Options.UseForeColor = True
            myGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
            myGridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb((CByte(50)), (CByte(50)), (CByte(178)))
            myGridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
            myGridView1.Appearance.FocusedRow.Options.UseBackColor = True
            myGridView1.Appearance.FocusedRow.Options.UseFont = True
            myGridView1.Appearance.FocusedRow.Options.UseForeColor = True
            myGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
            myGridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.FooterPanel.Options.UseBackColor = True
            myGridView1.Appearance.FooterPanel.Options.UseBorderColor = True
            myGridView1.Appearance.FooterPanel.Options.UseFont = True
            myGridView1.Appearance.FooterPanel.Options.UseForeColor = True
            myGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
            myGridView1.Appearance.GroupButton.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.GroupButton.Options.UseBackColor = True
            myGridView1.Appearance.GroupButton.Options.UseBorderColor = True
            myGridView1.Appearance.GroupButton.Options.UseFont = True
            myGridView1.Appearance.GroupButton.Options.UseForeColor = True
            myGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb((CByte(202)), (CByte(202)), (CByte(202)))
            myGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb((CByte(202)), (CByte(202)), (CByte(202)))
            myGridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.GroupFooter.Options.UseBackColor = True
            myGridView1.Appearance.GroupFooter.Options.UseBorderColor = True
            myGridView1.Appearance.GroupFooter.Options.UseFont = True
            myGridView1.Appearance.GroupFooter.Options.UseForeColor = True
            myGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb((CByte(58)), (CByte(110)), (CByte(165)))
            myGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
            myGridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold)
            myGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
            myGridView1.Appearance.GroupPanel.Options.UseBackColor = True
            myGridView1.Appearance.GroupPanel.Options.UseFont = True
            myGridView1.Appearance.GroupPanel.Options.UseForeColor = True
            myGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
            myGridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
            myGridView1.Appearance.GroupRow.Options.UseBackColor = True
            myGridView1.Appearance.GroupRow.Options.UseFont = True
            myGridView1.Appearance.GroupRow.Options.UseForeColor = True
            myGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
            myGridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold)
            myGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.HeaderPanel.Options.UseBackColor = True
            myGridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
            myGridView1.Appearance.HeaderPanel.Options.UseFont = True
            myGridView1.Appearance.HeaderPanel.Options.UseForeColor = True
            myGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
            myGridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb((CByte(212)), (CByte(208)), (CByte(200)))
            myGridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
            myGridView1.Appearance.HideSelectionRow.Options.UseFont = True
            myGridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
            myGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.HorzLine.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.HorzLine.ForeColor = System.Drawing.Color.Gray
            myGridView1.Appearance.HorzLine.Options.UseBackColor = True
            myGridView1.Appearance.HorzLine.Options.UseFont = True
            myGridView1.Appearance.HorzLine.Options.UseForeColor = True
            myGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
            myGridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
            myGridView1.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
            myGridView1.Appearance.OddRow.Options.UseBackColor = True
            myGridView1.Appearance.OddRow.Options.UseFont = True
            myGridView1.Appearance.OddRow.Options.UseForeColor = True
            myGridView1.Appearance.Preview.BackColor = System.Drawing.Color.White
            myGridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.White
            myGridView1.Appearance.Preview.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Navy
            myGridView1.Appearance.Preview.Options.UseBackColor = True
            myGridView1.Appearance.Preview.Options.UseFont = True
            myGridView1.Appearance.Preview.Options.UseForeColor = True
            myGridView1.Appearance.Row.BackColor = System.Drawing.Color.White
            myGridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
            myGridView1.Appearance.Row.Options.UseBackColor = True
            myGridView1.Appearance.Row.Options.UseFont = True
            myGridView1.Appearance.Row.Options.UseForeColor = True
            myGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
            myGridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb((CByte(243)), (CByte(243)), (CByte(243)))
            myGridView1.Appearance.RowSeparator.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Gray
            myGridView1.Appearance.RowSeparator.Options.UseBackColor = True
            myGridView1.Appearance.RowSeparator.Options.UseFont = True
            myGridView1.Appearance.RowSeparator.Options.UseForeColor = True
            myGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb((CByte(10)), (CByte(10)), (CByte(138)))
            myGridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
            myGridView1.Appearance.SelectedRow.Options.UseBackColor = True
            myGridView1.Appearance.SelectedRow.Options.UseFont = True
            myGridView1.Appearance.SelectedRow.Options.UseForeColor = True
            myGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
            myGridView1.Appearance.VertLine.Font = New System.Drawing.Font("Arial", 8F)
            myGridView1.Appearance.VertLine.ForeColor = System.Drawing.Color.Gray
            myGridView1.Appearance.VertLine.Options.UseBackColor = True
            myGridView1.Appearance.VertLine.Options.UseFont = True
            myGridView1.Appearance.VertLine.Options.UseForeColor = True
            myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {myGridColumn1})
            myGridView1.GridControl = myGridControl1
            myGridView1.Name = "myGridView1"
            ' 
            ' myGridColumn1
            ' 
            myGridColumn1.Caption = "myGridColumn1"
            myGridColumn1.CustomData = "test"
            myGridColumn1.Name = "myGridColumn1"
            myGridColumn1.Visible = True
            myGridColumn1.VisibleIndex = 0
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            dataSet1.Locale = New Globalization.CultureInfo("en-US")
            dataSet1.Tables.AddRange(New DataTable() {dataTable1})
            ' 
            ' propertyGrid1
            ' 
            propertyGrid1.CommandsVisibleIfAvailable = True
            propertyGrid1.Dock = DockStyle.Right
            propertyGrid1.LargeButtons = False
            propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            propertyGrid1.Location = New System.Drawing.Point(336, 0)
            propertyGrid1.Name = "propertyGrid1"
            propertyGrid1.PropertySort = PropertySort.Alphabetical
            propertyGrid1.Size = New System.Drawing.Size(216, 274)
            propertyGrid1.TabIndex = 1
            propertyGrid1.Text = "propertyGrid1"
            propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
            propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(552, 274)
            Me.Controls.Add(myGridControl1)
            Me.Controls.Add(propertyGrid1)
            Name = "Form1"
            Text = "Form1"
            CType(myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub
    End Class
End Namespace
