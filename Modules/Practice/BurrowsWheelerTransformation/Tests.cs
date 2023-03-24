using NUnit.Framework;

namespace codewars.Modules.Practice.BurrowsWheelerTransformation;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(encodingCases))]
    public Tuple<string, int> TestEncoding(string str)
        => Kata.Encode(str);

    private static TestCaseData[] encodingCases =
    {
        new TestCaseData("a").Returns(new Tuple<string, int>("a", 0)),
        new TestCaseData("aa").Returns(new Tuple<string, int>("aa", 0)),
        new TestCaseData("ab").Returns(new Tuple<string, int>("ba", 0)),
        new TestCaseData("aba").Returns(new Tuple<string, int>("baa", 1)),
        new TestCaseData("banana")
            .Returns(new Tuple<string, int>("nnbaaa", 3)),
        new TestCaseData("bananabar")
            .Returns(new Tuple<string, int>("nnbbraaaa", 4))
    };
}