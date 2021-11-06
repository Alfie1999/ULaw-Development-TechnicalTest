using System;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
  /// <summary>
  /// base class for Application Further info 
  /// </summary>
  public class ApplicationSubmissionWithFutherInfo : Application
  {
    private readonly IApplicationDetails _applicationDetails;
    public ApplicationSubmissionWithFutherInfo(IApplicationDetails applicationDetails)
    {
      _applicationDetails = applicationDetails
      ?? throw new ArgumentNullException(nameof(applicationDetails));
    }

    public override string Process()
    {
      var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
      result.AppendFormat("<p> Dear {0}, </p>", _applicationDetails.FirstName);
      result.AppendFormat("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", _applicationDetails.CourseCode, _applicationDetails.StartDate.ToLongDateString());
      result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
      result.Append("<br/> Yours sincerely,");
      result.Append("<p/> The Admissions Team,</body></html>");
      return result.ToString();
    }
  }
}
