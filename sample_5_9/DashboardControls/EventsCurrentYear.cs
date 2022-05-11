using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using EventsDB;

namespace sample_5_9.DashboardControls {
  public partial class EventsCurrentYear : DevExpress.XtraEditors.XtraUserControl {
    public EventsCurrentYear() {
      InitializeComponent();

      ConfigureGauge();
    }

    void ConfigureGauge() {
      int year = DateTime.Now.Year;
      int eventCount = new XPQuery<Event>(new UnitOfWork()).Where(e => e.StartDate.Year == year).Count();
      var ecyScale = eventsCurrentYearGauge.Scales[0];
      ecyScale.Value = eventCount;
    }
  }
}
