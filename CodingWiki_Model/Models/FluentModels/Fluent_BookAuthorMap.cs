﻿using CodingWiki_Model.Models.FluentModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models.FluentModels
{
    public class Fluent_BookAuthorMap
    {
        [Key]
        public int Book_Id { get; set; }
        //[ForeignKey("Author")]
        public int Author_Id { get; set; }
        //public Fluent_Book Book { get; set; }
        //public Fluent_Author Author { get; set; }
    }
}
