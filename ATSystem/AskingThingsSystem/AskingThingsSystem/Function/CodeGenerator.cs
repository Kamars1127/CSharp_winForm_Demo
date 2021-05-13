using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskingThingsSystem.Function
{
    class CodeGenerator
    {
        Random random;

        /*--- 純字母代碼 
         *-參數: 產生幾個字
         *-----------------------*/
        public string LettersCode(int count)
        {
            random = new Random();
            string code = "";

            for (int i=0; i<count; i++)
            {
                /*- ascii 十進位轉字元再轉字串 -*/
                //亂數取得 A-Z 其中一字
                char upperCase_Letter = Convert.ToChar(random.Next(65, 91));
                //亂數取得 a-z 其中一字
                char lowerCase_Letter = Convert.ToChar(random.Next(97, 123));

                /*- 取得其中一個字母 -*/
                char[] charArray = { upperCase_Letter, lowerCase_Letter };
                int index = random.Next(2);
                code += charArray[index].ToString();
            }

            return code;
        }
    }
}
