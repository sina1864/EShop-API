using System.Security.Cryptography;
using System.Text;

namespace Common.Application.SecurityUtil;

public static class PasswordHelper
{
    public static string EncodePasswordMd5(string pass)
    {
        using var md5 = MD5.Create();
        var inputBytes = Encoding.ASCII.GetBytes(pass);
        var hashBytes = md5.ComputeHash(inputBytes);

        var sb = new StringBuilder();
        for (var i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(i.ToString("X2"));
        }
        return sb.ToString();
    }
}