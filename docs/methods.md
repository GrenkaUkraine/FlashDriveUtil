# FlashDriveUtil Functions

In this section, you'll find detailed information about the functions provided by the FlashDriveUtil library. These functions enable you to interact with flash drives and perform various operations.

## `GetAllFlashes`

The `GetAllFlashes` function returns a list of all connected flash drives.

```csharp
List<Flash> GetAllFlashes()
```

Example usage:

```csharp
FlashDriveUtil flashDriveUtil = new FlashDriveUtil();
List<Flash> flashes = flashDriveUtil.GetAllFlashes();
```

## `GetFlash`

The `GetFlash` function allows you to retrieve information about a specific flash drive by its name.

```csharp
Flash GetFlash(string name)
```

Example usage:

```csharp
FlashDriveUtil flashDriveUtil = new FlashDriveUtil();
Flash flash = flashDriveUtil.GetFlash("MyFlashDrive");
```

## `GetDriveInfo`

The `GetDriveInfo` function converts a `Flash` object to a `DriveInfo` object.

```csharp
FlashDriveUtil flashDriveUtil = new FlashDriveUtil();
Flash flash = flashDriveUtil.GetFlash("MyFlashDrive");
DriveInfo driveInfo = flashDriveUtil.GetDriveInfo(flash);
```

## `Exception Handling`
`FlashDriveUtil` provides the `FlashManagerException` exception class to handle errors related to flash drive operations. Refer to the [exceptions.md](exceptions.md) file for more information on exception handling.

Continue exploring the library's functions to discover more ways to manage flash drives effectively.
