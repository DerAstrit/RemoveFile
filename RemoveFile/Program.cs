// remove a selected file from the directory

Console.WriteLine("Remove a file from the disk \n\n" +
                  "Enter the directory path");
string? path = Console.ReadLine();

Console.WriteLine("\nEnter the file name to be removed");
string? filename = Console.ReadLine();
    
string filepath = path + "\\" + filename;

Console.WriteLine("-------------------------------------------------------");

if (File.Exists(filepath))
{
    File.Delete(filepath);
    Console.WriteLine($"The File {filename} deleted successfully");
}
else
{
    Console.WriteLine("File does not exist");
}