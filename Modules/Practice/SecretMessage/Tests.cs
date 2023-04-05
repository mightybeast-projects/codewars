using NUnit.Framework;

namespace codewars.Modules.Practice.SecretMessage;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(encodingCases))]
    public string TestEncoding(string str) => Encoder.Encode(str);

    private static TestCaseData[] encodingCases =
    {
        new TestCaseData("a").Returns("b"),
        new TestCaseData("aa").Returns("bd"),
        new TestCaseData("aaa").Returns("bdh"),
        new TestCaseData("Banana").Returns("3dSpT,"),
        new TestCaseData("Bananabar").Returns("3dSpT,22K"),
        new TestCaseData("Hello, world!").Returns("atC5kif6Pg1J!"),
        new TestCaseData("The quick brown fox jumps over the lazy dog")
            .Returns("yFNYhdmEdViBbxc40,ROYNxw.keKCVq464dLYMh8Vya")
    };
}