namespace Ulaw.ApplicationProcessor
{
  public class ApplicationSubmissionWithTwoOneLawDegree :
  ApplicationSubmissionWithOffer
  {
    public ApplicationSubmissionWithTwoOneLawDegree(IApplicationDetails applicationDetails)
      : base(applicationDetails)
    {
      DegreeGrade = DegreeGradeEnum.twoOne;
      DegreeSubject = DegreeSubjectEnum.law;
      DepositAmount = 350.00M;
    }
  }
}

