﻿
namespace SereneLargeFileUpload.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Northwind.Region")]
    [BasedOnRow(typeof(Entities.RegionRow), CheckNames = true)]
    public class RegionForm
    {
        public Int32? RegionID { get; set; }
        public String RegionDescription { get; set; }
        public String FileUpload1 { get; set; }
        public String FileUpload2 { get; set; }
    }
}