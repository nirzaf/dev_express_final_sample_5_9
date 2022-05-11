namespace sample_5_9 {
  partial class EventView {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.commitChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.discardChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.printExportItem = new DevExpress.XtraBars.BarButtonItem();
      this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
      this.dayScrollerPanel = new DevExpress.XtraEditors.PanelControl();
      this.dayScrollbar = new DevExpress.XtraEditors.HScrollBar();
      this.eventCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
      this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
      this.customerCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.venueCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dayScrollerPanel)).BeginInit();
      this.dayScrollerPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eventCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
      this.splitContainerControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.venueCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // commitChangesItem
      // 
      this.commitChangesItem.Caption = "Save Changes";
      this.commitChangesItem.Id = 0;
      this.commitChangesItem.ImageOptions.SvgImage = global::sample_5_9.Properties.Resources.savechanges;
      this.commitChangesItem.Name = "commitChangesItem";
      // 
      // discardChangesItem
      // 
      this.discardChangesItem.Caption = "Discard Changes";
      this.discardChangesItem.Id = 1;
      this.discardChangesItem.ImageOptions.SvgImage = global::sample_5_9.Properties.Resources.discardchanges;
      this.discardChangesItem.Name = "discardChangesItem";
      // 
      // printExportItem
      // 
      this.printExportItem.Caption = "Print && Export";
      this.printExportItem.Id = 2;
      this.printExportItem.ImageOptions.SvgImage = global::sample_5_9.Properties.Resources.printexport;
      this.printExportItem.Name = "printExportItem";
      // 
      // schedulerStorage
      // 
      this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CustomCapacity", "Capacity", DevExpress.XtraScheduler.FieldValueType.Integer));
      this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CustomRoomSetup", "RoomSetup"));
      this.schedulerStorage.Appointments.Mappings.End = "EndTime";
      this.schedulerStorage.Appointments.Mappings.Start = "StartTime";
      this.schedulerStorage.Appointments.Mappings.Subject = "Name";
      this.schedulerStorage.EnableReminders = false;
      // 
      // dayScrollerPanel
      // 
      this.dayScrollerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.dayScrollerPanel.Controls.Add(this.dayScrollbar);
      this.dayScrollerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dayScrollerPanel.Location = new System.Drawing.Point(0, 51);
      this.dayScrollerPanel.Margin = new System.Windows.Forms.Padding(0);
      this.dayScrollerPanel.Name = "dayScrollerPanel";
      this.dayScrollerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 19, 0);
      this.dayScrollerPanel.Size = new System.Drawing.Size(581, 16);
      this.dayScrollerPanel.TabIndex = 2;
      // 
      // dayScrollbar
      // 
      this.dayScrollbar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dayScrollbar.LargeChange = 1;
      this.dayScrollbar.Location = new System.Drawing.Point(0, 0);
      this.dayScrollbar.Margin = new System.Windows.Forms.Padding(0);
      this.dayScrollbar.Maximum = 10;
      this.dayScrollbar.Name = "dayScrollbar";
      this.dayScrollbar.Size = new System.Drawing.Size(562, 16);
      this.dayScrollbar.TabIndex = 1;
      // 
      // eventCollection
      // 
      this.eventCollection.ObjectType = typeof(EventsDB.Event);
      this.eventCollection.Session = this.unitOfWork;
      // 
      // splitContainerControl1
      // 
      this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerControl1.Horizontal = false;
      this.splitContainerControl1.Location = new System.Drawing.Point(0, 150);
      this.splitContainerControl1.Name = "splitContainerControl1";
      this.splitContainerControl1.Panel1.Text = "Panel1";
      this.splitContainerControl1.Panel2.Controls.Add(this.dayScrollerPanel);
      this.splitContainerControl1.Panel2.Text = "Panel2";
      this.splitContainerControl1.Size = new System.Drawing.Size(581, 200);
      this.splitContainerControl1.SplitterPosition = 123;
      this.splitContainerControl1.TabIndex = 4;
      this.splitContainerControl1.Text = "splitContainerControl1";
      // 
      // customerCollection
      // 
      this.customerCollection.ObjectType = typeof(EventsDB.Customer);
      this.customerCollection.Session = this.unitOfWork;
      // 
      // venueCollection
      // 
      this.venueCollection.ObjectType = typeof(EventsDB.Venue);
      this.venueCollection.Session = this.unitOfWork;
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.commitChangesItem,
            this.discardChangesItem,
            this.printExportItem});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
      this.ribbonControl1.Size = new System.Drawing.Size(581, 150);
      // 
      // ribbonPageCategory1
      // 
      this.ribbonPageCategory1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.ribbonPageCategory1.Appearance.Options.UseBackColor = true;
      this.ribbonPageCategory1.Name = "ribbonPageCategory1";
      this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonPageCategory1.Text = "Events";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Data Operations";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.commitChangesItem);
      this.ribbonPageGroup2.ItemLinks.Add(this.discardChangesItem);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Persistence";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.printExportItem, true);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Tools";
      // 
      // EventsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerControl1);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "EventsView";
      this.Size = new System.Drawing.Size(581, 350);
      this.Load += new System.EventHandler(this.EventView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dayScrollerPanel)).EndInit();
      this.dayScrollerPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.eventCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
      this.splitContainerControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.venueCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
    private DevExpress.Xpo.XPCollection eventCollection;
    private DevExpress.Xpo.UnitOfWork unitOfWork;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.Xpo.XPCollection customerCollection;
    private DevExpress.Xpo.XPCollection venueCollection;
    private DevExpress.XtraBars.BarButtonItem commitChangesItem;
    private DevExpress.XtraBars.BarButtonItem discardChangesItem;
    private DevExpress.XtraEditors.HScrollBar dayScrollbar;
    private DevExpress.XtraEditors.PanelControl dayScrollerPanel;
    private DevExpress.XtraBars.BarButtonItem printExportItem;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
  }
}