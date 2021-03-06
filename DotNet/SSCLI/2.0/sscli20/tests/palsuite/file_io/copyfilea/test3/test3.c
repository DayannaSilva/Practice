/*=====================================================================
**
** Source:  test3.c
**
** Purpose: Tests the PAL implementation of the CopyFileA function
**          to see if a file can be copied to itself
**
** 
**  Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
** 
**  The use and distribution terms for this software are contained in the file
**  named license.txt, which can be found in the root of this distribution.
**  By using this software in any fashion, you are agreeing to be bound by the
**  terms of this license.
** 
**  You must not remove this notice, or any other, from this software.
** 
**
**===================================================================*/

#include <palsuite.h>

int __cdecl main(int argc, char *argv[])
{

    BOOL bRc = TRUE;
    char* szSrcExisting = "src_existing.tmp";
    char* szDest = "src_dest.tmp";
    FILE* tempFile = NULL;
    DWORD temp;
    int retCode;
    
    if (0 != PAL_Initialize(argc,argv))
    {
        return FAIL;
    }

     /* create the src_existing file */
    tempFile = fopen(szSrcExisting, "w");
    if (tempFile != NULL)
    {
        retCode = fputs("CopyFileA test file: src_existing.tmp ", tempFile);
        if(retCode < 0)
        {
            retCode = fclose(tempFile);
            if(retCode != 0)
            {
                Trace("CopyFileA: ERROR-> Couldn't close file: %s with error "
                      "%u.\n", szSrcExisting, GetLastError());
            }
            
            Fail("CopyFileA: ERROR-> Couldn't write to %s with error "
                "%u.\n", szSrcExisting, GetLastError());
        }
        retCode = fclose(tempFile);
        if(retCode != 0)
        {
            Fail("CopyFileA: ERROR-> Couldn't close file: %s with error "
                "%u.\n", szSrcExisting, GetLastError());
        }

    }
    else
    {
        Fail("CopyFileA: ERROR-> Couldn't create %s with "
            "error %ld\n",szSrcExisting,GetLastError());
    }

    /* set the file attributes of the source file to readonly */
    bRc = SetFileAttributes(szSrcExisting, FILE_ATTRIBUTE_READONLY);
    if(!bRc)
    {
        Fail("CopyFileA: ERROR-> Couldn't set file attributes for "
            "file %s with error %u\n", szSrcExisting, GetLastError());
    }

    /* copy the file */
    bRc = CopyFileA(szSrcExisting,szDest,TRUE);
    if(!bRc)
    {
        Fail("CopyFileA: Cannot copy a file with error, %u",GetLastError());
    }
    
  
    /* try to get file attributes of destination file */
    if (GetFileAttributesA(szDest) == -1)
    {
        Fail("CopyFileA: GetFileAttributes of destination file "
            "failed with error code %ld. \n",
            GetLastError());  
    }

    /* verify attributes of destination file to source file*/                    
    temp = GetFileAttributesA(szDest);
    if((temp & FILE_ATTRIBUTE_READONLY) != FILE_ATTRIBUTE_READONLY)
    {
        Fail("CopyFileA : The file attributes of the "
            "destination file do not match the file "
            "attributes of the source file.\n");
    }
    
    /* set the attributes of the destination file to normal again */
    bRc = SetFileAttributesA(szDest, FILE_ATTRIBUTE_NORMAL);
    if(!bRc)
    {
        Fail("CopyFileA: ERROR-> Couldn't set file attributes for "
            "file %s with error %u\n", szDest, GetLastError());
    }

    /* delete the newly copied file */
    bRc = DeleteFile(szDest);
    if(!bRc)
    {
        Fail("CopyFileA: DeleteFile failed to delete the"
            "file correctly with error,%u.\n",GetLastError());
    }

    /* set the attributes of the source file to normal again */
    bRc = SetFileAttributesA(szSrcExisting, FILE_ATTRIBUTE_NORMAL);
    if(!bRc)
    {
        Fail("CopyFileA: ERROR-> Couldn't set file attributes for "
            "file %s with error %u\n", szSrcExisting, GetLastError());
    }    
    
    /* delete the original file */
    bRc = DeleteFile(szSrcExisting);
    if(!bRc)
    {
        Fail("CopyFileA: DeleteFile failed to delete the"
            "file correctly with error,%u.\n",GetLastError());
    }
 
    PAL_Terminate();
    return PASS;
    
}
