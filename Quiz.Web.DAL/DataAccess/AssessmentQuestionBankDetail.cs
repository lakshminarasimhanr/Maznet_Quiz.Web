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
    
    public partial class AssessmentQuestionBankDetail
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> AssessmentID { get; set; }
        public Nullable<System.Guid> QuestionBankID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual AssessmentDetailMaster AssessmentDetailMaster { get; set; }
        public virtual QuestionBankMaster QuestionBankMaster { get; set; }
    }
}
