#pragma once
#include "pch.h"

using namespace std;
class FmLog
{
	typedef bool (*pLcb)(bool status, char* data);
private:
	char* fileName;
	void LogCallBask(bool status, char* data);
public:
	LogLevel level;
	FmLog(char* fileName, pLcb pcb);
	bool CreateLog(bool cover);
	void WriteLog(char* fileName, int level, pLcb pcb);
};

enum LogLevel {
	wFATAL = -1,
	wERROR,
	wINFO,
	wWARNING,
	wALL
};