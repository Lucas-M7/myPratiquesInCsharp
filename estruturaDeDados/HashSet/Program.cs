HashSet<string> names = [];

names.Add("Lucas");
names.Add("Fábio");
names.Add("Kauã");
names.Add("Guilherme");
names.Add("Lucas"); // This element is ignored, because it already exists in ensemble

string namesInLine = string.Join(", ", names);
Console.WriteLine(namesInLine);