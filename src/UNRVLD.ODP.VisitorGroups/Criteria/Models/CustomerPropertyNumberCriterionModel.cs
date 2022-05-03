﻿#if NET5_0
using System.ComponentModel.DataAnnotations;
using EPiServer.Personalization.VisitorGroups;

namespace UNRVLD.ODP.VisitorGroups.Criteria.Models
{
    public class CustomerPropertyNumberCriterionModel : CriterionModelBase
    {
        public override ICriterionModel Copy() { return base.ShallowCopy(); }

        [CriterionPropertyEditor(
            Order = 10,
            SelectionFactoryType = typeof(CustomerPropertyNumberSelectionFactory)
        )]
        [Required]
        [Display(Name = "Customer Property (number)")]
        public string PropertyName { get; set; }

        [CriterionPropertyEditor(
            Order = 20,
            SelectionFactoryType = typeof(NumberComparisonSelectionFactory)
        )]
        [Required]
        public string Comparison { get; set; }

        [Required]
        [CriterionPropertyEditor(Order = 30)]
        [Display(Name = "Value")]
        public int PropertyValue { get; set; }
    }
}
#endif