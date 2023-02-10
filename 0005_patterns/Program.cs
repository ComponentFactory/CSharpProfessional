namespace _0005_patterns
{
    public static class RedirectUrl
    {
        public static string Redirect1(Uri uri)
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

        public static string Redirect2(Uri uri)
        {
            return uri.Segments switch
            {
                ["/"] => "/home",
                [.. , "product" or "item"] => "/showcase",
                ["category", .. var rest] => string.Join("/", rest),
                _ => "/404"
            };
        }
    }
}
