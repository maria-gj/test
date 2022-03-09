using ConsoleApp1;

Console.WriteLine("-----------游戏说明-------------------");
Console.WriteLine("15个任意物品(可以是火柴牙签poker)\n" +
    "以下按牙签为例将15根牙签分成三行每行自上而下(其实方向不限)\n" +
    "分别是3、5、7根安排两个玩家，\n" +
    "每人可以在一轮内，在任意行拿任意根牙签，\n" +
    "但不能跨行拿最后一根牙签的人即为输家");
Console.WriteLine("------------------------------");
//Console.ReadLine();
try {


    Console.WriteLine("Please enter the line number selected by player 1:");
    int lineNum1 = int.Parse( Console.ReadLine());
    Console.WriteLine("Please enter the number of matchs taken by player 1:");
    int catchAmount1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the line number selected by player 2:");
    int lineNum2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the number of matchs taken by player 2:");
    int catchAmount2 = int.Parse(Console.ReadLine());

    //check input
    CheckProcess cp = new CheckProcess();
    if(cp.checkRangeOfLine(lineNum1) == false)
    {
        return;
    }
    if(cp.checkRangeOfLine(lineNum2) == false){
        return;
    }
    if(cp.compareLine(lineNum1, lineNum2) == false){
        return;
    }
    if(cp.checkRangeOfAmount(catchAmount1) == false){
        return;
    }
    if(cp.checkRangeOfAmount(catchAmount2) == false){
        return;
    }
    if(cp.checkInput(lineNum1, catchAmount1) == false){
        return;
    }
    if(cp.checkInput(lineNum2, catchAmount2) == false){
        return;
    }

    int[] amountAry = { 3, 5, 7 };
    int roopCounter = amountAry[lineNum1 - 1] < amountAry[lineNum2 - 1] ? amountAry[lineNum1 - 1] : amountAry[lineNum2 - 1];
    for (int i = 1;i <= roopCounter; i++ )
    {
        amountAry[lineNum1 - 1] = amountAry[lineNum1-1] - catchAmount1;
        amountAry[lineNum2 - 1] = amountAry[lineNum2 - 1] - catchAmount2;
        if (amountAry[lineNum1 - 1] == 0)
        {
            Console.WriteLine("!!!!!!!!Player 1 wins!!!!!!!!");
            return;
        }
        else if(amountAry[lineNum2 - 1] == 0)
        {
            Console.WriteLine("!!!!!!!!Player 2 wins!!!!!!!!");
            return;
        }
        //Console.WriteLine("Please enter the line number selected by player 1:");
        //lineNum1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of matchs taken by player 1:");
        catchAmount1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter the line number selected by player 2:");
        //lineNum2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of matchs taken by player 2:");
        catchAmount2 = int.Parse(Console.ReadLine());

        //check input
        cp = new CheckProcess();
        if(cp.checkRangeOfLine(lineNum1) == false){
            return;
        }
        if(cp.checkRangeOfLine(lineNum2) == false){
            return;
        }
        if(cp.compareLine(lineNum1, lineNum2) == false){
            return;
        }
        if(cp.checkRangeOfAmount(catchAmount1) == false){
            return;
        }
        if(cp.checkRangeOfAmount(catchAmount2) == false){
            return;
        }
        if(cp.checkInput(lineNum1, catchAmount1) == false){
            return;
        }
        if(cp.checkInput(lineNum2, catchAmount2) == false){
            return;
        }
    }
}
catch (Exception e) {
    Console.WriteLine(e);
}
