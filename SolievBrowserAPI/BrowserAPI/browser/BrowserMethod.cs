namespace Soliev
{
    public class BrowserMethod : IBrowserMethod
    {
        public string AddPageToHome()
        {
            return string.Format("Add page to Complete!");
        }

        public Browser Back(Browser browser)
        {
            browser.CoutOfPage = "Back page!";
            return browser;
        }

        public Browser EditUrl(Browser browser)
        {
            browser.Url = "Change url complete!";
            return browser;
        }

        public Browser Next(Browser browser)
        {
            browser.CurrentPage = "Next page !";
            return browser; 
        }

        public string Refresh()
        {
            return "Refresh complete!";
        }

        public string ShowHistory()
        {
            return "Show history!";
        }
    }
}
