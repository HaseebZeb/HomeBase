using System;

namespace DAL.Entities
{
    /// <summary>
    ///  Database Table for Appraisal Entity
    /// </summary>
    public class Appraisal
    {
        //[PrimaryKey]
        public string AppraisalID { get; set; }
        public long RepresentativeId { get; set; }
        public int BranchId { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyZip { get; set; }
        public string EntryContactName { get; set; }
        public string PropertyInfo { get; set; }
        public string LoanType { get; set; }
        public long LenderLoanNumber { get; set; }
        public string AppraisalCheck { get; set; }
        public int AppraisalTimeRequest { get; set; }
        public string EntryContactPhone { get; set; }
    }
}
