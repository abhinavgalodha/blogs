# Debugging JSON.Net to diagnose my problem

## Introduction

* Have you ever run into problem and thought about debugging a library source code to understand the actual implementation? 
* Have you been pulling your hairs about a problem you can't understand and searched across the internet and didn't found any details for your issue?

In this article, we will take dive into debugging and understand the behavior of the popular **Newtonsoft JSON** library to understand *how it deserializes a type from a string*. This is an actual problem that i faced during development and had to dig into the library code to understand the behavior. The same approach can be applied to other open source projects and would be useful to debug and understand the library code.


### Problem

I was working in an Asp.net Core API where one of the Properties of an Object was coming as null. 

Though the client was passing the 




## How to debug 



## Cloning and debugging

Clone the repository

## Actual Debugging

Open tests and modify the code.

## My Problem code

Can see the exception, when more than 1 parameterized it is throwing an exception.

## Conclusion

In this article we learned how to Debug and open source library project like JSON.net and identify and understand the expected behavior. We added our code in tests and debugged the Desexualization code to understand why the code is behaving in a certain way. Also, it was a good learning experience to read some one else code. I hope you enjoyed the article and  next time you run into a mysterious behavior, you will try to debug the Libraries code.