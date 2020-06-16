const assert = require('assert');
const client = require('./src/client')
const flat = require('./src/flat')

if(process.argv.length != 3) process.exit(1)

client.connect(async (err) => {
    assert.equal(null, err);
    console.log("Connected correctly to server");

    const db = client.db('new_york')

    let results

    switch(process.argv[2]) {
        case 'all':
            results = db.collection('restaurants').find()
            console.log(await results.toArray())
            break
        case 'countAll':
            results = db.collection('restaurants').find()
            console.log(await results.count())
            break
        case 'allFlatten':
            results = db.collection('restaurants').find()
            console.log((await results.toArray()).map(document => flat(document)))
            break
        default:
            console.error('command not found')
            process.exit(0)
            break
    }
  
    client.close();
  });