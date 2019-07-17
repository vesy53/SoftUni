namespace p01._01.StreamProgress
{
    using p01._01.StreamProgress.Contracts;

    public class Video : IStreamable
    {
        private string director;
        private double budget;

        public Video(string director, double budget, int length, int bytesSent)
        {
            this.director = director;

            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
