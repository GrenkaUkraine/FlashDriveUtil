# Getting Started with FlashDriveUtil

Welcome to the `FlashDriveUtil` documentation! This guide will help you get started with using the `FlashDriveUtil` library to work with flash drives in your .NET applications.

## Installation

To use `FlashDriveUtil` in your project, you need to install it first. There are a couple of ways to do this:

### NuGet Package Manager

You can install `FlashDriveUtil` using the **NuGet Package Manager**. Open the **Package Manager Console** and run the following command:

```sh
Install-Package FlashDriveUtil
```

## Basic Usage

Here's a simple example of how to use `FlashDriveUtil` in your application:

```cscsharp
using FlashDriveUtilManager;

class Program
{
    static void Main(string[] args)
    {
        FlashDriveUtil flashDriveUtil = new FlashDriveUtil();

        // Get a list of all connected flash drives
        List<Flash> flashes = flashDriveUtil.GetAllFlashes();

        foreach (var flash in flashes)
        {
            Console.WriteLine($"Flash Drive Name: {flash.Name}");
            Console.WriteLine($"Root Directory: {flash.RootDirectory.FullName}");

            // Convert Flash to DriveInfo
            DriveInfo driveInfo = flashDriveUtil.GetDriveInfo(flash);

            // Additional logic for working with DriveInfo
        }
    }
}
```

## Next Steps

Congratulations! You've successfully installed `FlashDriveUtil` and learned the basics of using it in your application. Now you can explore more advanced features and functionalities provided by the library to suit your needs.

For more information about available [methods](methods.md), [exceptions](exceptions.md), and [flash object](flash.md), please refer to the rest of our documentation.

## Conclusion
This "Getting Started" guide has provided you with the fundamental steps to begin using FlashDriveUtil in your .NET projects. Feel free to explore the library further and utilize its capabilities to enhance your flash drive management tasks.

If you have any questions or encounter any issues, don't hesitate to refer to our documentation or reach out to our support team.

Happy coding!