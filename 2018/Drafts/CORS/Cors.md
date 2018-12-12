# Adding CORS support in asp.net core

Are you building a microservice using asp.net core and worried about integrating with multiple frontend application?
Do you want to understand CORS?

Or have you encountered the below error, and never understood why the error happens?

<TODO: Add the image of the error>

One of the issue during integration of API with Frontend might be CORS. In this post we will take a look at CORS, and how to add the CORS support in the Asp.net core web api to enable multiple clients in different domain interact with the API.

In modern software development with the advent of the microservices and the rise of the Distributed applications, more components than ever before are being developed in isolation. The monolith applications are being architectured to build smaller more manageable components in the form of the Asp.net core web api. The microservices can be deployed and scaled independently of the frontend. Also, since the Frontend needs to communicate with the API, it is the API responsibility to ensure that it allows the clients to interact and send appropriate data to clients to enable a secure communication.

## What is CORS?

A request for a resource (like an image or a font) outside of the origin is known as a cross-origin request. CORS (cross-origin resource sharing) manages cross-origin requests.
Cors is a **SECURITY** mechanim employed by the browsers like (Firefox, Chrome, IE etc.) to prevent the browsers from making calls to another Website. This is basically like trusting only your friends

What is another website? Another website is def

CORS introduces a standard mechanism that can be used by all browsers for implementing cross-domain requests. The spec defines a set of headers that allow the browser and server to communicate about which requests are (and are not) allowed. CORS continues the spirit of the open web by bringing API access to all.


### Same Origin

This prevents JavaScript from making requests across domain boundaries.
The same-origin policy is a security measure standardized among browsers. The "origin" mostly refers to a "domain". It prevents different origins from interacting with each other, to prevent attacks such as Cross Site Request Forgery.
The same-origin policy is very restrictive.

The same-origin policy is an important security concept implemented by web browsers to prevent Javascript code from making requests against a different origin (e.g., different domain) than the one from which it was served. Although the same-origin policy is effective in preventing resources from different origins, it also prevents legitimate interactions between a server and clients of a known and trusted origin.

An origin is made up of the following three parts: the protocol, host, and port number. 

#### Why Same Origin

Allows to do CSRF, for another day..


CORS stands for CROSS ORIGIN RESOURCE SHARING

## Pre-flight requests

If a request may have implications on user data, a simple request is insufficient. Instead, a preflight CORS request is sent in advance of the actual request to ensure that the actual request is safe to send. Preflight requests are appropriate when the actual request is any HTTP Method other than GET, POST, or HEAD or if a POST request's content type is anything other than application/x-www-form-urlencoded, multipart/form-data, or text/plain. Also, if the request contains any custom headers, then a preflight request is required.

The preflight request is essentially asking the server if it would allow the DELETE request, without actually sending the DELETE request

Preflight requests use the OPTIONS header. The preflight request is sent before the original request, hence the term "preflight." The purpose of the preflight request is to determine whether or not the original request is safe (for example, a DELETE request)

AngularJS 

TODO : Check if angular js always send the Preflight request or not..

### Access-Control-Allow-Origin

The Access-Control-Allow-Origin header allows servers to specify how their resources are shared with external domains. When a GET request is made to access a resource on Server A, Server A will respond with a value for the Access-Control-Allow-Origin header. Many times, this value will be *, meaning that Server A will share the requested resources with any domain on the Internet. Other times, the value of this header may be set to a particular domain (or list of domains), meaning that Server A will share its resources with that specific domain (or list of domains). The Access-Control-Allow-Origin header is critical to resource security.

###



## How to add CORS in Asp.net core



## Sample Application

## Testing CORS is working and validating

## Summary


## References