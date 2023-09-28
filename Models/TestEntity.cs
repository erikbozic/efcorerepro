using System.ComponentModel.DataAnnotations;

namespace EFCoreRepro.Models;

public class TestEntity
{
    public long Id { get; set; }

    [MaxLength(32)]
    public Status Status { get; set; }
    
    [MaxLength(32)]
    public string SubStatus { get; set; }
}
