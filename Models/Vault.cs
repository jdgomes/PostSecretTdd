using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Vault
    {
        public Vault()
        {
            Secrets = new List<Secret>();
        }

        public List<Secret> Secrets { get; set; }
    }

    public class Secret
    {
        public string Message { get; set; }
    }
}
