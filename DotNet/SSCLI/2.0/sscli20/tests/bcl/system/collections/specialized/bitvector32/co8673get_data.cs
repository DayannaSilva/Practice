// ==++==
//
//   
//    Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//   
//    The use and distribution terms for this software are contained in the file
//    named license.txt, which can be found in the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by the
//    terms of this license.
//   
//    You must not remove this notice, or any other, from this software.
//   
//
// ==--==
using System.IO;
using System.Text;  
using System;
using System.Collections;
using System.Collections.Specialized;
public class Co8673get_Data
{
    public static String s_strActiveBugNums = "";
    public static String s_strDtTmVer       = "";
    public static String s_strClassMethod   = "BitVector32.Data";
    public static String s_strTFName        = "Co8673get_Data.cs";
    public static String s_strTFAbbrev      = s_strTFName.Substring(0, 6);
    public static String s_strTFPath        = Environment.CurrentDirectory;
    public virtual bool runTest()
    {
        Console.WriteLine(s_strTFPath + " " + s_strTFName + " , for " + s_strClassMethod + " , Source ver: " + s_strDtTmVer);
        int iCountErrors = 0;
        int iCountTestcases = 0;
        String strLoc = "Loc_000oo";
        BitVector32 bv32;         
        int data = 0;
        try
        {
            Console.WriteLine("1. default ctor");
            strLoc = "Loc_001oo"; 
            iCountTestcases++;
            bv32 = new BitVector32();
            if (bv32.Data != 0) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0001, Data = {0} after default ctor", bv32.Data);
            }
            data = 0;
            Console.WriteLine("2. ctor({0})", data);
            strLoc = "Loc_002oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0002, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = 1;
            Console.WriteLine("3. ctor({0})", data);
            strLoc = "Loc_003oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0003, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = -1;
            Console.WriteLine("4. ctor({0})", data);
            strLoc = "Loc_004oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0004, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = 2;
            Console.WriteLine("5. ctor({0})", data);
            strLoc = "Loc_005oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0005, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = 10;
            Console.WriteLine("6. ctor({0})", data);
            strLoc = "Loc_006oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0006, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = 99;
            Console.WriteLine("7. ctor({0})", data);
            strLoc = "Loc_007oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0007, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = -9;
            Console.WriteLine("8. ctor({0})", data);
            strLoc = "Loc_008oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0008, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = System.Int32.MinValue;
            Console.WriteLine("9. ctor({0})", data);
            strLoc = "Loc_009oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0009, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = System.Int32.MaxValue;
            Console.WriteLine("10. ctor({0})", data);
            strLoc = "Loc_010oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0010, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = System.Int32.MinValue / 2;
            Console.WriteLine("11. ctor({0})", data);
            strLoc = "Loc_011oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0011, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = System.Int32.MaxValue / 2;
            Console.WriteLine("12. ctor({0})", data);
            strLoc = "Loc_012oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0012, Data = {0} after ctor({1})", bv32.Data, data);
            }
            DateTime time = DateTime.Now;
            data = time.DayOfYear + time.Hour + time.Minute + time.Second;
            System.Random random = new System.Random(data);
            data = random.Next(System.Int32.MinValue, System.Int32.MaxValue);
            Console.WriteLine("13. ctor(random data: {0})", data);
            strLoc = "Loc_013oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0013, Data = {0} after ctor({1})", bv32.Data, data);
            }
            data = 7;
            Console.WriteLine("14. access Data on BitVector32({0})", data);
            strLoc = "Loc_014oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            Console.WriteLine("  a. check Data");
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0014a, Data = {0} after ctor({1})", bv32.Data, data);
            }
            iCountTestcases++;
            int mask = BitVector32.CreateMask();
            Console.WriteLine("  b. access via Mask " + mask);
            strLoc = "Loc_014oo"; 
            if ((bv32.Data & mask) != mask)
            {
                iCountErrors++;
                Console.WriteLine("Err_0014b, {0} & {1} != {1}", bv32.Data, mask);
            }
            iCountTestcases++;
            BitVector32.Section sect = BitVector32.CreateSection(1);
            Console.WriteLine("  c. access via Section {0}", sect.ToString());
            Console.WriteLine("   - get section value");
            strLoc = "Loc_015oo"; 
            if ((bv32[sect]) != 1)
            {
                iCountErrors++;
                Console.WriteLine("Err_0014c, bv32[{0}] != {1}", sect, 1);
            }
            Console.WriteLine("   - set section value and verify Data");
            bv32[sect] = 0; 
            if (bv32.Data != 6)
            {
                iCountErrors++;
                Console.WriteLine("Err_0014c, Data: {0} != {1}", bv32.Data, 6);
            }
            iCountTestcases++;
            strLoc = "Loc_016oo"; 
            sect = BitVector32.CreateSection(5);
            Console.WriteLine("  d. access via Section {0}", sect.ToString());
            Console.WriteLine("   - get section value");
            if ((bv32[sect]) != bv32.Data)
            {
                iCountErrors++;
                Console.WriteLine("Err_0014d, bv32[{0}] != {1}", sect, bv32.Data);
            }
            Console.WriteLine("   - set section value and verify Data");
            bv32[sect] = 0;
            if (bv32.Data != 0)
            {
                iCountErrors++;
                Console.WriteLine("Err_0014e, Data: {0} != {1}", bv32.Data, 0);
            }
            data = -1;
            Console.WriteLine("15. access Data on BitVector32({0})", data);
            strLoc = "Loc_017oo"; 
            iCountTestcases++;
            bv32 = new BitVector32(data);
            Console.WriteLine("  a. check Data");
            if (bv32.Data != data) 
            {
                iCountErrors++;
                Console.WriteLine("Err_0015a, Data = {0} after ctor({1})", bv32.Data, data);
            }
            iCountTestcases++;
            strLoc = "Loc_018oo";
            sect = BitVector32.CreateSection(1);
            sect = BitVector32.CreateSection(Int16.MaxValue, sect);
            sect = BitVector32.CreateSection(Int16.MaxValue, sect);
            sect = BitVector32.CreateSection(1, sect);
            Console.WriteLine("  b. access via Section: {0} - offset {1} - sign bit", sect.ToString(), (int)sect.Offset);
            Console.WriteLine(" " + bv32.ToString());
            bv32[sect] = 0; 
            if (bv32.Data != Int32.MaxValue)
            {
                iCountErrors++;
                Console.WriteLine("Err_0015b, Data: {0} != {1}", bv32.Data, Int32.MaxValue);
            }
        } 
        catch (Exception exc_general ) 
        {
            ++iCountErrors;
            Console.WriteLine (s_strTFAbbrev + " : Error Err_8888yyy!  strLoc=="+ strLoc +", exc_general==\n"+exc_general.ToString());
        }
        if ( iCountErrors == 0 )
        {
            Console.WriteLine( "Pass.   "+s_strTFPath +" "+s_strTFName+" ,iCountTestcases=="+iCountTestcases);
            return true;
        }
        else
        {
            Console.WriteLine("Fail!   "+s_strTFPath+" "+s_strTFName+" ,iCountErrors=="+iCountErrors+" , BugNums?: "+s_strActiveBugNums );
            return false;
        }
    }
    public static void Main(String[] args)
    {
        bool bResult = false;
        Co8673get_Data cbA = new Co8673get_Data();
        try 
        {
            bResult = cbA.runTest();
        } 
        catch (Exception exc_main)
        {
            bResult = false;
            Console.WriteLine(s_strTFAbbrev + " : Fail! Error Err_9999zzz! Uncaught Exception in main(), exc_main=="+exc_main);
        }
        if (!bResult)
        {
            Console.WriteLine ("Path: "+s_strTFName + s_strTFPath);
            Console.WriteLine( " " );
            Console.WriteLine( "Fail!  "+ s_strTFAbbrev);
            Console.WriteLine( " " );
        }
        if (bResult) Environment.ExitCode=0; else Environment.ExitCode=1;
    }
}
