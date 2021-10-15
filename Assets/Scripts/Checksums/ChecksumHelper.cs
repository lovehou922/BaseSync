using System.Security.Cryptography;
using System.Text;
/// <summary>
/// 校验工具类
/// </summary>

public class ChecksumHelper
{
    public static Encoding ENCODING = Encoding.UTF8;
    //计数MD5码
    public static string CalculateMD5(string str)
    {
        byte[] md5hash = MD5.Create().ComputeHash(ENCODING.GetBytes(str));
        StringBuilder sBuilder = new StringBuilder();
        // Loop through each byte of the hashed data 
        // and format each one as a hexadecimal string.
        // 遍历散列数据的每个字节
        // 并将每个格式设置为十六进制字符串。
        for (int i =0; i<md5hash.Length;i++)
        {
            sBuilder.Append(md5hash[i].ToString("x2"));
        }
        // 返回十六进制字符串。
        return sBuilder.ToString();
    }
    //计算hash校验
    public static string CalculateHash(string str)
    {
        return"";
    }

}
