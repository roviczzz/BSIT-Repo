const http = require('http');
const server = http.createServer((req, res) => {
if (req.method === 'GET') {
res.writeHead(200, { 'Content-Type': 'text/html' });
res.end(`
<!DOCTYPE html>
<html>
<head>
<title>Age Calculator</title>
<style>
body { background-color: #f2f2f2; font-family: Arial; padding: 20px; }
</style>
</head>
<body>
<h1>Age Calculator</h1>
<form id="ageForm">
<label for="name">Name:</label>
<input type="text" id="name" required><br><br>
<label for="birthday">Birthday:</label>
<input type="date" id="birthday" required><br><br>
<button type="submit">Calculate Age</button>
</form>
<p id="result"></p>
<script>
document.getElementById('ageForm').addEventListener('submit', function(event) {
event.preventDefault();
const name = document.getElementById('name').value;
const birthday = new Date(document.getElementById('birthday').value);
const age = calculateAge(birthday);
document.getElementById('result').textContent = \`Hello, \${name}. You are \${age} years old.\`;
});
function calculateAge(birthday) {
const today = new Date();
let age = today.getFullYear() - birthday.getFullYear();
const monthDiff = today.getMonth() - birthday.getMonth();
if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthday.getDate())) {
age--;
}
return age;
}
</script>
</body>
</html>
`);
} else {
res.writeHead(404, { 'Content-Type': 'text/plain' });
res.end('Page Not Found');
}
});
const PORT = 3000;
server.listen(PORT, () => {
console.log(`Server running on http://localhost:${PORT}`);
});