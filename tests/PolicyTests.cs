using OnyxSimCapacityLab;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(81, 94, 20, 12, 13);
        if (Policy.Score(signalcase_1) != 182) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "accept") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(61, 105, 9, 10, 9);
        if (Policy.Score(signalcase_2) != 177) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(76, 73, 27, 20, 8);
        if (Policy.Score(signalcase_3) != 87) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
