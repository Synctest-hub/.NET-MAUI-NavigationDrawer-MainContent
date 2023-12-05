namespace NavigationDrawerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.ItemSelected += listView_ItemSelected;
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Out box");
            list.Add("Sent");
            list.Add("Draft");
            listView.ItemsSource = list;
        }

        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem.ToString() == "Home")
                contentviewLabel.Text = "Home";
            else if (e.SelectedItem.ToString() == "Profile")
                contentviewLabel.Text = "Profile";
            else if (e.SelectedItem.ToString() == "Inbox")
                contentviewLabel.Text = "Inbox";
            else if (e.SelectedItem.ToString() == "Out box")
                contentviewLabel.Text = "Out box";
            else if (e.SelectedItem.ToString() == "Sent")
                contentviewLabel.Text = "Sent";
            else if (e.SelectedItem.ToString() == "Draft")
                contentviewLabel.Text = "The folder is empty";
            navigationDrawer.ToggleDrawer();
        }
    }
}
