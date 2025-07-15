const express = require('express');
const path = require('path');
const webpage1 = require('./public/webpage1');
const webpage2 = require('./public/webpage2');
const app = express();
const port = 8000;
app.use(express.static(path.join(__dirname, 'public')));
app.get('/', (req, res) => {
res.send(`
<!DOCTYPE html>
<html>
<head>
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Rubik:ital,wght@0,300..900;1,300..900&display=swap" rel="stylesheet">
<link rel="stylesheet" href="styles.css">
</head>

<body>
<ul class="navbar" style="margin-bottom: .5%;">
  <li class="left-float">
    <a href="#home" style="font-weight: 600; font-size: larger;">Keen Eyes Portfolio</a>
  </li>
  <li class="spacer"></li>
  <li><a href="#home">Home</a></li>
  <li><a href="#about">About</a></li>
  <li><a href="#background">Background</a></li>
  <li><a href="#skills">Skills</a></li>
  <li><a href="#works">Works</a></li>
</ul>

<div class="banner">
    <img src="/Resources/banner.jpg" alt="Banner Image"></div>

<br>
    <img src="/Resources/pfp.jpg" alt="Profile Picture" class="profile-pic">
<h1 class="center-items" id="about">Rovic</h1>
<p class="center-items">🇵🇭 22 | DLSU-D BSIT BIT33</p>
<br style="margin-bottom: .5%;">
<pre class="center-items">I'am a 22 y/o Information Technology student from De La Salle University - Dasmarinas that inspires professional, friendly and endless creativity of web development and multimedia.
    Besides being a developer, I indulge myself exploring and expressing my vision through digital means, by photography, video editing,
    consuming various medias such as films, animes, books, listening to podcasts and music, and most of my time playing video games. 
</pre>

<br style="margin-bottom: 8%;">
<h1 class="center-items" id="background">Background</h1>
<p class="center-items">Consistent Dean's Lister</p>
<p class="center-items">Former CSCSSG Logistics & Technicals Committee</p>
<p class="center-items">2025 DLSU-D Research Week Logistics Committee</p>
<p class="center-items">Chasing Victory 2023 VALORANT Player</p>
<p class="center-items">E-lympics VALORANT Player</p>
<p class="center-items">Chasing Victory 2025 VALORANT Player</p>





<br style="margin-bottom: 8%;">
<h1 class="center-items" id="skills">Skills</h1>
<p class="center-items">Front-End-Development: HTML, CSS, Php, Python, Java, Javascript, ASP.Net, C#, SQL</p>
<p class="center-items">Software: Visual Studio, Jetbrains, Github, Figma, Adobe Creative Cloud, Docker, Notion</p>


<br style="margin-bottom: 8%;">
<h1 class="center-items">Photography</h1>
<div class="gallery">
  <img src="/Resources/photo1.jpg" alt="Photography 1">
  <img src="/Resources/photo2.jpg" alt="Photography 2">
  <img src="/Resources/photo3.jpg" alt="Photography 3">
  <img src="/Resources/photo4.jpg" alt="Photography 4">
</div>

<br style="margin-bottom: 8%;">
<h1 class="center-items" id="works">Works</h1>
<p class="center-items">
<ul>
  <li><a href="/webpage1">Survey Form</a></li>
  <li><a href="/webpage2">Order Form</a></li>
  </ul>
</p>


</body>
</html>
`);
});
app.get('/webpage1', webpage1.handleRequest);
app.get('/webpage2', webpage2.handleRequest);
app.listen(port, () => {
console.log(`Server is running on http://localhost:${port}`);
});