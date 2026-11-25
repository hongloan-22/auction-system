namespace Auction.Api.Domain;

public class AuctionSession
{
    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal StartingPrice { get; set; }
    public decimal MinIncrement { get; set; }
    public decimal CurrentPrice { get; set; }
    public string? CurrentBidder { get; set; }
    public DateTime StartTime { get; set; }   // luôn là UTC
    public DateTime EndTime { get; set; }     // luôn là UTC
    public AuctionStatus Status { get; set; }
    public string? WinnerBidder { get; set; }
}