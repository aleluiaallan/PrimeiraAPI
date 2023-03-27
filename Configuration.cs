namespace Blog
{
    public static class Configuration
    {
        //Token - JWT - Json Web Token
        public static string JwtKey { get; set; } = "jd1kjdi12ujdsa90duJkAjn1jk1219jn!";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWG==";
        public static SmtConfiguration Smtp = new();

        public class SmtConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }

        }
    }
}
