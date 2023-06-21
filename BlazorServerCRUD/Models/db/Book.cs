using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCRUD.Models.db;

public partial class Book
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookId { get; set; }

    [Required(ErrorMessage = "กรุณากรอกชื่อหนังสือด้วย!!!")]
    public string? BookName { get; set; } = null!;

    [Required(ErrorMessage = "กรุณาเลือกประเภทหนังสือ!!!")]
    public int? CategoryId { get; set; }

    [Required(ErrorMessage = "กรุณาเลือกสำนักพิมพ์!!!")]
    public int? PublishId { get; set; }

    [Required(ErrorMessage = "กรุณากรอกรหัส ISBN ก่อน!!!")]
    public string? Isbn { get; set; }

    [Required(ErrorMessage = "กรุณากรอกต้นทุนหนังสิอ!!!")]
    public double? BookCost { get; set; }

    [Required(ErrorMessage = "กรุณาระบุราคาขาย!!!")]
    public double? BookPrice { get; set; }

    public virtual Category? Category { get; set; } = null!;

    public virtual Publisher? Publish { get; set; } = null!;
}
