const express = require('express');
const { MongoClient } = require('mongodb');
const app = express();
const port = 8080;
const uri = 'mongodb://127.0.0.1:27017/bookstore';

app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

app.get('/', async (req, res) => {
  try {
    const client = await MongoClient.connect(uri);
    const db = client.db();
    const collection = db.collection('books');
    
    // Fetch data from MongoDB
    const data = await collection.find({}).toArray();
    
    // Render the EJS template and pass the data
    res.render('myIndex', { data });
    
    // Close the MongoDB connection
    await client.close();
  } catch (err) {
    console.error('Error fetching data from MongoDB:', err);
    res.status(500).send('Internal Server Error');
  }
});

app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
