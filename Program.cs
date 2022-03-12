using System;
namespace Assignments
{
    class Program
    {
        public static void Main(string[] args)
        {
        START:
            Console.Clear();
            Console.WriteLine("Enter Ouestion number: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
/*Ouestion 1*/  case 1:
                    Console.WriteLine("Q1.Write a program to swap given two numbers.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Swapp sw = new ();
                    sw.swp();
                    break;
/*Ouestion 2*/  case 2:
                    Console.WriteLine("Q2.Write a program to check given number is even or odd.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    EvnOdd ev = new ();
                    ev.evnOd();
                    break;
/*Ouestion 3*/  case 3:
                    Console.WriteLine("Q3.Write a program to check given character is vowel or consonant.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    VlCt vc = new ();
                    vc.vocn();
                    break;
/*Ouestion 4*/  case 4:
                    Console.WriteLine("Q4.Write a program to find sum of 1 to n numbers using goto statement.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    SumGoto sc = new ();
                    sc.sgt();
                    break;
/*Ouestion 5*/  case 5:
                    Console.WriteLine("Q5.Write a program to find table of given number.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Table tb = new ();
                    tb.Tbl();
                    break;
/*Ouestion 6*/  case 6:
                    Console.WriteLine("Q6.Write a program to find all factors of given number.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    factr ft = new ();
                    ft.ftr();
                    break;
/*Ouestion 7*/  case 7:
                    Console.WriteLine("Q7.Write a program to assign suitable title (Miss, Mrs, Mr) to person. Take input one's gender and material status if required.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Titl tt = new ();
                    tt.titl();
                    break;
/*Ouestion 8*/  case 8:
                    Console.WriteLine("Q8.Write a program to convert 24-hour time format to 12-hour time format with am or pm appropriate.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Timee tm = new ();
                    tm.tmctr();
                    break;
/*Ouestion 9*/  case 9:
                    Console.WriteLine("Q9.Write a program to input electricity unit charge and calculate the total electricity bill according to the given condition: \nFor first 50 units Rs. 0.50/unit\nFor next 100 units Rs. 0.75/unit\nFor next 100 units Rs. 1.20/unit\nFor unit above 250 Rs. 1.50/unit\nAn additional surcharge of 20% is added to the bill.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Billing bl = new ();
                    bl.bill();
                    break;
/*Ouestion 10*/ case 10:
                    Console.WriteLine("Q10Write a program to calculate sum of all even numbers up to given number.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    SumOfEvn se = new ();
                    se.smevn();
                    break;
/*Ouestion 11*/ case 11:
                    Console.WriteLine("Q11.Write a program to enter student marks and calculate percentage and grade.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    student st = new ();
                    st.percnt();
                    break;
/*Ouestion 12*/ case 12:
                    Console.WriteLine("Q12.Write a program to calculate profit or loss.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    ProLos pl = new ();
                    pl.PL();
                    break;
/*Ouestion 13*/ case 13:
                    Console.WriteLine("Q13.Write a program to reverse the given number.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Reverse rr = new();
                    rr.rvr();
                    break;
/*Ouestion 14*/ case 14:
                    Console.WriteLine("Q14.Write a program to find given number is Armstrong or not.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Armstrong ar = new ();
                    ar.arm();
                    break;
/*Ouestion 15*/ case 15:
                    Console.WriteLine("Q15.Write a program to print Fibonacci series up to n number of terms.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Fibo ff = new ();
                    ff.fiboo();
                    break;
/*Ouestion 16*/ case 16:
                    Console.WriteLine("Q16.Write a program to print all prime numbers between given two intervals.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    PrimeNo pn = new ();
                    pn.prmNo();
                    break;
/*Ouestion 17*/ case 17:
                    Console.WriteLine("Q17.Write a program to print all Armstrong numbers between given two intervals.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    ArmInt at = new ();
                    at.ArIt();
                    break;
/*Ouestion 18*/ case 18:
                    Console.WriteLine("Q18.Write a program to find greater between given three numbers.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Great grt = new ();
                    grt.grt();
                    break;
/*Ouestion 19*/ case 19:
                    Console.WriteLine("Q19.Write a program to find sum of all digits in given number.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    DgtSum ds = new ();
                    ds.sumDgt();
                    break;
/*Ouestion 20*/ case 20:
                    Console.WriteLine("Q20.Write a C# program to convert given number in word. (357546  :  three five seven five four six )");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    WrdNum wn = new ();
                    wn.numWrd();
                    break;
/*Ouestion 21*/ case 21:
                    Console.WriteLine("Q21.Write a C# program to convert given number in word form . (147 : one hundred forty seven)");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    NunWrd nw = new ();
                    nw.wrdNm();
                    break;
/*Ouestion 22*/ case 22:
                    Console.WriteLine("Q22.Find the greater between given 3 numbers using ternary operator.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    GrTern gt = new ();
                    gt.GTern();
                    break;
/*Ouestion 23*/ case 23:
                    Console.WriteLine("Q23.Write a C# program to convert decimal number to binary.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    DecToBin db = new ();
                    db.dbn();
                    break;
/*Ouestion 24*/ case 24:
                    Console.WriteLine("Q24.Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 ).");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Perfec pr = new ();
                    pr.perf();
                    break;
/*Ouestion 25*/ case 25:
                    Console.WriteLine("Q25.Write a C# program to print all perfect numbers within given range.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    PerfRange prn = new ();
                    prn.perng();
                    break;
/*Ouestion 26*/ case 26:
                    Console.WriteLine("Q26.Write down a menu driven program using switch to convert various distance from one unit to other.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    DisCon dc = new ();
                    dc.distcon();
                    break;
/*Ouestion 27*/ case 27:
                    Console.WriteLine("Q27.Write a program in C# to read n number of values in an array and display it in reverse order.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    RevArr rrr = new ();
                    rrr.rvar(); 
                    break;
/*Ouestion 28*/ case 28:
                    Console.WriteLine("Q28.Write a program in C# to find the sum and average of all elements of the array.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    SmAvgArr sar = new ();
                    sar.smAvgAr();
                    break;
/*Ouestion 29*/ case 29:
                    Console.WriteLine("Q29.Write a program in C# to find maximum and minimum element in an array.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    MinMaxArr mnn = new ();
                    mnn.mimxar();
                    break;
/*Ouestion 30*/ case 30:
                    Console.WriteLine("Q30.Write a program in C# to sort the given array in descending order.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    SortArr sr = new ();
                    sr.arrSrt();
                    break;
/*Ouestion 31*/ case 31:
                    Console.WriteLine("Q31.Write a program in C# to search given element in array.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    SrchArr sa = new ();
                    sa.arrSch();
                    break;
/*Ouestion 32*/ case 32:
                    Console.WriteLine("Q32.Input one matrix and print its transpose.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    TranspMat mt = new ();
                    mt.matTrans();
                    break;
/*Ouestion 33*/ case 33:
                    Console.WriteLine("Q33.Input a square matrix and find the sum of diagonal elements.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    DiagSumMat dg = new ();
                    dg.dgsmat();
                    break;
/*Ouestion 34*/ case 34:
                    Console.WriteLine("Q34.Write a C# program to store the information of one student using structure.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    StrStud ss = new ();
                    ss.StudStr();
                    break;
/*Ouestion 35*/ case 35:
                    Console.WriteLine("Q35.Write a C# program to store the information of 5 employees using structure and array.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    EmpStrArr emp = new ();
                    emp.EmpStr();
                    break;
/*Ouestion 36*/ case 36:
                    Console.WriteLine("Q36.Demonstrate the use of all access specifiers with suitable example.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    AccSpec ac = new ();
                    ac.infoo();
                    break;
/*Ouestion 37*/ case 37:
                    Console.WriteLine("Q37.Input 3 numbers from command line argument and find greater between them using ternary operator.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    CmdTern cd = new ();
                    cd.trnCmd(args);
                    break;
/*Ouestion 38*/ case 38:
                    Console.WriteLine("Q38.Input 5 subjects marks from command line argument. Calculate percentage of student and assign appropriate grade.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Cmdstudent cs = new ();
                    cs.studCmd(args);
                    break;
/*Ouestion 39*/ case 39:
                    Console.WriteLine("Q39.Input a number from command line argument and check whether it is palindrome or not.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    CmdPalindrome cpm = new ();
                    cpm.palinCmd(args);
                    break;
/*Ouestion 40*/ case 40:
                    Console.WriteLine("Q40.Input a number from command line argument and check it is Armstrong or not.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    CmdArmstrong carm = new ();
                    carm.armCmd(args);
                    break;
/*Ouestion 41*/ case 41:
                    Console.WriteLine("Q41.Write a program which will demonstrate function overloading. Use minimum 3 functions");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    FuncOver fo = new ();
                    fo.overFun();
                    break;
/*Ouestion 42*/ case 42:
                    Console.WriteLine("Q42.Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Constr dft = new Constr();
                    Constr parm = new Constr("Parameter");
                    Constr cpy = new Constr(parm);
                    break;
/*Ouestion 43*/ case 43:
                    Console.WriteLine("Q43.Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    
                    break;
/*Ouestion 44*/ case 44:
                    Console.WriteLine("Q41.Write a program to demonstrate static constructor with proper example.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    StConst sm = new ();
                    break;
/*Ouestion 45*/ case 45:
                    Console.WriteLine("Q45.Write the program which will implement the concept of properties in c#.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Prop pp = new Prop();
                    pp.name = "Yash";
                    pp.pp();
                    break;
/*Ouestion 46*/ case 46:
                    Console.WriteLine("Q46.Write a C# program which will demonstrate the single inheritance. \n    Take base class as Bird and child class as parrot. \n    Write and inherit the appropriate methods");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    bird bd = new parrot();
                    break;
/*Ouestion 47*/ case 47:
                    Console.WriteLine("Q47.Write a C# program to demonstrate multilevel inheritance. \n    Base class: bird, middle class: flying birds, child class: any bird. \n    Use appropriate methods in related class.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Eagle bdd = new Eagle();
                    break;
/*Ouestion 48*/ case 48:
                    Console.WriteLine("Q48.Take Account as abstract class. Make saving a/c and current a/c as its child. Make hierarchical inheritance between them.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Account acc ;
                    acc = new SavingAcc();
                    acc.Acc();
                    acc = new CurrentAccount();
                    acc.Acc();
                    break;
/*Ouestion 49*/ case 49:
                    Console.WriteLine("Q49.Demonstrate multiple inheritance with the use of interface with suitable example.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    Multiple mi = new ();
                    mi.mulInhrt();
                    break;
/*Ouestion 50*/ case 50:
                    Console.WriteLine("Q50.Declare a class name 'A' with some methods and one parameterised constructor. \n    Derive another class 'B' from 'class A'. \n    In class B have some methods and constructor. \n    Demonstrate how base class parameterised constructor gets call from child class constructor.");
                    Console.WriteLine("|+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|\n");
                    B b = new B('b');
                    break;
                
                default:
                    Console.WriteLine("Coming Soon.....!!");
                    break;
            }

            Console.WriteLine("\n|*---------------------------------------*|");
            Console.WriteLine("To Proceed with another Questions PRESS 1\nTo Exit Application PRESS 0");
            int iterat = int.Parse(Console.ReadLine());
            if(iterat == 1)
                goto START;
            if(iterat == 0)
                Environment.Exit(0);
        }
    }
}
