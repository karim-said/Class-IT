namespace Soliev
{
    public interface IBrowserMethod
    {
        Browser Back(Browser browser);

        Browser Next(Browser browser);

        Browser EditUrl(Browser browser);

        string Refresh();

        string ShowHistory();

        string AddPageToHome();
    }
}
