namespace p01._01.StreamProgress.Contracts
{
    public interface IStreamable
    {
        int Length { get; set; }

        int BytesSent { get; set; }
    }
}
