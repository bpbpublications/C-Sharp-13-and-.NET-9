using System.Collections.Specialized;

NameValueCollection nameValueCollection = new NameValueCollection();
nameValueCollection.Add("first", "John");
nameValueCollection.Add("second", "Doe");
Console.WriteLine($"NameValueCollection - first: {nameValueCollection["first"]}");
// StringCollection
StringCollection stringCollection = new StringCollection();
stringCollection.AddRange(new[] { "John", "Doe" });
Console.WriteLine($"StringCollection - first item: {stringCollection[0]}");
// StringDictionary
StringDictionary stringDictionary = new StringDictionary();
stringDictionary["name"] = "John Doe";
Console.WriteLine($"StringDictionary - name: {stringDictionary["name"]}");
// HybridDictionary
HybridDictionary hybridDictionary = new HybridDictionary();
hybridDictionary["name"] = "John";
Console.WriteLine($"HybridDictionary - name: {hybridDictionary["name"]}");
// ListDictionary
ListDictionary listDictionary = new ListDictionary();
listDictionary["name"] = "John";
Console.WriteLine($"ListDictionary - name: {listDictionary["name"]}");
// OrderedDictionary
OrderedDictionary orderedDictionary = new OrderedDictionary();
orderedDictionary.Add("id", 1);
orderedDictionary.Add("name", "John");
Console.WriteLine($"OrderedDictionary - name: {orderedDictionary["name"]}");
// BitVector32
System.Collections.Specialized.BitVector32 bitVector = new System.Collections.Specialized.BitVector32(0);
int bit1 = System.Collections.Specialized.BitVector32.CreateMask();
int bit2 = System.Collections.Specialized.BitVector32.CreateMask(bit1);
bitVector[bit1] = true;
bitVector[bit2] = false;
Console.WriteLine($"BitVector32 - Bit1: {bitVector[bit1]}, Bit2: {bitVector[bit2]}");