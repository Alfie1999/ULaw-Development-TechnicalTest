namespace Ulaw.ApplicationProcessor
{
  public class ApplicationSubmissionWithFirstLawDegree :
  ApplicationSubmissionWithOffer
  {
    public ApplicationSubmissionWithFirstLawDegree(IApplicationDetails applicationDetails)
      : base(applicationDetails)
    {
      DegreeGrade = DegreeGradeEnum.first;
      DegreeSubject = DegreeSubjectEnum.law;
      DepositAmount = 350.00M;
    }
  }
}