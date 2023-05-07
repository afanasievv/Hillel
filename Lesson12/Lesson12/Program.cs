using Lesson12;
using SecondLesson;
using Serialization;
using System.Runtime.Serialization;

var mortar = new Mortar();
var gun = new Gun();

var xmlSerializer = new XMLSerializer();
var data = xmlSerializer.Serialize(mortar);
var xmlDeserialized = xmlSerializer.Deserialize(data);

var jsonSerializer = new JSONSerializer();
var json = jsonSerializer.Serialize(gun);
var jsonDeserialized= jsonSerializer.Deserialize(json);


