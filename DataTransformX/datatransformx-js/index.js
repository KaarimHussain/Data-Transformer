const xmlToJson = require('./xmlToJson');
const jsonToXml = require('./jsonToXml');

const mode = process.argv[2];
const input = process.argv[3];

if (!mode || !input) {
    console.log('Usage: node index.js [xml2json|json2xml] [filepath]');
    process.exit(1);
}

if (mode === 'xml2json') {
    xmlToJson(input);
} else if (mode === 'json2xml') {
    jsonToXml(input);
} else {
    console.log('Invalid mode.');
}