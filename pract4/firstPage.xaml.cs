using System.Runtime.CompilerServices;

namespace pract4;

public partial class firstPage : ContentPage
{
    private MouthOption mouthOption = new MouthOption();
    private bool _isCheck = true;
    private Mounth mounths;
    public firstPage()
    {
		InitializeComponent();
	}
    

    private void RadioButton_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var mounth = "";
        RadioButton rb = sender as RadioButton;

        if (rb.IsChecked && _isCheck)
        {
            mounth = rb.Content.ToString();
            DisplayAlert("ћес€ц", $"—ледующий мес€ц после {rb.Content.ToString()} - {mouthOption.GetMounth(mounth)}", "okay");
            _isCheck = false;
        }
        else _isCheck = true;
    }

}