//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz.Web.DAL.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EligibilityCriteriaDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EligibilityCriteriaDetail()
        {
            this.AssessmentDetailMasters = new HashSet<AssessmentDetailMaster>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> QuestionBankID { get; set; }
        public string Name { get; set; }
        public Nullable<long> NotConsider { get; set; }
        public Nullable<long> MayConsider { get; set; }
        public Nullable<long> StrongConsider { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentDetailMaster> AssessmentDetailMasters { get; set; }
        public virtual QuestionBankMaster QuestionBankMaster { get; set; }
    }
}