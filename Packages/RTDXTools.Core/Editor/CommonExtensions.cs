public static class CommonExtensions
{
    public static string ToAssetPath(this string path)
    {
        return path.Replace("\\", "/");
    }
}