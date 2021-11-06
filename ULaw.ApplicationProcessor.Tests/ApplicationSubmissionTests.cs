using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ulaw.ApplicationProcessor;

namespace ULaw.ApplicationProcessor.Tests
{

  [TestClass]
  public class ApplicationSubmissionTests
  {
    private const string OfferEmailForFirstLawDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law degree at grade: 1st.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
    private const string OfferEmailForTwoOneLawDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law degree at grade: 2:1.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
    private const string OfferEmailForFirstLawAndBusinessDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law and Business degree at grade: 1st.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
    private const string OfferEmailForTwoOneLawAndBusinessDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are delighted to offer you a place on our course reference: ABC123 starting on 22 September 2019.<br/> This offer will be subject to evidence of your qualifying Law and Business degree at grade: 2:1.<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £350.00 deposit fee to secure your place.<br/> We look forward to welcoming you to the University,<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";

    private const string FurtherInfoEmailResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application for our course reference: ABC123 starting on 22 September 2019, we are writing to inform you that we are currently assessing your information and will be in touch shortly.<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.<br/> Yours sincerely,<p/> The Admissions Team,</body></html>";
    private const string RejectionEmailForAnyThirdDegreeResult = @"<html><body><h1>Your Recent Application from the University of Law</h1><p> Dear Test, </p><p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.<br> Yours sincerely,<p/> The Admissions Team,</body></html>";

    private ApplicationDetails applicationDetails;

    [TestInitialize()]
    public void TestInitialize()
    {
      applicationDetails = new ApplicationDetails
      {
        Faculty = "Law",
        CourseCode = "ABC123",
        StartDate = new DateTime(2019, 9, 22),
        Title = "Mr",
        FirstName = "Test",
        LastName = "Tester",
        DateOfBirth = new DateTime(1991, 08, 14),
        RequiresVisa = false
      };
    }

    [TestMethod]
    public void ApplicationSubmissionWithFirstLawDegree_Throws_ArgumentNullException()
    {
      ApplicationDetails applicationDetailsNull = null;
      Assert.ThrowsException<ArgumentNullException>(() =>
        new ApplicationSubmissionWithFirstLawDegree(applicationDetailsNull));
    }

    [TestMethod]
    public void ApplicationSubmissionWithFirstLawDegree()
    {
      ApplicationSubmissionWithOffer thisSubmission =
        new ApplicationSubmissionWithFirstLawDegree(applicationDetails);
      thisSubmission.DepositAmount = 350.00M;
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, OfferEmailForFirstLawDegreeResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithFirstLawAndBusinessDegree()
    {
      ApplicationSubmissionWithOffer thisSubmission =
        new ApplicationSubmissionWithFirstLawAndBusinessDegree(applicationDetails);
      thisSubmission.DepositAmount = 350.00M;
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, OfferEmailForFirstLawAndBusinessDegreeResult);

    }

    [TestMethod]
    public void ApplicationSubmissionWithFirstEnglishDegree()
    {
      ApplicationSubmissionWithFutherInfo thisSubmission =
        new ApplicationSubmissionWithFirstEnglishDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithTwoOneLawDegree()
    {
      Application thisSubmission = new ApplicationSubmissionWithTwoOneLawDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, OfferEmailForTwoOneLawDegreeResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithTwoOneMathsDegree()
    {
      ApplicationSubmissionWithFutherInfo thisSubmission =
        new ApplicationSubmissionWithTwoOneMathsDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithTwoOneLawAndBusinessDegree()
    {
      Application thisSubmission =
        new ApplicationSubmissionWithTwoOneLawAndBusinessDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, OfferEmailForTwoOneLawAndBusinessDegreeResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithTwoTwoEnglishDegree()
    {
      ApplicationSubmissionWithFutherInfo thisSubmission =
        new ApplicationSubmissionWithTwoTwoEnglishDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithTwoTwoLawDegree()
    {
      ApplicationSubmissionWithFutherInfo thisSubmission =
        new ApplicationSubmissionWithTwoTwoLawDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, FurtherInfoEmailResult);
    }

    [TestMethod]
    public void ApplicationSubmissionWithThirdDegree()
    {
      Application thisSubmission =
        new ApplicationSubmissionWithThirdDegree(applicationDetails);
      string emailHtml = thisSubmission.Process();
      Assert.AreEqual(emailHtml, RejectionEmailForAnyThirdDegreeResult);
    }
  }
}
