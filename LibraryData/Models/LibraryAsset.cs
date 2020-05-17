using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }

        [Required] public string Title { get; set; }
        [Required] public int Year { get; set; } // Just store as an int for BC
        public Status Status { get; set; }
    
        public int StatusId { get; set; }
        public int LocationId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfCopies { get; set; }
        //public string Discriminator { get; set; }
        public virtual LibraryBranch Location { get; set; }

        
    }
} 