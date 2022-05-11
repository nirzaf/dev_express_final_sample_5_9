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
  public partial class RoomBookingsCurrentYear : DevExpress.XtraEditors.XtraUserControl {
    public RoomBookingsCurrentYear() {
      InitializeComponent();

      ConfigureGauge();
    }

    void ConfigureGauge() {
      int year = DateTime.Now.Year;
      int roomBookingsCount = new XPQuery<RoomBooking>(new UnitOfWork()).Where(rb => rb.StartTime.Year == year).Count();
      var rbcyScale = roomBookingsCurrentYearGauge.Scales[0];
      rbcyScale.Value = roomBookingsCount;
    }
  }
}
