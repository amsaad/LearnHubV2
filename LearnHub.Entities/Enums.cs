namespace LearnHub.Entities
{
    public enum EnrollmentState
    {
        Rejected = -1,
        Requested = 10,
        Enrolled = 100,
        Completed = 150
    }

    public enum TitleType
    {
        UnknownFile = 0,
        MediaFile = 10,
        ZipFile = 20,
        TXTFile = 30
    }
    public enum EntityType
    {
        Course = 10,
        CourseHeadTitle = 20,
        CourseTitle = 30

    }

    public enum SystemRoles
    {
        SysAdmin, SuperUser

    }

    public enum AppSignInStatus
    {
        Success = 0,
        //
        // Summary:
        //     User is locked out
        LockedOut = 1,
        //
        // Summary:
        //     Sign in requires addition verification (i.e. two factor)
        RequiresVerification = 2,
        //
        // Summary:
        //     Sign in failed
        Failure = 3,
        MustChangePassword = 4
    }
}