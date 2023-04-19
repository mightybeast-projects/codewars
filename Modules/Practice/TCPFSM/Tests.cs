using NUnit.Framework;

namespace codewars.Modules.Practice.TCPFSM;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(cases))]
    public void TestFSM(string[] events, string result)
        => Assert.AreEqual(result, Kata.TraverseStates(events));

    private static object[] cases =
    {
        new object[] { new[] { "APP_SEND" }, "ERROR" },
        new object[] { new[] { "APP_PASSIVE_OPEN" }, "LISTEN" },
        new object[] { new[] { "APP_ACTIVE_OPEN" }, "SYN_SENT" },
        new object[] { new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN" }, "CLOSE_WAIT" },
        new object[] { new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK" }, "ESTABLISHED" },
        new object[] { new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN", "APP_CLOSE" }, "LAST_ACK" },
        new object[] { new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK", "APP_CLOSE", "APP_SEND" }, "ERROR" },
    };
}