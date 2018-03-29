# Test Network Connectivity

Most of the code I write, involves connectivity from one machine to another remote machine via HTTP API's. It's utmost important to understand if the connectivity succeeds and the port for the communication is open. In this article, i will explore few technique to test the network connectivity with another machine & Port. You might find these helpful in case you need to verify the connectivity to remote machines.

1. The first step in this process is to verify the **Network** connectivity with the remote machine.

2. Next, Verify the Connectivity to the Destination port to check if the port is blocked or inaccessible.

[TBD]Diagram

# Various ways to verify the Connectivity from Client to Server

## Ping

The old good friend, "Ping". Using the **Ping** command, we can verify the network level connectivity between client and Remote Machine. Use **ping** command, passing the destination machine machine IP or Host name as shown below.

### Successfull Response 

![ping](Images/ping.png)

If Ping Succeeds, we will get a reply from destination machine. This ensures that the connectivity exists between source and destination machines.

### Failure Response 
If ping results in a **"Request timed out."** message, then there is a connectivity issue from Source to destination. 

![ping](Images/pingFailure.png)

*At the N/w level Ping rely on ICMP, which is layer 3, hence it doesn't check if a port is open or not.*
So, it is possible that ping works but still the call to API on destination machine doesn't work.


Telnet and HTTP, however, reside in the application layer, and so they require those ports to function.

### Telnet
Wikipedia defines Telnet as following..
>"Telnet is a protocol used on the Internet or local area networks to provide a bidirectional interactive text-oriented communication facility using a virtual terminal connection.". 

Telnet gets its name from Terminal Network. With Telnet, we can establish a host session to a server .
However, the communication is carried in plain text and hence not encrypted. Therefore, in Windows, by default the TelNet Command line interface is disabled. Telnet can be enabled in windows by Adding/Removing windows component using Control Panel.

if your client machine can connect to the server machine. Use the following steps to perform this test
	• Type the following in the Console (DOS) Window

telnet serverOne 1433

The default port for telnet is usually the port number 23.

IMPORTANT: On Windows Vista and Windows 7, Microsoft does not install the Telnet client by default. You will have to install this manually from Add Remove Windows Component. 
	• You should either see a blank screen or something garbled representing some binary data. This means you can connect to the server.
	• If you get a message like:

Could not open connection to the host, on port 1433: Connection failed

It means you cannot connect and there is a network problem.
Following is a list of reason why you cannot connect.
	• Most of the time a firewall is blocking the traffic. This firewall can either be on your local machine or on the server. Check both ends for a firewall. If the actual server is on a different network, for example across the Internet, there could be other firewalls in the middle.
	• The server process is NOT running. Ensure the server is running
Ensure the TCP/IP port number is correct. In the above example, I used 1

## Using Poweshell

### Option 1

If you're running Windows 8/Windows Server 2012 or newer, you can use the Test-NetConnectioncommand.
Ex : Test-NetConnection -Port 53 -ComputerName LON-DC1


New-Object Net.Sockets.TcpClient "10.45.23.109", 443 

### Option 2


New-Object Net.Sockets.TcpClient "10.45.23.109", 443 


Steps
1. Use the script bellow to check if the port is open.
2. Replace IP_Address_Server with the address of the server you are interested in.
3. Replace port with the port to check (e.g. 17777).
4. Save this script in a text file as porttest.ps1 and run in PowerShell.
$ipaddress = IP_Address_Server
$port = port
$connection = New-Object System.Net.Sockets.TcpClient($ipaddress, $port)
if ($connection.Connected) {
    Write-Host "Success"
}
else {
    Write-Host "Failed"
}

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



