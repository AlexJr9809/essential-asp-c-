// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

File.SetAttributes(filename,FileAttributes.ReadOnly);
Console.WriteLine(File.GetAttributes(filename));
// TODO: We can also get general information using a FileInfo
try{
    FileInfo f1 = new FileInfo(filename);
    Console.WriteLine($"{f1.Name} {f1.Extension} {f1.Length} bytes");
}catch(Exception e){
    Console.WriteLine($"Exception: {e}");

} 


// TODO: File information can also be manipulated
/*DateTime dt = new DateTime(2024,06,23);
File.SetCreationTime(filename,dt);
Console.WriteLine(File.GetCreationTime(filename));*/
