// public/webpage1.js

function handleRequest(req, res) {
  res.send(`
    <!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>Customer Experience Survey</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="style-survey.css">
</head>
<body>
  <div class="bg-blur"></div>
  <div class="container" style="max-width: 700px;">
    <div class="mini-banner"></div>
    <!-- Logo and Title -->
    <div class="survey-header">
      <img src="/Resources/logo.jpg" alt="Company Logo" class="survey-logo">
      <h2 class="survey-title">Datablitz Customer Experience Survey</h2>
    </div>

    <form id="googleForm">
      <fieldset>
        <legend>Personal Information</legend>
        <div class="form-row">
          <label for="name">Name</label>
          <input type="text" id="name" name="name" required autocomplete="off">
        </div>
        <div class="form-row">
          <label for="email">Email</label>
          <input type="email" id="email" name="email" autocomplete="off">
        </div>
        <div class="form-row">
          <label for="age">Age</label>
          <input type="number" id="age" name="age" min="10" max="100">
        </div>
      </fieldset>

      <fieldset>
        <legend>Service Rating</legend>
        <div class="form-row">
          <span class="section-label">How satisfied are you with our service?</span>
          <div class="radio-group">
            <label><input type="radio" name="rating" value="very_satisfied"> Very Satisfied</label>
            <label><input type="radio" name="rating" value="satisfied"> Satisfied</label>
            <label><input type="radio" name="rating" value="neutral"> Neutral</label>
            <label><input type="radio" name="rating" value="dissatisfied"> Dissatisfied</label>
          </div>
        </div>

        <div class="form-row">
          <span class="section-label">What features do you use? <small>(Check all that apply)</small></span>
          <div class="checkbox-group">
            <label><input type="checkbox" name="feature" value="chat"> Live Chat</label>
            <label><input type="checkbox" name="feature" value="support"> Email Support</label>
            <label><input type="checkbox" name="feature" value="faq"> FAQs</label>
          </div>
        </div>

        <div class="form-row">
          <label for="contact_method">Preferred Contact Method</label>
          <select name="contact_method" id="contact_method">
            <option value="">--Please choose--</option>
            <option value="email">Email</option>
            <option value="phone">Phone</option>
            <option value="chat">Live Chat</option>
          </select>
        </div>
      </fieldset>

      <fieldset>
        <legend>Additional Feedback</legend>
        <div class="form-row">
          <label for="comments">Comments</label>
          <textarea id="comments" name="comments" rows="4" placeholder="Your feedback..."></textarea>
        </div>
      </fieldset>

      <div class="form-actions">
        <input type="reset" value="Reset">
        <input type="submit" value="Submit">
      </div>
    </form>
  </div>
  <script>

  const scriptURL = 'https://script.google.com/macros/s/AKfycbxbBxzFju4l7g7DJhlRTF44RwVW3qN4OVPfwy2-UUQSJqKs6SYF72gem2RRxuz4rw-blQ/exec';

  const form = document.getElementById('googleForm');

 

//When the user clicks the submit button, this function runs.

  form.addEventListener('submit', e => {

    e.preventDefault(); //This stops the browser’s default action of reloading

    fetch(scriptURL, { method: 'POST', body: new FormData(form)})

      .then(response => {

        alert("Form submitted successfully!");

        form.reset();

      })

      .catch(error => alert('Error!', error.message));

  });

</script>
</body>
</html>
  `);
}

module.exports = { handleRequest };