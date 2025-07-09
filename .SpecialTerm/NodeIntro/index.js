const http = require('http');
const fs = require('fs'); //File System Module (read, write, delete, and modify files)
const server = http.createServer((req, res) => {
if (req.method === 'GET') {
fs.readFile('index.html', (err, data) => {
if (err) {
res.writeHead(500, { 'Content-Type': 'text/plain' });
res.end('Error loading HTML file.');
} else {
res.writeHead(200, { 'Content-Type': 'text/html' });
res.end(data);
}
});
} else {
res.writeHead(404, { 'Content-Type': 'text/plain' });
res.end('Not found');
}
});
server.listen(4000, () => {
console.log(' Server running on http://localhost:4000');})