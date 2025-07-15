// public/webpage2.js

function handleRequest(req, res) {
  res.send(`
    <!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>Rovic M. Rodriguez | Resume</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="style-resume.css">
</head>
<body>
  <div class="bg-blur"></div>
  <div class="container">
    <header class="resume-header">
      <div class="header-main">
        <div>
          <h1>Rovic M. Rodriguez</h1>
          <div class="header-contact muted">
            Imus City, Cavite, Philippines &nbsp; | &nbsp; +63 923 278 0597 &nbsp; | &nbsp; 
            <a href="mailto:rodriguezrovic16@gmail.com">rodriguezrovic16@gmail.com</a>
          </div>
        </div>
        <img src="Resources/pfp.png" alt="Rovic's Photo" class="profile-img-square">
      </div>
      <p class="about-me">
        Junior Developer and IT Specialist with a strong passion for web development and multimedia arts, striving for professional, creative, and collaborative excellence.
      </p>
    </header>

    <section class="resume-section">
      <div class="mini-banner"></div>
      <h2>Skills</h2>
      <ul class="skills-list">
        <li>Front-End Web Development (HTML, CSS, JavaScript)</li>
        <li>Programming: Java, C#, C++, Python</li>
        <li>Database: SQL</li>
        <li>Multimedia Editing</li>
        <li>Team Collaboration</li>
      </ul>
    </section>

    <section class="resume-section">
      <h2>Education</h2>
      <table>
        <tr>
          <th>Degree</th>
          <th>Institution</th>
          <th>Year</th>
        </tr>
        <tr>
          <td>Bachelor of Science in Information Technology</td>
          <td>De La Salle University Dasmarinas</td>
          <td>2026</td>
        </tr>
        <tr>
          <td>Senior High School</td>
          <td>De La Salle University Dasmarinas</td>
          <td>2020</td>
        </tr>
        <tr>
          <td>High School</td>
          <td>Pastorelle Jesus Good Shepherd School</td>
          <td>2020</td>
        </tr>
        <tr>
          <td>Elementary</td>
          <td>Pastorelle Jesus Good Shepherd School</td>
          <td>2016</td>
        </tr>
      </table>
    </section>

    <section class="resume-section">
      <h2>Certifications</h2>
      <ul>
        <li>Master the Mainframe 2021 – IBM, 2021</li>
        <li>Introduction to Cybersecurity – CISCO, 2021</li>
        <li>Cybersecurity Essentials – CISCO, 2021</li>
        <li>Introduction to IOT – CISCO, 2021</li>
        <li>Topserve Certificate of Completion – TOPSERVE, 2022</li>
      </ul>
    </section>

    <section class="resume-section">
      <h2>Experience</h2>
      <div class="exp-block">
        <div class="exp-title">
          <strong>Web Developer</strong>
          <span class="muted">@ CloudStaff, Makati City</span>
          <span class="exp-date">Mar 2027 – Present</span>
        </div>
        <ul>
          <li>Maintained and deployed internal web-based applications to support operations.</li>
          <li>Collaborated with cross-functional teams to optimize platform capabilities.</li>
          <li>Comprehensive testing and debugging of front-end and back-end code.</li>
          <li>Team Lead Developer</li>
        </ul>
      </div>
    </section>

    <section class="resume-section">
      <h2>Hobbies</h2>
      <ul class="hobbies-list">
        <li>Programming</li>
        <li>Multimedia Editing</li>
        <li>Photography</li>
        <li>Listening to Music</li>
        <li>Watching Media</li>
        <li>Gaming</li>
      </ul>
    </section>

    <section class="resume-section resume-footer">
                <div class="mini-banner"></div>
      <div>
        <strong>References:</strong> <br>
        <span class="muted">Dr. Eric S. Vargas — Office of Student Services Director, DLSU-D | 09232780597 | ericvargas@dlsud.edu.ph</span> <br>
      </div>
      <div class="portfolio-link">
        <a href="https://linktr.ee/roviczzz" target="_blank" class="portfolio-btn">Contact</a>
      </div>
    </section>

  </div>
</body>
</html>
  `);
}

module.exports = { handleRequest };