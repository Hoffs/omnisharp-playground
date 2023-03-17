// See https://aka.ms/new-console-template for more information
using OmniSharp.Extensions.LanguageServer.Protocol;
using TextDocReferenceRepro;

Console.WriteLine("Hello, World!");
var duri = DocumentUri.Parse("file:///Users/ignas/repositories/TextDocReferenceRepro/Program.cs");
var fsp = duri.GetFileSystemPath();
var replaced = fsp.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);

Console.WriteLine(duri);
Console.WriteLine(fsp);
Console.WriteLine(replaced);

// definition / references with source generated file
var xx = new MyClass();
// definition over 2 files
var x = new MyClass2();
var xxx = new MyClass3();


var y = x.ts;

