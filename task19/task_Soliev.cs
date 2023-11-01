using System;
using System.Collections.Generic;

class Browser
{
    private string Url;
    private int CountOfPage;
    private int CurrentPage;
    private List<string> History;
    private List<string> HomePage;

    public Browser()
    {
        Url = "https://www.google.com";
        CountOfPage = 1;
        CurrentPage = 1;
        History = new List<string>();
        HomePage = new List<string>();
        HomePage.Add(Url);
    }

    public Browser(string initialUrl, int pageCount, int currentPage)
    {
        Url = initialUrl;
        CountOfPage = pageCount;
        CurrentPage = currentPage;
        History = new List<string>();
        HomePage = new List<string>();
        HomePage.Add(Url);
    }

    public void Back()
    {
        if (CurrentPage > 1)
        {
            CurrentPage--;
            Url = History[CurrentPage - 1];
        }
        else
        {
            Console.WriteLine("Cannot go back further.");
        }
    }

    public void Next()
    {
        if (CurrentPage < CountOfPage)
        {
            CurrentPage++;
            Url = History[CurrentPage - 1];
        }
        else
        {
            Console.WriteLine("Cannot go forward further.");
        }
    }

    public void EditUrl(string newUrl)
    {
        Url = newUrl;
        History.Add(Url);
        CountOfPage = CurrentPage = History.Count;
    }

    public void Refresh()
    {
        if (CurrentPage <= History.Count)
        {
            Url = History[CurrentPage - 1];
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Browsing History:");
        foreach (string page in History)
        {
            Console.WriteLine(page);
        }
    }

    public void AddPageToHome(string page)
    {
        HomePage.Add(page);
    }

    public void ShowHomePage()
    {
        Console.WriteLine("Home Page:");
        foreach (string page in HomePage)
        {
            Console.WriteLine(page);
        }
    }
}

class Program
{
    static void Main()
    {
        Browser myBrowser = new Browser();
        myBrowser.EditUrl("https://www.google.com");
        myBrowser.Next();
        myBrowser.ShowHistory();
        myBrowser.AddPageToHome("https://www.youtube.com");
        myBrowser.AddPageToHome("https://www.github.com");
        myBrowser.ShowHomePage();
    }
}
