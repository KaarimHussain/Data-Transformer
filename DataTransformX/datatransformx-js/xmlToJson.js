const fs = require('fs');
const xml2js = require('xml2js');

async function xmlToJson(xmlPath) {
    const xml = fs.readFileSync(xmlPath, 'utf8');
    const result = await xml2js.parseStringPromise(xml, { mergeAttrs: true });
    console.log(JSON.stringify(result, null, 4));
}

module.exports = xmlToJson;