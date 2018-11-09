# Unicode - What every Developer must know?

## Why should I care?

Character encoding is the basics for of the text processing in computers.


### Can you read this?

<TODO Image>

### Why not?

Because of encoding, the content was in ..

In this modern world of internet we are communicating with people from across different part of the world with different languages. To read and understand the text we need to understand the encoding and Unicode.

As a developer it is imperative to understand the encoding to ensure that the data is read and saved correctly. Also, there are wierd cases which will frustrate you to the point where you might end up hurting yourself.

## History?

I will take an analogy of Zip/Postal code to explain bit of history. Zip is meant to uniquely identify a location in a given country. United States has 5 digit postal code with 4 digit extensions. For e.g. In US, 60563 zip reprents Naperville, IL and is different from Zip 78664 (RoundRock, TX). If i know the zip, i can accurately estimate the area which is represented by the zip code.

India, has 6 digit Zip/Postal code. When we refer to any location in india like 177033, it uniquely identifies that location.

An Indian Zip code will not work in US or will give an incorrect address. The same explanation is applicable to the Characters across various languages, a character in one language is different from another language and the code used to represent a charcter in one language needs to be be uniquely distinguishable.

 Initially, mostly english words were assigned the codes, like A - 41, Z- 65. Later, as other people from across the world started using the computers, there was a need to support other languages. Since, only 8 bits was used, it was not possible to map all the possible characters in the character set.

 ### ASCII was invented
 
Initially, when computer started to handle characters and words, they were limited to mostly English words. All information in computer is stored in the bits. 1 bit can store 2 possible states and a combination of 8 bits can store 256 combinations. So, ASCII was born and it used 256 characters.

Humans started to communicate across the world some time around .. They used words which consists of Characters. Each character is created by a symbol. The word *We* is same as *hum* in hindi, the intent is same, however the representation is different. Each character is different in each language and has a unique represenation. Think about a zip/postal code, a zip is unique in a country. 

## Why we need and How it started?

## basics of character encoding

## How to use and know

## Strange problems with the code for equality comparison

## conclusion


## TODO

Get some Images with encoding or without encoding to show the problem with the Encoding and importance
