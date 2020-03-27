using System;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Models.Interfaces;

namespace DataAccessLayer.Models {
    public class BaseEntity: IBaseEntity {

        [MaxLength(256)] 
        public string CreatedBy {get; set;}
        
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}