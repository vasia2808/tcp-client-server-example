using MessagePack;

var data = "Hello world!";
var serializedData = data.Serialize();
var deserializedData = serializedData.Deserialize<string>();

Console.WriteLine();