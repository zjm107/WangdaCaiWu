using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Tiger.Tools
{
    /// <summary>
    /// Convert ��ժҪ˵����
    /// </summary>
    public class TConvert
    {
        /// <summary>
        /// 
        /// </summary>
        public TConvert()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }


        /* ********************************************************************
         * public string ToCapMoneyNum(string str)
         * coding by 

         * email:


         * ********************************************************************
         */

        /// <summary>
        /// ת�����ֽ��������������С����
        /// </summary>
        /// <param name="str">�����ַ���</param>
        /// <returns>ת�������Ĵ�д����ַ������߳�����Ϣ��ʾ�ַ���</returns>
        public string ToCapMoneyNum(string str)
        {
            if (!IsPositveDecimal(str))
                return "����Ĳ��������֣�";
            if (Double.Parse(str) > 999999999999.99)
                return "����̫���޷����㣬������һ����Ԫ���µĽ��";
            char[] ch = new char[1];
            ch[0] = '.'; //С����
            string[] splitstr = null; //���尴С����ָ����ַ�������
            splitstr = str.Split(ch[0]);//��С����ָ��ַ���
            if (splitstr.Length == 1) //ֻ����������
                return ConvertData(str) + "Բ��";
            else //��С������
            {
                string rstr;
                rstr = ConvertData(splitstr[0]) + "Բ";//ת����������
                rstr += ConvertXiaoShu(splitstr[1]);//ת��С������
                return rstr;
            }
        }

        /// <summary>
        /// �ж��Ƿ����������ַ���
        /// </summary>
        /// <param name="str"> �ж��ַ���</param>
        /// <returns>��������֣�����true�����򷵻�false</returns>
        private bool IsPositveDecimal(string str)
        {
            Decimal d;
            try
            {
                d = Decimal.Parse(str);

            }
            catch (Exception)
            {
                return false;
            }
            if (d > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// ת�����֣�������
        /// </summary>
        /// <param name="str">��Ҫת�������������ַ���</param>
        /// <returns>ת�������Ĵ�д����ַ���</returns>
        private string ConvertData(string str)
        {
            string tmpstr = "";
            string rstr = "";
            int strlen = str.Length;
            if (strlen <= 4)//���ֳ���С����λ
            {
                rstr = ConvertDigit(str);

            }
            else
            {

                if (strlen <= 8)//���ֳ��ȴ�����λ��С�ڰ�λ
                {
                    tmpstr = str.Substring(strlen - 4, 4);//�Ƚ�ȡ�����λ����
                    rstr = ConvertDigit(tmpstr);//ת�������λ����
                    tmpstr = str.Substring(0, strlen - 4);//��ȡ��������
                    //������ת�������ּ����f��������
                    rstr = String.Concat(ConvertDigit(tmpstr) + "�f", rstr);
                    rstr = rstr.Replace("���f", "�f");
                    rstr = rstr.Replace("����", "��");

                }
                else
                    if (strlen <= 12)//���ֳ��ȴ��ڰ�λ��С��ʮ��λ
                    {
                        tmpstr = str.Substring(strlen - 4, 4);//�Ƚ�ȡ�����λ����
                        rstr = ConvertDigit(tmpstr);//ת�������λ����
                        tmpstr = str.Substring(strlen - 8, 4);//�ٽ�ȡ��λ����
                        rstr = String.Concat(ConvertDigit(tmpstr) + "�f", rstr);
                        tmpstr = str.Substring(0, strlen - 8);
                        rstr = String.Concat(ConvertDigit(tmpstr) + "�|", rstr);
                        rstr = rstr.Replace("��|", "�|");
                        rstr = rstr.Replace("���f", "��");
                        rstr = rstr.Replace("����", "��");
                        rstr = rstr.Replace("����", "��");
                    }
            }
            strlen = rstr.Length;
            if (strlen >= 2)
            {
                switch (rstr.Substring(strlen - 2, 2))//��ȡ����λ����
                {
                    case "����": rstr = rstr.Substring(0, strlen - 2) + "��"; break;
                    case "Ǫ��": rstr = rstr.Substring(0, strlen - 2) + "Ǫ"; break;
                    case "�f��": rstr = rstr.Substring(0, strlen - 2) + "�f"; break;
                    case "�|��": rstr = rstr.Substring(0, strlen - 2) + "�|"; break;

                }
            }

            return rstr;
        }
        /// <summary>
        /// ת�����֣�С�����֣�
        /// </summary>
        /// <param name="str">��Ҫת����С�����������ַ���</param>
        /// <returns>ת�������Ĵ�д����ַ���</returns>
        private string ConvertXiaoShu(string str)
        {
            int strlen = str.Length;
            string rstr;
            if (strlen == 1)
            {
                rstr = ConvertChinese(str) + "��";
                return rstr;
            }
            else
            {
                string tmpstr = str.Substring(0, 1);
                rstr = ConvertChinese(tmpstr) + "��";
                tmpstr = str.Substring(1, 1);
                rstr += ConvertChinese(tmpstr) + "��";
                rstr = rstr.Replace("���", "");
                rstr = rstr.Replace("���", "");
                return rstr;
            }


        }

        /// <summary>
        /// ת������
        /// </summary>
        /// <param name="str">ת�����ַ�������λ���ڣ�</param>
        /// <returns></returns>
        private string ConvertDigit(string str)
        {
            int strlen = str.Length;
            string rstr = "";
            switch (strlen)
            {
                case 1: rstr = ConvertChinese(str); break;
                case 2: rstr = Convert2Digit(str); break;
                case 3: rstr = Convert3Digit(str); break;
                case 4: rstr = Convert4Digit(str); break;
            }
            rstr = rstr.Replace("ʰ��", "ʰ");
            strlen = rstr.Length;

            return rstr;
        }

        /// <summary>
        /// ת����λ����
        /// </summary>
        private string Convert4Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string str4 = str.Substring(3, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "Ǫ";
            rstring += ConvertChinese(str2) + "��";
            rstring += ConvertChinese(str3) + "ʰ";
            rstring += ConvertChinese(str4);
            rstring = rstring.Replace("��Ǫ", "��");
            rstring = rstring.Replace("���", "��");
            rstring = rstring.Replace("��ʰ", "��");
            rstring = rstring.Replace("����", "��");
            rstring = rstring.Replace("����", "��");
            rstring = rstring.Replace("����", "��");
            return rstring;
        }
        /// <summary>
        /// ת����λ����
        /// </summary>
        private string Convert3Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "��";
            rstring += ConvertChinese(str2) + "ʰ";
            rstring += ConvertChinese(str3);
            rstring = rstring.Replace("���", "��");
            rstring = rstring.Replace("��ʰ", "��");
            rstring = rstring.Replace("����", "��");
            rstring = rstring.Replace("����", "��");
            return rstring;
        }
        /// <summary>
        /// ת����λ����
        /// </summary>
        private string Convert2Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "ʰ";
            rstring += ConvertChinese(str2);
            rstring = rstring.Replace("��ʰ", "��");
            rstring = rstring.Replace("����", "��");
            return rstring;
        }
        /// <summary>
        /// ��һλ����ת�������Ĵ�д����
        /// </summary>
        private string ConvertChinese(string str)
        {
            //"��Ҽ��������½��ƾ�ʰ��Ǫ�f�|Բ���Ƿ�"
            string cstr = "";
            switch (str)
            {
                case "0": cstr = "��"; break;
                case "1": cstr = "Ҽ"; break;
                case "2": cstr = "��"; break;
                case "3": cstr = "��"; break;
                case "4": cstr = "��"; break;
                case "5": cstr = "��"; break;
                case "6": cstr = "½"; break;
                case "7": cstr = "��"; break;
                case "8": cstr = "��"; break;
                case "9": cstr = "��"; break;
            }
            return (cstr);
        }


        /// <summary>
  /// ��ȡ���������ַ���ƴ������ĸ
  /// </summary>
  /// <param name="input">���������ַ���</param>
  /// <returns>ƴ������ĸ</returns>
        static public string ConvertPinYin(string input)
        {
            int len = input.Length;
            string reVal = "";
            for(int i=0;i<len;i++)
            {
                reVal += getSpell(input.Substring(i,1));
            }
            return reVal;
        }

  /// <summary>
  /// ��ȡһ�����������ֵ�ƴ������ĸ
  /// </summary>
  /// <param name="cn">һ������������</param>
  /// <returns>ƴ������ĸ</returns>
        static public string getSpell(string cn)
        {
            byte[] arrCN = Encoding.Default.GetBytes(cn);
            if(arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area<<8) + pos;
                int[] areacode = {45217,45253,45761,46318,46826,47010,47297,47614,48119,48119,49062,49324,49896,50371,50614,50622,50906,51387,51446,52218,52698,52698,52698,52980,53689,54481};
                for(int i=0;i<26;i++)
                {
                    int max = 55290;
                    if(i != 25) max = areacode[i+1];
                    if(areacode[i]<=code && code<max)
                    {
                        return Encoding.Default.GetString(new byte[]{(byte)(65+i)});
                    }
                }
                return "?";
            }
            else return cn;
        }


        /// <summary>
        /// �ж��Ƿ���ƴ��
        /// </summary>
        /// <param name="pinyin"></param>
        /// <returns></returns>
        public static bool IsPinYin(string pinyin)
        {


            Regex r = new Regex(@"^[a-zA-Z]*$");
            if (r.IsMatch(pinyin))
            {
                return true;
            }
            else
            {
                return false;
            }

        }





    }//


}
