namespace _0005_patterns
{
    public static class CheckList
    {
        public static string CheckNumebrs(int[] numbers)
        {
            return numbers switch
            {
                [] => "(Empty)",
                [1] => "Constant",
                [1, 2, 3] => "Constants",
                [_, 2, 3] => "Any placeholder",
                [_, _, _] => "Any placeholders",
                [>4] => "Relational",
                [>4, >=5, <=6, <7] => "Relational options",
                [>0 and <10] => "Logical AND",
                [not 8] => "Logical NOT",
                [_, 1 or 2 or 3] => "Logical OR",
                [_, (>=5 and <=7) or (>=12 and <=14)] => "Ranges using both",
                [4, ..] => "Starts with",
                [.., 5] => "Ends with",
                [6, .., 6] => "Starts and Ends",
                [7, .. int[] middle, 7] => middle.Length.ToString(),
                [8, int a, int b, ..] => (a + b).ToString(),
                null => "Null",
                _ => "Unknown pattern"
            };
        }

        public static string CheckObjects(object[] objects)
        {
            return objects switch
            {
                [int] => "Number",
                [string] => "Text",
                [DateTime { DayOfWeek: DayOfWeek.Monday }] => "Monday",
                [DateTime { DayOfWeek: DayOfWeek.Tuesday } dt] => dt.ToShortDateString(),
                var other => other.ToString(),
            };
        }

        public static bool CheckExamples(string[] names)
        {
            if (names is ["Alice", ..])
                return true;

            switch(names)
            {
                case ["Alice", ..]:
                    break;
            }

            return names is [.., { Length: 6 }];
        }        
    }
}
