// See https://aka.ms/new-console-template for more information

using System.Globalization;

class Card
{
    public string CardNumber;
    public string OwnerFullname;
    public string ExpDate;
    public int SecurityCode;
    public string BankName;

}
public class Program
{
    public static void Main(string[] args)
    {
        Card card = new Card();
        card.CardNumber = "4169-7388-3489-4590";
        card.ExpDate = "03/26";
        card.BankName = "Kapital Bank";
        card.SecurityCode = 960;
        card.OwnerFullname = "Abdullah Manafli";
        Console.WriteLine( "CardNumber:" + card.CardNumber);
        Console.WriteLine( "OwnerFullname:" + card.OwnerFullname);
        Console.WriteLine( "ExpDate:" + card.ExpDate);
        Console.WriteLine( "BankName:" + card.BankName);
        Console.WriteLine( "SecurityCode:" + card.SecurityCode);
    }
}