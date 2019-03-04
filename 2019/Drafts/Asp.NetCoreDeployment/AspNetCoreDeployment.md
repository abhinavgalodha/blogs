# Step by Step guide for Deployment of Asp.net Core applications  in IIS

## Introduction

In this article, we will do a step by step setup of an Asp.Net core Application in IIS. The Web Site/Web API will reside in IIS and can leverage the existing functionality of the IIS.We will take a look into various options of Deploying an Asp.net core application like Self Contained Deployment and Framework Dependent Deployments.

## Why Host in IIS

IIS is the one of the stable Application Server in the Market today. It offers a lot of functionality like Process management.

<TODO> : Add a couple of features of IIS.

Asp.net Core uses a new Kestrel Web Server for Managing the Asp.net core Requests. 

## Publish the Asp.Net Core Application

The first step is to create Artifacts/outputs for our Application. We need to compile our application and prepare the outputs so that it can be served by an Application Server. We will use the publish option for artifact creation. Asp.net core can be published in 2 ways, Self Contained Deployment and Framework Dependent Deployment.

### Deployment Modes - Self Contained Deployment / Framework Dependent Deployment

* Self Contained Deployment (SCD)
  * Ships the entire Asp.net core runtime and the application together in Same Folder.
  * Allows side by side versioning allowing multiple versions of the Asp.net core runtime to be used on the same machine.
  * Artifact size is bigger.
  
* Framework Dependent Deployment (FDD)
  * Requires the Asp.net core runtime to be installed on the machine.
  * Artifacts size is smaller.
  * Doesn't allow multiple version of the .net core runtime to be installed.

You will need to decide which deployment mode works for you. For more information, refer here
<ToDO> Ms docs link






#### Publish using Visual Studio


#### Publish using command line



### Pros and Cons

## Installation on the IIS Server

### Hosting Bundle

#### VC Runtime

### Application Pool

### Website setup and Mapping

#### In Process and Out Of Process Hosting

### Validation Steps

## Conclusion

### References

#### Version History

3/4/2018 - 1