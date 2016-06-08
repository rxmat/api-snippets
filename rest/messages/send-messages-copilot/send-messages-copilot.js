// Download the Node helper library from twilio.com/docs/node/install
// These vars are your accountSid and authToken from twilio.com/user/account
var accountSid = '{{ account_sid }}';
var authToken = "{{ auth_token }}";
var client = require('twilio')(accountSid, authToken);

client.sendMessage({
    messagingServiceSid: 'MG9752274e9e519418a7406176694466fa',
    to: '+16518675309',
    body: 'Phantom Menace was clearly the best of the prequel trilogy.'
}, function(err, message) {
    console.log(message);
});