using Core.Model;

namespace UI.Presenters;

public interface IAppointmentPresenter
{
    void InitWith(Appointment appointment, string pacientId);
    void Show();

}