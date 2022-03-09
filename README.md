# SignalRChat
## What is Signal R?
SignalR is a data notification service and it is an open-source provided by Microsoft that help us for real-time functionality to apps(Any front end). Real-time functionality means that it sends server-side messages to push client-side without any user action.
This kind of communication is managed through protocols, There are three kinds of protocols that signalR uses:
1. WebSockets
2. Server-Sent Events
3. Long Polling

Note: The default is a websocket


### SignalR is used in many application scenarios such as
1. Chat applications
2. Online gaming
3. Automatic updating of applications
4. Notifications and alerts and so on.

## Using the code
We have 2 solutions here. Backened and the client
1. DemoChat.WebApi : This solution needs to be built and hosted on Azure cloud as a normal App service.
2. DemoChat.Client: This solution can be deployed on any 2 mobiles and start chating. 

Note:  
1. You can also host client app on 2 simulators and it do the job for you.
2. Please update the Huburl in Constants class with actual url hosted on azure Ex: http://xxxx.azurewebsites.net/chatter

## Snapshots
<p align="center">
  <img src="/Images/joinchatpage.JPG" height="500">
</p>
<p align="center">
  <img src="/Images/chat.JPG" height="600">
</p>
