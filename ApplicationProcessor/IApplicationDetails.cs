using System;

namespace Ulaw.ApplicationProcessor
{
  /// <summary>
  /// IApplicationDetails 
  /// interface for application details
  /// enables DI for the ApplicationDetails class
  /// </summary>
  public interface IApplicationDetails
  {
    Guid ApplicationId { get; }
    string CourseCode { get; }
    DateTime DateOfBirth { get; }
    string Faculty { get; }
    string FirstName { get; }
    string LastName { get; }
    bool RequiresVisa { get; }
    DateTime StartDate { get; }
    string Title { get; }
  }
}