using p01._01.StreamProgress.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace p01._01.StreamProgress
{
    public class StreamProgressInfo
    {
        private IStreamable streamObject;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable streamObject)
        {
            this.streamObject = streamObject;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamObject.BytesSent * 100) / this.streamObject.Length;
        }
    }
}
