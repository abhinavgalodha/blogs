# Various ways to verify the Connectivity from Client to Server

Most of the code I write, involves connectivity from one machine to another remote machine. For e.g. While working on a Frontend application, it needs to communcate with Another API. It's utmost important to understand if the connectivity exists between the two machines and the port for the destination machine is open. In this article, i will explore few technique to test the network connectivity with another machine & Port number. You might find these helpful in case you need to verify the connectivity to remote machines.

### What are various Steps to verify Connectivity

1. The first step in this process is to verify the **Network** connectivity with the remote machine.

2. Next, Verify the Connectivity to the Destination port to check if the port is blocked or inaccessible.

[TBD]Diagram

# Verify the Connectivity from Client to Server Using Ping

## Check Connectivity between machines using Ping

The old good friend, "Ping". Using the **Ping** command, we can verify the network level connectivity between client and Remote Machine.

### How to use ping

1. Open command prompt.
2. Enter ping command, passing the destination machine machine IP or Host name e.g. **ping 34.45.5.6**

### Successfull Response 

![ping](Images/ping.png)

If Ping Succeeds, we will get a reply from destination machine. This ensures that the connectivity exists between source and destination machines.

### Failure Response 
If ping results in a **"Request timed out."** message, then there is a connectivity issue from Source to destination. 

![ping](Images/pingFailure.png)

*At the N/w level Ping rely on ICMP, which is layer 3, hence it doesn't check if a port is open or not.*
So, it is possible that ping works but still the call to API on destination machine doesn't work.

## Verify the Connectivity from Client to Server Using Telnet

Wikipedia defines Telnet as 
>"Telnet is a protocol used on the Internet or local area networks to provide a bidirectional interactive text-oriented communication facility using a virtual terminal connection.". At N/w level, Telnet works in the Application layer and needs the ports connectivity.

Telnet gets its name from Terminal Network. With Telnet, we can establish a host session to a server. The advantage of using Telnet is that we can verify the connectivity to a port as well.

### Why Telnet is not preffered?

Telnet uses plain text for communication and hence not encrypted. Therefore, in Windows, by default the TelNet Client is disabled. Telnet can be enabled in windows by Adding/Removing windows component using Control Panel.


### How to use Telnet

1. Enter command prompt.
2. Use telnet command passing in the Destination Server Name/Address and the port number. e.g. telnet destination 80. 

**Note:** The default port for telnet is 23. So, if we omit the port number in telnet command, the  Telnet will try to connect to the destination using port 23.

### Telnet succeeds

After entering the telnet command, we will see the text *"Connecting to HostName..."* as shown in below image.

![telnet connecting](Images/telnetConnecting.png)

If the connection succeds, We will see a blank screen. Notice the Title of the console window. It should read Telnet <DestinationName>

![telnet connected](Images/telnetConnected.png)

### Telnet Failure

![telnet failure](Images/telnetFailure.png)
If the destination Machine or the port is inaccesible, we will get the error *"Could not open connection to the host, on port 80: Connection failed"*

## Verify the Connectivity from Client to Server Using Powershell
My most preffered option, It is powerful as It allows to explore all the potential of .net framework as we can call any method of the .net framework using powershell. 

### Option 1 - Test-NetConnectioncommand

If you're running Windows 8/Windows Server 2012 or newer, you can use the Test-NetConnectioncommand.

The Test-NetConnection cmdlet displays diagnostic information for a connection. It supports ping test, TCP test, route tracing, and route selection diagnostics. Depending on the input parameters, the output can include the DNS lookup results, a list of IP interfaces, IPsec rules, route/source address selection results, and/or confirmation of connection establishment.

```
Test-NetConnection -Port 53 -ComputerName LON-DC1
```

**Output**

```
PS C:\> Test-NetConnection -ComputerName "www.contoso.com" -InformationLevel "Detailed"
PingReplyDetails (RTT) : 164 ms
ComputerName           : www.contoso.com
RemoteAddress          : 65.55.39.10
NameResolutionResults  : 65.55.39.10
64.4.6.100
InterfaceAlias         : Ethernet
SourceAddress          : 10.137.193.122
NetRoute (NextHop)     : 10.137.192.1
PingSucceeded          : True
PingReplyDetails (RTT) : 164 ms
```

### Option 2

Initializes a new instance of the TcpClient class and connects to the specified port on the specified host.

This constructor creates a new TcpClient and makes a synchronous connection attempt to the provided host name and port number. The underlying service provider will assign the most appropriate local IP address and port number. TcpClient will block until it either connects or fails. This constructor allows you to initialize, resolve the DNS host name, and connect in one convenient step.

If IPv6 is enabled and the TcpClient(String, Int32) method is called to connect to a host that resolves to both IPv6 and IPv4 addresses, the connection to the IPv6 address will be attempted first before the IPv4 address. This may have the effect of delaying the time to establish the connection if the host is not listening on the IPv6 address.

```
New-Object Net.Sockets.TcpClient "10.45.23.109", 443 
```

$ipaddress = IP_Address_Server
$port = port
$connection = New-Object System.Net.Sockets.TcpClient($ipaddress, $port)
if ($connection.Connected) {
    Write-Host "Success"
}
else {
    Write-Host "Failed"
}



## Summary
In this article, we explored 3 techniques to verify the connectivity to destination machine and the port number. We looked at the Ping, Telnet and powershell commands to verify the connectivity. These technique are mostly supported on Windows Operating System.



How to verify connectivity?
Why?
How?


• Most of the time a firewall is blocking the traffic. This firewall can either be on your local machine or on the server. Check both ends for a firewall. If the actual server is on a different network, for example across the Internet, there could be other firewalls in the middle.
	• The server process is NOT running. Ensure the server is running