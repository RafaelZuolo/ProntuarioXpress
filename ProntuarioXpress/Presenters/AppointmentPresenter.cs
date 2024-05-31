using UI.ViewItems;

namespace UI.Presenters;

public class AppointmentPresenter
{
    private IAppointmentForm form;
    private AppointmentViewItem appointment = new();

    public AppointmentPresenter(IAppointmentForm form)
    {
        this.form = form;
    }

    internal void Show()
    {
        form.ShowForm();
    }
}
