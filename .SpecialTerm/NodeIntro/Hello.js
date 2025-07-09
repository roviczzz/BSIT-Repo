var http = require('http');
http.createServer(function (req, res) {
res.write("Hello");
res.end();
}).listen(8000);
console.log("Server is running at http://localhost:8000");