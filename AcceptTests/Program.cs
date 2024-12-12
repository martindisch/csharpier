var actualFiles = Directory.GetFiles("Src/CSharpier.Tests", "*.actual.test", SearchOption.AllDirectories);

foreach (var file in actualFiles)
{
    var expectedFileExists = File.Exists(file.Replace(".actual.test", ".expected.test"));
    var targetExtension = expectedFileExists ? ".expected.test" : ".test";
    File.Move(file, file.Replace(".actual.test", targetExtension), overwrite: true);
}