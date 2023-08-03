namespace Test;

public class StreamIOTest
{
    public static void GetCurrencies()
    {

    }
}

class CurrencyService
{
    private readonly HttpClient _httpClient;
    public CurrencyService()
    {
        _httpClient = new HttpClient();
    }
/*
    public string GetCurrenies()
    {
        string url = "https://test/";
        var result = _httpClient.GetStringAsync(url).Result;
        return result;
    }
    */
}