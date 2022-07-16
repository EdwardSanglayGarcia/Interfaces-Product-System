namespace ProductSystemLibrary.Data
{
    public class DefaultData
    {
        public string desktopPath = 
            Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop
                )+$"/sample{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}-{DateTime.Now.Millisecond}.csv";

    }
}
