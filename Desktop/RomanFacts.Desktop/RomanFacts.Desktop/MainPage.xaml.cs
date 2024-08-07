using RomanFacts.Library;

namespace RomanFacts.Desktop
{
    public partial class MainPage : ContentPage
    {
        private Service factService;

        public MainPage()
        {
            InitializeComponent();
            factService = new Service();
            ShowFact();
        }


        private void ShowFact(string category = "history")
        {
            // history is the default.. TODO: Make random
            
            var fact = factService.GetFact(category);
            FactLabel.Text = fact;
        }

        #region Control Actions

        #region Clicks
        private void OnRefreshFactClicked(object sender, EventArgs e)
        {
            ShowFact();
        }
        #endregion

        #region OnChanged
        private void OnCategoryChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            // TODO: Sanitize selected text or disable user text input
            var category = picker.SelectedItem.ToString();
            ShowFact(category);
        }
        #endregion

        #endregion


    }
}
