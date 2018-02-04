using System;
using Microsoft.VisualBasic.FileIO;

namespace gunter.roy.bestbuy

{
    public class Credential
    {
        public string CredentialName { get; set; }
        public string UserName { get; set; }
        public string Key { get; set; }

        private const string PATH = "C:\\Keys\\keys.csv";

        public Credential(string name)
        {
            // Pull credentials from local store
            // Format is:
            // CredentialName, UserName, Key

            try
            {
                // Parse values
                using (TextFieldParser parser = new TextFieldParser(PATH))
                {
                    parser.Delimiters = new string[] { "," };

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        string credentialName = fields[0];
                        string userName = fields[1];
                        string key = fields[2];

                        if (name == credentialName)
                        {
                            CredentialName = name;
                            UserName = userName;
                            Key = key;
                        }
                        else
                        {
                            throw new CredentialException("There is no credential named " + name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Serializable]
        public class CredentialException : Exception
        {
            public CredentialException()
                : base()
            { }

            public CredentialException(string message)
                : base(message)
            { }

            public CredentialException(string format, params object[] args)
                : base(string.Format(format, args))
            { }

            public CredentialException(string message, Exception innerException)
                : base(message, innerException)
            { }

            public CredentialException(string format, Exception innerException, params object[] args)
                : base(string.Format(format, args), innerException)
            { }
        }
    }
}
