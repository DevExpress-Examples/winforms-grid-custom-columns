using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MyXtraGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private MyXtraGrid.MyGridControl myGridControl1;
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private MyXtraGrid.MyGridColumn myGridColumn1;
		private MyXtraGrid.MyGridView myGridView1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			propertyGrid1.SelectedObject = myGridColumn1;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.myGridControl1 = new MyXtraGrid.MyGridControl();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.myGridView1 = new MyXtraGrid.MyGridView();
			this.myGridColumn1 = new MyXtraGrid.MyGridColumn();
			this.dataSet1 = new System.Data.DataSet();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// myGridControl1
			// 
			this.myGridControl1.DataSource = this.dataTable1;
			this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// myGridControl1.EmbeddedNavigator
			// 
			this.myGridControl1.EmbeddedNavigator.Name = "";
			this.myGridControl1.Location = new System.Drawing.Point(0, 0);
			this.myGridControl1.MainView = this.myGridView1;
			this.myGridControl1.Name = "myGridControl1";
			this.myGridControl1.Size = new System.Drawing.Size(336, 274);
			this.myGridControl1.TabIndex = 0;
			this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										  this.myGridView1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
																			  this.dataColumn1});
			this.dataTable1.TableName = "Table1";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "Column1";
			// 
			// myGridView1
			// 
			this.myGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(212)), ((System.Byte)(212)), ((System.Byte)(212)));
			this.myGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
			this.myGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
			this.myGridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
			this.myGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
			this.myGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.LightGray;
			this.myGridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.WhiteSmoke;
			this.myGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.LightGray;
			this.myGridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
			this.myGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
			this.myGridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
			this.myGridView1.Appearance.DetailTip.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(225)));
			this.myGridView1.Appearance.DetailTip.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.DetailTip.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.DetailTip.Options.UseBackColor = true;
			this.myGridView1.Appearance.DetailTip.Options.UseFont = true;
			this.myGridView1.Appearance.DetailTip.Options.UseForeColor = true;
			this.myGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(243)), ((System.Byte)(243)));
			this.myGridView1.Appearance.Empty.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.Empty.ForeColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.Empty.Options.UseBackColor = true;
			this.myGridView1.Appearance.Empty.Options.UseFont = true;
			this.myGridView1.Appearance.Empty.Options.UseForeColor = true;
			this.myGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(223)), ((System.Byte)(223)));
			this.myGridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
			this.myGridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.myGridView1.Appearance.EvenRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.EvenRow.Options.UseFont = true;
			this.myGridView1.Appearance.EvenRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(212)), ((System.Byte)(208)), ((System.Byte)(200)));
			this.myGridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(118)), ((System.Byte)(170)), ((System.Byte)(225)));
			this.myGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(212)), ((System.Byte)(208)), ((System.Byte)(200)));
			this.myGridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.myGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
			this.myGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
			this.myGridView1.Appearance.FilterCloseButton.Options.UseFont = true;
			this.myGridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
			this.myGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(28)), ((System.Byte)(80)), ((System.Byte)(135)));
			this.myGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(212)), ((System.Byte)(208)), ((System.Byte)(200)));
			this.myGridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
			this.myGridView1.Appearance.FilterPanel.Options.UseFont = true;
			this.myGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
			this.myGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(58)), ((System.Byte)(58)), ((System.Byte)(58)));
			this.myGridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.FixedLine.Options.UseBackColor = true;
			this.myGridView1.Appearance.FixedLine.Options.UseFont = true;
			this.myGridView1.Appearance.FixedLine.Options.UseForeColor = true;
			this.myGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(225)));
			this.myGridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
			this.myGridView1.Appearance.FocusedCell.Options.UseFont = true;
			this.myGridView1.Appearance.FocusedCell.Options.UseForeColor = true;
			this.myGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
			this.myGridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(50)), ((System.Byte)(50)), ((System.Byte)(178)));
			this.myGridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.FocusedRow.Options.UseFont = true;
			this.myGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
			this.myGridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
			this.myGridView1.Appearance.FooterPanel.Options.UseFont = true;
			this.myGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
			this.myGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.GroupButton.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.GroupButton.Options.UseBackColor = true;
			this.myGridView1.Appearance.GroupButton.Options.UseBorderColor = true;
			this.myGridView1.Appearance.GroupButton.Options.UseFont = true;
			this.myGridView1.Appearance.GroupButton.Options.UseForeColor = true;
			this.myGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(202)), ((System.Byte)(202)), ((System.Byte)(202)));
			this.myGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(202)), ((System.Byte)(202)), ((System.Byte)(202)));
			this.myGridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
			this.myGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
			this.myGridView1.Appearance.GroupFooter.Options.UseFont = true;
			this.myGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
			this.myGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(58)), ((System.Byte)(110)), ((System.Byte)(165)));
			this.myGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
			this.myGridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.myGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
			this.myGridView1.Appearance.GroupPanel.Options.UseFont = true;
			this.myGridView1.Appearance.GroupPanel.Options.UseForeColor = true;
			this.myGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.GroupRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.GroupRow.Options.UseFont = true;
			this.myGridView1.Appearance.GroupRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.myGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.myGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.myGridView1.Appearance.HeaderPanel.Options.UseFont = true;
			this.myGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.myGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(212)), ((System.Byte)(208)), ((System.Byte)(200)));
			this.myGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.HideSelectionRow.Options.UseFont = true;
			this.myGridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.HorzLine.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.HorzLine.ForeColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.HorzLine.Options.UseBackColor = true;
			this.myGridView1.Appearance.HorzLine.Options.UseFont = true;
			this.myGridView1.Appearance.HorzLine.Options.UseForeColor = true;
			this.myGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
			this.myGridView1.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.myGridView1.Appearance.OddRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.OddRow.Options.UseFont = true;
			this.myGridView1.Appearance.OddRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.Preview.BackColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
			this.myGridView1.Appearance.Preview.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
			this.myGridView1.Appearance.Preview.Options.UseBackColor = true;
			this.myGridView1.Appearance.Preview.Options.UseFont = true;
			this.myGridView1.Appearance.Preview.Options.UseForeColor = true;
			this.myGridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
			this.myGridView1.Appearance.Row.Options.UseBackColor = true;
			this.myGridView1.Appearance.Row.Options.UseFont = true;
			this.myGridView1.Appearance.Row.Options.UseForeColor = true;
			this.myGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(243)), ((System.Byte)(243)));
			this.myGridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
			this.myGridView1.Appearance.RowSeparator.Options.UseFont = true;
			this.myGridView1.Appearance.RowSeparator.Options.UseForeColor = true;
			this.myGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(10)), ((System.Byte)(10)), ((System.Byte)(138)));
			this.myGridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
			this.myGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
			this.myGridView1.Appearance.SelectedRow.Options.UseFont = true;
			this.myGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
			this.myGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
			this.myGridView1.Appearance.VertLine.Font = new System.Drawing.Font("Arial", 8F);
			this.myGridView1.Appearance.VertLine.ForeColor = System.Drawing.Color.Gray;
			this.myGridView1.Appearance.VertLine.Options.UseBackColor = true;
			this.myGridView1.Appearance.VertLine.Options.UseFont = true;
			this.myGridView1.Appearance.VertLine.Options.UseForeColor = true;
			this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							   this.myGridColumn1});
			this.myGridView1.GridControl = this.myGridControl1;
			this.myGridView1.Name = "myGridView1";
			// 
			// myGridColumn1
			// 
			this.myGridColumn1.Caption = "myGridColumn1";
			this.myGridColumn1.CustomData = "test";
			this.myGridColumn1.Name = "myGridColumn1";
			this.myGridColumn1.Visible = true;
			this.myGridColumn1.VisibleIndex = 0;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
																		  this.dataTable1});
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(336, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.propertyGrid1.Size = new System.Drawing.Size(216, 274);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 274);
			this.Controls.Add(this.myGridControl1);
			this.Controls.Add(this.propertyGrid1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
