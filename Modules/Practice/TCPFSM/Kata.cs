namespace codewars.Modules.Practice.TCPFSM;

public class Kata
{
    public static string TraverseStates(string[] events)
    {
        State currentState = State.CLOSED;

        foreach (string e in events)
        {
            Event eventToApply = (Event)Enum.Parse(typeof(Event), e);
            Rule rule = StateRules.rules
                .FirstOrDefault(x => x.currentState == currentState &&
                    x.currentEvent == eventToApply);

            if (rule != null)
                currentState = rule.newState;
            else
                currentState = State.ERROR;
        }

        return currentState.ToString();
    }
}