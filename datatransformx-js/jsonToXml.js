const fs = require('fs');
const js2xmlparser = require('js2xmlparser');

function jsonToXml(jsonPath) {
    const json = fs.readFileSync(jsonPath, 'utf8');
    const obj = JSON.parse(json);
    const xml = js2xmlparser.parse("root", obj);
    console.log(xml);
}

module.exports = jsonToXml;