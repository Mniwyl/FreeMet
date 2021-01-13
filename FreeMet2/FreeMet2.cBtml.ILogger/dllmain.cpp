// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"
#include "FmLog.h"
#include <iostream>
#include <fstream>

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

FmLog::FmLog(char* fileName,pLcb pcb)
{
    this->fileName = fileName;
}

bool FmLog::CreateLog(bool cover)
{
    FILE* fp = NULL;
    fp = fopen(this->fileName, "a +");
    if (!fp)
    {
        return false;
    }
    else {

    }
}

