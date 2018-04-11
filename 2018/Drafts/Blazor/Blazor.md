# Death Of Javascript; Writing Client side code from Angular, React, Vue to C# blazor

or 

# Replacing Angular,React, Vue, Javascript with C# for Building Client Side Application

or

# Death of Javascript; Long live C#

Or

# How to replace Javascript with C# for Client side coding…
Or

# Write C# .Net code for Client Side Application development

Or 

#Blaze your way with c#

Are you a C#, C++ developer and Javascript never made sense for you while writing the Client Side Applications?
You are in for a good Surprise, Microsoft Asp.net team has announced the Experimental Version of Blazor as first Public preview on 6th Feb. Blazor let's you use all your C# knowlegde to Apply in Client Side development. Blazor replaces Javascript Code with C#. Essentially, it means that rather then writing the Client side code in Angular, React, Vue you can use C# and Razor. Does that sound a dream ??Continue reading...

## History Of Blazor 

Last Year, Steve Sanderson (The Creator Knockout.js) started working on an side project Blazor. After his NDC Demo at OSLO and the positive feedback for Blazor. The ASP.Net team created a Experimental version of Blazor.

### What's in the Name Blazor

### Blazor = Browser + Razor

Blazor gets it name from the Razor which most ASP.Net MVC developers would be Familiar with. Razor is a markup syntax for HTML and C#. Moreover, it runs on the Browser and Hence combine the power of Browser and Razor.

## What is Blazor?

>Blazor is a Single page web application (SPA) framework built on .NET that runs in the browser via WebAssembly.

It’s a framework for client-side applications written in .NET, running under WebAssembly. It offers all the benefits of the rich, modern single-page application (SPA) platform. Additionaly, it allows to use .Net throughout the code base. It means that we can write the code for the Client, Server in the same technology (.Net). Additionaly, Same classes can be shared by both client and server code. Blazor is based on existing web technologies like HTML and CSS, but you use C# and Razor syntax instead of JavaScript to build composable web UI.


## What is Web Assembly?

**Web Assembly is a Web Standard to promote native performance on the web.**  It defines a low level format **allowing the developers to write the code in High level Languages (C, C++) and compile the code into WebAssembly.** The Web Assembly can then be executed by the Browser at nearly the native speed. Web Assembly is supported by all modern Browsers (Firefox, Chrome, Edge, Safari). It is a low-level assembly-like language with a compact binary format that runs with near-native performance.

WebAssembly is designed to complement and run alongside JavaScript. Web Assembly Modules can be invoked from Javascript and vice versa.  Use cases of Web assembly includes 3D games, Virtual and Augmented Reality, computer vision, image/video editing, and a number of other domains that demand native performance.

## The importance of Web Assembly.

Running .NET in the browser is made possible by WebAssembly.  This is the foundational piece needed to build a .NET runtime that can run in the browser. **No plugins or transpilation needed.** You run normal .NET assemblies in the browser using a WebAssembly based .NET runtime.


## How Blazor works using Web Assembly?

The client application is compiled as .Net assemblies and gets downloaded and run in a web browser using a WebAssembly based .NET runtime. Only the .NET runtime itself is compiled to WebAssembly. There is discussion to cache the dll once for each application in the future so that the download cost is low. As of now, Blazor now runs on Mono, which is currently significantly larger, but opportunities for size optimization abound, including merging and trimming the runtime and application binaries. Other potential download size mitigations include caching and using a CDN.




## Blazor - Does c# replaces Javascript?

Blazor allows to replace the javascript with c#. Strictly, Blazor is not meant to be a replacement of javascript but a Complementar language to Javasript. It is a client side solution based on html, and CSS. C# is replacing the js part using web assembly. So nothing has changed on how you access / modify html controls.

## Why blazor is helpful to a C# Developer?

Blazor allows the .Net Developer to Utilize  existing skills for the ClientSide development. It enables the developers to Write fast Single Page Applications build on a reusable Component based Model.

Blazor promises to greatly simplify the task of building fast and beautiful single-page applications that run in any browser. It does this by enabling developers to write .NET-based web apps that run client-side in web browsers using open web standards.

## Is it suitable to use .NET for browser apps?

Web development has improved in many ways over the years but building modern web applications still poses challenges. Using .NET in the browser offers many advantages that can help make web development easier and more productive:

• Stable and consistent: .NET offers standard APIs, tools, and build infrastructure across all .NET platforms that are stable, feature rich, and easy to use.
• Modern innovative languages: .NET languages like C# and F# make programming a joy and keep getting better with innovative new language features.
• Industry leading tools: The Visual Studio product family provides a great .NET development experience on Windows, Linux, and macOS.
• Fast and scalable: .NET has a long history of performance, reliability, and security for web development on the server. Using .NET as a full-stack solution makes it easier to build fast, reliable and secure applications.




## \Q: What features will Blazor support?

Blazor will support all of the features of a modern single page app framework:
	• A component model for building composable UI
	• Routing
	• Layouts
	• Forms and validation
	• Dependency injection
	• JavaScript interop
	• Live reloading in the browser during development
	• Server-side rendering
	• Full .NET debugging both in browsers and in the IDE
	• Rich IntelliSense and tooling
	• Ability to run on older (non-WebAssembly) browsers via asm.js
	• Publishing and app size trimming

## Q: Can I use Blazor with ASP.NET Core on the server?

Yes! Blazor optionally integrates with ASP.NET Core to provide a seamless and consistent full-stack web development solution.

## Q: Is Blazor a .NET port of an existing JavaScript framework?

Blazor is inspired by existing modern single page app frameworks, like React, Angular, and Vue, but is also a new framework in its own right.

## Q: Why is Blazor an "experimental" project?

Blazor is an experimental project because there are still lots of questions to answer about its viability and appeal. The purposes of this initial experimental phase is to work through the any outstanding technical issues, to gauge interest and to listen to feedback. While we are optimistic about Blazor's future, at this time Blazor is not a committed product and should be considered pre-alpha.


## Q: Is this Silverlight all over again?

No, Blazor is a .NET web framework based on HTML and CSS that runs in the browser using open web standards. It requires no plugin and works on mobile devices and older browsers.

#3 Q: Does Blazor use XAML?

No, Blazor is a web framework based on HTML, CSS, and other standard web technologies.

## Q: Is WebAssembly supported in all browsers?

Yes, WebAssembly has achieved cross-browser consensus and all modern browsers now support WebAssembly
For IE 11, it has a transpiler.


##Q: Does Blazor work on mobile browsers? 
Yes, modern mobile browsers also support WebAssembly.

##Q: What about older browsers that don't support WebAssembly? 
For example, does Blazor work in IE?
For older browsers that don't support WebAssembly Blazor will fallback to using an asm.js based .NET runtime. Using asm.js is slower and has a larger download size, but is still quite functional.
Q: Can I use .NET Standard libraries with Blazor?
Yes, the .NET runtime used for Blazor supports .NET Standard 2.0. APIs that aren't supported in the browser throw NotSupportedExceptions.
Q: Don't you need features like garbage collection and threading added to WebAssembly to make this work?
No, WebAssembly in its current state is sufficient. The .NET runtime handles its own garbage collection and threading concerns.

Q: Can I use existing JavaScript libraries with Blazor?
Yes, Blazor applications can call into JavaScript through JavaScript interop APIs. You can call JS from C# code and vice versa.
Q: Can I access the DOM from a Blazor app?
You can access the DOM through JavaScript interop from .NET code. However, Blazor is a component based framework that minimizes the need to access the DOM directly.
Q: Why Mono? Why not .NET Core or CoreRT?
Mono is a Microsoft sponsored open source implementation of the .NET Framework. Mono is used by Xamarin for building native client apps for Android, iOS, and macOS and also by Unity for game development. Microsoft’s Xamarin team announced their plans to add support for WebAssembly to Mono and they have been making steady progress. Because Blazor is a client-side web UI framework targeted at WebAssembly, Mono is a natural fit.
By comparison, .NET Core is primarily used for server applications and for cross-platform console apps. .NET Core can be used for creating an ASP.NET Core backend for a Blazor app, but not for building the client app itself. CoreRT is a .NET Core runtime optimized for AoT compilation and while it has WebAssembly aspirations the project is still a work in progress and not a shipping product.

