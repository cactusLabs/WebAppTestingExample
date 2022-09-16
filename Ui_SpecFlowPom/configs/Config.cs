namespace WebAppTestingExample.configs
{
    internal class Config
    {
        // This isn't an advisable approach, but is used for the simplicity of demonstation
        // See readme for further details, however - register as a user with https://gearspace.com/,
        // validate the membership, then add your username and password values here.  Again,
        // this is far from ideal and credentials, particularly passwords should not be committed.
        string username = "";
        string password = "";

        public string GetPassword()
        {
            return password;
        }
        public string GetUsername()
        {
            return username;
        }
    }
}
