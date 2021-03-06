using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckProcess
    {
        public CheckProcess()
        {

        }

        public Boolean checkInput(int line, int amount) {
            bool resultFlg = true;

            if (line==1 && (amount<0 || amount > 3)) { 
                resultFlg=false;
            }
            if (line == 2 && (amount < 0 || amount > 5))
            {
                resultFlg=false;
            }
            if (line == 1 && (amount < 0 || amount > 7))
            {
                resultFlg = false;
            }
            if (resultFlg == false) { 
                Console.WriteLine("please intpu correct amount");
            }
            return resultFlg;
        }

        public Boolean checkRangeOfLine(int line)
        {
            if (line != 1 && line != 2 && line != 3)
            {
                Console.WriteLine("please input correct line number.");
                return false;
            }
            return true;
            
        }

        public Boolean compareLine(int line1, int line2)
        {
            if (line1==line2) {
                return false;
            }
            return true;
        }

        public Boolean checkRangeOfAmount(int amount)
        {
            if (amount <1 || amount >7)
            {
                Console.WriteLine("please input correct amount.");
                return false;
            }
            return true;
        }

        public Boolean checkMain(int lineNum1, int lineNum2,int catchAmount1, int catchAmount2)
        {
            if (checkRangeOfLine(lineNum1) == false)
            {
                return false;
            }
            if (checkRangeOfLine(lineNum2) == false)
            {
                return false;
            }
            if (compareLine(lineNum1, lineNum2) == false)
            {
                return false;
            }
            if (checkRangeOfAmount(catchAmount1) == false)
            {
                return false;
            }
            if (checkRangeOfAmount(catchAmount2) == false)
            {
                return false;
            }
            if (checkInput(lineNum1, catchAmount1) == false)
            {
                return false;
            }
            if (checkInput(lineNum2, catchAmount2) == false)
            {
                return false;
            }
            return true;
        }
    }
}
