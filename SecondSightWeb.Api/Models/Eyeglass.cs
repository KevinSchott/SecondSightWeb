using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondSightWeb.Api.Models
{
    public class Eyeglass
    {
        #region Enums

        public enum LensTypeEnum
        {
            Single,
            Multifocal
        }

        public enum GenderEnum
        {
            Male,
            Female,
            Unisex
        }

        public enum SizeEnum
        {
            Small,
            Medium,
            Large,
            Child
        }

        public enum TintEnum
        {
            None,
            Light,
            Dark
        }
        
        public enum StatusEnum
        {
            Active,
            Dispensed,
            Deleted
        }

        #endregion

        public string SKU { get; set; }

        public double SphereOD { get; set; }
        public double CylinderOD { get; set; }
        public int AxisOD { get; set; }
        public double AddOD { get; set; }
        public double SphereOS { get; set; }
        public double CylinderOS { get; set; }
        public int AxisOS { get; set; }
        public double AddOS { get; set; }

        public LensTypeEnum LensType { get; set; }
        public GenderEnum Gender { get; set; }
        public SizeEnum Size { get; set; }
        public TintEnum Tint { get; set; }

        public StatusEnum Status { get; set; }

    }
}