# Summary
Measuring and Reporting the Response time of an API (Asp.Net Core).

## Introduction
Performance is the buzz word for the API's. One of the most important and measurable parameters of the performance of an API is the Response time of the API. In this article, we will understand how to add code to measure the response time of the API and then return the Response time data to the end client.

## What is the need?
So, let's take a moment to think why we would ever need such a feature to measure the Response time of an API. 

Following are some of the points that have been inspiration for writing code to Capture response time.

1. You need to define the SLA (Service Level Agreements) for your API with your clients. The clients needs to understand how much time does the API takes to respond back. The response time data over the time, can help us decide an SLA for our API.

2. Management is interested in reports as to how fast or slow is the Application. You need to have data to corrobarate your claims. It is worth to have reports on the performance of the application and share with Stakeholders.

3. Client needs to have the information of the Response time of the API, so that they can track how much time is spent in client and the Server.

You might also have encountered similar requests in your project and it is worthwhile looking at an approach to capture the response time for the API.

## Where to add the code?
Ignore the N/w
Ignore the IIS Startup..


Let's explore a couple of approaches to capture the Response time of our API focusing mostly on capturing the time spent in our API. 
Our objective is to calculate the time elapsed in milliseconds from the time the request is recieved by the Asp.net core runtime to the time the response is processed and sent back from the Server.

One very naive approach to capture response time of an API would be to add code to every API method at start and end and then measure the delta to calculate the response time. 

`// GET api/values/5
[HttpGet]
public IActionResult Get()
{
    // Start the watch
    var watch = new Stopwatch();
    watch.Start();
    
    // Your actual Business logic

    // End the watch
    watch.Stop();
    var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
}
`

## What is Asp.Net Core Middleware

## What to do with the Response time data?

## Defining the code

## Conclusion
