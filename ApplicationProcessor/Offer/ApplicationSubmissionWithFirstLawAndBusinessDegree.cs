namespace Ulaw.ApplicationProcessor
{
  public class ApplicationSubmissionWithFirstLawAndBusinessDegree :
    ApplicationSubmissionWithOffer
  {
    public ApplicationSubmissionWithFirstLawAndBusinessDegree(IApplicationDetails applicationDetails)
      : base(applicationDetails)
    {
      DegreeGrade = DegreeGradeEnum.first;
      DegreeSubject = DegreeSubjectEnum.lawAndBusiness;
      DepositAmount = 350.00M;
    }
  }
}
