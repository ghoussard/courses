const MongoClient = require('mongodb').MongoClient;

const user = encodeURIComponent('root');
const password = encodeURIComponent('root');
const authMechanism = 'DEFAULT';

// Connection URL
const url = `mongodb://${user}:${password}@localhost:27017/?authMechanism=${authMechanism}`;

// Create a new MongoClient
const client = new MongoClient(url);

module.exports = client