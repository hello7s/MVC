﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace DoubleR.Models
{
    public class TuneRummy
    {
        public int PlayerId { get; set; }
        public string ScreenName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}