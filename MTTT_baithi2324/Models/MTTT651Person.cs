using System.ComponentModel.DataAnnotations;

namespace MTTT_baithi2324.Models;
    
public class MTTT651Person {
[Key]
 public int PersonID{ get; set; }
 public string? FullName { get; set; }
 public int Age { get; set; }
 }