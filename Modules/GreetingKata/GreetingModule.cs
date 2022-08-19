using System.Text;

namespace GreetingKata;

public class GreetingModule
{
    private string[] _inputNames;
    private List<string> _normalNames;
    private List<string> _shoutedNames;
    private StringBuilder _result;

    internal string Greet(params string[] names)
    {
        _inputNames = names;

        if (names == null)
            return "Hello, my friend.";

        if (names.Count<string>() == 1)
            return GreetOnePerson(_inputNames[0]);
        else
            return GreetSeveralPeople();
    }

    private string GreetOnePerson(string name)
    {
        if (name.ToUpper() == name) return "HELLO " + name + "!";

        return "Hello, " + name + ".";
    }

    private string GreetSeveralPeople()
    {
        _result = new StringBuilder("Hello, ");

        AppendSeveralPeopleToResult();

        return _result.ToString();
    }

    private void AppendSeveralPeopleToResult()
    {
        SplitInputNames();
        FormatNormalNames();
        FormatShoutedNames();
    }

    private void SplitInputNames()
    {
        InitializeLists();

        foreach (string name in _inputNames)
        {
            if (name == name.ToUpper())
            {
                _shoutedNames.Add(name);
                continue;
            }

            if (name.Contains(","))
            {
                if (name.Contains("\""))
                {
                    _normalNames.Add(name.Replace("\"", ""));
                    continue;
                }

                AddCommaSeparatedNames(name);
                continue;
            }

            _normalNames.Add(name);
        }
    }

    private void FormatNormalNames()
    {
        int namesSize = _normalNames.Count();

        for (int i = 0; i < namesSize; i++)
        {
            string name = _normalNames[i];

            if (namesSize > 2)
            {
                if (i != 0)
                {
                    if (i == namesSize - 1)
                        _result.Append(", and ");
                    else
                        _result.Append(", ");
                }
            }
            else if (i != 0)
                _result.Append(" and ");

            _result.Append(_normalNames[i]);
        }

        _result.Append(".");
    }

    private void FormatShoutedNames()
    {
        if (_shoutedNames.Any<string>())
            foreach (string shoutedName in _shoutedNames)
                _result.Append(" AND HELLO " + shoutedName + "!");
    }

    private void InitializeLists()
    {
        _normalNames = new List<string>();
        _shoutedNames = new List<string>();
    }

    private void AddCommaSeparatedNames(string names)
    {
        string[] commaSeparatedNames = names.Split(", ");
        _normalNames.Add(commaSeparatedNames[0]);
        _normalNames.Add(commaSeparatedNames[1]);
    }
}