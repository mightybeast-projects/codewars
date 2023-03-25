using NUnit.Framework;

namespace codewars.Modules.Practice.BurrowsWheelerTransformation;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(encodingCases))]
    public Tuple<string, int> TestEncoding(string str)
        => Kata.Encode(str);

    [Test, TestCaseSource(nameof(decodingCases))]
    public string TestDecoding(string s, int i) => Kata.Decode(s, i);

    private static TestCaseData[] encodingCases =
    {
        new TestCaseData("").Returns(new Tuple<string, int>("", 0)),
        new TestCaseData("a").Returns(new Tuple<string, int>("a", 0)),
        new TestCaseData("aa").Returns(new Tuple<string, int>("aa", 0)),
        new TestCaseData("ab").Returns(new Tuple<string, int>("ba", 0)),
        new TestCaseData("aba").Returns(new Tuple<string, int>("baa", 1)),
        new TestCaseData("banana")
            .Returns(new Tuple<string, int>("nnbaaa", 3)),
        new TestCaseData("bananabar")
            .Returns(new Tuple<string, int>("nnbbraaaa", 4)),
        new TestCaseData("Banana")
            .Returns(new Tuple<string, int>("annBaa", 0)),
        new TestCaseData("Humble Bundle")
            .Returns(new Tuple<string, int>("e emnllbduuHB", 2)),
        new TestCaseData("Mellow Yellow")
            .Returns(new Tuple<string, int>("ww MYeelllloo", 1))
    };

    private static TestCaseData[] decodingCases =
    {
        new TestCaseData("", 0).Returns(""),
        new TestCaseData("a", 0).Returns("a"),
        new TestCaseData("aa", 0).Returns("aa"),
        new TestCaseData("ba", 0).Returns("ab"),
        new TestCaseData("baa", 1).Returns("aba"),
        new TestCaseData("nnbaaa", 3).Returns("banana"),
        new TestCaseData("nnbbraaaa", 4).Returns("bananabar"),
        new TestCaseData("annBaa", 0).Returns("Banana"),
        new TestCaseData("e emnllbduuHB", 2).Returns("Humble Bundle"),
        new TestCaseData("ww MYeelllloo", 1).Returns("Mellow Yellow")
    };
}