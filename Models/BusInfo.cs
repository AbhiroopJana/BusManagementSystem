using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusManagementSystem.Models;

[Table("BusInfo")]
public partial class BusInfo
{
    [Key]
    [Column("BusID")]
    public int BusId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string BoardingPoint { get; set; } = null!;

    [Column(TypeName = "date")]
    [DataType(DataType.Date)]
    public DateTime TravelDate { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal Amount { get; set; }

    [Range(1, 5)]    
    public int Rating { get; set; }
}
