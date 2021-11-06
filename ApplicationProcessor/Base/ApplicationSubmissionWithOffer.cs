using System;
using System.ComponentModel;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
  /// <summary>
  /// base class for Application Offers
  /// </summary>
  public class ApplicationSubmissionWithOffer : Application
  {
    private readonly IApplicationDetails _applicationDetails;

    /// <summary>
    /// The enums are only used by a Applications submission(s) with offers, 
    /// it's okay to declare it within this class as it'not 
    /// needed to be used anywhere else.
    /// </summary>
    protected enum DegreeGradeEnum : int
    {
      [Description("1st")]
      first,
      [Description("2:1")]
      twoOne,
      [Description("2:2")]
      twoTwo,
      [Description("3rd")]
      third
    }

    protected enum DegreeSubjectEnum : int
    {
      [Description("Law")]
      law,
      [Description("Law and Business")]
      lawAndBusiness,
      [Description("Maths")]
      maths,
      [Description("English")]
      English
    }

    public ApplicationSubmissionWithOffer(IApplicationDetails applicationDetails)
    {
      _applicationDetails = applicationDetails
        ?? throw new ArgumentNullException(nameof(applicationDetails));
    }

    protected DegreeGradeEnum DegreeGrade { get; set; }
    protected DegreeSubjectEnum DegreeSubject { get; set; }
    /// <summary>
    /// public decimal DepositAmount 
    /// made public to have the ability to re-assign 
    /// </summary>
    public decimal DepositAmount { get; set; }

    public override string Process()
    {
      var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
      result.AppendFormat("<p> Dear {0}, </p>", _applicationDetails.FirstName);
      result.AppendFormat("<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {0} starting on {1}.", _applicationDetails.CourseCode, _applicationDetails.StartDate.ToLongDateString());
      result.AppendFormat("<br/> This offer will be subject to evidence of your qualifying {0} degree at grade: {1}.", DegreeSubject.ToDescription(), DegreeGrade.ToDescription());
      result.AppendFormat("<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{0} deposit fee to secure your place.", DepositAmount.ToString());
      result.Append("<br/> We look forward to welcoming you to the University,");
      result.Append("<br/> Yours sincerely,");
      result.Append("<p/> The Admissions Team,");
      result.Append("</body></html>");
      return result.ToString();
    }
  }
}
