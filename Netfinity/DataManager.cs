using ModelLayer;

namespace Netfinity
{
    public class DataManager
    {
        public Vault GetVault()
        {
            return new Vault()
            {
                Secrets = new System.Collections.Generic.List<Secret>()
                {
                    new Secret { Message = "I'm actually 100% bald, it's a great toupee"}
                }
            };
        }
    }
}
