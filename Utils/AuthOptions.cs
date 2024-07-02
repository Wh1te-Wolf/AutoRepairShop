using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AutoRepairShop.Utils;

public class AuthOptions
{
    public const string ISSUER = "AutoRepairShop";
    public const string AUDIENCE = "AutoRepairShop";
    public const int LIFETIME = 10;
    private const string KEY = "MySuperPrivateKeyMySuperPrivateKey";

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
}
