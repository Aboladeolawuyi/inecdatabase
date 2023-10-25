using System.ComponentModel.DataAnnotations;

public class votes
{
    [Key]
    public int SerialNumber { get; set; }

    public string NameOfRA { get; set; }

    public string Code { get; set; }

    public int NumberOfRegisteredVoters { get; set; }

    public int NumberOfAccreditedVoters { get; set; }

    public int A { get; set; }
    public int AAC { get; set; }

    public int ADC { get; set; }

    public int ADP { get; set; }

    public int APC { get; set; }

    public int APM { get; set; }

    public int APP { get; set; }

    public int BP { get; set; }

    public int LP { get; set; }

    public int NNPP { get; set; }

    public int NRM { get; set; }

    public int PDP { get; set; }

    public int PRP { get; set; }

    public int SDP { get; set; }

    public int YPP { get; set; }

    public int ZLP { get; set; }

    public int TotalValidVotes { get; set; }

    public int RejectedVotes { get; set; }
}
