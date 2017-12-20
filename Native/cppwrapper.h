#ifndef _CPP_WRAPPER_H_
#define _CPP_WRAPPER_H_

#include "sco.h"
#include "scoReader.h"
#include "scoWriter.h"

extern "C" _declspec(dllexport) void _stdcall SCO_Read(const char* fileName, sco_file_t* dest)
{
	FILE* fp = fopen(fileName, "rb");
	read_sco_file(fp, dest);
}
#endif