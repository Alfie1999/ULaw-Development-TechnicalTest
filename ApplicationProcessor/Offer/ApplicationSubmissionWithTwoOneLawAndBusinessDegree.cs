namespace Ulaw.ApplicationProcessor
{
  public class ApplicationSubmissionWithTwoOneLawAndBusinessDegree
 : ApplicationSubmissionWithOffer
  {
    public ApplicationSubmissionWithTwoOneLawAndBusinessDegree(IApplicationDetails applicationDetails)
      : base(applicationDetails)
    {
      DegreeGrade = DegreeGradeEnum.twoOne;
      DegreeSubject = DegreeSubjectEnum.lawAndBusiness;
      DepositAmount = 350.00M;
    }
  }
}
