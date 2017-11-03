namespace TestEnv1.Helper
{

    public class Settings : ISettings

    {

        #region Implementation of ISettings


        public string SomRefreshToken { get; set; }

        public string Password { get; set; }
   
        public string Username { get; set; }
        
        public string UUId { get; set; }
        #endregion

    }
}