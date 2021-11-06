using System;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
  public class ApplicationSubmissionWithThirdDegree : Application
  {
    private readonly IApplicationDetails _applicationDetails;
    public ApplicationSubmissionWithThirdDegree(IApplicationDetails applicationDetails)
    {
      _applicationDetails = applicationDetails
       ?? throw new ArgumentNullException(nameof(applicationDetails));
    }

    public override string Process()
    {
      var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
      result.AppendFormat("<p> Dear {0}, </p>", _applicationDetails.FirstName);
      result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
      result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
      result.Append("<br> Yours sincerely,");
      result.Append("<p/> The Admissions Team,");
      result.Append("</body></html>");
      return result.ToString();
    }
  }
}
