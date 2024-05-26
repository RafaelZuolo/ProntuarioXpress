using UI.ViewItems;

namespace UI.Presenters;

public class AppointmentPresenter
{
    private AppointmentForm form;
    private AppointmentViewItem appointment = new();

    public AppointmentPresenter(AppointmentForm form)
    {
        this.form = form;
    }

    internal void Show()
    {
        form.Show();
    }
}
