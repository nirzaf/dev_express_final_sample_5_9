using DevExpress.XtraEditors;
using EventsDB;
using DevExpress.XtraBars.Docking2010;

namespace sample_5_9 {
  public partial class EventView : XtraUserControl {
    public EventView() {
      InitializeComponent();
    }

    private void EventView_Load(object sender, System.EventArgs e) {
      TransactionalChangeHandler.Hookup<Event>(
        DocumentManager.FromControl(ParentForm).View, unitOfWork, commitChangesItem,
        discardChangesItem, eventCollection);
    }
  }
}