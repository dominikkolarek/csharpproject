namespace ZooApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Animal
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Species { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Gender { get; set; }

        public int? Age { get; set; }

        public int? ZooId { get; set; }

        public virtual Zoo Zoo { get; set; }
    }
}
