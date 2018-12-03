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
    
    public partial class AssessmentDetailMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentDetailMaster()
        {
            this.AssessmentQuestionBankDetails = new HashSet<AssessmentQuestionBankDetail>();
            this.ExamFinalReports = new HashSet<ExamFinalReport>();
        }
    
        public System.Guid ID { get; set; }
        public string AssessmentName { get; set; }
        public Nullable<bool> IsBrowserLock { get; set; }
        public Nullable<bool> IsPrintScreenLock { get; set; }
        public Nullable<System.Guid> EligibilityCriteriaId { get; set; }
        public Nullable<System.DateTime> ScheduledStartDatetime { get; set; }
        public Nullable<System.DateTime> ScheduledEndDatetime { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual EligibilityCriteriaDetail EligibilityCriteriaDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentQuestionBankDetail> AssessmentQuestionBankDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamFinalReport> ExamFinalReports { get; set; }
    }
}
