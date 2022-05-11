namespace sample_5_9.DashboardControls {
  partial class Venues {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
      this.uow = new DevExpress.Xpo.UnitOfWork(this.components);
      this.eventCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.roomBookingCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
      ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eventCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
      this.SuspendLayout();
      // 
      // eventCollection
      // 
      this.eventCollection.ObjectType = typeof(EventsDB.Event);
      this.eventCollection.Session = this.uow;
      // 
      // roomBookingCollection
      // 
      this.roomBookingCollection.ObjectType = typeof(EventsDB.RoomBooking);
      this.roomBookingCollection.Session = this.uow;
      // 
      // chartControl1
      // 
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      this.chartControl1.Diagram = xyDiagram1;
      this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
      this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
      this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
      this.chartControl1.Legend.Name = "Default Legend";
      this.chartControl1.Location = new System.Drawing.Point(0, 0);
      this.chartControl1.Name = "chartControl1";
      series1.ArgumentDataMember = "Venue.Name";
      series1.DataSource = this.eventCollection;
      series1.Name = "Events";
      series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
      series2.ArgumentDataMember = "Room.Venue.Name";
      series2.DataSource = this.roomBookingCollection;
      series2.Name = "Room Bookings";
      series2.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
      this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
      this.chartControl1.Size = new System.Drawing.Size(556, 363);
      this.chartControl1.TabIndex = 0;
      // 
      // Venues
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.chartControl1);
      this.Name = "Venues";
      this.Size = new System.Drawing.Size(556, 363);
      ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eventCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roomBookingCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.Xpo.UnitOfWork uow;
    private DevExpress.Xpo.XPCollection eventCollection;
    private DevExpress.Xpo.XPCollection roomBookingCollection;
    private DevExpress.XtraCharts.ChartControl chartControl1;
  }
}
