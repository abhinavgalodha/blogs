# Who deleted the file?
Had you ever a scenario, where a file has been deleted from a machine and you are wondering who deleted the file and had no idea who was the culprit. Good Luck! In this article, i will try to explain a technique available on windows machine to find out who deleted the file.

## Motivation
The reason for writing this article is that we faced this issue in our production and i thought it might be useful for readers if ever they encounter such an issue. Our problem started when one of our production server went out of the load balancer. We have an Asp.net core 2.x application, which is deployed as a Self contained Application. In a self contained deployment the complete .net core framework is bundled in a folder and it also includes your asp.net core Exe which is initiated by the IIS server. In our scenario, the exe was being deleted which was causing 502.5 process error as the Host Process couldn't be started. Since, this is a production server and has restricted access it wasn't possible that a user is deleting the file. It was random delete operation and happened on some servers while others were working fine. This was the inspiration for identifying how the exe was getting deleted.

If you couldn't follow with the this reasoning, yoy may be able to relate with following scenario where you might beed to find out who deleted the file?

* A Shared folder among the team has certain files deleted.
* The deployed application is missing certain files.

## What Windows OS offers?
Windows offers the Audit features using various Policies which allows to Audit the access requests, Audit login, Process tracking etc. The policies basically defines a registry setting which defines the behavior of the feature. 

# How to know who deled the file?
The following process would help us in identifying who deleted the file.
1. Set up Local Group Security Audit Policy for monitoring the File System. This is done using the Group Policy editor or Local Group Policy Editor.
2. Set up Audit Policy for the folder and define what kind of Auditing is required. Define who and what is required to be Audited.
3. 

