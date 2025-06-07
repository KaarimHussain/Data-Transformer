import 'dart:convert';
import 'package:xml/xml.dart';

String xmlToJson(String xmlString) {
  final document = XmlDocument.parse(xmlString);
  final map = <String, dynamic>{};
  for (final node in document.rootElement.children.whereType<XmlElement>()) {
    map[node.name.toString()] = node.text;
  }
  return const JsonEncoder.withIndent('  ').convert(map);
}

String jsonToXml(String jsonString) {
  final data = jsonDecode(jsonString) as Map<String, dynamic>;
  final builder = XmlBuilder();
  builder.processing('xml', 'version="1.0"');
  builder.element('root', nest: () {
    data.forEach((key, value) {
      builder.element(key, nest: value.toString());
    });
  });
  return builder.buildDocument().toXmlString(pretty: true);
}

void main(List<String> args) {
  if (args.length != 2) {
    print('Usage: dart main.dart [xml2json|json2xml] [file path]');
    return;
  }
  final mode = args[0];
  final path = args[1];
  final file = File(path);
  final content = file.readAsStringSync();

  if (mode == 'xml2json') {
    print(xmlToJson(content));
  } else if (mode == 'json2xml') {
    print(jsonToXml(content));
  } else {
    print('Invalid mode');
  }
}