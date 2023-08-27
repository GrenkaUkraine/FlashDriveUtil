namespace FlashDriveUtil
{
    public class FlashManagerException : Exception
    {
        // Custom exception class to handle errors in FlashManager operations.
        public FlashManagerException(string message) : base(message) { }
        public FlashManagerException(string message, Exception innerException) : base(message, innerException) { }
    }

    public struct Flash
    {
        public string Name { get; set; }  // Name of the flash drive.
        public DirectoryInfo RootDirectory { get; set; }  // Root directory of the flash drive.

        // Explicit conversion from Flash to DriveInfo.
        public static explicit operator DriveInfo(Flash flash)
        {
            return new DriveInfo(flash.RootDirectory.FullName);
        }

        // Explicit conversion from Flash to string (name).
        public static explicit operator string(Flash flash)
        {
            return flash.Name;
        }
    }

    public class FlashDriveUtil
    {
        // Returns a list of all connected flash drives.
        public List<Flash> GetAllFlashes()
        {
            List<Flash> flashes = new List<Flash>();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    try
                    {
                        Flash flash = new Flash { Name = drive.Name, RootDirectory = drive.RootDirectory };
                        flashes.Add(flash);
                    }
                    catch (Exception ex)
                    {
                        throw new FlashManagerException($"Error accessing {drive.Name}", ex);
                    }
                }
            }

            return flashes;
        }

        // Gets information about a specific flash drive by its name.
        public Flash GetFlash(string name)
        {
            List<Flash> flashes = GetAllFlashes();
            Flash flash = flashes.Find(
                f => f.Name.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase
                )
            );
            IsFlashError(flash);
            return flash;
        }

        // Converts Flash object to DriveInfo.
        public DriveInfo GetDriveInfo(Flash flash)
        {
            return (DriveInfo)flash;
        }

        // Checks if a Flash object represents an empty flash drive.
        public bool IsFlash(Flash flash)
        {
            return flash.Name == null && flash.RootDirectory == null;
        }

        // Throws an exception if the provided flash is not valid.
        private void IsFlashError(Flash flash)
        {
            if (!IsFlash(flash))
            {
                throw new FlashManagerException($"Flash Drive '{flash.Name}' not found.");
            }
        }
    }
}
