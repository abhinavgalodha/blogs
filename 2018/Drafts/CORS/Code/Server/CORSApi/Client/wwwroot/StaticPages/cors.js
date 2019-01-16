function getCurrentServerDateTime() {

	var url = "https://localhost:5001/api/date";
	var xhr = new XMLHttpRequest();

	xhr.onload = function() {
		var responseText = xhr.responseText;
		console.log(responseText);
		// process the response.
	};
       
	xhr.onerror = function() {
		console.log('There was an error!');
	};

	xhr.open('Get', url);

	xhr.send();
}



