namespace Login_Data_Storage
{
    public class LoginClass
    {
        private string userApp;
        private string passApp;
        public string name;
        Encoder encode = new Encoder();

        public LoginClass(string user, string pass)
        {
            userApp = encode.encryptString(user);
            passApp = encode.encryptString(pass);
        }

        public LoginClass(string user, string pass, string labelname)
        {
            name = labelname;
            userApp = encode.encryptString(user);
            passApp = encode.encryptString(pass);
        }

        public string getDecodedUser()
        {
            return encode.decryptString(userApp);
        }

        public string getDecodedPass()
        {
            return encode.decryptString(passApp);
        }


    }
}
