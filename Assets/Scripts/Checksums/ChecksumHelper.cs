using System.Security.Cryptography;
using System.Text;
/// <summary>
/// У�鹤����
/// </summary>

public class ChecksumHelper
{
    public static Encoding ENCODING = Encoding.UTF8;
    //����MD5��
    public static string CalculateMD5(string str)
    {
        byte[] md5hash = MD5.Create().ComputeHash(ENCODING.GetBytes(str));
        StringBuilder sBuilder = new StringBuilder();
        // Loop through each byte of the hashed data 
        // and format each one as a hexadecimal string.
        // ����ɢ�����ݵ�ÿ���ֽ�
        // ����ÿ����ʽ����Ϊʮ�������ַ�����
        for (int i =0; i<md5hash.Length;i++)
        {
            sBuilder.Append(md5hash[i].ToString("x2"));
        }
        // ����ʮ�������ַ�����
        return sBuilder.ToString();
    }
    //����hashУ��
    public static string CalculateHash(string str)
    {
        return"";
    }

}
