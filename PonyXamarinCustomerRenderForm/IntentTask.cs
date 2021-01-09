using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DeveloperHelperXForm.Models
{
    public partial class IntentTask
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("IntentTaskID")]
        public long IntentTaskId { get; set; }
        [Display]
        [Required]
        [Column(TypeName = "NVARCHAR(128)")]
        public string IntentTaskTitle { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(10000)")]
        public string IntentTaskParameter { get; set; }
        [Column(TypeName = "NVARCHAR(10000)")]
        public string IntentTaskRunParameter { get; set; }
        [Column(TypeName = "NVARCHAR(128)")]
        public string IntentTaskType { get; set; }
        public override string ToString() { return this.IntentTaskTitle.ToString() ; }
    }
}
