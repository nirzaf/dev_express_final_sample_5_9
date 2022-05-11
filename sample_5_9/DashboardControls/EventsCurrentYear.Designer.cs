namespace sample_5_9.DashboardControls {
  partial class EventsCurrentYear {
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
      DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
      DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
      DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
      this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
      this.eventsCurrentYearGauge = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
      this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
      this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
      this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
      ((System.ComponentModel.ISupportInitialize)(this.eventsCurrentYearGauge)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
      this.SuspendLayout();
      // 
      // gaugeControl1
      // 
      this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.eventsCurrentYearGauge});
      this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
      this.gaugeControl1.Name = "gaugeControl1";
      this.gaugeControl1.Size = new System.Drawing.Size(470, 291);
      this.gaugeControl1.TabIndex = 0;
      // 
      // eventsCurrentYearGauge
      // 
      this.eventsCurrentYearGauge.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
      this.eventsCurrentYearGauge.Bounds = new System.Drawing.Rectangle(6, 6, 458, 279);
      this.eventsCurrentYearGauge.Name = "eventsCurrentYearGauge";
      this.eventsCurrentYearGauge.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
      this.eventsCurrentYearGauge.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
      // 
      // arcScaleComponent1
      // 
      this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
      this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
      this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
      this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
      this.arcScaleComponent1.AppearanceScale.Brush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#058897");
      this.arcScaleComponent1.AppearanceScale.Width = 3F;
      this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9.75F);
      this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00E1F3");
      this.arcScaleComponent1.AutoRescaling = true;
      this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F);
      this.arcScaleComponent1.EndAngle = 0F;
      this.arcScaleComponent1.MajorTickCount = 6;
      this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
      this.arcScaleComponent1.MajorTickmark.ShapeOffset = -11F;
      this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style17_1;
      this.arcScaleComponent1.MajorTickmark.TextOffset = -22F;
      this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
      this.arcScaleComponent1.MaxValue = 20F;
      this.arcScaleComponent1.MinorTickCount = 4;
      this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
      this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style17_2;
      this.arcScaleComponent1.Name = "scale1";
      this.arcScaleComponent1.RadiusX = 95F;
      this.arcScaleComponent1.RadiusY = 85F;
      arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#09AC86");
      arcScaleRange1.EndPercent = 0.6F;
      arcScaleRange1.EndValue = 33F;
      arcScaleRange1.Name = "Range0";
      arcScaleRange1.ShapeOffset = 0F;
      arcScaleRange1.StartPercent = 0F;
      arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#CAB46E");
      arcScaleRange2.EndPercent = 0.9F;
      arcScaleRange2.EndValue = 66F;
      arcScaleRange2.Name = "Range1";
      arcScaleRange2.ShapeOffset = 0F;
      arcScaleRange2.StartPercent = 0.6F;
      arcScaleRange2.StartValue = 33F;
      arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C16268");
      arcScaleRange3.EndPercent = 1F;
      arcScaleRange3.EndValue = 100F;
      arcScaleRange3.Name = "Range2";
      arcScaleRange3.ShapeOffset = 0F;
      arcScaleRange3.StartPercent = 0.9F;
      arcScaleRange3.StartValue = 66F;
      this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
      this.arcScaleComponent1.RescalingBestValues = true;
      this.arcScaleComponent1.RescalingThresholdMax = 0.3F;
      this.arcScaleComponent1.StartAngle = -180F;
      this.arcScaleComponent1.Value = 10F;
      // 
      // arcScaleBackgroundLayerComponent1
      // 
      this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
      this.arcScaleBackgroundLayerComponent1.Name = "bg";
      this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.68F);
      this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style17;
      this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 179F);
      this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
      // 
      // arcScaleNeedleComponent1
      // 
      this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
      this.arcScaleNeedleComponent1.EndOffset = 4F;
      this.arcScaleNeedleComponent1.Name = "needle";
      this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style17;
      this.arcScaleNeedleComponent1.StartOffset = -27F;
      this.arcScaleNeedleComponent1.ZOrder = -50;
      // 
      // EventsCurrentYear
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gaugeControl1);
      this.Name = "EventsCurrentYear";
      this.Size = new System.Drawing.Size(470, 291);
      ((System.ComponentModel.ISupportInitialize)(this.eventsCurrentYearGauge)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
    private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge eventsCurrentYearGauge;
    private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
    private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
    private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
  }
}
