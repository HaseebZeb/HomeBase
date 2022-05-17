using BLL.Contracts;
using Component;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading.Tasks;

namespace HomeBase.Controllers
{
    //attribute specifies that it's a web service(api) controller
    [ApiController]
    //Public route to access the actions in this controller
    [Route("api/CodingExam")]
    public class CodingExamController : ControllerBase
    {
        //It will help us in logging request responses and in custom logging scenarios
        private readonly ILogger<CodingExamController> _logger;
        private readonly IAppraisal _bllAppraisal;

        //default constructor
        public CodingExamController(ILogger<CodingExamController> logger, IAppraisal bllAppraisal)
        {
            _logger = logger;
            _bllAppraisal = bllAppraisal;
        }

        /// <summary>
        /// this method recieves XML as input and saves data 
        ///  Authorization is not implaced, anybody without token can access it
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("SaveXML")]
        public IActionResult SaveXML()
        {
            CodingExamXML deserializedXML = new CodingExamXML();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(Request.Body, Encoding.UTF8))
            {
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(CodingExamXML));
                deserializedXML = (CodingExamXML)ser.Deserialize(reader);
            }
            _bllAppraisal.Store(deserializedXML);
            return Ok();
        }
    }
}
