using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UsingPointers
{
    class APIFileReader
    {
        const uint GenericRead = 0x80000000;
        const uint OpenExisting = 3;
        const uint UseDefault = 0;
        int fileHandle;

        [DllImport("karnel32", SetLastError = true)]
        static extern unsafe int CreateFile(
            string filename,
            uint desiredAccess,
            uint shareMode,
            uint attributes,
            uint creationDisposition,
            uint flagAndAttributes,
            uint templateFile);

        [DllImport("karnel32", SetLastError = true)]
        static extern unsafe bool ReadFile(
            int hFile,
            void* lpBuffer,
            int nBytesToRead,
            int* nBytesRead,
            int overlapped);

        //konstruktor otvara postojecu datotkeu i postavlja clan za identifikator datoteke
        public APIFileReader(string filename)
        {
            fileHandle = CreateFile(
                filename,           //ime datoteke
                GenericRead,        //desiredAccess
                UseDefault,         //shareMode
                UseDefault,         //atributi
                OpenExisting,       //creationDisposition
                UseDefault,         //flagsAndAttributes
                UseDefault);        //templateFile
        }

        public unsafe int Read(byte[] buffer, int index, int count)
        {
            int bytesRead = 0;
            fixed(byte* bytePointer = buffer)
            {
                ReadFile(
                    fileHandle,             //hFile
                    bytePointer + index,    //lpBuffer
                    count,                  //nBytesToRead
                    &bytesRead,             //nBytesRead
                    0);                     //overlapped
            }

            return bytesRead;
        }
    }
}
