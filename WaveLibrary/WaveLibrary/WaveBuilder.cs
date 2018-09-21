using System;
using System.Collections.Generic;
using System.Text;
using WaveLibrary.Writingformats;

namespace WaveLibrary
{
    class WaveBuilder
    {
        //Fields in order of file

        readonly BigEndianInt32 FileFormat = new BigEndianInt32(0x52494646);            //"RAFF"
        LittleEndianInt32 filesize; //36 + SubChunk2Size
        readonly BigEndianInt32 FileType = new BigEndianInt32(0x57415645);              //"WAVE"
        readonly BigEndianInt32 format_chunk_market = new BigEndianInt32(0x666d7420);   //"fmt "
        readonly LittleEndianInt32 Subchunk1Size = new LittleEndianInt32(16);
        readonly LittleEndianInt16 AudioFormat = new LittleEndianInt16(1);
        readonly LittleEndianInt16 NumChannels = new LittleEndianInt16(1);
        LittleEndianInt32 SampleRate; //8000, 44100, etc.
        LittleEndianInt32 ByteRate; //SampleRate * NumChannels * BitsPerSample / 8
        LittleEndianInt16 BlockAlign; //NumChannels * BitsPerSample / 8 (number of bytes per sample including all channels)
        LittleEndianInt16 BitsPerSample; //8 or 16

        readonly BigEndianInt32 data_chunk_header = new BigEndianInt32(0x64617461);     //"data"
        LittleEndianInt32 Subchunk2Size; //NumSamples * NumChannels * BitsPerSample / 8 (The number of bytes in the data)
        byte[] Data; //the data
    }
}
