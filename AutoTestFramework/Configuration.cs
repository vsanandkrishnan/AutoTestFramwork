namespace AutoTestFramework
{
    public static class Configuration
    {
        public static string BASE_URL = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234";
                public static string RepeatPassword = "asfdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfAsdfG";

                }

                public static class Password
                {

                }

                public static class Email
                {

                }
            }
        }
    }
}
