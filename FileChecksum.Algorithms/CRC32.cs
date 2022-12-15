namespace FileChecksum.Algorithms
{
    public static class CRC32
    {
        private static readonly uint[] _table;
        private static readonly uint _reversedPolynomial = 0xEDB88320;

        static CRC32()
        {
            _table = GenerateTable();
        }
        
        private static uint[] GenerateTable()
        {
            var table = new uint[256];

            for (var i = 0; i < 256; ++i)
            {
                var value = (uint)i;

                for (var j = 8; j > 0; --j)
                {
                    if ((value & 1) == 1)
                    {
                        value = (value >> 1) ^ _reversedPolynomial;
                    }
                    else
                    {
                        value >>= 1;
                    }
                }

                table[i] = value;
            }

            return table;
        }

        private static uint AddByte(uint crc, byte byteValue)
        {
            return (crc >> 8) ^ _table[byteValue ^ (crc & 0x000000FF)];
        }

        public static uint ComputeBytes(byte[] buffer)
        {
            var crc = 0xFFFFFFFF;

            for (var i = 0; i < buffer.Length; ++i)
            {
                crc = AddByte(crc, buffer[i]);
            }

            crc = ~crc;
            crc = (crc < 0) ? (0xFFFFFFFF + crc + 1) : crc;

            return crc;
        }
    }
}

