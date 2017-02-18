using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommercialCode
{
    public class MorseCode
    {
        #region 固定数据
        string[] PlainText =
        {
           "-",".",
           "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
           "0","1","2","3","4","5","6","7","8","9",
           ":",",",";","?","=","'","/","!","_","(",")","$","&","@","\""
        };
        string[] Morsecode =
        {
            "横点点点点横","点横点横点横",
            "点横","横点点点","横点横点","横点点","点","点点横点","横横点","点点点点","点点","点横横横","横点横","点横点点","横横","横点","横横横","点横横点","横横点横","点横点","点点点","横","点点横","点点点横","点横横","横点点横","横点横横","横横点点",
           "横横横横横","点横横横横","点点横横横","点点点横横","点点点点横","点点点点点","横点点点点","横横点点点","横横横点点","横横横横点",
           "横横横点点点","横横点点横横","横点横点横点","点点横横点点","横点点点横","点横横横横点","横点点横点","横点横点横横","点点横横点横","横点横横点","横点横横点横","点点点横点点横","点点点点","点横横点横点","点横点点横点"
        };//使用中文是为了避免转换"-""."这样的特殊字符为摩尔斯电码时出现干扰
        #endregion
        #region 程序内部变量
        string point_pri = ".";
        string line_pri = "-";
        #endregion
        #region 开放变量（属性）
        public string point
        {
            get
            {
                return point_pri;
            }
            set
            {
                point_pri = value;
            }
            
        }
        public string line
        {
            get
            {
                return line_pri;
            }
            set
            {
                line_pri = value;
            }

        }

        #endregion
        public MorseCode()//初始程序（构造函数）
        {

        }
       
        /// <summary>
        /// 文字转摩尔斯电码
        /// </summary>
        /// <param name="inputtext">待转换的文字</param>
        /// <returns>对应的摩尔斯电码</returns>
        public string TextToCode(string inputtext)//文字转摩尔斯电码
        {
            string OUTPUTTEXT=inputtext.ToUpper();//读取参数并进行大写处理
            for(int i=0;i<PlainText.Length; i++)//
            {
                OUTPUTTEXT = OUTPUTTEXT.Replace(PlainText[i],Morsecode[i]+" ");//将字母替换为对应的摩尔斯电码
            }
            OUTPUTTEXT = OUTPUTTEXT.Replace("横",line_pri);//将转换好的摩尔斯电码按照用户设置的点、横样式进行处理
            OUTPUTTEXT = OUTPUTTEXT.Replace("点",point_pri);
            return OUTPUTTEXT;//输出
        }
        
        /// <summary>
        /// 摩尔斯电码转文字
        /// </summary>
        /// <param name="inputtext">待转换的摩尔斯电码</param>
        /// <returns>对应的文字</returns>
        public string CodeToText(string inputtext)//摩尔斯电码转文字
        {
            string outputtext = inputtext;//读取参数
            outputtext = outputtext.Replace(line_pri,"横");//预处理
            outputtext = outputtext.Replace(point_pri,"点");
            string[] converting = outputtext.Split(' ');//将摩尔斯电码装入字符串数组

            for (int i = 0; i < converting.Length; i++)
            {
                for (int a = 0; a < Morsecode.Length; a++)
                {
                    if (converting[i]==Morsecode[a])//
                    {
                        converting[i] = PlainText[a];//替换为对应字母
                    }
                }
            }

            outputtext = null;//
            for (int i=0;i<converting.Length;i++)
            {
                outputtext = outputtext + converting[i];//将字符串数组出现组装成一个字符串
            }
            outputtext = outputtext.Replace("横",line_pri);//处理无效的摩尔斯电码
            outputtext = outputtext.Replace("点",point_pri);
            return outputtext; //输出           
        }

        
    }
}
