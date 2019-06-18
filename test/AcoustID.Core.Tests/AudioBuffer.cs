﻿
namespace AcoustID.Tests
{
    using AcoustID.Audio;
    using System;

    /// <summary>
    /// Simple audio buffer.
    /// </summary>
    public class AudioBuffer : IAudioConsumer
    {
        public short[] data;

        public void Consume(short[] input, int length)
        {
            if (data == null)
            {
                data = new short[length];
                Array.Copy(input, 0, data, 0, length);
                return;
            }

            int last_size = data.Length;

            Array.Resize(ref data, last_size + length);
            Array.Copy(input, 0, data, last_size, length);
        }
    }
}
