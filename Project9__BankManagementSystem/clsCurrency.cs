using System;
using System.Collections.Generic;
using System.IO;

public class clsCurrecy
{
    private string _country;
    private string _currencyCode;
    private string _currencyName;
    private float _rate;

    public clsCurrecy () { }
    public clsCurrecy(string country, string currencyCode, string currencyName, float rate)
    {
        _country = country;
        _currencyCode = currencyCode;
        _currencyName = currencyName;
        _rate = rate;
    }

    private static string ConvertCurrencyObjToDataLine(clsCurrecy currency, string separator = "#//#")
    {
        return $"{currency._country}{separator}{currency._currencyCode}{separator}{currency._currencyName}{separator}{currency._rate}";
    }

    private static clsCurrecy ConvertLineToCurrencyObj(string line, string separator = "#//#")
    {
        var currencyData = line.Split(new string[] { separator }, StringSplitOptions.None);
        return new clsCurrecy(currencyData[0], currencyData[1], currencyData[2], float.Parse(currencyData[3]));
    }

    private static List<clsCurrecy> LoadCurrencyDataFromFile()
    {
        var currencies = new List<clsCurrecy>();

        if (File.Exists("Currencies.txt"))
        {
            using (var file = new StreamReader("Currencies.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    currencies.Add(ConvertLineToCurrencyObj(line));
                }
            }
        }

        return currencies;
    }

    private static void SaveCurrencyDataToFile(List<clsCurrecy> currencies)
    {
        using (var file = new StreamWriter("Currencies.txt"))
        {
            foreach (var currency in currencies)
            {
                file.WriteLine(ConvertCurrencyObjToDataLine(currency));
            }
        }
    }

    private void Update()
    {
        var currencies = LoadCurrencyDataFromFile();

        for (int i = 0; i < currencies.Count; i++)
        {
            if (currencies[i]._currencyCode == _currencyCode)
            {
                currencies[i] = this;
                break;
            }
        }

        SaveCurrencyDataToFile(currencies);
    }

    //public static List<clsCurrecy> GetAllUSDRates()
    //{
    //    return LoadCurrencyDataFromFile();
    //}

    public string CurrencyCode => _currencyCode;
    public string Country => _country;
    public string CurrencyName => _currencyName;
    public float Rate => _rate;

    public bool UpdateRate(float newRate)
    {
        _rate = newRate;
        Update();
        return true;
    }

    public static clsCurrecy FindByCode(string currencyCode)
    {
        currencyCode = currencyCode.ToUpper();

        if (File.Exists("Currencies.txt"))
        {
            using (var file = new StreamReader("Currencies.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var currency = ConvertLineToCurrencyObj(line);
                    if (currency.CurrencyCode == currencyCode)
                    {
                        return currency;
                    }
                }
            }
        }

        return null;
    }

    public static clsCurrecy FindByCountry(string country)
    {
        country = country.ToUpper();

        if (File.Exists("Currencies.txt"))
        {
            using (var file = new StreamReader("Currencies.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var currency = ConvertLineToCurrencyObj(line);
                    if (currency.Country.ToUpper() == country)
                    {
                        return currency;
                    }
                }
            }
        }

        return null; 
    }

    
    public static bool IsCurrencyExist(string currencyCode)
    {
        return FindByCode(currencyCode) != null;
    }

    public static List<clsCurrecy> GetCurrenciesList()
    {
        return LoadCurrencyDataFromFile();
    }

    public double ConvertToUSD(double amount)
    {
        return amount / _rate;
    }

    public double ConvertToOtherCurrency(double amount, clsCurrecy currency)
    {
        double amountInUsd = ConvertToUSD(amount);
        return currency.CurrencyCode == "USD" ? amountInUsd : amountInUsd * currency.Rate;
    }
}
