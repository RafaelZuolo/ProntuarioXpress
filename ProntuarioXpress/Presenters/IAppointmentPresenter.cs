using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public interface IAppointmentPresenter
{
    void InitWith(Appointment appointment, string pacientId);
    void InitWith(AppointmentViewItem appointmentViewitem, string pacientId);
    void Show();

}