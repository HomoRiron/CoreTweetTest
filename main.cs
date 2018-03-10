using System;
using CoreTweet;

class main{
  static string ConsumerKey = "";
  static string ConsumerSecret = "";
  static Tokens tokens;
  static void Main(string[] args){
    if(args[0].ToLower() == "oauth"){
      OAuth();
    }else{
      Normal("YourAccessToken","YourAccessTokenSecret");
    }
    LoginResult();
  }
  static void OAuth(){
    var session = OAuth.Authorize(ConsumerKey,ConsumerSecret);
    System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
    Console.Write("PIN:");
    var PinCode = Console.ReadLine();
    tokens = OAuth.GetTokens(session,PinCode);
  }
  static void Normal(string AccessToken,string AccessTokenSecret){
     tokens = Tokens.Create(ConsumerKey,ConsumerSecret,AccessToken,AccessTokenSecret);
  }
  static void LoginResult(){
    var Profile = tokens.Account.VerifyCredentials();
    Console.WriteLine("Login Success");
    Console.WriteLine($"Screen Name: @{Profile.ScreenName}");
  }
}
