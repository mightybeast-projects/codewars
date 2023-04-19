namespace codewars.Modules.Practice.TCPFSM;

public class StateRules
{
    public static Rule[] rules = new Rule[]
    {
        new Rule
        {
            currentState = State.CLOSED,
            currentEvent = Event.APP_PASSIVE_OPEN,
            newState = State.LISTEN
        },
        new Rule
        {
            currentState = State.CLOSED,
            currentEvent = Event.APP_ACTIVE_OPEN,
            newState = State.SYN_SENT
        },
        new Rule
        {
            currentState = State.LISTEN,
            currentEvent = Event.RCV_SYN,
            newState = State.SYN_RCVD
        },
        new Rule
        {
            currentState = State.LISTEN,
            currentEvent = Event.APP_SEND,
            newState = State.SYN_SENT
        },
        new Rule
        {
            currentState = State.LISTEN,
            currentEvent = Event.APP_CLOSE,
            newState = State.CLOSED
        },
        new Rule
        {
            currentState = State.SYN_RCVD,
            currentEvent = Event.APP_CLOSE,
            newState = State.FIN_WAIT_1
        },
        new Rule
        {
            currentState = State.SYN_RCVD,
            currentEvent = Event.RCV_ACK,
            newState = State.ESTABLISHED
        },
        new Rule
        {
            currentState = State.SYN_SENT,
            currentEvent = Event.RCV_SYN,
            newState = State.SYN_RCVD
        },
        new Rule
        {
            currentState = State.SYN_SENT,
            currentEvent = Event.RCV_SYN_ACK,
            newState = State.ESTABLISHED
        },
        new Rule
        {
            currentState = State.SYN_SENT,
            currentEvent = Event.APP_CLOSE,
            newState = State.CLOSED
        },
        new Rule
        {
            currentState = State.ESTABLISHED,
            currentEvent = Event.APP_CLOSE,
            newState = State.FIN_WAIT_1
        },
        new Rule
        {
            currentState = State.ESTABLISHED,
            currentEvent = Event.RCV_FIN,
            newState = State.CLOSE_WAIT
        },
        new Rule
        {
            currentState = State.FIN_WAIT_1,
            currentEvent = Event.RCV_FIN,
            newState = State.CLOSING
        },
        new Rule
        {
            currentState = State.FIN_WAIT_1,
            currentEvent = Event.RCV_FIN_ACK,
            newState = State.TIME_WAIT
        },
        new Rule
        {
            currentState = State.FIN_WAIT_1,
            currentEvent = Event.RCV_ACK,
            newState = State.FIN_WAIT_2
        },
        new Rule
        {
            currentState = State.CLOSING,
            currentEvent = Event.RCV_ACK,
            newState = State.TIME_WAIT
        },
        new Rule
        {
            currentState = State.FIN_WAIT_2,
            currentEvent = Event.RCV_FIN,
            newState = State.TIME_WAIT
        },
        new Rule
        {
            currentState = State.TIME_WAIT,
            currentEvent = Event.APP_TIMEOUT,
            newState = State.CLOSED
        },
        new Rule
        {
            currentState = State.CLOSE_WAIT,
            currentEvent = Event.APP_CLOSE,
            newState = State.LAST_ACK
        },
        new Rule
        {
            currentState = State.LAST_ACK,
            currentEvent = Event.RCV_ACK,
            newState = State.CLOSED
        }
    };
}