# web-api-example
Getting my head around web api. I'm following the tutorial here https://docs.microsoft.com/en-gb/aspnet/core/tutorials/first-web-api-mac

It's fair to say that some of the .Net core pattern is a little unfamiliar, but the more I look at it, the more it seems like the only way to fly - so many nice shortcuts. I particularly like the way it's got JSON front-and-centre, e.g. the way the controller method parameters are decorated with [FromBody] to indicate explicitly that it's expecting a json representation of data to come down the pipe. No (or perhaps less?) mucking about with JsonConvert!

Attribute routing is very neat. No more "doh" forgot to add something to the Routing class.

dotnet run

THe more I read, the more I like.

In terms of authentication, this is an interesting blog post https://jonhilton.net/2017/05/03/login-authentication-asp-net-core-web-api-big-picture/ which suggests a third authentication server that would provide a token in the form of a cookie to the user. If we're looking at this from the perspective of a smart contract or state channel interacting with a web api, I imagine the API would be looking for the client to be carrying a keychain that it knows about. In the same way that a smart contract is looking for transactions signed by specific keys, perhaps the API would operate in a similar way. If a state channel was opened for a specific user/account (or set of accounts) it would want all subsequent interactions to be signed by the same account. Not sure what that means in practice yet. 
Here's another good piece by Incapsula about general principles https://www.incapsula.com/blog/best-practices-for-securing-your-api.html
