namespace LearnHub.Entities
{
    public enum EnrollmentState
    {
        Rejected = -1,
        Requested = 10,
        Enrolled =100,
        Completed =150
    }

    public enum TitleType
    {
        UnknownFile = 0,
        MediaFile=10,
        ZipFile=20,
        TXTFile=30
    }
    public enum EntityType
    {
        Course = 10,
        CourseHeadTitle = 20,
        CourseTitle = 30

    }

}