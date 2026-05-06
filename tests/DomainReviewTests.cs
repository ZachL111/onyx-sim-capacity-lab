using OnyxSimCapacityLab;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(61, 49, 13, 63);
        if (DomainReviewLens.Score(item) != 195) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
