namespace _0005_patterns
{
    public static class RedirectUrl
    {
        public static string Redirect(Uri uri)
        {
            string[] segments = uri.Segments;
            if (segments.Length > 0)
            {
                if ((segments.Length == 1) && (segments[0] == "/"))
                {
                    return "/home";
                }

                int lastIndex = segments.Length - 1;
                if (segments.Length >= 1)
                {
                     if ((segments[lastIndex] == "product") || (segments[lastIndex] == "item"))
                     {
                        return "/showcase";
                     }

                    if (segments[0] == "category")
                    {
                        return string.Join("/", segments, 1, lastIndex);
                    }
                }
            }
            return "/404";
        }
    }
}
