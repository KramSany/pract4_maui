namespace pract4;

public partial class secondPage : ContentPage
{
    private MouthOption mouthOption = new MouthOption();
    private Mounth mounth;
	public secondPage()
	{
		InitializeComponent();
	}

    private void NextMounthBtn_OnClicked(object sender, EventArgs e)
    {
        if (!Enum.IsDefined(typeof(Mounth), entryMounth.Text))
        {
            DisplayAlert("��������������!", "������ ������ ���, ���� ��� ���", "��");
            entryMounth.Text = "";
        }
        else DisplayAlert("�����", $"��������� ����� ����� {entryMounth.Text} - {mouthOption.GetMounth(entryMounth.Text)}", "okay");
        


    }
}