using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Component
{
    [XmlRoot(ElementName = "HomeBase")]
    public class CodingExamXML
    {
        [XmlElement(ElementName = "timestamp")]
        public string Timestamp { get; set; }
        [XmlElement(ElementName = "token")]
        public string Token { get; set; }
        [XmlElement(ElementName = "signature")]
        public string Signature { get; set; }
        [XmlElement(ElementName = "orderID")]
        public string OrderID { get; set; }
        [XmlElement(ElementName = "userid")]
        public long UserId { get; set; }
        [XmlElement(ElementName = "username")]
        public string Username { get; set; }
        [XmlElement(ElementName = "useremail")]
        public string UserEmail { get; set; }
        [XmlElement(ElementName = "userphone")]
        public string UserPhone { get; set; }
        [XmlElement(ElementName = "branchid")]
        public int BranchId { get; set; }
        [XmlElement(ElementName = "borrower_name")]
        public string BorrowerName { get; set; }
        [XmlElement(ElementName = "property_address")]
        public string PropertyAddress { get; set; }
        [XmlElement(ElementName = "property_zip")]
        public string PropertyZip { get; set; }
        [XmlElement(ElementName = "entry_contact_name")]
        public string EntryContactName { get; set; }
        [XmlElement(ElementName = "property_info")]
        public string PropertyInfo { get; set; }
        ////Can be an enum
        [XmlElement(ElementName = "loan_type")]
        public string LoanType { get; set; }
        [XmlElement(ElementName = "lender_loan_num")]
        public long LenderLoanNumber { get; set; }
        [XmlElement(ElementName = "appraisal_check")]
        public string AppraisalCheck { get; set; }
        //Can be a seperate class
        [XmlElement(ElementName = "appraisal_type")]
        public List<AppraisalType> AppraisalTypes { get; set; }
        [XmlElement(ElementName = "appraisal_time_request")]
        public int AppraisalTimeRequest { get; set; }
        [XmlElement(ElementName = "entry_contact_phone")]
        public string EntryContactPhone { get; set; }
        [XmlElement(ElementName = "payment")]
        public PaymentModel Payment { get; set; }
    }
    public class PaymentModel
    {
        [XmlElement(ElementName = "payment_type")]
        //can be an enum
        public string PaymentType { get; set; }
        [XmlElement(ElementName = "link_email")]
        public string LinkEmail { get; set; }
    }
    public class AppraisalType
    {
        [XmlElement(ElementName = "type")]

        //can be an enum
        public string Type { get; set; }
    }
}
