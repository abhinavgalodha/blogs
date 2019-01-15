function createCORSRequest(method, url) {
    var xhr = new XMLHttpRequest();

    xhr.onload = function() {
        var responseText = xhr.responseText;
        console.log(responseText);
        // process the response.
       };
       
       xhr.onerror = function() {
         console.log('There was an error!');
       };

    xhr.open(method, url);

    xhr.send();
  }
  
  
  
