# FlashDriveUtil Flash Object

In this section, you'll learn about the `Flash` object provided by the `FlashDriveUtil` library. The `Flash` object represents a flash drive and contains information about the drive's name and root directory.

## Properties

### `Name`

The `Name` property represents the name of the flash drive.

Example:

```csharp
Flash flash = new Flash();
string name = flash.Name; // Get the name of the flash drive
```

### `RootDirectory`

The `RootDirectory` property represents the root directory of the flash drive, represented as a `DirectoryInfo` object.

Example:

```csharp
Flash flash = new Flash();
DirectoryInfo rootDirectory = flash.RootDirectory; // Get the root directory of the flash drive
```

## Conversion

The `Flash` object can be explicitly converted to other types.

### Conversion to DriveInfo

You can convert a `Flash` object to a `DriveInfo` object using an explicit cast.

```csharp
Flash flash = new Flash();
DriveInfo driveInfo = (DriveInfo)flash; // Convert Flash to DriveInfo
```

### Conversion to string

You can also convert a Flash object to a string (the flash drive's name) using an explicit cast.

```csharp
Flash flash = new Flash();
string name = (string)flash; // Convert Flash to string (name)
```

## Example Usage

Here's an example of how you can use the `Flash` object in your application:

```csharp
FlashDriveUtil flashDriveUtil = new FlashDriveUtil();
Flash flash = flashDriveUtil.GetFlash("MyFlashDrive");

Console.WriteLine($"Flash Drive Name: {flash.Name}");
Console.WriteLine($"Root Directory: {flash.RootDirectory.FullName}");
```

By understanding the properties and conversion methods of the `Flash` object, you can effectively retrieve and utilize information about connected flash drives.
