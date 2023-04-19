namespace codewars.Modules.Practice.TCPFSM;

public enum State
{
    ERROR, CLOSED, LISTEN, SYN_SENT, SYN_RCVD,
    ESTABLISHED, CLOSE_WAIT, LAST_ACK,
    FIN_WAIT_1, FIN_WAIT_2, CLOSING, TIME_WAIT
}