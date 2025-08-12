
public class FileManager
{
    public void CreateFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine("File has been created and content written.");
    }

    public void ReadFile(string path)
    {
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void AppendToFile(string path, string content)
    {
        File.AppendAllText(path, content);
        Console.WriteLine("Content has been appended to the file.");
    }

    public void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File has been deleted.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}

class Program
{
    static void Main()
    {
        FileManager fileManager = new FileManager();
        int choice;

        do
        {
            Console.WriteLine("\n===== FILE MANAGER MENU =====");
            Console.WriteLine("1. Create file and write content");
            Console.WriteLine("2. Read file");
            Console.WriteLine("3. Append content to file");
            Console.WriteLine("4. Delete file");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter file name: ");
                    string createPath = Console.ReadLine();
                    Console.Write("Enter content: ");
                    string createContent = Console.ReadLine();
                    fileManager.CreateFile(createPath, createContent);
                    break;

                case 2:
                    Console.Write("Enter file name: ");
                    string readPath = Console.ReadLine();
                    fileManager.ReadFile(readPath);
                    break;

                case 3:
                    Console.Write("Enter file name: ");
                    string appendPath = Console.ReadLine();
                    Console.Write("Enter content to append: ");
                    string appendContent = Console.ReadLine();
                    fileManager.AppendToFile(appendPath, appendContent);
                    break;

                case 4:
                    Console.Write("Enter file name: ");
                    string deletePath = Console.ReadLine();
                    fileManager.DeleteFile(deletePath);
                    break;

                case 0:
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        } while (choice != 0);
    }
}
