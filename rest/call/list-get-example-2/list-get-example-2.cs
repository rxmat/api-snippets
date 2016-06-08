// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
class Example 
{
  static void Main(string[] args) 
  {
    // Find your Account Sid and Auth Token at twilio.com/user/account
    string AccountSid = "{{ account_sid }}";
    string AuthToken = "{{ auth_token }}";
    var twilio = new TwilioRestClient(AccountSid, AuthToken);

    var request = new CallListRequest();
    request.Status = "completed";
    request.StartTimeComparison = ComparisonType.EqualTo;
    request.StartTime = new DateTime(2009, 07, 06);
    var calls = twilio.ListCalls(request);
    
    foreach (var call in calls.Calls)
    {
      Console.WriteLine(call.Direction);
    }
  }
}