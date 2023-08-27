# Exception Handling in FlashDriveUtil

In this section, you'll learn how to handle exceptions that can occur while using the FlashDriveUtil library.

## `FlashManagerException`

The `FlashManagerException` is an exception class provided by the library. It is used to handle errors that might occur during flash drive operations.

### Constructors

- `FlashManagerException(string message)`: Creates a new instance of the exception with the specified error message.
- `FlashManagerException(string message, Exception innerException)`: Creates a new instance of the exception with the specified error message and a reference to the inner exception that caused this exception.

## Handling Exceptions

When using the FlashDriveUtil functions, it's important to wrap your code in try-catch blocks to handle any potential exceptions.

Example:

```csharp
try
{
    FlashDriveUtil flashDriveUtil = new FlashDriveUtil();
    Flash flash = flashDriveUtil.GetFlash("MyFlashDrive");
}
catch (FlashManagerException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

By handling exceptions properly, you can ensure a more robust and stable application while working with flash drives.
