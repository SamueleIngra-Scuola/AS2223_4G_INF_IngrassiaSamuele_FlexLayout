namespace FlexLayout;

public partial class MainPage : ContentPage
{
    Vector serial = new Vector();
    Vector batteryLife = new Vector();
    Vector price = new Vector();

    public MainPage()
	{
		InitializeComponent();
	}

	private void btnEnter_Clicked(object sender, EventArgs e)
	{
		serial.Insert(Int32.Parse(txtSerial.Text));
        batteryLife.Insert(Int32.Parse(txtBatteryLife.Text));
        price.Insert(Int32.Parse(txtPrice.Text));
    }
}

